CREATE PROCEDURE InsertProduct
(
@Supplier_ID INT,
@Name  NVARCHAR(50) ,
@Type NVARCHAR(50),
@Price DECIMAL(3,3)

)

AS 
BEGIN
INSERT INTO Product

(
Supplier_ID,
 Name,
 Type,
Price
)

VALUES
( 
@Supplier_ID ,
@Name   ,
@Type ,
@Price )
END
