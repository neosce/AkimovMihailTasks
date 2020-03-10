CREATE TABLE [dbo].[UserProduct] (
    [IdUser]    INT NOT NULL,
    [IdProduct] INT NOT NULL,
    CONSTRAINT [FK_UserProduct_User] FOREIGN KEY ([IdUser]) REFERENCES [dbo].[User] ([Id]),
    CONSTRAINT [FK_UserProduct_Product] FOREIGN KEY ([IdProduct]) REFERENCES [dbo].[Product] ([Id])
);

