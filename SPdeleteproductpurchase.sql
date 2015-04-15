CREATE PROCEDURE deleteProductPurchase

@Product_Purchase_ID INT


AS
DELETE Product_Purchase
FROM Product_Purchase
WHERE Product_Purchase_ID=@Product_Purchase_ID
