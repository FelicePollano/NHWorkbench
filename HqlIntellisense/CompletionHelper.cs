// 2010 Felice Pollano
// felice@felicepollano.com
// www.felicepollano.com

namespace HqlIntellisense
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    class CompletionHelper
    {

        private CompletionHelper()
        {
        }

        public static string getCanonicalPath(List<EntityNameReference> qts, string name)
        {
            IDictionary<string, string> alias2Type = new Dictionary<string, string>();

            foreach (var enr in qts)
            {
                alias2Type[enr.Alias] = enr.EntityName;
            }
            if (qts.Count == 1)
            {
                EntityNameReference visible = (EntityNameReference)qts[0];
                string alias = visible.Alias;
                if (name.Equals(alias))
                {
                    return visible.EntityName;
                }
                else if (string.IsNullOrEmpty(alias) || alias.Equals(visible.EntityName))
                {
                    return visible.EntityName + "/" + name;
                }
            }
            return getCanonicalPath(new HashSet<string>(), alias2Type, name);
        }


        private static string getCanonicalPath(HashSet<string> resolved, IDictionary<string, string> alias2Type, string name)
        {
            if (resolved.Contains(name))
            {
                // To prevent a stack overflow
                return name;
            }
            resolved.Add(name);
            string type = null;
            alias2Type.TryGetValue(name, out type);

            if (type != null)
            {
                return name.Equals(type) ? name : getCanonicalPath(resolved, alias2Type, type);
            }
            int idx = name.LastIndexOf('.');
            if (idx == -1)
            {
                return type != null ? type : name;
            }
            string baseName = name.Substring(0, idx);
            string prop = name.Substring(idx + 1);
            if (isAliasNown(alias2Type, baseName))
            {
                return getCanonicalPath(resolved, alias2Type, baseName) + "/" + prop;
            }
            else
            {
                return name;
            }
        }

        private static bool isAliasNown(IDictionary<string, string> alias2Type, string alias)
        {
            if (alias2Type.ContainsKey(alias))
            {
                return true;
            }
            int idx = alias.LastIndexOf('.');
            if (idx == -1)
            {
                return false;
            }
            return isAliasNown(alias2Type, alias.Substring(0, idx));
        }

    }
}