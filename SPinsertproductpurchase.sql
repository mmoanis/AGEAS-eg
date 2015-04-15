CREATE PROCEDURE InsertProductPurchase
(
@Product_Purchase_ID INT, 
@Product_ID INT,
@Purchase_ID INT,
@Quantity INT
)

AS 
BEGIN
INSERT INTO Product_Purchase

(
Product_Purchase_ID , 
Product_ID ,
Purchase_ID ,
Quantity 
)

VALUES
(
@Product_Purchase_ID , 
@Product_ID ,
@Purchase_ID ,
@Quantity 
)
END
