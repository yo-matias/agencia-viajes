DECLARE @IdPais INT, @IdProvincia INT;

-- Argentina
INSERT INTO [dbo].[Paises] ([Pais],[Gentilicio]) VALUES ('Argentina', 'Argentino');
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
INSERT INTO [dbo].[Paises] ([Pais],[Gentilicio]) VALUES ('Brazil', 'Brasilero');
SET @IdPais = SCOPE_IDENTITY();
INSERT INTO [dbo].[Provincias]([Provincia],[IdPais]) VALUES('Pará', @IdPais);
SET @IdProvincia = SCOPE_IDENTITY();
INSERT INTO [dbo].[Ciudades] ([Ciudad],[IdProvincia]) VALUES ('Belém', @IdProvincia);
INSERT INTO [dbo].[Provincias]([Provincia],[IdPais]) VALUES('Río Grande del Sur', @IdPais);
SET @IdProvincia = SCOPE_IDENTITY();
INSERT INTO [dbo].[Ciudades] ([Ciudad],[IdProvincia]) VALUES ('Porto Alegre', @IdProvincia);

-- Uruguay
INSERT INTO [dbo].[Paises] ([Pais],[Gentilicio]) VALUES ('Uruguay', 'Uruguayo');
SET @IdPais = SCOPE_IDENTITY();

INSERT INTO [dbo].[Provincias]([Provincia],[IdPais]) VALUES('Montevideo', @IdPais);
SET @IdProvincia = SCOPE_IDENTITY();
INSERT INTO [dbo].[Ciudades] ([Ciudad],[IdProvincia]) VALUES ('Montevideo', @IdProvincia);

INSERT INTO [dbo].[Provincias]([Provincia],[IdPais]) VALUES('Paysandú', @IdPais);
SET @IdProvincia = SCOPE_IDENTITY();
INSERT INTO [dbo].[Ciudades] ([Ciudad],[IdProvincia]) VALUES ('Paysandú', @IdProvincia);

INSERT INTO [dbo].[Provincias]([Provincia],[IdPais]) VALUES('Salto', @IdPais);
SET @IdProvincia = SCOPE_IDENTITY();
INSERT INTO [dbo].[Ciudades] ([Ciudad],[IdProvincia]) VALUES ('Salto', @IdProvincia);

-- Chile
INSERT INTO [dbo].[Paises] ([Pais],[Gentilicio]) VALUES ('Chile', 'Chileno');
SET @IdPais = SCOPE_IDENTITY();

INSERT INTO [dbo].[Provincias]([Provincia],[IdPais]) VALUES('Arica', @IdPais);
SET @IdProvincia = SCOPE_IDENTITY();
INSERT INTO [dbo].[Ciudades] ([Ciudad],[IdProvincia]) VALUES ('Arica', @IdProvincia);

INSERT INTO [dbo].[Provincias]([Provincia],[IdPais]) VALUES('Elqui', @IdPais);
SET @IdProvincia = SCOPE_IDENTITY();
INSERT INTO [dbo].[Ciudades] ([Ciudad],[IdProvincia]) VALUES ('Coquimbo', @IdProvincia);

INSERT INTO [dbo].[Provincias]([Provincia],[IdPais]) VALUES('Santiago', @IdPais);
SET @IdProvincia = SCOPE_IDENTITY();
INSERT INTO [dbo].[Ciudades] ([Ciudad],[IdProvincia]) VALUES ('Santiago', @IdProvincia);