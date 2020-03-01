CREATE TABLE [dbo].[Award](
	[IdAward] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	PRIMARY KEY CLUSTERED ([IdAward] ASC)
);