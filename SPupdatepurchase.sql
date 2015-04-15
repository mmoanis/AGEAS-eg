CREATE PROCEDURE UpdatePurchase
(
@Purchase_ID INT, 
@Customer_ID INT,
@Name  NVARCHAR(50) ,
@Is_On_Installment BIT,
@Discount DECIMAL(3,3),
@Value DECIMAL(3,3),
@Recieved_Value DECIMAL(3,3)
)

AS 
BEGIN
UPDATE Purchase SET

Customer_ID= @Customer_ID ,
Name =@Name ,
Is_On_Installment = @Is_On_Installment,
Discount= @Discount ,
Value= @Value ,
Recieved_Value =@Recieved_Value
WHERE Purchase_ID= @Purchase_ID



END
