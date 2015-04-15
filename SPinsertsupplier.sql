CREATE PROCEDURE InsertSupplier
(
@Supplier_ID INT,

@Name  NVARCHAR(50) ,
@Phone VARCHAR(14),
@Address NVARCHAR(100),
@Company NVARCHAR(50)
)

AS 
BEGIN
INSERT INTO Supplier

(Supplier_ID,
 Name,
 Phone,
 Address,
 Company
)

VALUES
(
@Supplier_ID,

@Name   ,
@Phone ,
@Address ,
@Company 
)
END
