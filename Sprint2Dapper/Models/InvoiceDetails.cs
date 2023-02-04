namespace Models
{
    public class InvoiceDetails
    {
        public int invoice_detail_id { get; set; }
        public int invoice_id_fk{ get; set; }
        public int product_id_fk { get; set; }
        public int quantity { get; set; }
        public double subtotal { get; set; }
    }
}
