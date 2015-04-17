CREATE PROCEDURE InsertProductPurchase
(
@Product_ID INT,
@Purchase_ID INT,
@Quantity INT
)

AS 
BEGIN
INSERT INTO Product_Purchase

(
Product_ID ,
Purchase_ID ,
Quantity 
)

VALUES
(
@Product_ID ,
@Purchase_ID ,
@Quantity 
)
END
