SET IDENTITY_INSERT [dbo].[Company] ON
INSERT INTO [dbo].[Company] ([Id], [CompanyName], [InfoURL]) VALUES (1, N'ABC Industries', N'http://abcindustries.com')
INSERT INTO [dbo].[Company] ([Id], [CompanyName], [InfoURL]) VALUES (2, N'JBC Holdings', N'http://www.jbc.com')
SET IDENTITY_INSERT [dbo].[Company] OFF
SET IDENTITY_INSERT [dbo].[Project] ON
INSERT INTO [dbo].[Project] ([Id], [ProjectName], [Description]) VALUES (1, N'Connected City', N'Infrastructure development project within Auckland City')
INSERT INTO [dbo].[Project] ([Id], [ProjectName], [Description]) VALUES (2, N'Solar Eco Housing', N'Affordable City Housing project involves solar energy ')
SET IDENTITY_INSERT [dbo].[Project] OFF
SET IDENTITY_INSERT [dbo].[ProjectManager] ON
INSERT INTO [dbo].[ProjectManager] ([Id], [ProjectManagerName], [Email]) VALUES (1, N'Tim Brendon', N'brendon@expenses.com')
INSERT INTO [dbo].[ProjectManager] ([Id], [ProjectManagerName], [Email]) VALUES (2, N'Harry Newman', N'harry@expenses.com')
SET IDENTITY_INSERT [dbo].[ProjectManager] OFF
SET IDENTITY_INSERT [dbo].[Expenses] ON
INSERT INTO [dbo].[Expenses] ([Id], [CompanyId], [ProjectId], [ProjectManagerId], [ExpenseDescription], [SpentAmount]) VALUES (1, 1, 1, 1, N'Initilal Tools  Cost', CAST(10000.00 AS Decimal(18, 2)))
INSERT INTO [dbo].[Expenses] ([Id], [CompanyId], [ProjectId], [ProjectManagerId], [ExpenseDescription], [SpentAmount]) VALUES (2, 2, 2, 2, N'Electrical Designing Cost', CAST(450000.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Expenses] OFF
