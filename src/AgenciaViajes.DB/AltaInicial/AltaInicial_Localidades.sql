DECLARE @IdPais INT, @IdProvincia INT;

-- Argentina
INSERT INTO [dbo].[Paises] ([Pais]) VALUES ('Argentina');
SET @IdPais = SCOPE_IDENTITY();
-- Argentina -- Santa Fe
INSERT INTO [dbo].[Provincias]([Provincia],[IdPais]) VALUES('Santa Fe', @IdPais);
SET @IdProvincia = SCOPE_IDENTITY();
-- Argentina -- Santa Fe -- [Ciudades]
INSERT INTO [dbo].[Ciudades] ([Ciudad],[IdProvincia]) VALUES ('Santa Fe', @IdProvincia);
INSERT INTO [dbo].[Ciudades] ([Ciudad],[IdProvincia]) VALUES ('Rosario', @IdProvincia);

-- Argentina -- Entre Ríos
INSERT INTO [dbo].[Provincias]([Provincia],[IdPais]) VALUES('Entre Ríos', @IdPais);
SET @IdProvincia = SCOPE_IDENTITY();
-- Argentina -- Entre Ríos -- [Ciudades]
INSERT INTO [dbo].[Ciudades] ([Ciudad],[IdProvincia]) VALUES ('Rafaela', @IdProvincia);
INSERT INTO [dbo].[Ciudades] ([Ciudad],[IdProvincia]) VALUES ('Paraná', @IdProvincia);

-- Argentina -- Buenos Aires
INSERT INTO [dbo].[Provincias]([Provincia],[IdPais]) VALUES('Buenos Aires', @IdPais);
SET @IdProvincia = SCOPE_IDENTITY();
-- Argentina -- Buenos Aires -- [Ciudades]
INSERT INTO [dbo].[Ciudades] ([Ciudad],[IdProvincia]) VALUES ('Buenos Aires', @IdProvincia);

-- Brazil
INSERT INTO [dbo].[Paises] ([Pais]) VALUES ('Brazil');
SET @IdPais = SCOPE_IDENTITY();

-- Uruguay
INSERT INTO [dbo].[Paises] ([Pais]) VALUES ('Uruguay');
SET @IdPais = SCOPE_IDENTITY();

-- Chile
INSERT INTO [dbo].[Paises] ([Pais]) VALUES ('Chile');
SET @IdPais = SCOPE_IDENTITY();