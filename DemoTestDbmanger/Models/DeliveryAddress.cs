using DBManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpdySvc.Models
{
    [DataMember(ID_FIELD = "DAId", TABLE_NAME = "DeliveryAddress", ERASE_FIELD = "DAId")]
    public class DeliveryAddress
    {
        public int DAId { get; set; }
        public String ContactName { get; set; }
        public String ContactPhoneNumber { get; set; }
        public String BranchName { get; set; }
        public String CompanyName { get; set; }
        public String Address1 { get; set; }
        public String Address2 { get; set; }
        public String City { get; set; }
        public String County { get; set; }
        public String Postcode { get; set; }
        public int CountryID { get; set; }
        public String PhoneNumber { get; set; }
        public String MobileNumber { get; set;}
        public String FaxNumber { get; set; }
        public String Email { get; set; }
        public String AdditionalEmail { get; set; }
        public int CreatedBy { get; set; }
        public String CreatedAt { get; set; }
    }
}