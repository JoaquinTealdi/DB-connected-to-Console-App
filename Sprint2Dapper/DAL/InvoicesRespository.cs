using Dapper;
using Models;
using Sprint2Dapper;

namespace DAL
{
    public class InvoicesRespository
    {

        public static IEnumerable<CustomersInnerInvoices> GetSalesPerCustomers()
        {
            var sales = DB.db.Query<CustomersInnerInvoices>("SELECT c.last_name," +
                "i.invoice_date," +
                "i.invoice_number,invoice_total AS amount" +
                "FROM Customers c INNER JOIN Invoices i ON c.customer_id = i.customer_id_fk ORDER BY(c.last_name)");

            return sales;
        }

        public static IEnumerable<Invoices> GetTodaySales()
        {
            DateTime date = DateTime.Now;
            var sales = DB.db.Query<Invoices>("SELECT * FROM Invoices WHERE invoice_date=@date", date);
            return sales;
        }
    }
}
