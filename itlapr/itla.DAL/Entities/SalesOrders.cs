using itlapr.DAL.Entities.Core;
using System;
using System.Data.SqlTypes;

namespace itlapr.DAL.Entities
{
    public class SalesOrders : AuditEntity
    {
        public int orderid { get; set; }
        public int? custid { get; set; }
        public int empid { get; set; }
        public DateTime orderdate { get; set; }
        public DateTime requireddate { get; set; }
        public DateTime? shippeddate { get; set; }
        public int shipperid { get; set; }
        public SqlMoney freight { get; set; }
        public string shipname { get; set; }
        public string shipadress { get; set; }
        public string shipcity { get; set; }
        public string? shipregion { get; set; }
        public string shipostalcode { get; set; }
        public string shipconuntry { get; set; }
        public DateTime DeletedDate { get; set; }
        public int UserDeleted { get; set;}
    }
}