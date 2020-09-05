SET IDENTITY_INSERT [dbo].[Expenses] ON
INSERT INTO [dbo].[Expenses] ([Id], [CompanyId], [ProjectId], [ProjectManagerId], [ExpenseDescription], [SpentAmount]) VALUES (1, 1, 1, 1, N'Initilal Tools  Cost', CAST(10000.00 AS Decimal(18, 2)))
INSERT INTO [dbo].[Expenses] ([Id], [CompanyId], [ProjectId], [ProjectManagerId], [ExpenseDescription], [SpentAmount]) VALUES (2, 2, 2, 2, N'Electrical Designing Cost', CAST(450000.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Expenses] OFF
