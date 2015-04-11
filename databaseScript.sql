-- Database generation script
--
USE master ;

GO


CREATE DATABASE AGEAS;

GO

USE AGEAS;

GO

-- customers table

CREATE TABLE Customer ( 
    Customer_ID INT IDENTITY(1, 1) PRIMARY KEY,
    Name Nvarchar(50) NOT NULL,
    Balance decimal(3, 3) 
)

 -- suppliers table

CREATE TABLE Supplier (
    Supplier_ID INT IDENTITY(1, 1) PRIMARY KEY,
    Name Nvarchar(50) NOT NULL,
    Phone varchar(14) NOT NULL UNIQUE,
    Address nvarchar(100) NOT NULL,
    Company nvarchar(50) NOT NULL UNIQUE
)

GO


CREATE TABLE Product (
    Product_ID INT IDENTITY(1, 1) PRIMARY KEY,
    Supplier_ID INT
        FOREIGN KEY REFERENCES Supplier(Supplier_ID),
    Name Nvarchar(50) NOT NULL,
    TYPE nvarchar(50),
    Price decimal(3, 3) NOT NULL
)


CREATE TABLE Transaction (
    Transaction_ID INT IDENTITY(1, 1) PRIMARY KEY,
    Customer_ID INT
        FOREIGN KEY REFERENCES Customer(Customer_ID),
    Name Nvarchar(50) NOT NULL,
    Discount decimal(3, 3) NOT NULL,
    Total_Revenue decimal(3, 3) NOT NULL
)


CREATE TABLE Product_Transaction (
    Product_Transaction_ID int IDENTITY(1, 1) PRIMARY KEY,
    Product_ID INT 
        FOREIGN KEY REFERENCES Product(Product_ID),
    Transaction_ID INT
        FOREIGN KEY REFERENCES Transaction(Transaction_ID),
    Quantity INt NOT NULL
)

