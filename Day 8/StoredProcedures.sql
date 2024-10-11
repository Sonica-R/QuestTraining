/*CREATE TABLE medications(
	id INT PRIMARY KEY IDENTITY(1, 1),
	name VARCHAR(50),
	category VARCHAR(50),
	expiry_date INT,
	supplier_id INT,
	stock_quantity INT

	CONSTRAINT fk_supplier_id FOREIGN KEY (supplier_id) REFERENCES suppliers(id)
)*/

/*CREATE TABLE suppliers(
	id INT PRIMARY KEY IDENTITY(1, 1),
	name VARCHAR(50) NOT NULL,
	contact_person VARCHAR(50),
	phone BIGINT,
	email VARCHAR(25),
	address VARCHAR(50)
)*/

/*CREATE TABLE customers(
	id INT PRIMARY KEY IDENTITY(1, 1),
	name VARCHAR(50) NOT NULL,
	phone BIGINT,
	email VARCHAR(25),
	address VARCHAR(50)
)*/

/*CREATE TABLE sales(
	id INT PRIMARY KEY IDENTITY(1, 1),
	customer_id INT,
	medication_id INT,
	quantity INT,
	sale_date DATETIME DEFAULT GETDATE(),
	total_price DECIMAL(15, 2)

	CONSTRAINT fk_sale_id FOREIGN KEY (customer_id) REFERENCES customers(id),
	CONSTRAINT fk_medication_id FOREIGN KEY (medication_id) REFERENCES medications(id)
)*/

/*CREATE TABLE inventory(
	id INT PRIMARY KEY IDENTITY(1, 1),
	medication_id INT,
	supplier_id INT,
	stock_in INT,
	stock_out INT,
	date_added DATETIME DEFAULT GETDATE()

	CONSTRAINT fk_medication_inventory_id FOREIGN KEY (medication_id) REFERENCES medications(id),
	CONSTRAINT fk_suppier_nventory_id FOREIGN KEY (supplier_id) REFERENCES suppliers(id)
)*/

/*CREATE PROCEDURE sp_CreateMedication
	@name VARCHAR(50),
	@category VARCHAR(50),
	@expiry_date INT,
	@supplier_id INT,
	@stock_quantity INT
AS
BEGIN
	INSERT INTO medications(name, category, expiry_date, supplier_id, stock_quantity) VALUES 
	(@name, @category, @expiry_date, @supplier_id, @stock_quantity)

END*/

	--INSERT INTO MEDICATIONS
/*EXEC sp_CreateMedication 
    @name = 'Paracetamol',
    @category = 'Analgesic',
    @expiry_date = 202507,
    @supplier_id = 1,
    @stock_quantity = 150;*/

/*CREATE PROCEDURE sp_CreateSuppliers
	@name VARCHAR(50),
	@contact_person VARCHAR(50),
	@phone BIGINT,
	@email VARCHAR(25),
	@address VARCHAR(50)
AS
BEGIN
	INSERT INTO suppliers(name, contact_person, phone, email, address) VALUES
	(@name, @contact_person, @phone, @email, @address)
END*/

/*EXEC sp_CreateSuppliers
    @name = 'HealthCorp',
    @contact_person = 'John Doe',
    @phone = 9876543210,
    @email = 'johndoe@healthcorp.com',
    @address = '123 Health Street, Springfield';*/

/*CREATE PROCEDURE sp_CreateCustomers
	@name VARCHAR(50),
	@phone BIGINT,
	@email VARCHAR(25),
	@address VARCHAR(50)
AS
BEGIN
	INSERT INTO customers(name, phone, email, address) VALUES
	(@name, @phone, @email, @address)
END*/

--DROP PROCEDURE sp_CreateCustomers;

/*EXEC sp_CreateCustomers
    @name = 'Jane Smith',
    @phone = 9876543210,
    @email = 'janesmith@gmail.com',
    @address = '456 Maple Avenue, Newtown';*/

    --INSERT NEW CUSTOMER
	/*EXEC sp_CreateCustomers
    @name = 'John Doe',
    @phone = 9876543233,
    @email = 'johndoe@gmail.com',
    @address = '789 Oak Drive, Lakeside';*/

/*CREATE PROCEDURE sp_CreateSales
	@customer_id INT,
	@medication_id INT,
	@quantity INT,
	@sale_date DATETIME,
	@total_price DECIMAL(15, 2)
AS
BEGIN
	INSERT INTO sales(customer_id, medication_id, quantity, sale_date, total_price) VALUES
	(@customer_id, @medication_id, @quantity, @sale_date, @total_price)
END*/

/*EXEC sp_CreateSales
    @customer_id = 1,
    @medication_id = 2,
    @quantity = 3,
    @sale_date = '2024-10-10 10:00:00',
    @total_price = 150.75;*/

--JOIN query to fetch medications and its supplier names
/*SELECT medications.name, suppliers.name 
FROM medications 
INNER JOIN 
suppliers 
ON medications.supplier_id = suppliers.id
ORDER BY medications.supplier_id;*/

--Sales data
/*SELECT medications.name AS medcicine_name, customers.name AS customer_name, sales.quantity AS sales_quantity 
FROM sales
INNER JOIN 
customers
ON customers.id = sales.customer_id
INNER JOIN 
medications
ON medications.id = sales.medication_id
ORDER BY 
customers.id;*/

--
SELECT * FROM medications WHERE expiry_date > 60;





