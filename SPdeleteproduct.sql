CREATE PROCEDURE deleteProduct

@Product_ID INT


AS
DELETE Product
FROM Product
WHERE Product_ID=@Product_ID


