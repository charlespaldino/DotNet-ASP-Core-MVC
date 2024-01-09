SET IDENTITY_INSERT [dbo].[MonthlySpecials] ON
INSERT INTO [dbo].[MonthlySpecials] ([ID], [Tags], [Name], [Description], [ImageURL], [URL], [Type], [Price]) VALUES (1, N'Spa', N'Day Spa Package', N'California Calm', N'/images/calm_bug.gif', N'/tours/tour_detail_cycle.htm', 0, CAST(250.00 AS Decimal(18, 2)))
INSERT INTO [dbo].[MonthlySpecials] ([ID], [Tags], [Name], [Description], [ImageURL], [URL], [Type], [Price]) VALUES (2, N'Travel, Sea, Ocean, Beach', N'2 Day Salton Sea', N'From Desert to Sea', N'/images/desert_bug.gif', N'/tours/tour_detail_cycle.htm', 1, CAST(350.00 AS Decimal(18, 2)))
INSERT INTO [dbo].[MonthlySpecials] ([ID], [Tags], [Name], [Description], [ImageURL], [URL], [Type], [Price]) VALUES (3, N'Backpacking', N'Big Sur Retreat', N'Backpack Cali', N'/images/backpack_bug.gif', N'/tours/tour_detail_cycle.htm', 2, CAST(620.00 AS Decimal(18, 2)))
INSERT INTO [dbo].[MonthlySpecials] ([ID], [Tags], [Name], [Description], [ImageURL], [URL], [Type], [Price]) VALUES (4, N'Food', N'Tapas & Groves', N'Taste of California', N'/images/taste_bug.gif', N'/tours/tour_detail_taste.htm', 3, CAST(150.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[MonthlySpecials] OFF
