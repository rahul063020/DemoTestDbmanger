using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DBManager;

namespace SpdySvc.Models
{
    public class Cart
    {
        public String ITEM_ID { get; set; }
        public String Quantity { get; set; }
        public String ProductCode { get; set; }
        public String ProductName { get; set; }
        public String UnitQty { get; set; }
        public String FromDate { get; set; }
        public String ToDate { get; set; }
        public Decimal Cost { get; set; }
        public Decimal TotalHireValue { get; set; }
        public Decimal TotalBuyValue { get; set; }
        public Decimal TotalSpeedyShield { get; set; }
        public Decimal TotalVAT { get; set; }
        public Decimal TotalHireCost { get; set; }        
        public String Logo { get; set; }
        public String TotalDays { get; set; }
        public String Currency { get; set; }       
        
    }
    
    public class OrderSummery
    {
        public String OrderId { get; set; }
        public String SubTotal { get; set; }
        public String GrandTotal { get; set; }
        public String Vat { get; set; }        
    }
}