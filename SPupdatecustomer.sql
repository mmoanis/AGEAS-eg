CREATE PROCEDURE UpdateCustomer
(
@Customer_ID INT, 
@Name  NVARCHAR(50) ,
@Balance  DECIMAL(3,3)
)

AS 
BEGIN
UPDATE Customer SET




Name=@Name,
Balance=@Balance
WHERE Customer_ID= @Customer_ID



END
