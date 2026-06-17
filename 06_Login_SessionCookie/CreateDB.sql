-- Run this script in SQL Server Management Studio
-- Creates the LoginDB database and Users table

CREATE DATABASE LoginDB;
GO

USE LoginDB;
GO

CREATE TABLE Users (
    UserId   INT PRIMARY KEY IDENTITY(1,1),
    Username VARCHAR(50) NOT NULL UNIQUE,
    Password VARCHAR(100) NOT NULL,   -- In production: store hashed passwords
    Email    VARCHAR(100),
    CreatedAt DATETIME DEFAULT GETDATE()
);
GO

-- Insert test users
INSERT INTO Users (Username, Password, Email) VALUES
('admin',  'admin123',  'admin@example.com'),
('john',   'pass123',   'john@example.com'),
('alice',  'alice456',  'alice@example.com');
GO

SELECT * FROM Users;
