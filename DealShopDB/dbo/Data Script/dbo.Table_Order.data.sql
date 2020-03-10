SET IDENTITY_INSERT [dbo].[Table_Order] ON
INSERT INTO [dbo].[Table_Order] ([Order], [IdProduct], [IdUser], [Status]) VALUES (1, 1, 2, N'Awaiting')
INSERT INTO [dbo].[Table_Order] ([Order], [IdProduct], [IdUser], [Status]) VALUES (2, 6, 2, N'Awaiting')
SET IDENTITY_INSERT [dbo].[Table_Order] OFF
