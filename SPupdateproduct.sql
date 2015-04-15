CREATE PROCEDURE UpdateProduct
(
@Product_ID INT, 
@Supplier_ID INT,
@Name  NVARCHAR(50) ,
@Type NVARCHAR(50),
@Price DECIMAL(3,3)
)

AS 
BEGIN
UPDATE Product SET



Supplier_ID=@Supplier_ID,
 Name=@Name,
 Type=@Type,
Price=@Price
WHERE Product_ID= @Product_ID



END
