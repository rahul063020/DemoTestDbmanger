using DBManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpdySvc.Models
{
     [DataMember(ID_FIELD = "CCID", TABLE_NAME = "CostCenter")]
    public class CostCenter
    {
         public String CCID { get; set; }
         public String Name { get; set; }
         public String Details { get; set; }
         public int? POID { get; set; }
         public String CostCode { get; set; }
    }
}