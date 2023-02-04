namespace Models
{
    public class Invoices
    {
        public int invoice_id { get; set; }
        public int invoice_number { get; set; }
        public DateTime invoice_date { get; set; }
        public double invoice_total { get; set; }
        public int customer_id_fk { get; set; }
    }
}
