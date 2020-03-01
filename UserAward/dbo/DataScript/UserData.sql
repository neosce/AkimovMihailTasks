SET IDENTITY_INSERT [dbo].[User] ON
INSERT INTO [dbo].[User] ([Id], [Name], [DateTime], [Age]) VALUES (2, N'Victor', N'10.03.1991', 15)
INSERT INTO [dbo].[User] ([Id], [Name], [DateTime], [Age]) VALUES (3, N'Ivan', N'16.04.1993 0:00:00', 26)
INSERT INTO [dbo].[User] ([Id], [Name], [DateTime], [Age]) VALUES (4, N'Igor', N'10.01.1955 0:00:00', 65)
INSERT INTO [dbo].[User] ([Id], [Name], [DateTime], [Age]) VALUES (1005, N'Dima', N'10.03.1991 0:00:00', 28)
INSERT INTO [dbo].[User] ([Id], [Name], [DateTime], [Age]) VALUES (1007, N'Alex', N'01.02.1995 0:00:00', 25)
SET IDENTITY_INSERT [dbo].[User] OFF
