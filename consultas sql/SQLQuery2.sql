/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Nombre]
      ,[Precio]
      ,[Imagen]
      ,[_id]
  FROM [Aplicacion_Productos].[dbo].[Articulos]

/****** Object:  Table [dbo].[Articulos]    Script Date: 3/17/2022 8:41:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Articulos](
	[Nombre] [nvarchar](max) NULL,
	[Precio] [varchar](max) NULL,
	[Imagen] [varbinary](max) NULL,
	[_id] [int] NOT NULL IDENTITY(1,1),
CONSTRAINT [PK_Articulos] PRIMARY KEY CLUSTERED 
(
	[_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

drop table Articulos
drop table Carrito_
