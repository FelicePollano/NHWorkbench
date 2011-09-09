// 2010 Felice Pollano
// felice@felicepollano.com
// www.felicepollano.com
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.ObjectBuilder;
using Microsoft.Practices.ObjectBuilder2;
using NHibernate.Tool.WorkBench.Core.WireAttributes;
using System.Reflection;

namespace NHibernate.Tool.WorkBench.Core
{
    class WireImportExports:UnityContainerExtension,IBuilderStrategy
    {
        
        protected override void Initialize()
        {
            Context.Strategies.Add(this, UnityBuildStage.Initialization);
            
        }



        #region IBuilderStrategy Members

        public void PostBuildUp(IBuilderContext context)
        {
            ManageExports(context);
            ManageImports(context);
        }

        private void ManageImports(IBuilderContext context)
        {
            foreach (PropertyInfo pi in context.Existing.GetType().GetProperties())
            {
                ImportAttribute[] imports = pi.GetCustomAttributes(typeof(ImportAttribute), true) as ImportAttribute[];
                if (imports.Length > 0)
                {
                    pi.SetValue(context.Existing, Container.Resolve(pi.PropertyType), null);
                }
            }
        }

        private void ManageExports(IBuilderContext context)
        {
            ExportAttribute[] atts = context.Existing.GetType().GetCustomAttributes(typeof(ExportAttribute), true) as ExportAttribute[];
            if (atts.Length > 0)
            {
                Type typeOfInstance = context.Existing.GetType();
                foreach (var att in atts)
                {
                    if (att.Type != null)
                        typeOfInstance = att.Type;
                    Container.RegisterInstance(typeOfInstance, context.Existing);
                }
            }
        }

        public void PostTearDown(IBuilderContext context)
        {
           
        }

        public void PreBuildUp(IBuilderContext context)
        {
            
        }

        public void PreTearDown(IBuilderContext context)
        {
           
        }

        #endregion
    }
}
