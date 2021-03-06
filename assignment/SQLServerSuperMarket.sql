USE [master]
GO
/****** Object:  Database [Supermarket]    Script Date: 01/09/2017 09:36:55 ******/
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'Supermarket')
BEGIN
CREATE DATABASE [Supermarket]
END

GO
USE [Supermarket]
GO
/****** Object:  Table [dbo].[Offers]    Script Date: 01/09/2017 09:36:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Offers](
	[OfferID] [int] IDENTITY(1,1) NOT NULL,
	[OfferDescription] [nvarchar](60) NOT NULL,
	[ShortDescription] [nchar](10) NOT NULL,
	[TFTPOTGroup] [int] NULL,
	[DiscountPercentage] [int] NULL,
 CONSTRAINT [PK_Offers] PRIMARY KEY CLUSTERED 
(
	[OfferID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Products]    Script Date: 01/09/2017 09:36:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[OfferID] [int] NULL,
	[ProductName] [nvarchar](40) NOT NULL,
	[UnitPrice] [money] NOT NULL CONSTRAINT [DF_Products_UnitPrice]  DEFAULT ((0)),
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Offers] ON 

GO
INSERT [dbo].[Offers] ([OfferID], [OfferDescription], [ShortDescription], [TFTPOTGroup], [DiscountPercentage]) VALUES (1, N'Buy one get one free', N'BOGOF     ', NULL, NULL)
GO
INSERT [dbo].[Offers] ([OfferID], [OfferDescription], [ShortDescription], [TFTPOTGroup], [DiscountPercentage]) VALUES (2, N'Three for the price of two on selected sandwich fillers', N'TFTPOT    ', 1, NULL)
GO
INSERT [dbo].[Offers] ([OfferID], [OfferDescription], [ShortDescription], [TFTPOTGroup], [DiscountPercentage]) VALUES (3, N'Three for the price of two on selected milk based products', N'TFTPOT    ', 2, NULL)
GO
INSERT [dbo].[Offers] ([OfferID], [OfferDescription], [ShortDescription], [TFTPOTGroup], [DiscountPercentage]) VALUES (4, N'Discount of 10%', N'Discount  ', NULL, 10)
GO
INSERT [dbo].[Offers] ([OfferID], [OfferDescription], [ShortDescription], [TFTPOTGroup], [DiscountPercentage]) VALUES (5, N'Discount 0f 20%', N'Discount  ', NULL, 20)
GO
SET IDENTITY_INSERT [dbo].[Offers] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

GO
INSERT [dbo].[Products] ([ProductID], [OfferID], [ProductName], [UnitPrice]) VALUES (1, 1, N'Beans', 0.5600)
GO
INSERT [dbo].[Products] ([ProductID], [OfferID], [ProductName], [UnitPrice]) VALUES (2, NULL, N'Corn Flakes', 2.2200)
GO
INSERT [dbo].[Products] ([ProductID], [OfferID], [ProductName], [UnitPrice]) VALUES (3, 2, N'Cheddar Cheese (250g)', 1.9900)
GO
INSERT [dbo].[Products] ([ProductID], [OfferID], [ProductName], [UnitPrice]) VALUES (4, 2, N'Ham (5 slices)', 2.4900)
GO
INSERT [dbo].[Products] ([ProductID], [OfferID], [ProductName], [UnitPrice]) VALUES (5, 3, N'Milk (2 litre Semi Skimmed)', 2.1000)
GO
INSERT [dbo].[Products] ([ProductID], [OfferID], [ProductName], [UnitPrice]) VALUES (6, 3, N'Milk (1 litre Semi Skimmed)', 1.2000)
GO
INSERT [dbo].[Products] ([ProductID], [OfferID], [ProductName], [UnitPrice]) VALUES (7, 3, N'Milk (0.5 litre Semi Skimmed)', 0.6500)
GO
INSERT [dbo].[Products] ([ProductID], [OfferID], [ProductName], [UnitPrice]) VALUES (8, 3, N'Milk ( 2litre Skimmed)', 2.1000)
GO
INSERT [dbo].[Products] ([ProductID], [OfferID], [ProductName], [UnitPrice]) VALUES (9, 3, N'Milk (1 litre Skimmed)', 1.2000)
GO
INSERT [dbo].[Products] ([ProductID], [OfferID], [ProductName], [UnitPrice]) VALUES (10, 3, N'Milk (0.5 litre Skimmed)', 0.6500)
GO
INSERT [dbo].[Products] ([ProductID], [OfferID], [ProductName], [UnitPrice]) VALUES (11, NULL, N'Margerine (500g)', 2.1200)
GO
INSERT [dbo].[Products] ([ProductID], [OfferID], [ProductName], [UnitPrice]) VALUES (12, NULL, N'Butter (500g)', 2.3400)
GO
INSERT [dbo].[Products] ([ProductID], [OfferID], [ProductName], [UnitPrice]) VALUES (13, 4, N'Eggs (Pack of 6)', 1.5900)
GO
INSERT [dbo].[Products] ([ProductID], [OfferID], [ProductName], [UnitPrice]) VALUES (14, 1, N'Toothpaste', 1.0000)
GO
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Offers] FOREIGN KEY([OfferID])
REFERENCES [dbo].[Offers] ([OfferID])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Offers]
GO
USE [master]
GO
ALTER DATABASE [Supermarket] SET  READ_WRITE 
GO
