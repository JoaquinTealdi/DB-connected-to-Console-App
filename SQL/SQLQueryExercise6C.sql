USE Sprint2DB;

-- i
SELECT c.category_name, 
	count(p.product_id) AS Products_Amount 
FROM Categories c INNER JOIN Products p ON c.category_id = p.category_id_fk
GROUP BY(c.category_name);

--ii
--name
SELECT c.last_name,
	i.invoice_date,
	i.invoice_number,
	invoice_total AS amount
FROM Customers c INNER JOIN Invoices i ON c.customer_id = i.customer_id_fk
ORDER BY(c.last_name);

--date
SELECT c.last_name,
	i.invoice_date,
	i.invoice_number,
	invoice_total AS amount
FROM Customers c INNER JOIN Invoices i ON c.customer_id = i.customer_id_fk
ORDER BY(i.invoice_date);

--iii
SELECT p.product_name,
	p.description,
	p.price
FROM Products p INNER JOIN InvoiceDetails i ON p.product_id = i.product_id_fk
				INNER JOIN Invoices n ON n.invoice_id = i.invoice_id_fk
				WHERE( n.invoice_date =	CONVERT(DATE,'12/26/2022',101));