-- Database generation script
--
USE master ;

-- remove datbase if it already exists
IF EXISTS(select * from sys.databases where name='AGEAS')
    DROP DATABASE AGEAS


GO


CREATE DATABASE AGEAS;

GO

USE AGEAS;

GO

-- customers table

CREATE TABLE Customer ( 
    Customer_ID INT IDENTITY(1, 1) PRIMARY KEY,
    Name NVARCHAR(50) NOT NULL,
    Balance DECIMAL(3, 3) 
)

 -- suppliers table

CREATE TABLE Supplier (
    Supplier_ID INT IDENTITY(1, 1) PRIMARY KEY,
    Name NVARCHAR(50) NOT NULL,
    Phone VARCHAR(14) NOT NULL UNIQUE,
    Address NVARCHAR(100) NOT NULL,
    Company NVARCHAR(50) NOT NULL UNIQUE
)

GO

-- product table
CREATE TABLE Product (
    Product_ID INT IDENTITY(1, 1) PRIMARY KEY,
    Supplier_ID INT
        FOREIGN KEY REFERENCES Supplier(Supplier_ID),
    Name NVARCHAR(50) NOT NULL,
    TYPE NVARCHAR(50),
    Price DECIMAL(3, 3) NOT NULL
)

-- purchases table
CREATE TABLE Purchase (
    Purchase_ID INT IDENTITY(1, 1) PRIMARY KEY,
    Customer_ID INT
        FOREIGN KEY REFERENCES Customer(Customer_ID),
    Name Nvarchar(50) NOT NULL,
    Discount DECIMAL(3, 3) NOT NULL,
    Total_Revenue DECIMAL(3, 3) NOT NULL
)

-- product purchaese relation
CREATE TABLE Product_Purchase (
    Product_Purchase_ID INT IDENTITY(1, 1) PRIMARY KEY,
    Product_ID INT 
        FOREIGN KEY REFERENCES Product(Product_ID),
    Purchase_ID INT
        FOREIGN KEY REFERENCES Purchase(Purchase_ID),
    Quantity INt NOT NULL
)

