/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Nombre]
      ,[Precio]
      ,[Imagen]
      ,[_id]
      ,[Supermercado]
      ,[Categoria]
  FROM [Aplicacion_Productos].[dbo].[Articulos]

  INSERT INTO Usuario Values('diego','1234')

  SELECT TOP (1000)
  [Usuario],
  [Contrase�a]
  FROM [Aplicacion_Productos].[dbo].[Usuario]

  SELECT COUNT(*) FROM [Aplicacion_Productos].[dbo].[Usuario] WHERE [Usuario] = 'diego' and [Contrase�a] = '1234'