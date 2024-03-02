namespace ClassLibrary1
{
    public class SalesLine
    {
        //clases oara el conjunto de datos: Sales line y Sales line Ds
        public string CustAccount { get; set; }
        public string CustName { get; set; }
        public string ItemId { get; set; }
        public string Decription  { get; set; }
        public decimal Qty { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
