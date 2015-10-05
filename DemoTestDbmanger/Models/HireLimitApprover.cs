using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpdySvc.Models
{

    public class HireLimitApprover
    {
        public int UserID{get;set;}
        public String Email{get;set;}
        public String FirstName{get;set;}
        public String LastName{get;set;}
        public String JobTitle{get;set;}
        public double HireLimit{get;set;}
        public int  Role_ID{get;set;}
        public String Role_Name { get; set; }

    }
}