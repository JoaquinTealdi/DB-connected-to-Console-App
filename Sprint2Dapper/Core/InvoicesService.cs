using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class InvoicesService
    {
        public static void GetSalesPerCustomers()
        {
            var sales = InvoicesRespository.GetSalesPerCustomers();
            foreach (var i in sales)
            {
                Console.WriteLine(i.last_name+ " " +i.invoice_id+ " " +i.invoice_date + " " +i.invoice_total);
            }
        }

        public static void GetTodaySales()
        {
            var sales = InvoicesRespository.GetTodaySales();
            foreach (var i in sales)
            {
                Console.WriteLine(i.invoice_id+ " " + i.invoice_date + " " + i.invoice_total);
            }
        }
    }
}
