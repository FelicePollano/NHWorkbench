using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Tool.WorkBench.Core;
using NHibernate.Tool.WorkBench.Core.WireAttributes;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using System.IO;
using NHibernate.Tool.WorkBench.Log;
using log4net;
using NHibernate.Tool.WorkBench.Project;
using NHibernate.Tool.WorkBench.Core.Commands;
using Effectus.Infrastructure;
using NHibernate.Tool.WorkBench.Events;
using NHibernate.Tool.WorkBench.Config;
using NHibernate.Tool.WorkBench.Mapping;
using NHibernate.Tool.WorkBench.Hql;
using HqlIntellisense;

namespace NHibernate.Tool.WorkBench.Main
{
    [Presenter]
    [Export(Type=typeof(IPropertyService))]
    class MainPresenter:IPresenter,IPropertyService
    {
        MainForm form;
        ITypeFactory factory;
        ILog logger;
        
        public MainPresenter(MainForm form,ITypeFactory factory,ILog logger)
        {
           
            this.form = form;
            this.factory = factory;
            this.logger = logger;
            form.DockPanel.ContentAdded += new EventHandler<DockContentEventArgs>(DockPanel_ContentAdded);
            form.DockPanel.ContentRemoved += new EventHandler<DockContentEventArgs>(DockPanel_ContentRemoved);
            
            this.form.FormClosing += new FormClosingEventHandler(form_FormClosing);
            EventPublisher.Register((OpenFileRequest r) => OpenFile(r.FilePath));
            EventPublisher.Register((ProjectFileMoved pm) => FileLocationMoved(pm.PreviousPath,pm.NewPath));
            form.NewConfig += new EventHandler(form_NewConfig);
            form.NewHql += new EventHandler(form_NewHql);
            form.NewMapping += new EventHandler(form_NewMapping);
            form.OpenFile += new EventHandler(form_OpenFile);
        }

        private void FileLocationMoved(string previous, string current)
        {
            foreach (DockContent d in form.DockPanel.Documents)
            {
                if (d is IHavePath)
                {
                    if (string.Equals(previous, ((IHavePath)d).DocPath, StringComparison.OrdinalIgnoreCase))
                    {
                        ((IHavePath)d).DocPath = current;
                        return;
                    }
                }
            }
        }

        void form_OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog sfd = new OpenFileDialog();
            sfd.AddExtension = true;
            sfd.CustomPlaces.Add(new FileDialogCustomPlace(ApplicationEnvironment.Instance.DocumentPath));

            sfd.Filter = ApplicationEnvironment.Instance.GetCombinedFilters();

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                OpenFile(sfd.FileName);
            }
        }

        

        void form_NewMapping(object sender, EventArgs e)
        {
            var presenter = factory.Get<MappingPresenter>();
            presenter.Startup();
            presenter.SetInitialText(GetType().Assembly.GetManifestResourceStream("NHibernate.Tool.WorkBench.DocTemplates.mapping.xml"));
        }

        void form_NewHql(object sender, EventArgs e)
        {
            var presenter = factory.Get<HqlPresenter>();
            presenter.Startup();
        }

        void form_NewConfig(object sender, EventArgs e)
        {
            var presenter = factory.Get<ConfigPresenter>();
            presenter.Startup();
            presenter.SetInitialText(GetType().Assembly.GetManifestResourceStream("NHibernate.Tool.WorkBench.DocTemplates.config.xml"));
        }

        private void OpenFile(string path)
        {
            foreach (DockContent d in form.DockPanel.Documents)
            {
                if (d is IHavePath)
                {
                    if (string.Equals(path, ((IHavePath)d).DocPath, StringComparison.OrdinalIgnoreCase))
                    {
                        d.Activate();
                        return;
                    }
                }
            }
            CreateDocumentAmbience(path);
        }

        private void CreateDocumentAmbience(string filePath)
        {
            if (filePath.ToLower().EndsWith(".config"))
            {
                var presenter = factory.Get<ConfigPresenter>();
                presenter.Startup();
                presenter.LoadFile(filePath);
            }
            else
            if (filePath.ToLower().EndsWith(".hbm.xml"))
            {
                var presenter = factory.Get<MappingPresenter>();
                presenter.Startup();
                presenter.LoadFile(filePath);
            }
            else
            if (filePath.ToLower().EndsWith(".xml"))
            {
                var presenter = factory.Get<ConfigPresenter>();
                presenter.Startup();
                presenter.LoadFile(filePath);
            }
            else
            if (filePath.ToLower().EndsWith(".hql"))
            {
                var presenter = factory.Get<HqlPresenter>();
                presenter.Startup();
                presenter.LoadFile(filePath);
            }
        }

        void DockPanel_ContentRemoved(object sender, DockContentEventArgs e)
        {
            if (e.Content is ISupportsCommands)
            {
                factory.Get<ICommandRouter>().Unregister(e.Content as ISupportsCommands);
            }

        }

        void DockPanel_ContentAdded(object sender, DockContentEventArgs e)
        {
            if (e.Content is ISupportsCommands)
            {
                factory.Get<ICommandRouter>().Register(e.Content as ISupportsCommands);
            }
        }

        void form_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.DockPanel.SaveAsXml(ApplicationEnvironment.Instance.DockigSettings);
        }
        #region IPresenter Members

        public object View
        {
            get { return form; }
        }
        public void Startup()
        {
            if (!Directory.Exists(ApplicationEnvironment.Instance.DocumentPath))
            {
                Directory.CreateDirectory(ApplicationEnvironment.Instance.DocumentPath);
            }
            if (File.Exists(ApplicationEnvironment.Instance.DockigSettings))
            {
                form.DockPanel.LoadFromXml(ApplicationEnvironment.Instance.DockigSettings, new DeserializeDockContent(new DeserializeDockContent(GetContentFromPersistString)));
            }
            else
            {
                factory.Get<LogPresenter>().Startup();
                factory.Get<ProjectPresenter>().Startup();
            }
            
            Application.Run(form);
        }
        public event EventHandler Disposed;

        #endregion
        private IDockContent GetContentFromPersistString(string persistString)
        {
            if (persistString.EndsWith("View"))
            {
                string presenter = persistString.Substring(0, persistString.LastIndexOf("View"));
                presenter += "Presenter";
                System.Type t = System.Type.GetType(presenter);
                if (null != t)
                {
                    IPresenter p = factory.Get(t) as IPresenter;
                    if (null != p)
                    {
                        p.Startup();
                        return p.View as IDockContent;
                    }
                }
            }
            if (persistString.EndsWith(".docmemento"))
            {
                if (File.Exists(persistString))
                {
                    
                }
            }
            return null;
        }

        #region IPropertyService Members

        public object GetProperty(string name)
        {
            switch (name)
            {
                case "FirstResult":
                    return form.FirstResult;
                case "MaxResults":
                    return form.MaxResults;
                default:
                    return false;
            }
        }

        #endregion

       
    }

}
