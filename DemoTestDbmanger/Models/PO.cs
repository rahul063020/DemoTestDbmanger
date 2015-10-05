using DBManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpdySvc.Models
{
    [DataMember(ID_FIELD = "PoID", TABLE_NAME = "Tbl_PO")]
    public class PO
    {
        public String PoID { get; set; }
        public String PoRef { get; set; }
        public String POName { get; set; }
        public double? Limit { get;set; }
        public bool Status { get; set; }
        public String CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public int? ApproverID { get; set; }
        public String CostCode { get; set; }
        public int? CostCodeID { get; set; }
        
    }

    [DataMember(ID_FIELD = "CostCodeId", UPDATE_FIELD = "CostCodeId", TABLE_NAME = "Tbl_CostCode")]

    public class CostCode
    {
        public int CostCodeId { get; set; }
        public int  POID { get; set; }
        public double Limit { get; set; }
        public String CostCodeName { get; set; }
        public String POName { get; set; }
        public double Threashold { get; set; }
    }

    [DataMember(ID_FIELD = "PoID", TABLE_NAME = "Tbl_PO")]
    public class POApprover
    {
        public String PoID { get; set; }
        public String PoRef { get; set; }
        public String POName { get; set; }
        public double? Limit { get; set; }
        public DateTime? CreatedTime { get; set; }
        public int? ApproverID { get; set; }
        public String CostCode { get; set; }
        public int? CostCodeID { get; set; }


    }
}