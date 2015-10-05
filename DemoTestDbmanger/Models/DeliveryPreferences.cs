using DBManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpdySvc.Models
{
    public class DeliveryPreferences
    {
        public int  DeliveryMethodId { get; set; }
        public String BranchName { get; set; }
        public String SiteContactName { get; set; }
        public String SiteContactTelephone { get; set; }
        public String FullTradingName { get; set; }
        public String PostCode { get; set; }
        public String Address1 { get; set; }
        public String Address2 { get; set; }
        public String City { get; set; }
        public String County { get; set; }
        public String Country { get; set; }
        public String Telephone { get; set; }
        public String Mobile { get; set; }
        public String Fax { get; set; }
        public String DeliveryInstructions { get; set; }
        public int PoId { get; set; }
        public int CCId { get; set; }
        
        
    }
}