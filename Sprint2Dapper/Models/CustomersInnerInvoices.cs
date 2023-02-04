namespace Models
{
    public class CustomersInnerInvoices
    {
        public int customer_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public int invoice_id { get; set; }
        public int invoice_number { get; set; }
        public DateTime invoice_date { get; set; }
        public double invoice_total { get; set; }
        public int customer_id_fk { get; set; }
    }
}
