CREATE TABLE [dbo].[Table_Order] (
    [Order]     INT           IDENTITY (1, 1) NOT NULL,
    [IdProduct] INT           NOT NULL,
    [IdUser]    INT           NOT NULL,
    [Status]    NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Table_Order] PRIMARY KEY CLUSTERED ([Order] ASC),
    CONSTRAINT [FK_Table_Order_User] FOREIGN KEY ([IdUser]) REFERENCES [dbo].[User] ([Id]),
    CONSTRAINT [FK_Table_Order_Product] FOREIGN KEY ([IdProduct]) REFERENCES [dbo].[Product] ([Id])
);

