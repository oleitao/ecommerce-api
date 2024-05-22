USE [master]
GO
/****** Object:  Database [ecommerce-db]    Script Date: 5/22/2024 10:13:50 PM ******/
CREATE DATABASE [ecommerce-db]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ecommerce-db', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\ecommerce-db.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ecommerce-db_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\ecommerce-db_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [ecommerce-db] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ecommerce-db].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ecommerce-db] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ecommerce-db] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ecommerce-db] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ecommerce-db] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ecommerce-db] SET ARITHABORT OFF 
GO
ALTER DATABASE [ecommerce-db] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [ecommerce-db] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ecommerce-db] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ecommerce-db] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ecommerce-db] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ecommerce-db] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ecommerce-db] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ecommerce-db] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ecommerce-db] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ecommerce-db] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ecommerce-db] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ecommerce-db] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ecommerce-db] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ecommerce-db] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ecommerce-db] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ecommerce-db] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [ecommerce-db] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ecommerce-db] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ecommerce-db] SET  MULTI_USER 
GO
ALTER DATABASE [ecommerce-db] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ecommerce-db] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ecommerce-db] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ecommerce-db] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ecommerce-db] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ecommerce-db] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [ecommerce-db] SET QUERY_STORE = ON
GO
ALTER DATABASE [ecommerce-db] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [ecommerce-db]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 5/22/2024 10:13:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[migration_id] [nvarchar](150) NOT NULL,
	[product_version] [nvarchar](32) NOT NULL,
 CONSTRAINT [pk___ef_migrations_history] PRIMARY KEY CLUSTERED 
(
	[migration_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[categories]    Script Date: 5/22/2024 10:13:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[categories](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[title] [nvarchar](max) NULL,
	[sub_title] [nvarchar](max) NULL,
	[image_url] [nvarchar](max) NULL,
 CONSTRAINT [pk_categories] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[image_urls]    Script Date: 5/22/2024 10:13:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[image_urls](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[product_id] [int] NOT NULL,
	[public_url] [nvarchar](max) NULL,
	[url] [nvarchar](max) NULL,
 CONSTRAINT [pk_image_urls] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[products]    Script Date: 5/22/2024 10:13:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[products](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[category_id] [int] NULL,
	[name] [nvarchar](max) NULL,
	[description] [nvarchar](max) NULL,
	[price] [int] NOT NULL,
	[discount_price] [int] NOT NULL,
	[rating] [int] NOT NULL,
	[total_sell] [int] NOT NULL,
	[stock] [int] NOT NULL,
 CONSTRAINT [pk_products] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[reviews]    Script Date: 5/22/2024 10:13:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[reviews](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[user_id] [int] NULL,
	[comment] [nvarchar](max) NULL,
	[rating] [int] NOT NULL,
	[product_id] [int] NULL,
 CONSTRAINT [pk_reviews] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[shop_avatars]    Script Date: 5/22/2024 10:13:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[shop_avatars](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[public_id] [nvarchar](max) NULL,
	[url] [nvarchar](max) NULL,
	[shop_id] [int] NULL,
 CONSTRAINT [pk_shop_avatars] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[shops]    Script Date: 5/22/2024 10:13:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[shops](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](max) NULL,
	[ratings] [int] NOT NULL,
	[product_id] [int] NULL,
 CONSTRAINT [pk_shops] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 5/22/2024 10:13:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[full_name] [nvarchar](max) NULL,
	[sex] [nvarchar](1) NOT NULL,
	[age] [int] NOT NULL,
	[birthday] [datetime2](7) NULL,
	[hobby] [nvarchar](max) NULL,
	[email] [nvarchar](max) NULL,
 CONSTRAINT [pk_users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Index [ix_image_urls_product_id]    Script Date: 5/22/2024 10:13:50 PM ******/
CREATE NONCLUSTERED INDEX [ix_image_urls_product_id] ON [dbo].[image_urls]
(
	[product_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [ix_products_category_id]    Script Date: 5/22/2024 10:13:50 PM ******/
CREATE NONCLUSTERED INDEX [ix_products_category_id] ON [dbo].[products]
(
	[category_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [ix_reviews_product_id]    Script Date: 5/22/2024 10:13:50 PM ******/
CREATE NONCLUSTERED INDEX [ix_reviews_product_id] ON [dbo].[reviews]
(
	[product_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [ix_reviews_user_id]    Script Date: 5/22/2024 10:13:50 PM ******/
CREATE NONCLUSTERED INDEX [ix_reviews_user_id] ON [dbo].[reviews]
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [ix_shop_avatars_shop_id]    Script Date: 5/22/2024 10:13:50 PM ******/
CREATE NONCLUSTERED INDEX [ix_shop_avatars_shop_id] ON [dbo].[shop_avatars]
(
	[shop_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [ix_shops_product_id]    Script Date: 5/22/2024 10:13:50 PM ******/
CREATE NONCLUSTERED INDEX [ix_shops_product_id] ON [dbo].[shops]
(
	[product_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[image_urls]  WITH CHECK ADD  CONSTRAINT [fk_image_urls_products_product_id] FOREIGN KEY([product_id])
REFERENCES [dbo].[products] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[image_urls] CHECK CONSTRAINT [fk_image_urls_products_product_id]
GO
ALTER TABLE [dbo].[products]  WITH CHECK ADD  CONSTRAINT [fk_products_categories_category_id] FOREIGN KEY([category_id])
REFERENCES [dbo].[categories] ([id])
GO
ALTER TABLE [dbo].[products] CHECK CONSTRAINT [fk_products_categories_category_id]
GO
ALTER TABLE [dbo].[reviews]  WITH CHECK ADD  CONSTRAINT [fk_reviews_products_product_id] FOREIGN KEY([product_id])
REFERENCES [dbo].[products] ([id])
GO
ALTER TABLE [dbo].[reviews] CHECK CONSTRAINT [fk_reviews_products_product_id]
GO
ALTER TABLE [dbo].[reviews]  WITH CHECK ADD  CONSTRAINT [fk_reviews_users_user_id] FOREIGN KEY([user_id])
REFERENCES [dbo].[users] ([id])
GO
ALTER TABLE [dbo].[reviews] CHECK CONSTRAINT [fk_reviews_users_user_id]
GO
ALTER TABLE [dbo].[shop_avatars]  WITH CHECK ADD  CONSTRAINT [fk_shop_avatars_shops_shop_id] FOREIGN KEY([shop_id])
REFERENCES [dbo].[shops] ([id])
GO
ALTER TABLE [dbo].[shop_avatars] CHECK CONSTRAINT [fk_shop_avatars_shops_shop_id]
GO
ALTER TABLE [dbo].[shops]  WITH CHECK ADD  CONSTRAINT [fk_shops_products_product_id] FOREIGN KEY([product_id])
REFERENCES [dbo].[products] ([id])
GO
ALTER TABLE [dbo].[shops] CHECK CONSTRAINT [fk_shops_products_product_id]
GO
USE [master]
GO
ALTER DATABASE [ecommerce-db] SET  READ_WRITE 
GO
