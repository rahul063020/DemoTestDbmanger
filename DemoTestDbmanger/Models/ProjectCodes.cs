using DBManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpdySvc.Models
{
     [DataMember(ID_FIELD = "PCID", TABLE_NAME = "ProjectCodes") ]
    public class ProjectCodes
    {
      public int PCID {get;set;}
      public string Name {get;set;}
      public DateTime CreationTime {get;set;}
      public int CreatedBy {get;set;}
      public bool Status {get;set;}

     //Additional Fields
      public int? USERID { get; set; }
      public string Email { get; set; }
      public string FirstName { get; set; }
      public string LastName { get; set; }
      public string JobTitle { get; set; }
      public string MobileNumber { get; set; }

    }
}