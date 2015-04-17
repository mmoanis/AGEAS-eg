CREATE PROCEDURE Insertcustomer
(
@Name  NVARCHAR(50) ,
@Balance  DECIMAL(3,3)
)

AS 
BEGIN
INSERT INTO Customer
(
Name,
 Balance
) 
VALUES
(
@Name,
@Balance
)
END

