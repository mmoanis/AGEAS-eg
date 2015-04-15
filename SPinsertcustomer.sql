CREATE PROCEDURE Insertcustomer
(
@Customer_ID INT,
@Name  NVARCHAR(50) ,
@Balance  DECIMAL(3,3)
)

AS 
BEGIN
INSERT INTO Customer
(
Customer_ID, 
Name,
 Balance
) 
VALUES
(
@Customer_ID,
@Name,
@Balance
)
END

