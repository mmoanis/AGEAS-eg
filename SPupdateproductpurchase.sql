CREATE PROCEDURE UpdateProductPurchase
(
@Product_Purchase_ID INT, 
@Product_ID INT,
@Purchase_ID INT,
@Quantity INT
)

AS 
BEGIN
UPDATE Product_Purchase SET



Product_ID=@Product_ID  ,
Purchase_ID=@Purchase_ID ,
Quantity =@Quantity 
WHERE Product_Purchase_ID =@Product_Purchase_ID


END
