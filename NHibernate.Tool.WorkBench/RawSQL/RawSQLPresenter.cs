using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Tool.WorkBench.Core;
using NHibernate.Tool.WorkBench.Core.WireAttributes;

namespace NHibernate.Tool.WorkBench.RawSQL
{
    [Presenter]
    class RawSQLPresenter:IPresenter
    {
        RawSQLView view;
        RawSQLModel model;
        
        public RawSQLPresenter(RawSQLView view,RawSQLModel model)
        {
            this.view = view;
            this.model = model;
        }
        #region IPresenter Members

        public object View
        {
            get { return view; }
        }

        public event EventHandler Disposed;

        public void Startup()
        {
            
        }

        #endregion

        public void Present(ExecutedHqlResults res)
        {
            model.Results = res;
            view.ShowResults(model.Results);
        }

        public void Activate()
        {
            view.ShowResults(model.Results);
        }

        public void Deactivate()
        {
            view.ShowResults(RawSQLModel.EmptyResults);
        }
    }
}
