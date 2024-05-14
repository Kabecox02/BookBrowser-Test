CREATE DATABASE BookBrowser;

USE BookBrowser
GO

CREATE TABLE Books (
	Author VARCHAR(50), 
	Genre VARCHAR(100),
	ISBN INT,
	Title VARCHAR(100), 
	Publisher VARCHAR(100)
);

CREATE TABLE BookHistory (
	Author VARCHAR(50), 
	Genre VARCHAR(100), 
	ISBN INT, 
	Title VARCHAR(100), 
	Publisher VARCHAR(100)
);

CREATE TABLE credentials (
	username VARCHAR(20),
	passwrd VARCHAR(20)
);

INSERT INTO Books (Author, Genre, ISBN, Title, Publisher)
VALUES
	('Edgar Allen Poe', 'Gothic Fiction', 1, 'The Raven', 'Harper & Brothers'),
	('F. Scott Fitzgerald', 'Tragedy', 2, 'The Great Gatsby', 'Charles Scribner''s Sons'),
	('J.D. Salinger', 'Realistic Fiction', 3, 'The Catcher in the Rye', 'Litte, Brown and Company'),
	('Herman Melville', 'Adventure Fiction', 4, 'Moby Dick', 'Harper & Brothers'),
	('Harper Lee', 'Thriller', 5, 'To Kill a Mockingbirg', 'HarperCollins Publisher'),
	('Jane Austen', 'Romance', 6, 'Pride and Prejudice', 'T. Egerton, Whitehall'),
	('Emily Bronte', 'Gothic Fiction', 7, 'Wuthering Heights', 'Simon & Schuster'),
	('John Steinbeck', 'Historical Fiction', 8, 'The Grapes of Wrath', 'The Viking Press-Kames Lloyd'),
	('Mark Twain', 'Fiction', 9, 'Adventures of Huckleberry Finn', 'Chatto & Windus'),
	('George Orwell', 'Political Sattire', 10, 'Animal Farm', 'Secker and Warburg');

INSERT INTO credentials (username, passwrd)
VALUES ('Admin', 'Admin123');
	
