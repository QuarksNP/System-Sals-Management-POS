using System.Data.SqlTypes;

namespace itlapr.Web.Models
{
    public class SalesModel
    {
        public int orderid { get; set; }
        public int custid { get; set; }
        public int empid { get; set; }
        public string orderdate { get; set; }
        public string requireddate { get; set; }
        public int shipperid { get; set; }
        public string shippeddate { get; set; }

        public double freight { get; set; }
        public string shipname { get; set; }
        public string shipadress { get; set; }
        public string shipcity { get; set; }
        public string shipregion { get; set; }
        public string shipostalcode { get; set; }
        public string shipconuntry { get; set; }
    }
}