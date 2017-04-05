using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POC.DynamicColumns.Models
{
    public class Column
    {
        public string Name { get; set; }
        public List<Row> Rows { get; set; }
    }
}