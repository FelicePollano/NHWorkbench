// 2010 Felice Pollano
// felice@felicepollano.com
// www.felicepollano.com

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Tool.WorkBench.Core;
using NHibernate.Tool.WorkBench.Core.WireAttributes;
using ICSharpCode.XmlEditor;
using System.IO;

namespace NHibernate.Tool.WorkBench.Config
{
    [Presenter]
    class ConfigPresenter:AbstractDocumentPresenter<ConfigDocument,ICSharpCode.XmlEditor.XmlEditorControl>
    {
        public ConfigPresenter(ITypeFactory factory)
            :base(factory)
        {

        }
        public override void Startup()
        {
           
        }
        protected override void InitializeEditor(ICSharpCode.XmlEditor.XmlEditorControl e)
        {
            XmlSchemaCompletionData schema = new XmlSchemaCompletionData(new StreamReader(GetType().Assembly.GetManifestResourceStream("NHibernate.Tool.WorkBench.Schemas.nhibernate-configuration.xsd")));
            e.SchemaCompletionDataItems.Add(schema);
        }
        static int count;
        protected override string GetEmptyName()
        {
            return string.Format("hibernate-cfg{0}.xml", ++count);
        }
        
    }
}
