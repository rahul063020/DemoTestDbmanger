using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpdySvc.Models
{
    public class JQueryDataTableParamModel
    {
        public bool bDestroy {get;set;}
        public bool bFilter { get; set; }
        public string sSearch { get; set; }
        public int iDisplayStart { get; set; }
        public int iDisplayLength { get; set; }
        public string sEcho { get; set; }
    }
}