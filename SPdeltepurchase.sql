CREATE PROCEDURE deletePurchase

@Purchase_ID INT


AS
DELETE Purchase
FROM Purchase
WHERE Purchase_ID=@Purchase_ID
