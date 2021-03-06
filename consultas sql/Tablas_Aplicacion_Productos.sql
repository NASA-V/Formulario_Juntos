USE [Aplicacion_Productos]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 3/22/2022 9:38:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[Usuario] [nvarchar](max) NULL,
	[Contraseña] [nvarchar](max) NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Admin] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Articulos]    Script Date: 3/22/2022 9:38:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Articulos](
	[Nombre] [varchar](max) NULL,
	[Precio] [varchar](max) NULL,
	[Imagen] [varbinary](max) NULL,
	[_id] [int] IDENTITY(1,1) NOT NULL,
	[Supermercado] [varchar](max) NULL,
	[Categoria] [varchar](max) NULL,
 CONSTRAINT [PK_Articulos] PRIMARY KEY CLUSTERED 
(
	[_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Carrito_]    Script Date: 3/22/2022 9:38:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Carrito_](
	[Articulo] [int] NULL,
	[Disponibilidad] [varchar](max) NULL,
	[Descripcion] [varchar](max) NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Carrito_] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Facturacion_]    Script Date: 3/22/2022 9:38:08 PM ******/
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
/****** Object:  Table [dbo].[Metodo_de_Pago]    Script Date: 3/22/2022 9:38:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Metodo_de_Pago](
	[Numero de Tarjeta] [varchar](max) NULL,
	[Nombre] [varchar](max) NULL,
	[Fecha de Vencimiento] [date] NULL,
	[CVV] [int] NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Metodo_de_Pago] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Perfil]    Script Date: 3/22/2022 9:38:08 PM ******/
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
/****** Object:  Table [dbo].[Usuario]    Script Date: 3/22/2022 9:38:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Usuario] [varchar](max) NULL,
	[Contraseña] [varchar](max) NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
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
