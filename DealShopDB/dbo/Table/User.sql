CREATE TABLE [dbo].[User] (
    [Id]                INT           IDENTITY (1, 1) NOT NULL,
    [LoginEmail]        NVARCHAR (50) NOT NULL,
    [Password]          NVARCHAR (50) NOT NULL,
    [FirstName]         NVARCHAR (50) NOT NULL,
    [LastName]          NVARCHAR (50) NOT NULL,
    [DateOfBirthday]    NVARCHAR (50) NOT NULL,
    [Address]           NVARCHAR (50) NOT NULL,
    [Age]               INT           NOT NULL,
    [Money]             DECIMAL (18)  CONSTRAINT [DF_User_Money] DEFAULT ((0)) NOT NULL,
    [CreditsCardNumber] INT           NULL,
    [UserLogo]          BINARY (50)   NULL,
    [UserRights]        NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED ([Id] ASC)
);