SET IDENTITY_INSERT [dbo].[Company] ON
INSERT INTO [dbo].[Company] ([Id], [CompanyName], [InfoURL]) VALUES (1, N'ABC Industries', N'http://abcindustries.com')
INSERT INTO [dbo].[Company] ([Id], [CompanyName], [InfoURL]) VALUES (2, N'JBC Holdings', N'http://www.jbc.com')
SET IDENTITY_INSERT [dbo].[Company] OFF
