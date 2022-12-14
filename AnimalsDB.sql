USE [AnimalsDB]
GO
/****** Object:  Table [dbo].[TBAnimals]    Script Date: 27/06/2021 21:16:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBAnimals](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Weight] [float] NULL,
	[EatMeat] [bit] NULL,
	[Continent] [nvarchar](50) NULL,
 CONSTRAINT [PK_TBAnimals] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TBAnimals] ON 

INSERT [dbo].[TBAnimals] ([ID], [Name], [Weight], [EatMeat], [Continent]) VALUES (1, N'Koala', 15, 0, N'AUSTRALIA')
INSERT [dbo].[TBAnimals] ([ID], [Name], [Weight], [EatMeat], [Continent]) VALUES (2, N'Kangaroo', 95, 0, N'AUSTRALIA')
INSERT [dbo].[TBAnimals] ([ID], [Name], [Weight], [EatMeat], [Continent]) VALUES (3, N'Wallaby', 20, 0, N'AUSTRALIA')
INSERT [dbo].[TBAnimals] ([ID], [Name], [Weight], [EatMeat], [Continent]) VALUES (4, N'Wombat', 35, 0, N'AUSTRALIA')
INSERT [dbo].[TBAnimals] ([ID], [Name], [Weight], [EatMeat], [Continent]) VALUES (5, N'Quokka', 4.5, 0, N'AUSTRALIA')
INSERT [dbo].[TBAnimals] ([ID], [Name], [Weight], [EatMeat], [Continent]) VALUES (6, N'Dingo', 20, 1, N'AUSTRALIA')
INSERT [dbo].[TBAnimals] ([ID], [Name], [Weight], [EatMeat], [Continent]) VALUES (7, N'Platypus', 2.4, 1, N'AUSTRALIA')
INSERT [dbo].[TBAnimals] ([ID], [Name], [Weight], [EatMeat], [Continent]) VALUES (8, N'Quoll', 7, 0, N'AUSTRALIA')
INSERT [dbo].[TBAnimals] ([ID], [Name], [Weight], [EatMeat], [Continent]) VALUES (9, N'Tasmanian Devil', 8, 1, N'AUSTRALIA')
INSERT [dbo].[TBAnimals] ([ID], [Name], [Weight], [EatMeat], [Continent]) VALUES (10, N'Tree Kangaroo', 9, 0, N'AUSTRALIA')
INSERT [dbo].[TBAnimals] ([ID], [Name], [Weight], [EatMeat], [Continent]) VALUES (11, N'Lion', 249, 1, N'AFRICA')
INSERT [dbo].[TBAnimals] ([ID], [Name], [Weight], [EatMeat], [Continent]) VALUES (12, N'African Bush Elephant', 3000, 0, N'AFRICA')
INSERT [dbo].[TBAnimals] ([ID], [Name], [Weight], [EatMeat], [Continent]) VALUES (13, N'Asian Elephant', 5000, 0, N'EURASIA')
INSERT [dbo].[TBAnimals] ([ID], [Name], [Weight], [EatMeat], [Continent]) VALUES (14, N'Rhinoceros', 3500, 0, N'AFRICA')
INSERT [dbo].[TBAnimals] ([ID], [Name], [Weight], [EatMeat], [Continent]) VALUES (15, N'Leopard', 90, 1, N'AFRICA')
INSERT [dbo].[TBAnimals] ([ID], [Name], [Weight], [EatMeat], [Continent]) VALUES (16, N'Giraffe', 1930, 0, N'AFRICA')
INSERT [dbo].[TBAnimals] ([ID], [Name], [Weight], [EatMeat], [Continent]) VALUES (17, N'Zebra', 405, 0, N'AFRICA')
INSERT [dbo].[TBAnimals] ([ID], [Name], [Weight], [EatMeat], [Continent]) VALUES (18, N'Hippopotamus', 4500, 0, N'AFRICA')
INSERT [dbo].[TBAnimals] ([ID], [Name], [Weight], [EatMeat], [Continent]) VALUES (19, N'Cheetah', 65, 1, N'AFRICA')
INSERT [dbo].[TBAnimals] ([ID], [Name], [Weight], [EatMeat], [Continent]) VALUES (20, N'Antelope', 900, 0, N'AFRICA')
INSERT [dbo].[TBAnimals] ([ID], [Name], [Weight], [EatMeat], [Continent]) VALUES (21, N'Beaver', 27, 0, N'EURASIA')
INSERT [dbo].[TBAnimals] ([ID], [Name], [Weight], [EatMeat], [Continent]) VALUES (22, N'Bear', 450, 1, N'EURASIA')
INSERT [dbo].[TBAnimals] ([ID], [Name], [Weight], [EatMeat], [Continent]) VALUES (23, N'Chipmunk', 0.113, 0, N'NORTH AMERICA')
INSERT [dbo].[TBAnimals] ([ID], [Name], [Weight], [EatMeat], [Continent]) VALUES (24, N'Lynx', 25, 1, N'EURASIA')
INSERT [dbo].[TBAnimals] ([ID], [Name], [Weight], [EatMeat], [Continent]) VALUES (25, N'Deer', 450, 0, N'EURASIA')
INSERT [dbo].[TBAnimals] ([ID], [Name], [Weight], [EatMeat], [Continent]) VALUES (26, N'Mink', 1.5, 1, N'EURASIA')
INSERT [dbo].[TBAnimals] ([ID], [Name], [Weight], [EatMeat], [Continent]) VALUES (27, N'Siberian Tiger', 350, 1, N'EURASIA')
INSERT [dbo].[TBAnimals] ([ID], [Name], [Weight], [EatMeat], [Continent]) VALUES (28, N'Raccoon', 9, 1, N'NORTH AMERICA')
INSERT [dbo].[TBAnimals] ([ID], [Name], [Weight], [EatMeat], [Continent]) VALUES (29, N'Moose', 720, 0, N'NORTH AMERICA')
INSERT [dbo].[TBAnimals] ([ID], [Name], [Weight], [EatMeat], [Continent]) VALUES (30, N'Eagle', 7, 1, N'NORTH AMERICA')
INSERT [dbo].[TBAnimals] ([ID], [Name], [Weight], [EatMeat], [Continent]) VALUES (31, N'Arctic Hare', 5, 0, N'NORTH AMERICA')
INSERT [dbo].[TBAnimals] ([ID], [Name], [Weight], [EatMeat], [Continent]) VALUES (32, N'Armadillo', 30, 0, N'NORTH AMERICA')
INSERT [dbo].[TBAnimals] ([ID], [Name], [Weight], [EatMeat], [Continent]) VALUES (33, N'Barn Owl', 0.55, 1, N'NORTH AMERICA')
INSERT [dbo].[TBAnimals] ([ID], [Name], [Weight], [EatMeat], [Continent]) VALUES (34, N'Albatross', 10, 1, N'NORTH AMERICA')
INSERT [dbo].[TBAnimals] ([ID], [Name], [Weight], [EatMeat], [Continent]) VALUES (35, N'Alpaca', 84, 0, N'SOUTH AMERICA')
INSERT [dbo].[TBAnimals] ([ID], [Name], [Weight], [EatMeat], [Continent]) VALUES (36, N'Anteater', 40, 0, N'SOUTH AMERICA')
INSERT [dbo].[TBAnimals] ([ID], [Name], [Weight], [EatMeat], [Continent]) VALUES (37, N'Chinchilla', 0.5, 0, N'SOUTH AMERICA')
INSERT [dbo].[TBAnimals] ([ID], [Name], [Weight], [EatMeat], [Continent]) VALUES (38, N'Coati', 8, 0, N'SOUTH AMERICA')
INSERT [dbo].[TBAnimals] ([ID], [Name], [Weight], [EatMeat], [Continent]) VALUES (39, N'Cotton-top Tamarin
', 0.9, 0, N'SOUTH AMERICA')
INSERT [dbo].[TBAnimals] ([ID], [Name], [Weight], [EatMeat], [Continent]) VALUES (40, N'Capybara
', 70, 0, N'SOUTH AMERICA')
INSERT [dbo].[TBAnimals] ([ID], [Name], [Weight], [EatMeat], [Continent]) VALUES (41, N'Booby', 1.8, 1, N'SOUTH AMERICA')
INSERT [dbo].[TBAnimals] ([ID], [Name], [Weight], [EatMeat], [Continent]) VALUES (42, N'Guinea Pig
', 1.5, 0, N'SOUTH AMERICA')
INSERT [dbo].[TBAnimals] ([ID], [Name], [Weight], [EatMeat], [Continent]) VALUES (43, N'Penguin
', 35, 1, N'ANTARCTIC')
INSERT [dbo].[TBAnimals] ([ID], [Name], [Weight], [EatMeat], [Continent]) VALUES (44, N'Leopard Seal', 591, 1, N'ANTARCTIC')
INSERT [dbo].[TBAnimals] ([ID], [Name], [Weight], [EatMeat], [Continent]) VALUES (45, N'Emperor Penguin', 45, 1, N'ANTARCTIC')
INSERT [dbo].[TBAnimals] ([ID], [Name], [Weight], [EatMeat], [Continent]) VALUES (46, N'Adelie Penguin', 6, 1, N'ANTARCTIC')
INSERT [dbo].[TBAnimals] ([ID], [Name], [Weight], [EatMeat], [Continent]) VALUES (47, N'Chinstrap Penguin', 6, 1, N'ANTARCTIC')
INSERT [dbo].[TBAnimals] ([ID], [Name], [Weight], [EatMeat], [Continent]) VALUES (48, N'King Penguin', 16, 1, N'ANTARCTIC')
INSERT [dbo].[TBAnimals] ([ID], [Name], [Weight], [EatMeat], [Continent]) VALUES (49, N'Blue Whale', 160000, 1, N'ANTARCTIC')
INSERT [dbo].[TBAnimals] ([ID], [Name], [Weight], [EatMeat], [Continent]) VALUES (50, N'Fin Whale', 70000, 1, N'ANTARCTIC')
INSERT [dbo].[TBAnimals] ([ID], [Name], [Weight], [EatMeat], [Continent]) VALUES (51, N'Humpback Whale', 99800, 1, N'ANTARCTIC')
SET IDENTITY_INSERT [dbo].[TBAnimals] OFF
GO
