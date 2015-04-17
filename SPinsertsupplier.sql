CREATE PROCEDURE InsertSupplier
(
@Name  NVARCHAR(50) ,
@Phone VARCHAR(14),
@Address NVARCHAR(100),
@Company NVARCHAR(50)
)

AS 
BEGIN
INSERT INTO Supplier

(
 Name,
 Phone,
 Address,
 Company
)

VALUES
(
@Name   ,
@Phone ,
@Address ,
@Company 
)
END
