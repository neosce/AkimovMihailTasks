CREATE TABLE [dbo].[Product] (
    [Id]              INT            IDENTITY (1, 1) NOT NULL,
    [NameProduct]     NVARCHAR (50)  NOT NULL,
    [Price]           DECIMAL (18)   NOT NULL,
    [Color]           NVARCHAR (50)  NOT NULL,
    [Gender]          NVARCHAR (50)  NULL,
    [Description]     NVARCHAR (MAX) NULL,
    [QuantityOfGoods] INT            NOT NULL,
    [Category]        NVARCHAR (50)  NOT NULL,
    [Size]            INT            NOT NULL,
    [ImageProduct]    BINARY (50)    NULL,
    CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED ([Id] ASC)
);