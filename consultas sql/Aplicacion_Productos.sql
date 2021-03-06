USE [master]
GO
/****** Object:  Database [Aplicacion_Productos]    Script Date: 3/17/2022 8:41:49 PM ******/
CREATE DATABASE [Aplicacion_Productos]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Aplicacion_Productos', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Aplicacion_Productos.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Aplicacion_Productos_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Aplicacion_Productos_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Aplicacion_Productos] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Aplicacion_Productos].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Aplicacion_Productos] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Aplicacion_Productos] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Aplicacion_Productos] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Aplicacion_Productos] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Aplicacion_Productos] SET ARITHABORT OFF 
GO
ALTER DATABASE [Aplicacion_Productos] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Aplicacion_Productos] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Aplicacion_Productos] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Aplicacion_Productos] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Aplicacion_Productos] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Aplicacion_Productos] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Aplicacion_Productos] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Aplicacion_Productos] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Aplicacion_Productos] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Aplicacion_Productos] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Aplicacion_Productos] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Aplicacion_Productos] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Aplicacion_Productos] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Aplicacion_Productos] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Aplicacion_Productos] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Aplicacion_Productos] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Aplicacion_Productos] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Aplicacion_Productos] SET RECOVERY FULL 
GO
ALTER DATABASE [Aplicacion_Productos] SET  MULTI_USER 
GO
ALTER DATABASE [Aplicacion_Productos] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Aplicacion_Productos] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Aplicacion_Productos] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Aplicacion_Productos] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Aplicacion_Productos] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Aplicacion_Productos', N'ON'
GO
ALTER DATABASE [Aplicacion_Productos] SET QUERY_STORE = OFF
GO
USE [Aplicacion_Productos]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 3/17/2022 8:41:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[Usuario] [nvarchar](max) NULL,
	[Contraseña] [nvarchar](max) NULL,
	[id] [int] NOT NULL IDENTITY(1,1),
 CONSTRAINT [PK_Admin] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Articulos]    Script Date: 3/17/2022 8:41:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Articulos](
	[Nombre] [varchar](max) NULL,
	[Precio] [varchar](max) NULL,
	[Imagen] [varbinary](max) NULL,
	[_id] [int] NOT NULL IDENTITY(1,1),
	[Supermercado] [varchar](max) NULL,
	[Categoria][varchar](max) NULL,
 CONSTRAINT [PK_Articulos] PRIMARY KEY CLUSTERED 
(
	[_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Carrito_]    Script Date: 3/17/2022 8:41:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Carrito_](
	[Articulo] [int] NULL,
	[Disponibilidad] [varchar](max) NULL,
	[Descripcion] [varchar](max) NULL,
	[id] [int] NOT NULL IDENTITY(1,1),
 CONSTRAINT [PK_Carrito_] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Facturacion_]    Script Date: 3/17/2022 8:41:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Facturacion_](
	[Descripcion] [int] NULL,
	[Precio] [int] NULL,
	[Impuestos] [decimal](4, 2) NULL,
	[Metodo de Pago] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Metodo_de_Pago]    Script Date: 3/17/2022 8:41:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Metodo_de_Pago](
	[Numero de Tarjeta] [varchar](max) NULL,
	[Nombre] [varchar](max) NULL,
	[Fecha de Vencimiento] [date] NULL,
	[CVV] [int] NULL,
	[id] [int] NOT NULL IDENTITY(1,1),
 CONSTRAINT [PK_Metodo_de_Pago] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Perfil]    Script Date: 3/17/2022 8:41:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Perfil](
	[Imagen] [varbinary](max) NULL,
	[Nombre] [varchar](max) NULL,
	[Apellidos] [varchar](max) NULL,
	[Telefono] [varchar](max) NULL,
	[Usuario] [int] NULL,
	[Correo Electronico] [varchar](max) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 3/17/2022 8:41:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Usuario] [varchar](max) NULL,
	[Contraseña] [varchar](max) NULL,
	[id] [int] NOT NULL IDENTITY(1,1),
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Carrito_]  WITH CHECK ADD  CONSTRAINT [FK_Carrito__Articulos] FOREIGN KEY([Articulo])
REFERENCES [dbo].[Articulos] ([_id])
GO
ALTER TABLE [dbo].[Carrito_] CHECK CONSTRAINT [FK_Carrito__Articulos]
GO
ALTER TABLE [dbo].[Facturacion_]  WITH CHECK ADD  CONSTRAINT [FK_Facturacion__Carrito_] FOREIGN KEY([Descripcion])
REFERENCES [dbo].[Carrito_] ([id])
GO
ALTER TABLE [dbo].[Facturacion_] CHECK CONSTRAINT [FK_Facturacion__Carrito_]
GO
ALTER TABLE [dbo].[Facturacion_]  WITH CHECK ADD  CONSTRAINT [FK_Facturacion__Metodo_de_Pago] FOREIGN KEY([Metodo de Pago])
REFERENCES [dbo].[Metodo_de_Pago] ([id])
GO
ALTER TABLE [dbo].[Facturacion_] CHECK CONSTRAINT [FK_Facturacion__Metodo_de_Pago]
GO
ALTER TABLE [dbo].[Perfil]  WITH CHECK ADD  CONSTRAINT [FK_Perfil_Usuario] FOREIGN KEY([Usuario])
REFERENCES [dbo].[Usuario] ([id])
GO
ALTER TABLE [dbo].[Perfil] CHECK CONSTRAINT [FK_Perfil_Usuario]
GO
USE [master]
GO
ALTER DATABASE [Aplicacion_Productos] SET  READ_WRITE 
GO
