// 2010 Felice Pollano
// felice@felicepollano.com
// www.felicepollano.com

namespace HqlIntellisense
{
    using System;
    public class EntityNameReference
    {

        private string alias;

        private string entityName;

        public EntityNameReference(string type, string alias)
        {
            this.entityName = type;
            this.alias = alias;
        }

        /** 
         * 
         * @return The alias, the "p" in "Product as p" 
         */
        public string Alias
        {
            get { return alias; }
        }

        /**
         * 
         * @return the entityname, the "Product" in "Product as b"
         */
        public string EntityName
        {
            get { return entityName; }
        }

        public string ToString()
        {
            return alias + ":" + entityName;
        }



    }
}