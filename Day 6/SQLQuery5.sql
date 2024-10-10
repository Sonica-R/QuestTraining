CREATE TABLE users(
	id INT PRIMARY KEY IDENTITY,
	first_name VARCHAR(50) NOT NULL,
	last_name VARCHAR(50) NOT NULL,
	email VARCHAR(100) NOT NULL UNIQUE,
	age INT NOT NULL DEFAULT 18
)

INSERT INTO users(first_name, last_name, email, age) VALUES
--('User', '1', 'user1@mail.com', 20)
--('User', '2', 'user2@mail.com', 22)
('User', '3', 'user3@mail.com', 23)