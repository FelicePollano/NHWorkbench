// 2010 Felice Pollano
// felice@felicepollano.com
// www.felicepollano.com
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Tool.WorkBench.Core.WireAttributes;
using Fatica.Labs.HqlEditor;
using NHibernate.Tool.WorkBench.Core;
using NHibernate.Tool.WorkBench.Main;
using HqlIntellisense;
using System.Timers;
using NHibernate.Tool.WorkBench.Core.WireAttributes.UiHelpers;
using NHibernate.Tool.WorkBench.Log;
using NHibernate.Tool.WorkBench.RawSQL;
using NHibernate.Tool.WorkBench.Results;

namespace NHibernate.Tool.WorkBench.Hql
{
    [Presenter]
    class HqlPresenter : AbstractDocumentPresenter<HqlDocument,HqlEditor>
    {
        [Import]
        public ILogModel LogModel { get; set; }
        [Import]
        public IPropertyService Props { get; set; }

        [Import]
        public IConfigurationDataProvider Cfg { set { editor.NHConfigDataProvider=value ;} }
        [Import]
        public IQueryTranslator Translator { set;get; }

        RawSQLPresenter rawSql;
        ResultsPresenter results;

        public HqlPresenter(ITypeFactory factory)
            :base(factory)
        {
            UpdateTimer = new Timer(1200);
            UpdateTimer.AutoReset = false;
            UpdateTimer.Elapsed += new ElapsedEventHandler(UpdateTimer_Elapsed);
            ((HqlDocument)View).Run += new EventHandler(HqlPresenter_Run);
            
            rawSql = factory.Get<RawSQLPresenter>();
            rawSql.Startup();

            results = factory.Get<ResultsPresenter>();
            results.Startup();

            ((HqlDocument)View).Activated += new EventHandler(HqlPresenter_Activated);
            ((HqlDocument)View).Deactivate += new EventHandler(HqlPresenter_Deactivate);
        }

        void HqlPresenter_Deactivate(object sender, EventArgs e)
        {
            rawSql.Deactivate();
            results.Deactivate();
        }

        void HqlPresenter_Activated(object sender, EventArgs e)
        {
            rawSql.Activate();
            results.Activate();
        }

        void HqlPresenter_Run(object sender, EventArgs e)
        {
            string[] qres = Translator.Execute(editor.Document.TextContent,(int)Props.GetProperty("FirstResult"),(int)Props.GetProperty("MaxResults"));
            //((HqlDocument)View).PresentResults(qres);
            results.Present(qres);
        }

        void UpdateTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            editor.SafeInvoke(
                ()=>
                    {
                        var res = Translator.Translate(editor.Document.TextContent);
                        LogModel.Clear();
                        (View as HqlDocument).UpdateCanExecute(res);
                        rawSql.Present(res);
                    }
            );
        }
        HqlEditor editor;
        Timer UpdateTimer;
        protected override void InitializeEditor(HqlEditor e)
        {
            editor = e;
            e.Document.DocumentChanged += new ICSharpCode.TextEditor.Document.DocumentEventHandler(Document_DocumentChanged);
        }

        void Document_DocumentChanged(object sender, ICSharpCode.TextEditor.Document.DocumentEventArgs e)
        {
            UpdateTimer.Stop();
            UpdateTimer.Start();
        }

        public override void Startup()
        {
            
        }
        static int count;
        protected override string GetEmptyName()
        {
            return string.Format("Hql{0}.hql",++count);
        }
    }
}
