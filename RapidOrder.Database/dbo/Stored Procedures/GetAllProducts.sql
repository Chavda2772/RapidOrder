CREATE PROCEDURE GetAllProducts
AS
BEGIN
    SELECT 
        ProductId, 
        ProductName, 
        ProductPrice, 
        ProductImageUrl
    FROM 
        Products;
END;