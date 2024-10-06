CREATE TABLE [dbo].[Products] (
    [productId]          INT             NOT NULL,
    [productName]        NVARCHAR (255)  NULL,
    [productPrice]       DECIMAL (18, 2) NULL,
    [productShortName]   NVARCHAR (255)  NULL,
    [productDescription] NVARCHAR (MAX)  NULL,
    [createdDate]        DATETIME        NULL,
    [deliveryTimeSpan]   NVARCHAR (50)   NULL,
    [categoryId]         INT             NULL,
    [productImageUrl]    NVARCHAR (255)  NULL,
    [categoryName]       NVARCHAR (255)  NULL,
    PRIMARY KEY CLUSTERED ([productId] ASC)
);

