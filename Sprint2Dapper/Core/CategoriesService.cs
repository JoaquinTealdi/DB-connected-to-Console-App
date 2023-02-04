using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class CategoriesService
    {
        public static void GetCategories()
        {
            var categories = CategoriesRepository.GetCategories();
            foreach (var i in categories)
            {
                Console.WriteLine(i.category_id + " " + i.category_name + " " + i.category_description);
            }
        }
    }
}
