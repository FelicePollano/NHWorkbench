using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Tool.WorkBench.Core.WireAttributes;
using NHibernate.Tool.WorkBench.Core;

namespace NHibernate.Tool.WorkBench.Results
{
    [Presenter]
    class ResultsPresenter:IPresenter
    {
        ResultsView view;
        ResultsModel model;
        public ResultsPresenter(ResultsView view,ResultsModel model)
        {
            this.model = model;
            this.view = view;
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

        public void Activate()
        {
            view.ShowResults(model.Results);
        }

        public void Deactivate()
        {
            view.ShowResults(ResultsModel.NoResults);
        }

        public void Present(string[] qres)
        {
            model.Results = qres;
            view.ShowResults(model.Results);
        }
    }
}
