/*CREATE TABLE account(
	account_id BIGINT PRIMARY KEY,
	account_no INT,
	username varchar(50),
	date_created DATETIME,
	address varchar(50),
	phone_no BIGINT,
	account_type varchar(25),
	account_balance DECIMAL(18, 2)
)*/
--SELECT * FROM account
/*CREATE TABLE transactions(
	transaction_id BIGINT PRIMARY KEY,
	from_account_id BIGINT,
	transfer_date DATETIME,
	transaction_type varchar(25),
	account_id BIGINT,
	to_account_id BIGINT,
	transaction_amount DECIMAL,

	CONSTRAINT fk_account_id FOREIGN KEY (from_account_id) REFERENCES account(account_id)
)*/

--ALTER TABLE transactions ALTER COLUMN from_account BIGINT;
--ALTER TABLE transactions ADD CONSTRAINT fk_transac_id FOREIGN KEY (account_id) REFERENCES account(account_id)

--ALTER TABLE transactions DROP CONSTRAINT fk_account_id;
--SELECT * FROM transactions;


/*INSERT INTO account (account_id, account_no, username, date_created, address, phone_no, account_type, account_balance) VALUES
(1, 1010, 'jdoe', '2024-01-01 10:00:00', '123 Elm St', 5551234567, 'Savings', 1000.00),
(2, 1020, 'asmith', '2024-01-05 09:30:00', '456 Oak St', 5552345678, 'Checking', 2500.00),
(3, 1030, 'mjones', '2024-01-10 12:15:00', '789 Maple St', 5553456789, 'Savings', 500.00),
(4, 1040, 'bwhite', '2024-01-12 08:45:00', '135 Pine St', 5554567890, 'Checking', 3000.00),
(5, 1050, 'klewis', '2024-01-15 11:20:00', '246 Birch St', 5555678901, 'Savings', 1500.00),
(6, 1060, 'hparker', '2024-01-20 10:10:00', '357 Cedar St', 5556789012, 'Checking', 1200.00),
(7, 1070, 'dgreen', '2024-01-25 09:00:00', '468 Spruce St', 5557890123, 'Savings', 800.00),
(8, 1080, 'mturner', '2024-01-30 08:30:00', '579 Willow St', 5558901234, 'Checking', 4000.00),
(9, 1090, 'lking', '2024-02-01 10:45:00', '680 Redwood St', 5559012345, 'Savings', 900.00),
(10, 1100, 'nperez', '2024-02-05 11:55:00', '791 Cypress St', 5550123456, 'Checking', 3500.00);*/

/*INSERT INTO transactions (transaction_id, account_id, transfer_date, transaction_type, account_id, to_account_id, transaction_amount) VALUES
(1, 1010, '2024-02-10 14:30:00', 'Transfer', 1, 1020, 200.00),
(2, 1020, '2024-02-11 11:15:00', 'Transfer', 2, 1030, 300.00),
(3, 1030, '2024-02-12 09:45:00', 'Deposit', 3, NULL, 150.00),
(4, 1040, '2024-02-13 16:00:00', 'Withdrawal', 4, NULL, 500.00),
(5, 1050, '2024-02-14 10:30:00', 'Transfer', 5, 1060, 100.00),
(6, 1060, '2024-02-15 13:45:00', 'Transfer', 6, 1070, 250.00),
(7, 1070, '2024-02-16 15:30:00', 'Deposit', 7, NULL, 300.00),
(8, 1080, '2024-02-17 12:00:00', 'Withdrawal', 8, NULL, 200.00),
(9, 1090, '2024-02-18 08:30:00', 'Transfer', 9, 1100, 400.00),
(10, 1100, '2024-02-19 10:00:00', 'Deposit', 10, NULL, 500.00);*/

/*INSERT INTO transactions (transaction_id, from_account_id, transfer_date, transaction_type, account_id, to_account_id, transaction_amount) VALUES 
(101, 1, '2024-02-10 09:30:00', 'Transfer', 1, 2, 500.00),
(102, 2, '2024-02-12 14:20:00', 'Withdrawal', 2, NULL, 300.00),
(103, 3, '2024-02-14 11:45:00', 'Deposit', 3, NULL, 200.00),
(104, 4, '2024-02-16 16:00:00', 'Transfer', 4, 5, 1000.00),
(105, 5, '2024-02-18 12:30:00', 'Withdrawal', 5, NULL, 150.00),
(106, 6, '2024-02-20 10:10:00', 'Transfer', 6, 7, 400.00),
(107, 7, '2024-02-22 09:00:00', 'Deposit', 7, NULL, 500.00),
(108, 8, '2024-02-24 08:45:00', 'Transfer', 8, 9, 1200.00),
(109, 9, '2024-02-26 10:15:00', 'Withdrawal', 9, NULL, 250.00),
(110, 10, '2024-02-28 11:55:00', 'Transfer', 10, 1, 3000.00);*/


--DELETE FROM account WHERE account_id = 2;
--SELECT * FROM account;

--UPDATE account SET account_balance = account_balance - 500 WHERE account_id = 4;
--SELECT * FROM account WHERE account_id = 4;

--UPDATE account SET account_balance = account_balance + 500 WHERE account_id = 4;
--SELECT * FROM account WHERE account_id = 4;

--UPDATE account SET username = 'John', phone_no = 9007890389, address = 'New York', account_type = 'Current' WHERE account_id = 5;
--SELECT * from account WHERE account_id = 5;

--INSERT INTO transactions (transaction_id, from_account, transfer_date, transaction_type, account_id, to_account, transaction_amount) VALUES (11, 1010, '2024-02-20 09:45:00', 'Transfer', 1, 1030, 350.00)
--UPDATE accounts SET account_balance = account_balance + 700 WHERE account_id = 1;

/*SELECT account.account_id as acc_id, account.username as acc_name, transactions.transaction_id as transac_id, transactions.transaction_type as transac_type, transactions.transfer_date as [date] from 
account 
INNER JOIN 
transactions
ON account.account_id = transactions.account_id WHERE account.account_id = 1;*/

--SELECT * FROM account WHERE account_no = (SELECT account_no FROM account WHERE account_no = 101)