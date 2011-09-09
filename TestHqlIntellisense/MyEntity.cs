using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Iesi.Collections.Generic;

namespace TestHqlIntellisense
{
    public class MyEntity
    {
        public string P1 { get; set; }
        public string P2 { get; set; }
        public string P3 { get; set; }
        public Referenced Referenced { get; set; }
        public ISet<string> Collection { get; set; }

    }
    public class Referenced
    {
        public string C1 { get; set; }
        public string C2 { get; set; }
        public string C3 { get; set; }
    }
}
