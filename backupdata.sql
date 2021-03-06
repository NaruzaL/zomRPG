USE [Wastelander]
GO
INSERT [dbo].[AspNetUsers] ([Id], [AccessFailedCount], [ConcurrencyStamp], [Email], [EmailConfirmed], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [SecurityStamp], [TwoFactorEnabled], [UserName]) VALUES (N'0e92da45-106b-4bb0-998d-4d7177c0589e', 0, N'10b1fcfd-b911-4eb7-83d1-4d330c892cad', NULL, 0, 1, NULL, NULL, N'JARED7223@HOTMAIL.COM', N'AQAAAAEAACcQAAAAEP5sMJbS6p8kbJ1Y3HVEIhRL5RCFNGTCb6HLROLZoQpP1wMYxau448JSfzoTG2hLtw==', NULL, 0, N'fa78ad4f-6130-48c2-818a-956a8f4b3cd5', 0, N'jared7223@hotmail.com')
INSERT [dbo].[AspNetUsers] ([Id], [AccessFailedCount], [ConcurrencyStamp], [Email], [EmailConfirmed], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [SecurityStamp], [TwoFactorEnabled], [UserName]) VALUES (N'49bd42de-b6b4-431a-a24b-d955d94c51ae', 0, N'1d6c75c4-e2be-46f6-a48e-efa179f32dd0', NULL, 0, 1, NULL, NULL, N'PDLAZURAN@GMAIL.COM', N'AQAAAAEAACcQAAAAEK+Z/r8peEizaaeXp2Fv9BThECnXwURxQWgmoljkjG4nsO3eI+Sga/iVO3qXe3BuuA==', NULL, 0, N'8e1f1bac-25f2-4933-a8f2-f7af850f2a2c', 0, N'pdlazuran@gmail.com')
SET IDENTITY_INSERT [dbo].[Items] ON 

INSERT [dbo].[Items] ([ItemId], [AttackEffect], [EnduranceEffect], [HealsPlayer], [LuckEffect], [Name], [Rarity], [Type]) VALUES (1, 0, 0, 0, 0, N'Backpack', N'Legendary', N'Back Accessory')
INSERT [dbo].[Items] ([ItemId], [AttackEffect], [EnduranceEffect], [HealsPlayer], [LuckEffect], [Name], [Rarity], [Type]) VALUES (2, 1, 0, 0, 0, N'Geg''s Gat', N'Uncommon', N'Weapon')
INSERT [dbo].[Items] ([ItemId], [AttackEffect], [EnduranceEffect], [HealsPlayer], [LuckEffect], [Name], [Rarity], [Type]) VALUES (3, 1, 0, 0, 0, N'Baseball Bat', N'Common', N'Weapon')
INSERT [dbo].[Items] ([ItemId], [AttackEffect], [EnduranceEffect], [HealsPlayer], [LuckEffect], [Name], [Rarity], [Type]) VALUES (4, 1, 0, 0, 0, N'Fire Axe', N'Uncommon', N'Weapon')
INSERT [dbo].[Items] ([ItemId], [AttackEffect], [EnduranceEffect], [HealsPlayer], [LuckEffect], [Name], [Rarity], [Type]) VALUES (5, 1, 0, 0, 0, N'Shotgun', N'Rare', N'Weapon')
INSERT [dbo].[Items] ([ItemId], [AttackEffect], [EnduranceEffect], [HealsPlayer], [LuckEffect], [Name], [Rarity], [Type]) VALUES (6, 1, 0, 0, 0, N'Katana', N'Legendary', N'Weapon')
INSERT [dbo].[Items] ([ItemId], [AttackEffect], [EnduranceEffect], [HealsPlayer], [LuckEffect], [Name], [Rarity], [Type]) VALUES (7, 0, 1, 0, 0, N'Kevlar Vest', N'Rare', N'Armor')
INSERT [dbo].[Items] ([ItemId], [AttackEffect], [EnduranceEffect], [HealsPlayer], [LuckEffect], [Name], [Rarity], [Type]) VALUES (8, 0, 1, 0, 0, N'Platemail', N'Rare', N'Armor')
INSERT [dbo].[Items] ([ItemId], [AttackEffect], [EnduranceEffect], [HealsPlayer], [LuckEffect], [Name], [Rarity], [Type]) VALUES (9, 0, 1, 0, 0, N'Riot Shield', N'Uncommon', N'Armor')
INSERT [dbo].[Items] ([ItemId], [AttackEffect], [EnduranceEffect], [HealsPlayer], [LuckEffect], [Name], [Rarity], [Type]) VALUES (10, 0, 1, 0, 0, N'Football Pads', N'Common', N'Armor')
INSERT [dbo].[Items] ([ItemId], [AttackEffect], [EnduranceEffect], [HealsPlayer], [LuckEffect], [Name], [Rarity], [Type]) VALUES (11, 0, 1, 0, 0, N'Elbow and Knee Pads', N'Common', N'Armor')
INSERT [dbo].[Items] ([ItemId], [AttackEffect], [EnduranceEffect], [HealsPlayer], [LuckEffect], [Name], [Rarity], [Type]) VALUES (12, 0, 0, 1, 0, N'First Aid', N'Uncommon', N'Healing')
INSERT [dbo].[Items] ([ItemId], [AttackEffect], [EnduranceEffect], [HealsPlayer], [LuckEffect], [Name], [Rarity], [Type]) VALUES (13, 0, 0, 0, 1, N'Painkillers', N'Common', N'Healing')
INSERT [dbo].[Items] ([ItemId], [AttackEffect], [EnduranceEffect], [HealsPlayer], [LuckEffect], [Name], [Rarity], [Type]) VALUES (14, 0, 0, 1, 0, N'Alcohol', N'Common', N'Healing')
INSERT [dbo].[Items] ([ItemId], [AttackEffect], [EnduranceEffect], [HealsPlayer], [LuckEffect], [Name], [Rarity], [Type]) VALUES (15, 0, 0, 1, 0, N'An Actual Doctor', N'Rare', N'Healing')
INSERT [dbo].[Items] ([ItemId], [AttackEffect], [EnduranceEffect], [HealsPlayer], [LuckEffect], [Name], [Rarity], [Type]) VALUES (16, 0, 0, 1, 0, N'Canned Food', N'Common', N'Healing')
INSERT [dbo].[Items] ([ItemId], [AttackEffect], [EnduranceEffect], [HealsPlayer], [LuckEffect], [Name], [Rarity], [Type]) VALUES (17, 0, 0, 0, 1, N'Gold Necklace', N'Common', N'Charm')
INSERT [dbo].[Items] ([ItemId], [AttackEffect], [EnduranceEffect], [HealsPlayer], [LuckEffect], [Name], [Rarity], [Type]) VALUES (18, 0, 0, 0, 1, N'Lucky 8 Ball', N'Uncommon', N'Charm')
INSERT [dbo].[Items] ([ItemId], [AttackEffect], [EnduranceEffect], [HealsPlayer], [LuckEffect], [Name], [Rarity], [Type]) VALUES (19, 0, 0, 0, 1, N'Fresh Rabbit''s Foot', N'Rare', N'Charm')
SET IDENTITY_INSERT [dbo].[Items] OFF
SET IDENTITY_INSERT [dbo].[Locations] ON 

INSERT [dbo].[Locations] ([LocationId], [Description], [ItemId], [Name], [SpawnEnemy]) VALUES (2, N'Start', 1, N'Start', 0)
INSERT [dbo].[Locations] ([LocationId], [Description], [ItemId], [Name], [SpawnEnemy]) VALUES (3, N'A small gas station', 16, N'Gas Station', 25)
INSERT [dbo].[Locations] ([LocationId], [Description], [ItemId], [Name], [SpawnEnemy]) VALUES (4, N'Walking towards downtown', 1, N'Downtown', 0)
INSERT [dbo].[Locations] ([LocationId], [Description], [ItemId], [Name], [SpawnEnemy]) VALUES (5, N'Police station downtown', 5, N'Police Station', 17)
INSERT [dbo].[Locations] ([LocationId], [Description], [ItemId], [Name], [SpawnEnemy]) VALUES (6, N'Bar', 14, N'Bar', 17)
INSERT [dbo].[Locations] ([LocationId], [Description], [ItemId], [Name], [SpawnEnemy]) VALUES (7, N'Big hospital', 15, N'Hospital', 19)
INSERT [dbo].[Locations] ([LocationId], [Description], [ItemId], [Name], [SpawnEnemy]) VALUES (8, N'They sell armor', 8, N'Antique Store', 19)
INSERT [dbo].[Locations] ([LocationId], [Description], [ItemId], [Name], [SpawnEnemy]) VALUES (9, N'Front gate of goal', 2, N'Gate', 25)
INSERT [dbo].[Locations] ([LocationId], [Description], [ItemId], [Name], [SpawnEnemy]) VALUES (10, N'Walking into Neighborhood', 1, N'Neighborhood', 0)
INSERT [dbo].[Locations] ([LocationId], [Description], [ItemId], [Name], [SpawnEnemy]) VALUES (11, N'house in the neighborhood', 10, N'House', 13)
INSERT [dbo].[Locations] ([LocationId], [Description], [ItemId], [Name], [SpawnEnemy]) VALUES (12, N'Fire station', 4, N'Fire Department', 14)
INSERT [dbo].[Locations] ([LocationId], [Description], [ItemId], [Name], [SpawnEnemy]) VALUES (13, N'Bus station', 17, N'Transit Center', 15)
INSERT [dbo].[Locations] ([LocationId], [Description], [ItemId], [Name], [SpawnEnemy]) VALUES (14, N'building stuff', 12, N'Construction Site', 16)
INSERT [dbo].[Locations] ([LocationId], [Description], [ItemId], [Name], [SpawnEnemy]) VALUES (15, N'Geg''s home', 1, N'Sanctuary', 100)
SET IDENTITY_INSERT [dbo].[Locations] OFF
SET IDENTITY_INSERT [dbo].[Players] ON 

INSERT [dbo].[Players] ([PlayerId], [Attack], [Endurance], [Expierience], [LocationId], [Luck], [Name], [UserId]) VALUES (5, 7, 7, 0, 2, 7, N'Gekk', N'0e92da45-106b-4bb0-998d-4d7177c0589e')
INSERT [dbo].[Players] ([PlayerId], [Attack], [Endurance], [Expierience], [LocationId], [Luck], [Name], [UserId]) VALUES (6, 10, 7, 0, 2, 4, N'Buba Fett', N'49bd42de-b6b4-431a-a24b-d955d94c51ae')
SET IDENTITY_INSERT [dbo].[Players] OFF
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20170809171326_Initial', N'1.0.1')
