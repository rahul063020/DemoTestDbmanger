using DBManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpdySvc.Models
{
     [DataMember(ID_FIELD = "PCUSR_ID", TABLE_NAME = "ProjectCode_User")]
    public class ProjectCodesUserID
    {
      public int  PCUSR_ID {get;set;}
      public int  PCID {get;set;}
      public int  USERID {get;set;}
    }
}