CREATE PROCEDURE UpdateSupplier
(
@Supplier_ID INT,
@Name  NVARCHAR(50) ,
@Phone VARCHAR(14),
@Address NVARCHAR(100),
@Company NVARCHAR(50)
)

AS 
BEGIN
UPDATE Supplier SET




Name=@Name,
Phone=@Phone,
Address=@Address,
Company=@Company
WHERE Supplier_ID= @Supplier_ID



END
