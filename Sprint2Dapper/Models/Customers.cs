namespace Models
{
    public class Customers
    {
        public int customer_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public Invoices invoice { get; set; }     
    }
    
}
