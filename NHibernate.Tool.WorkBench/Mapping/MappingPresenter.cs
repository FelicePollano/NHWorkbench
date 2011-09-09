// 2010 Felice Pollano
// felice@felicepollano.com
// www.felicepollano.com
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Tool.WorkBench.Core.WireAttributes;
using NHibernate.Tool.WorkBench.Core;
using ICSharpCode.XmlEditor;
using System.IO;

namespace NHibernate.Tool.WorkBench.Mapping
{
    [Presenter]
    class MappingPresenter : AbstractDocumentPresenter<MappingDocument, ICSharpCode.XmlEditor.XmlEditorControl>
    {
        public MappingPresenter(ITypeFactory factory )
            :base(factory)
        {

        }
        protected override void InitializeEditor(ICSharpCode.XmlEditor.XmlEditorControl e)
        {
            XmlSchemaCompletionData schema = new XmlSchemaCompletionData(new StreamReader(GetType().Assembly.GetManifestResourceStream("NHibernate.Tool.WorkBench.Schemas.nhibernate-mapping.xsd")));
            e.SchemaCompletionDataItems.Add(schema);
        }

        public override void Startup()
        {
            
        }
        static int count;
        protected override string GetEmptyName()
        {
            return string.Format("mapping{0}.hbm.xml", ++count);
        }
    }
}
