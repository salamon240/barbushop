using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace barbushop
{
    public class DbListAdapter
    {
        public string field { get; set; }
        public string value { get; set; }

        public DbListAdapter(string field, string value)
        {
            this.field = field;
            this.value = value;

        }
        
    }
}