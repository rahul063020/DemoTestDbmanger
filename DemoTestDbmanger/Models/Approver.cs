using DBManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpdySvc.Models
{
    [DataMember(ID_FIELD = "ID", UPDATE_FIELD = "ID", ERASE_FIELD = "ApproverID", TABLE_NAME = "Tbl_Approver")]
    public class Approver
    {
        public int? ID { get; set; }
        public int FromHour { get; set; }
        public int ToHour { get; set; }
        public int ApproverID { get; set; }
        public int TotalWorkingHour { get; set; }
        public int Day { get; set; }
        public DateTime? CreatedAt { get; set; }

    }
    [DataMember(TABLE_NAME = "Qry_Approver_user")]
    public class ApproverMdl
    {
        public int? ID { get; set; }
        public int FromHour { get; set; }
        public int ToHour { get; set; }
        public int ApproverID { get; set; }
        public int TotalWorkingHour { get; set; }
        public int Day { get; set; }
        public DateTime CreatedAt { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserID { get; set; }
        public string Email { get; set; }
        public bool  Sun { get; set; }
        public bool  Mon { get; set; }
        public bool  Tue { get; set; }
        public bool  Wed { get; set; }
        public bool  Thu { get; set; }
        public bool  Fri { get; set; }
        public bool  Sat { get; set; }
        public DateTime? FromHoliday { get; set; }
        public DateTime? ToHoliday { get; set; }
    }

    [DataMember(ID_FIELD = "ID", UPDATE_FIELD = "ID", ERASE_FIELD = "ApproverID", TABLE_NAME = "Tbl_ApproverDetails")]
    public class ApproverDelails
    {
        public int? ID { get; set; }
        public int ApproverID { get; set; }
        public bool Sun { get; set; }
        public bool Mon { get; set; }
        public bool Tue { get; set; }
        public bool Wed { get; set; }
        public bool Thu { get; set; }
        public bool Fri { get; set; }
        public bool Sat { get; set; }
        public DateTime? FromHoliday { get; set; }
        public DateTime? ToHoliday { get; set; }

    }
}