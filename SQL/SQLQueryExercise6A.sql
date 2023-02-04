CREATE DATABASE Sprint2DB;
USE Sprint2DB;
-- A
CREATE TABLE Customers(
	customer_id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	first_name varchar(50) NOT NULL,
	last_name varchar(50) NOT NULL
)

CREATE TABLE Invoices(
	invoice_id INT PRIMARY KEY IDENTITY(1,1),
	invoice_number INT NOT NULL,	
	invoice_date DATE NOT NULL,
	invoice_total FLOAT NOT NULL,
	customer_id_fk INT NOT NULL,
	FOREIGN KEY (customer_id_fk) REFERENCES Customers(customer_id)
)

CREATE TABLE InvoiceDetails(
	invoice_detail_id INT PRIMARY KEY IDENTITY(1,1),
	invoice_id_fk INT NOT NULL,
	product_id_fk INT NOT NULL,
	quantity INT NOT NULL,
	subtotal FLOAT NOT NULL
	FOREIGN KEY(invoice_id_fk) REFERENCES Invoices(invoice_id),
	FOREIGN KEY(product_id_fk) REFERENCES Products(product_id)
)

CREATE TABLE Products (
	product_id INT PRIMARY KEY IDENTITY(1,1),
	category_id_fk INT NOT NULL,
	product_name VARCHAR(50) NOT NULL,
	description VARCHAR(200) NULL,
	price FLOAT NOT NULL,
	FOREIGN KEY(category_id_fk) REFERENCES Categories (category_id)
)

CREATE TABLE Categories (
	category_id INT PRIMARY KEY IDENTITY(1,1),
	category_name VARCHAR(50) NOT NULL,
	category_description VARCHAR(200) NULL
)