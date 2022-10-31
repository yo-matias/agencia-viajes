USE [AgenciaViajesDB]
GO

DECLARE @IdPais INT;
DECLARE @IdProvincia INT;

-- Limpieza previos
/*
TRUNCATE TABLE [dbo].[Ciudades];
TRUNCATE TABLE [dbo].[Provincias];
TRUNCATE TABLE [dbo].[Paises];
*/

-- Argentina
INSERT INTO [dbo].[Paises] ([Descripcion]) VALUES ('Argentina');
SET @IdPais = SCOPE_IDENTITY();
-- Argentina -- Santa Fe
INSERT INTO [dbo].[Provincias]([Descripcion],[IdPais]) VALUES('Santa Fe', @IdPais);
SET @IdProvincia = SCOPE_IDENTITY();
-- Argentina -- Santa Fe -- [Ciudades]
INSERT INTO [dbo].[Ciudades] ([Descripcion],[IdProvincia]) VALUES ('Santa Fe', @IdProvincia);
INSERT INTO [dbo].[Ciudades] ([Descripcion],[IdProvincia]) VALUES ('Rosario', @IdProvincia);

-- Argentina -- Entre Ríos
INSERT INTO [dbo].[Provincias]([Descripcion],[IdPais]) VALUES('Entre Ríos', @IdPais);
SET @IdProvincia = SCOPE_IDENTITY();
-- Argentina -- Entre Ríos -- [Ciudades]
INSERT INTO [dbo].[Ciudades] ([Descripcion],[IdProvincia]) VALUES ('Rafaela', @IdProvincia);
INSERT INTO [dbo].[Ciudades] ([Descripcion],[IdProvincia]) VALUES ('Paraná', @IdProvincia);

-- Argentina -- Buenos Aires
INSERT INTO [dbo].[Provincias]([Descripcion],[IdPais]) VALUES('Buenos Aires', @IdPais);
SET @IdProvincia = SCOPE_IDENTITY();
-- Argentina -- Buenos Aires -- [Ciudades]
INSERT INTO [dbo].[Ciudades] ([Descripcion],[IdProvincia]) VALUES ('Buenos Aires', @IdProvincia);

-- Brazil
INSERT INTO [dbo].[Paises] ([Descripcion]) VALUES ('Brazil');
SET @IdPais = SCOPE_IDENTITY();

-- Uruguay
INSERT INTO [dbo].[Paises] ([Descripcion]) VALUES ('Uruguay');
SET @IdPais = SCOPE_IDENTITY();

-- Chile
INSERT INTO [dbo].[Paises] ([Descripcion]) VALUES ('Chile');
SET @IdPais = SCOPE_IDENTITY();