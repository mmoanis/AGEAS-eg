CREATE PROCEDURE deletesupplier

@Supplier_ID INT


AS
DELETE Supplier
FROM Supplier
WHERE Supplier_ID=@Supplier_ID
