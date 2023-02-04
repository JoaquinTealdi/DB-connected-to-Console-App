using Dapper;
using Models;
using Sprint2Dapper;
using System.Data;

namespace DAL
{
    public class ProductsRepository
    { 
        public static IEnumerable<Products> GetProducts()
        {
            var products = DB.db.Query<Products>("SELECT * FROM Products");
            return products;          
        }
    }
}
