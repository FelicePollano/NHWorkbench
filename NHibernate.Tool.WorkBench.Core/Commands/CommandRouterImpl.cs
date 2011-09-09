// 2010 Felice Pollano
// felice@felicepollano.com
// www.felicepollano.com
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace NHibernate.Tool.WorkBench.Core.Commands
{
    public class CommandRouterImpl:ICommandRouter
    {
        IList<ISupportsCommands> agents = new List<ISupportsCommands>();
        Dictionary<string, int> CommandHandlerCount = new Dictionary<string, int>();
        public CommandRouterImpl()
        {
            Application.Idle += new EventHandler(Application_Idle);
        }
        public event EventHandler PreExecute;

        private bool UniqueHandler(string ID)
        {
            if (CommandHandlerCount.ContainsKey(ID))
            {
                return CommandHandlerCount[ID] == 1;
            }
            return false;
        }
        void Application_Idle(object sender, EventArgs e)
        {
            foreach (IUpdatable upd in items)
            {
                bool enable = false;
               
                foreach (var agent in agents)
                {
                    if (agent.Active || UniqueHandler(upd.Cmd.ID))
                    {
                        foreach (var b in agent.Bindings)
                        {
                            if (b.Command.ID == upd.Cmd.ID)
                                enable = b.CanExecute();
                        }
                    }
                }
                upd.Update(enable);
            }
        }
        #region ICommandRouter Members

        public void Register(ISupportsCommands agent)
        {
            if (!agents.Contains(agent))
            {
                foreach (var cb in agent.Bindings)
                {
                    if (!CommandHandlerCount.ContainsKey(cb.Command.ID))
                    {
                        CommandHandlerCount[cb.Command.ID] = 0;
                    }
                    CommandHandlerCount[cb.Command.ID] ++;
                }
                agents.Add(agent);
            }
        }
        public void Unregister(ISupportsCommands agent)
        {
            if (agents.Contains(agent))
            {
                foreach (var cb in agent.Bindings)
                {
                    CommandHandlerCount[cb.Command.ID]--;
                }
                agents.Remove(agent);
            }
        }
        public void Execute(Command cmd)
        {
            
            foreach (var agent in agents.ToArray())
            {
                if (agent.Active || UniqueHandler(cmd.ID))
                {
                    foreach (var binding in agent.Bindings)
                    {
                        if (binding.Command.ID == cmd.ID)
                        {
                            if (null != PreExecute)
                                PreExecute(this, EventArgs.Empty);
                            try
                            {
                                binding.Execute();
                            }
                            catch (Exception e)
                            {
                                if (null != ExceptionExecuting)
                                    ExceptionExecuting(this, new ExecutingExceptionEventArgs() { Exception = e });
                                else
                                    throw e;
                            }
                        }
                    }
                }
            }
        }
        List<IUpdatable> items = new List<IUpdatable>();
        public void BindToUI<T>(Command cmd, T UIItem, string executeEvent, Action<T,bool> updateAction)
        {
            var item = new UIItem<T>(this)
                {
                    Cmd = cmd
                ,
                    UIObject = UIItem
                ,
                    ExecuteEvent = executeEvent
                ,
                    UpdateAction = updateAction
                };
            item.Wire();
            items.Add(item);
            
        }

        #endregion
        class UIItem<T>:IUpdatable
        {
            ICommandRouter router;
            public UIItem(ICommandRouter router)
            {
                this.router = router;
            }
            public Command Cmd { get; set; }
            public Action<T,bool> UpdateAction{ get; set; }
            public string ExecuteEvent { get; set; }
            public T UIObject { get; set; }

            #region IUpdatable Members

            public void Update(bool upd)
            {
                UpdateAction(UIObject, upd);
            }

            #endregion

            internal void Wire()
            {
                EventInfo ei = UIObject.GetType().GetEvent(ExecuteEvent);
                ei.AddEventHandler(UIObject
                                   ,Delegate.CreateDelegate(ei.EventHandlerType,this,GetType().GetMethod("Handler"))
                                );
            }
            public void Handler(object sender, EventArgs args)
            {
                router.Execute(Cmd);
            }
        }
        interface IUpdatable
        {
            void Update(bool upd);
            Command Cmd { get; set; }
        }
        public event EventHandler<ExecutingExceptionEventArgs> ExceptionExecuting;
    }
}
