using DBManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpdySvc.Models
{
     [DataMember(ID_FIELD = "OrderId", TABLE_NAME = "Qry_ReportOrderBasedOnCC")]
    public class orderPdf
    {
        public int OrderId { get; set; }
        public string CustomerOrderNumber { get; set; }
         public string AccountName { get; set; }
         public string FirstName { get; set; }
         public string LastName { get; set; }
         public string CostCodeName { get; set; }
         public string POName { get; set; }
         public int POID { get; set; }
         public decimal TotalHire { get; set; }
         public decimal TotalBuy { get; set; }
         public decimal TotalVat { get; set; }
         public decimal Limit { get; set; }
         public decimal SpendLimit { get; set; }
         public decimal TotalHireCost { get; set; }

    }
}