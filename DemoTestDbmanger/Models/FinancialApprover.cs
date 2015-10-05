using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DBManager;

namespace SpdySvc.Models
{
    [DataMember(ID_FIELD = "FAID", TABLE_NAME = "FinancialApprover")]
    public class FinancialApprover
    {
        public int FAID { get; set; }
        public int UserId { get; set; }
        public String AssignUserID { get; set; }        
        public String Email { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String AF { get; set; }
        public String AL { get; set; }
    }

}