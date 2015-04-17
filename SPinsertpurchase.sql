CREATE PROCEDURE InsertPurchase
(
@Customer_ID INT,
@Name  NVARCHAR(50) ,
@Is_On_Installment BIT,
@Discount DECIMAL(3,3),
@Value DECIMAL(3,3),
@Recieved_Value DECIMAL(3,3)


)

AS 
BEGIN
INSERT INTO Purchase

(
Customer_ID ,
Name ,
Is_On_Installment,
Discount ,
Value ,
Recieved_Value 
)

VALUES
( 
@Customer_ID ,
@Name   ,
@Is_On_Installment,
@Discount,
@Value ,
@Recieved_Value 
)
END
