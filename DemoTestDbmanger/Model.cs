using DBManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model.DemoTestDbmanger
{   
    [DataMember(TABLE_NAME = "Model", ID_FIELD = "ID")]
    public class Model
    {
        [DataMember(SYNC_PROERTY=false)]
        public int ID { get; set; }
        public String Name { get; set; }
        public int Role { get; set; }
        public double Count { get; set; }
        public Guid GuId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
    [DataMember(TABLE_NAME = "School", ID_FIELD = "ID")]
    public class School
    {
        public int? ID { get; set; }
        public String Name { get; set; }
        public int? Role { get; set; }
        public double? Count { get; set; }
        public Guid? GuId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? USER_ID { get; set; }
    }

 
}