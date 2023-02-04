using Core;
using Dapper;
using Sprint2Dapper;
using System.ComponentModel.Design;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.Xml.Schema;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Choice an option:");
            Console.WriteLine("1: Products Stock");
            Console.WriteLine("2: Sales per Customers");
            Console.WriteLine("3: Sales Report of the day");
            Console.WriteLine("4: Categories");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ProductsService.GetProducts(); break;
                case 2:
                    InvoicesService.GetSalesPerCustomers(); break;
                case 3:
                    InvoicesService.GetTodaySales(); break;
                case 4:
                    CategoriesService.GetCategories(); break;
                default:
                    throw new Exception("¡Error! Wrong option, you can only choice 1, 2, 3 or 4"); break;
            }
        }
        catch (Exception e)
        {

            Console.WriteLine(e.Message);
        }
        Console.ReadLine();
    }
}
