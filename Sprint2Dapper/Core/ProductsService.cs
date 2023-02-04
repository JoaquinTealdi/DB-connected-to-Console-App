using DAL;
using Models;

namespace Core
{
    public class ProductsService  
    {
        public static void GetProducts()
        {
            var products = ProductsRepository.GetProducts();
            foreach (var i in products)
            {
                Console.WriteLine(i.product_id +" "+ i.product_name +" "+i.description + " " +i.price);
            };
        }
    }
}
