CREATE TABLE [dbo].[Cart] (
    [CartId]    INT      IDENTITY (1, 1) NOT NULL,
    [UserId]    INT      NULL,
    [ProductId] INT      NULL,
    [Quantity]  INT      NULL,
    [AddedDate] DATETIME DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([CartId] ASC),
    FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Products] ([productId]),
    CONSTRAINT [FK__Cart__UserId__38996AB5] FOREIGN KEY ([UserId]) REFERENCES [dbo].[UserInfo] ([UserId])
);

