namespace Models
{
    public class Products
    {
        public int product_id { get; set; }
        public int category_id_fk { get; set; }
        public string product_name { get; set; }
        public string description { get; set; }
        public double price { get; set; }
    }
}
