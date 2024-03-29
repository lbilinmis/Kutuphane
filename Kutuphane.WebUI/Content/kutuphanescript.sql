USE [KutuphaneDB]
GO
/****** Object:  Table [dbo].[TblCategory]    Script Date: 10.02.2023 18:27:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblCategory](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [varchar](50) NULL,
	[Durum] [bit] NULL,
 CONSTRAINT [PK_TblCategory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblCeza]    Script Date: 10.02.2023 18:27:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblCeza](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UyeId] [int] NULL,
	[BaslangicTarihi] [smalldatetime] NULL,
	[BitisTarihi] [smalldatetime] NULL,
	[ParaCezasi] [decimal](18, 2) NULL,
	[HareketId] [int] NULL,
 CONSTRAINT [PK_TblCeza] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblHakkimizda]    Script Date: 10.02.2023 18:27:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblHakkimizda](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Aciklama] [nvarchar](max) NULL,
 CONSTRAINT [PK_TblHakkimizda] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblHareket]    Script Date: 10.02.2023 18:27:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblHareket](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[KitapId] [int] NULL,
	[UyeId] [int] NULL,
	[PersonelId] [int] NULL,
	[AlisTarihi] [smalldatetime] NULL,
	[IadeTarihi] [smalldatetime] NULL,
	[TeslimTarihi] [smalldatetime] NULL,
	[Durumu] [bit] NULL,
 CONSTRAINT [PK_TblHareket] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblIletisim]    Script Date: 10.02.2023 18:27:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblIletisim](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Konu] [varchar](50) NULL,
	[Mesaj] [varchar](1000) NULL,
 CONSTRAINT [PK_TblIletisim] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblKasa]    Script Date: 10.02.2023 18:27:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblKasa](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ay] [varchar](20) NULL,
	[Tutar] [decimal](18, 2) NULL,
 CONSTRAINT [PK_TblKasa] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblKitap]    Script Date: 10.02.2023 18:27:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblKitap](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [varchar](50) NULL,
	[KategoriId] [int] NULL,
	[BasimYili] [char](4) NULL,
	[YayinEvi] [varchar](50) NULL,
	[Sayfa] [varchar](4) NULL,
	[YazarId] [int] NULL,
	[Durum] [bit] NULL,
	[ResimUrl] [varchar](500) NULL,
 CONSTRAINT [PK_TblKitap] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblMesajlar]    Script Date: 10.02.2023 18:27:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblMesajlar](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Gonderen] [nvarchar](50) NULL,
	[Alici] [nvarchar](50) NULL,
	[Konu] [nvarchar](50) NULL,
	[Icerik] [text] NULL,
	[Tarih] [smalldatetime] NULL,
 CONSTRAINT [PK_TblMesajlar] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblPersonel]    Script Date: 10.02.2023 18:27:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblPersonel](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AdSoyad] [varchar](100) NULL,
 CONSTRAINT [PK_TblPersonel] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblUye]    Script Date: 10.02.2023 18:27:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblUye](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [varchar](50) NULL,
	[Soyad] [varchar](50) NULL,
	[EMail] [varchar](50) NULL,
	[KullaniciAdi] [varchar](50) NULL,
	[Sifre] [varchar](100) NULL,
	[Fotograf] [varchar](250) NULL,
	[Telefon] [varchar](20) NULL,
	[Okul] [varchar](250) NULL,
 CONSTRAINT [PK_TblUye] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblYazar]    Script Date: 10.02.2023 18:27:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblYazar](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [varchar](50) NULL,
	[Soyad] [varchar](50) NULL,
	[Detay] [varchar](max) NULL,
 CONSTRAINT [PK_TblYazar] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TblCategory] ON 

INSERT [dbo].[TblCategory] ([Id], [Ad], [Durum]) VALUES (6, N'Fantastik', 1)
INSERT [dbo].[TblCategory] ([Id], [Ad], [Durum]) VALUES (7, N'Bilim Kurgu', 1)
INSERT [dbo].[TblCategory] ([Id], [Ad], [Durum]) VALUES (8, N'Edebiyat', 1)
SET IDENTITY_INSERT [dbo].[TblCategory] OFF
SET IDENTITY_INSERT [dbo].[TblCeza] ON 

INSERT [dbo].[TblCeza] ([Id], [UyeId], [BaslangicTarihi], [BitisTarihi], [ParaCezasi], [HareketId]) VALUES (1, 3, NULL, NULL, CAST(20.00 AS Decimal(18, 2)), 6)
INSERT [dbo].[TblCeza] ([Id], [UyeId], [BaslangicTarihi], [BitisTarihi], [ParaCezasi], [HareketId]) VALUES (2, 3, NULL, NULL, CAST(0.00 AS Decimal(18, 2)), 2)
INSERT [dbo].[TblCeza] ([Id], [UyeId], [BaslangicTarihi], [BitisTarihi], [ParaCezasi], [HareketId]) VALUES (3, 3, NULL, NULL, CAST(0.00 AS Decimal(18, 2)), 3)
INSERT [dbo].[TblCeza] ([Id], [UyeId], [BaslangicTarihi], [BitisTarihi], [ParaCezasi], [HareketId]) VALUES (4, 3, NULL, NULL, NULL, 5)
INSERT [dbo].[TblCeza] ([Id], [UyeId], [BaslangicTarihi], [BitisTarihi], [ParaCezasi], [HareketId]) VALUES (5, 3, NULL, NULL, NULL, 4)
INSERT [dbo].[TblCeza] ([Id], [UyeId], [BaslangicTarihi], [BitisTarihi], [ParaCezasi], [HareketId]) VALUES (6, 3, NULL, NULL, CAST(11.00 AS Decimal(18, 2)), 4)
INSERT [dbo].[TblCeza] ([Id], [UyeId], [BaslangicTarihi], [BitisTarihi], [ParaCezasi], [HareketId]) VALUES (7, 3, NULL, NULL, CAST(21.00 AS Decimal(18, 2)), 5)
SET IDENTITY_INSERT [dbo].[TblCeza] OFF
SET IDENTITY_INSERT [dbo].[TblHareket] ON 

INSERT [dbo].[TblHareket] ([Id], [KitapId], [UyeId], [PersonelId], [AlisTarihi], [IadeTarihi], [TeslimTarihi], [Durumu]) VALUES (1, 2, 3, 1, CAST(N'2023-01-26T00:00:00' AS SmallDateTime), CAST(N'2023-02-02T00:00:00' AS SmallDateTime), CAST(N'2023-02-04T16:40:00' AS SmallDateTime), 1)
INSERT [dbo].[TblHareket] ([Id], [KitapId], [UyeId], [PersonelId], [AlisTarihi], [IadeTarihi], [TeslimTarihi], [Durumu]) VALUES (2, 9, 3, 1, CAST(N'2023-01-28T00:00:00' AS SmallDateTime), CAST(N'2023-02-04T00:00:00' AS SmallDateTime), CAST(N'2023-02-04T16:43:00' AS SmallDateTime), 1)
INSERT [dbo].[TblHareket] ([Id], [KitapId], [UyeId], [PersonelId], [AlisTarihi], [IadeTarihi], [TeslimTarihi], [Durumu]) VALUES (3, 10, 3, 1, CAST(N'2023-01-28T00:00:00' AS SmallDateTime), CAST(N'2023-02-04T00:00:00' AS SmallDateTime), CAST(N'2023-02-04T16:43:00' AS SmallDateTime), 1)
INSERT [dbo].[TblHareket] ([Id], [KitapId], [UyeId], [PersonelId], [AlisTarihi], [IadeTarihi], [TeslimTarihi], [Durumu]) VALUES (4, 10, 3, 1, CAST(N'2023-01-28T00:00:00' AS SmallDateTime), CAST(N'2023-01-24T00:00:00' AS SmallDateTime), CAST(N'2023-02-04T16:44:00' AS SmallDateTime), 1)
INSERT [dbo].[TblHareket] ([Id], [KitapId], [UyeId], [PersonelId], [AlisTarihi], [IadeTarihi], [TeslimTarihi], [Durumu]) VALUES (5, 1, 3, 1, CAST(N'2023-01-10T00:00:00' AS SmallDateTime), CAST(N'2023-01-14T00:00:00' AS SmallDateTime), CAST(N'2023-02-04T16:44:00' AS SmallDateTime), 1)
INSERT [dbo].[TblHareket] ([Id], [KitapId], [UyeId], [PersonelId], [AlisTarihi], [IadeTarihi], [TeslimTarihi], [Durumu]) VALUES (6, 1, 3, 1, CAST(N'2023-01-01T00:00:00' AS SmallDateTime), CAST(N'2023-01-15T00:00:00' AS SmallDateTime), CAST(N'2023-02-04T16:42:00' AS SmallDateTime), 1)
INSERT [dbo].[TblHareket] ([Id], [KitapId], [UyeId], [PersonelId], [AlisTarihi], [IadeTarihi], [TeslimTarihi], [Durumu]) VALUES (7, 9, 3, 1, CAST(N'2023-02-04T00:00:00' AS SmallDateTime), CAST(N'2023-02-11T00:00:00' AS SmallDateTime), NULL, NULL)
INSERT [dbo].[TblHareket] ([Id], [KitapId], [UyeId], [PersonelId], [AlisTarihi], [IadeTarihi], [TeslimTarihi], [Durumu]) VALUES (8, 7, 3, 1, CAST(N'2023-02-08T00:00:00' AS SmallDateTime), CAST(N'2023-02-15T00:00:00' AS SmallDateTime), NULL, NULL)
INSERT [dbo].[TblHareket] ([Id], [KitapId], [UyeId], [PersonelId], [AlisTarihi], [IadeTarihi], [TeslimTarihi], [Durumu]) VALUES (9, 3, 1, 1, CAST(N'2023-02-08T00:00:00' AS SmallDateTime), CAST(N'2023-02-15T00:00:00' AS SmallDateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[TblHareket] OFF
SET IDENTITY_INSERT [dbo].[TblIletisim] ON 

INSERT [dbo].[TblIletisim] ([Id], [Ad], [Email], [Konu], [Mesaj]) VALUES (1, N'Mehmet', N'erenhabibasik@gmail.com', N'DEneme ', N'İçerik igirlecek')
SET IDENTITY_INSERT [dbo].[TblIletisim] OFF
SET IDENTITY_INSERT [dbo].[TblKitap] ON 

INSERT [dbo].[TblKitap] ([Id], [Ad], [KategoriId], [BasimYili], [YayinEvi], [Sayfa], [YazarId], [Durum], [ResimUrl]) VALUES (1, N'Mavi Balina', 6, N'2022', N'Roman', N'125', 5, 1, N'1.jpg')
INSERT [dbo].[TblKitap] ([Id], [Ad], [KategoriId], [BasimYili], [YayinEvi], [Sayfa], [YazarId], [Durum], [ResimUrl]) VALUES (2, N'Sarı Gelin', 6, N'2023', N'Beyaz Gül', N'250', 4, 1, N'2.jpg')
INSERT [dbo].[TblKitap] ([Id], [Ad], [KategoriId], [BasimYili], [YayinEvi], [Sayfa], [YazarId], [Durum], [ResimUrl]) VALUES (3, N'Yitik Bir Aşkın Gölgesinde', 8, N'2022', N'SEL', N'236', 4, 0, N'3.jpg')
INSERT [dbo].[TblKitap] ([Id], [Ad], [KategoriId], [BasimYili], [YayinEvi], [Sayfa], [YazarId], [Durum], [ResimUrl]) VALUES (4, N'Nar Çiçekleri: Çokkültürlülük Üstüne Denemeler', 8, N'2021', N'SEL', N'152', 7, NULL, N'4.jpg')
INSERT [dbo].[TblKitap] ([Id], [Ad], [KategoriId], [BasimYili], [YayinEvi], [Sayfa], [YazarId], [Durum], [ResimUrl]) VALUES (5, N'Evdalê Zeynikê''nin Hayatından Bir Gün', 7, N'2020', N'SEL', N'152', 6, NULL, N'15.jpg')
INSERT [dbo].[TblKitap] ([Id], [Ad], [KategoriId], [BasimYili], [YayinEvi], [Sayfa], [YazarId], [Durum], [ResimUrl]) VALUES (6, N'Kale', 7, N'2019', N'SEL', N'160', 6, NULL, N'16.jpg')
INSERT [dbo].[TblKitap] ([Id], [Ad], [KategoriId], [BasimYili], [YayinEvi], [Sayfa], [YazarId], [Durum], [ResimUrl]) VALUES (7, N'Gezginler', 6, N'2018', N'SEL', N'120', 6, 0, N'17.jpg')
INSERT [dbo].[TblKitap] ([Id], [Ad], [KategoriId], [BasimYili], [YayinEvi], [Sayfa], [YazarId], [Durum], [ResimUrl]) VALUES (8, N'Çalışma Şartları', 8, N'2009', N'Yağmur', N'150', 4, NULL, N'8.jpg')
INSERT [dbo].[TblKitap] ([Id], [Ad], [KategoriId], [BasimYili], [YayinEvi], [Sayfa], [YazarId], [Durum], [ResimUrl]) VALUES (9, N'Giden Ömür', 6, N'2022', N'Yağmur', N'160', 6, 0, N'9.jpg')
INSERT [dbo].[TblKitap] ([Id], [Ad], [KategoriId], [BasimYili], [YayinEvi], [Sayfa], [YazarId], [Durum], [ResimUrl]) VALUES (10, N'Devrim', 8, N'2019', N'Bolca', N'120', 4, 1, N'10.jpg')
SET IDENTITY_INSERT [dbo].[TblKitap] OFF
SET IDENTITY_INSERT [dbo].[TblMesajlar] ON 

INSERT [dbo].[TblMesajlar] ([Id], [Gonderen], [Alici], [Konu], [Icerik], [Tarih]) VALUES (1, N'lbilinmis@gelisim.edu.tr', N'leventamed@gmail.com', N'Deneme', N'ffrfrfrf', CAST(N'2023-02-07T17:59:00' AS SmallDateTime))
SET IDENTITY_INSERT [dbo].[TblMesajlar] OFF
SET IDENTITY_INSERT [dbo].[TblPersonel] ON 

INSERT [dbo].[TblPersonel] ([Id], [AdSoyad]) VALUES (1, N'Levent BİLİNMİŞ')
SET IDENTITY_INSERT [dbo].[TblPersonel] OFF
SET IDENTITY_INSERT [dbo].[TblUye] ON 

INSERT [dbo].[TblUye] ([Id], [Ad], [Soyad], [EMail], [KullaniciAdi], [Sifre], [Fotograf], [Telefon], [Okul]) VALUES (1, N'Levent', N'BİLİNMİŞ', N'lbilinmis@gelisim.edu.tr', N'lbilinmis', N'1', NULL, N'05389456798', N'İstanbul Gelişim Üniversitesi')
INSERT [dbo].[TblUye] ([Id], [Ad], [Soyad], [EMail], [KullaniciAdi], [Sifre], [Fotograf], [Telefon], [Okul]) VALUES (3, N'Emel', N'Arzu', N'e.arzu@gmaiil.com', N'earzu', N'1', NULL, N'5555555555', N'-')
SET IDENTITY_INSERT [dbo].[TblUye] OFF
SET IDENTITY_INSERT [dbo].[TblYazar] ON 

INSERT [dbo].[TblYazar] ([Id], [Ad], [Soyad], [Detay]) VALUES (4, N'Mehmet', N'Emin Yurdakul', NULL)
INSERT [dbo].[TblYazar] ([Id], [Ad], [Soyad], [Detay]) VALUES (5, N'Feqiye', N'Teyran', NULL)
INSERT [dbo].[TblYazar] ([Id], [Ad], [Soyad], [Detay]) VALUES (6, N'Sherlock', N'Adams', NULL)
INSERT [dbo].[TblYazar] ([Id], [Ad], [Soyad], [Detay]) VALUES (7, N'Mehmed ', N'Uzun', NULL)
INSERT [dbo].[TblYazar] ([Id], [Ad], [Soyad], [Detay]) VALUES (8, N'Can', N'Cabab', NULL)
SET IDENTITY_INSERT [dbo].[TblYazar] OFF
ALTER TABLE [dbo].[TblHareket] ADD  CONSTRAINT [DF_TblHareket_Durumu]  DEFAULT ((0)) FOR [Durumu]
GO
ALTER TABLE [dbo].[TblKitap] ADD  CONSTRAINT [DF_TblKitap_Durum]  DEFAULT ((1)) FOR [Durum]
GO
ALTER TABLE [dbo].[TblCeza]  WITH CHECK ADD  CONSTRAINT [FK_TblCeza_TblHareket] FOREIGN KEY([HareketId])
REFERENCES [dbo].[TblHareket] ([Id])
GO
ALTER TABLE [dbo].[TblCeza] CHECK CONSTRAINT [FK_TblCeza_TblHareket]
GO
ALTER TABLE [dbo].[TblCeza]  WITH CHECK ADD  CONSTRAINT [FK_TblCeza_TblUye] FOREIGN KEY([UyeId])
REFERENCES [dbo].[TblUye] ([Id])
GO
ALTER TABLE [dbo].[TblCeza] CHECK CONSTRAINT [FK_TblCeza_TblUye]
GO
ALTER TABLE [dbo].[TblHareket]  WITH CHECK ADD  CONSTRAINT [FK_TblHareket_TblKitap] FOREIGN KEY([KitapId])
REFERENCES [dbo].[TblKitap] ([Id])
GO
ALTER TABLE [dbo].[TblHareket] CHECK CONSTRAINT [FK_TblHareket_TblKitap]
GO
ALTER TABLE [dbo].[TblHareket]  WITH CHECK ADD  CONSTRAINT [FK_TblHareket_TblPersonel] FOREIGN KEY([PersonelId])
REFERENCES [dbo].[TblPersonel] ([Id])
GO
ALTER TABLE [dbo].[TblHareket] CHECK CONSTRAINT [FK_TblHareket_TblPersonel]
GO
ALTER TABLE [dbo].[TblHareket]  WITH CHECK ADD  CONSTRAINT [FK_TblHareket_TblUye] FOREIGN KEY([UyeId])
REFERENCES [dbo].[TblUye] ([Id])
GO
ALTER TABLE [dbo].[TblHareket] CHECK CONSTRAINT [FK_TblHareket_TblUye]
GO
ALTER TABLE [dbo].[TblKitap]  WITH CHECK ADD  CONSTRAINT [FK_TblKitap_TblCategory] FOREIGN KEY([KategoriId])
REFERENCES [dbo].[TblCategory] ([Id])
GO
ALTER TABLE [dbo].[TblKitap] CHECK CONSTRAINT [FK_TblKitap_TblCategory]
GO
ALTER TABLE [dbo].[TblKitap]  WITH CHECK ADD  CONSTRAINT [FK_TblKitap_TblYazar] FOREIGN KEY([YazarId])
REFERENCES [dbo].[TblYazar] ([Id])
GO
ALTER TABLE [dbo].[TblKitap] CHECK CONSTRAINT [FK_TblKitap_TblYazar]
GO
/****** Object:  StoredProcedure [dbo].[EnFazlaKitapOlanYazar]    Script Date: 10.02.2023 18:27:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[EnFazlaKitapOlanYazar]
as

select TOP 1 B.Ad+' '+B.Soyad FROM TblKitap A
inner join TblYazar B on A.YazarId=B.Id
group by B.Ad,B.Soyad order by COUNT(*) desc
 
GO
