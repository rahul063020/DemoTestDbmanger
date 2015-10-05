using DBManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpdySvc.Models
{
    public class Authorization
    {
        public UserRoles AssignedUserRole { get; set; }

        public enum UserRoles
        {
          Admin=1,
          Approver, 
          Requestor,
          AccountManager
        }
        public Authorization()
        { 
        
        }
        public int UserID { get; set; }
        public int UserRoleID { get; set; }
        public bool CanApprove { get; set; }
        public bool CanCancel { get; set; }
        public bool CanViewHire { get; set; }
        public bool CanViewUser { get; set; }
        public int AccessLevel { get; set; }
        public List<Tbl_Role> UserRolesList { get; set; }
          
        public bool HasRole(UserRoles ur)
        {
            bool hasrole = false;

            if (AssignedUserRole == ur)
                hasrole = true;

            return hasrole;
        }

        [DataMember(ID_FIELD = "Permission_ID", TABLE_NAME = "Tbl_Permission")]
        public class Tbl_Permission
        {
            public String Permission_ID { get; set; }
            public bool CanApprove { get; set; }
            public bool CanCancel { get; set; }
            public bool CanViewHire { get; set; }
            public bool CanViewUser { get; set; }
           
        }

        [DataMember(ID_FIELD = "Role_ID", TABLE_NAME = "Tbl_Role")]
        public class Tbl_Role
        {
            public String Role_ID { get; set; }
            public String Role_Name { get; set; }
            public String Role_Priority { get; set; }
        }

        
        [DataMember(ID_FIELD = "LinkRolePermission_ID", TABLE_NAME = "Tbl_RolePermission")]
        public class Tbl_RolePermission
        {
            public String LinkRolePermission_ID { get; set; }
            public String Permission_ID { get; set; }
            public String Role_ID { get; set; }
        }

        [DataMember(ID_FIELD = "UserRole_ID", TABLE_NAME = "Tbl_UserRole")]
        public class Tbl_UserRole
        {
            public String UserRole_ID { get; set; }
            public String User_ID { get; set; }
            public String Role_ID { get; set; }
        }

         [DataMember(ID_FIELD = "UserID", TABLE_NAME = "Qry_UserDetails")]
        public class Qry_UserRoleDetails
        { 
      public String  UserID{ get; set; }
      public String CustomerID{ get; set; }
      public String Token{ get; set; }
      public String Email{ get; set; }
      public String Password{ get; set; }
      public String Admin{ get; set; }
      public String AdminID{ get; set; }
      public String FirstName{ get; set; }
      public String LastName{ get; set; }
      public String JobTitle{ get; set; }
      public String Address1{ get; set; }
      public String Address2{ get; set; }
      public String Address3{ get; set; }
      public String City{ get; set; }
      public String County{ get; set; }
      public String CountryID{ get; set; }
      public String PostCode{ get; set; }
      public String PhoneNumber{ get; set; }
      public String PhoneDiallingCode{ get; set; }
      public String PhoneExtension{ get; set; }
      public String MobileNumber{ get; set; }
      public String FaxNumber{ get; set; }
      public String Notes{ get; set; }
      public String Division{ get; set; }
      public String Disabled{ get; set; }
      public String CreateDateTime{ get; set; }
      public String CreatedBy{ get; set; }
      public String LastModifiedDateTime{ get; set; }
      public String LastModifiedBy{ get; set; }
      public String LastLoginDateTime{ get; set; }
      public String UserType{ get; set; }
      public String ReceivesMails{ get; set; }
      public String Title{ get; set; }
      public String DateOfBirth{ get; set; }
      public String HireLimit{ get; set; }
      public String LimitPercentage{ get; set; }
      public String SaltedPassword{ get; set; }
      public String UserRoleID{ get; set; }
      public String Role_Name{ get; set; }
      public String Role_Priority{ get; set; }
      public String UserRole_ID{ get; set; }
      public String User_ID{ get; set; }
      public String Role_ID{ get; set; }
      public String Permission_ID{ get; set; }
      public String CanApprove{ get; set; }
      public String CanCancel{ get; set; }
      public String CanViewHire{ get; set; }
      public String CanViewUser { get; set; }
        
        }

    }
}