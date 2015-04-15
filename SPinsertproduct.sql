CREATE PROCEDURE InsertProduct
(@Product_ID INT, 
@Supplier_ID INT,
@Name  NVARCHAR(50) ,
@Type NVARCHAR(50),
@Price DECIMAL(3,3)

)

AS 
BEGIN
INSERT INTO Product

(Product_ID,
Supplier_ID,
 Name,
 Type,
Price
)

VALUES
(
@Product_ID , 
@Supplier_ID ,
@Name   ,
@Type ,
@Price )
END
