using DBManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpdySvc.Models
{
    [DataMember(ID_FIELD = "OrderId", TABLE_NAME = "Qry_OrderDetails") ]
    public class Qry_OrderDetails
    {
      public int  OrderId {get;set;}
      public string  CustomerAccountID {get;set;}
      public string  UserId {get;set;}
      public string  OrderPlacedBy {get;set;}
      public string  CreatedDate {get;set;}
      public string  CustomerOrderNumber {get;set;}
      public string  SpeedyOrderNumber {get;set;}
      public string  DELCode {get;set;}
      public string  OnHireDate {get;set;}
      public string  OffHireDate {get;set;}
      public string  DeliveryCharge {get;set;}
      public string  TotalHire {get;set;}
      public string  TotalBuy {get;set;}
      public string  TotalVAT {get;set;}
      public string  TotalNet {get;set;}
      public string  TotalSpeedyShield {get;set;}
      public string  TotalHireDeposit {get;set;}
      public string  TotalHireCost {get;set;}
      public string  TotalPayable {get;set;}
      public string  Note {get;set;}
      public string  ContactName {get;set;}
      public string  ContactPhoneNumber {get;set;}
      public string  DeliveryMethodId {get;set;}
      public string  BranchName {get;set;}
      public string  CompanyName {get;set;}
      public string  Address1 {get;set;}
      public string  Address2 {get;set;}
      public string  City {get;set;}
      public string  County {get;set;}
      public string  Postcode {get;set;}
      public string  CountryID {get;set;}
      public string  PhoneNumber {get;set;}
      public string  MobileNumber {get;set;}
      public string  FaxNumber {get;set;}
      public string  Email {get;set;}
      public string  AdditionalEmail {get;set;}
      public string  PaymentRefNo {get;set;}
      public string  PaymentMethodID {get;set;}
      public string  OrderStatusID {get;set;}
      public string  POReference {get;set;}
      public string  ApproverID {get;set;}
      public string  ContractNo {get;set;}
      public string  PoId {get;set;}
      public string  HireLimit {get;set;}
      public string  CostCodeName { get; set; }
      public string  Limit {get;set;}
      public string  Name {get;set;}
    }
}