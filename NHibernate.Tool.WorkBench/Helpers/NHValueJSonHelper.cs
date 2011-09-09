// 2010 Felice Pollano
// felice@felicepollano.com
// www.felicepollano.com

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace NHibernate.Tool.WorkBench.Helpers
{
    public static class NHValueJSonHelper
    {
        public static object GetJSonSerializable(object Value)
        {
            System.Type type = Value.GetType();
            switch (type.Name)
            {
                case "SimpleValue":
                    return new { Name=type.FullName, TypeName=type.GetProperty("TypeName").GetValue(Value,null)};
                case "OneToMany":
                    return new { Name = type.FullName, ReferencedEntityName = type.GetProperty("ReferencedEntityName").GetValue(Value, null) };
                case "ManyToOne":
                    return new { Name = type.FullName, ReferencedEntityName = type.GetProperty("ReferencedEntityName").GetValue(Value, null) };
            }
            return null;
        }
        public static object JSonDeserialize(Assembly nhAssembly, IDictionary<string, object> jsonRep)
        {
            try
            {
                System.Type t = nhAssembly.GetType(jsonRep["Name"] as string);
                var obj = Activator.CreateInstance(t,new object[]{null});
                if( null != obj )
                {
                    foreach( KeyValuePair<string,object> kp in jsonRep )
                    {
                        if( kp.Key != "Name" )
                        {
                            t.GetProperty(kp.Key).SetValue(obj,kp.Value, null);
                        }
                    }
                }
                return obj;
            }
            catch
            {
                return null;
            }
        }
    }
}
