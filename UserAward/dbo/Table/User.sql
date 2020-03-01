CREATE TABLE [dbo].[User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[DateTime] [nvarchar](50) NOT NULL,
	[Age] [int] NOT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
	)
