// 2010 Felice Pollano
// felice@felicepollano.com
// www.felicepollano.com

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Tool.WorkBench.Core;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using System.IO;
using ICSharpCode.TextEditor;
using Effectus.Infrastructure;

namespace NHibernate.Tool.WorkBench
{
    abstract class AbstractDocumentPresenter<T,TEditor>:IPresenter where T:SupportEditorCommandContent
                                                                   where TEditor:TextEditorControl
    {
        T view;
        public AbstractDocumentPresenter(ITypeFactory factory)
        {
            view = factory.Get<T>();
            InitializeEditor((TEditor)view.GetEditor());
            view.FileNameChanged += new EventHandler<NHibernate.Tool.WorkBench.Events.FileNameChanged>(view_FileNameChanged);
            view.Text = GetEmptyName();
        }

        protected abstract string GetEmptyName();
        

        void view_FileNameChanged(object sender, NHibernate.Tool.WorkBench.Events.FileNameChanged e)
        {
            EventPublisher.Publish(e, this);
        }

        protected abstract void InitializeEditor(TEditor e);

        public void SetInitialText(Stream stream)
        {
            StreamReader sr = new StreamReader(stream);
            view.GetEditor().Document.TextContent = sr.ReadToEnd();
        }


        #region IPresenter Members

        public virtual object View
        {
            get { return view; }
        }
        public event EventHandler Disposed;
        public abstract void Startup();
        #endregion
        public void SetName(string name)
        {
            view.Text = name;
        }
        public void LoadFile(string path)
        {
            SetName(Path.GetFileName(path));
            view.LoadFile(path);
        }
    }
}
