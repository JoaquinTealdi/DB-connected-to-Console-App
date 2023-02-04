using Dapper;
using Models;
using Sprint2Dapper;

namespace DAL
{
    public class CategoriesRepository
    {
        public static IEnumerable<Categories> GetCategories()
        {
            var categories = DB.db.Query<Categories>("SELECT * FROM Categories");
            return categories;
        }
    }
}
