CREATE TABLE userdata(
	user_id BIGINT IDENTITY,
	first_name VARCHAR(50) NOT NULL,
	last_name VARCHAR(50) NOT NULL,
	username VARCHAR(25) NOT NULL,
	email VARCHAR(100) NOT NULL,
	phone_number VARCHAR(20),
	dob DATETIME,
	password_hash VARCHAR(250),	
	about TEXT
);

--ALTER TABLE userdata ADD CONSTRAINT PK_users_id PRIMARY KEY (user_id);

--ALTER TABLE userdata ADD CONSTRAINT users_username UNIQUE (username)

--ALTER TABLE userdata ADD CONSTRAINT UQ_users_email UNIQUE (email)

--CREATE INDEX IX_users_phone ON userdata (phone_number)

--ALTER TABLE userdata ADD CONSTRAINT CHK_users_phone CHECK (LEN(phone_number) BETWEEN 7 AND 20)

--ALTER TABLE userdata ADD CONSTRAINT CHK_users_dob CHECK (dob < GETDATE())

/*INSERT INTO userdata (first_name, last_name, username, email, phone_number, dob, password_hash, about) VALUES
('John', 'Doe', 'jdoe', 'johndoe@example.com', '555-1234', '1990-01-01', 'hash123', 'Loves technology.'),
('Jane', 'Smith', 'jsmith', 'janesmith@example.com', '555-5678', '1992-05-10', 'hash456', 'Enjoys photography.'),
('Alice', 'Johnson', 'ajohnson', 'alicej@example.com', '555-8765', '1988-09-15', 'hash789', 'Avid traveler and writer.'),
('Bob', 'Brown', 'bbrown', 'bobb@example.com', '555-4321', '1995-03-20', 'hash101', 'Fitness enthusiast and gamer.'),
('Charlie', 'Davis', 'cdavis', 'charlied@example.com', '555-6789', '1993-07-30', 'hash102', 'Passionate about music.'),
('Emily', 'Miller', 'emiller', 'emilym@example.com', '555-9876', '1985-12-12', 'hash103', 'Artist and designer.'),
('Frank', 'Wilson', 'fwilson', 'frankw@example.com', '555-3456', '1991-11-22', 'hash104', 'Software engineer.'),
('Grace', 'Lee', 'glee', 'gracel@example.com', '555-6543', '1994-06-15', 'hash105', 'Loves cooking and baking.'),
('Henry', 'Taylor', 'htaylor', 'henryt@example.com', '555-8769', '1996-10-05', 'hash106', 'Photography enthusiast.'),
('Ivy', 'Harris', 'iharris', 'ivyh@example.com', '555-6547', '1990-08-08', 'hash107', 'Enjoys outdoor adventures.');*/


