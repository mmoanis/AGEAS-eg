CREATE PROCEDURE deletecustomer

@Customer_ID INT


AS
DELETE Customer
FROM Customer
WHERE Customer_ID=@Customer_ID
