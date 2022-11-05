CREATE TABLE [dbo].[Ciudades] (
    [IdCiudad]    INT          NOT NULL,
    [Ciudad]      VARCHAR (60) NULL,
    [IdProvincia] INT          NOT NULL,
    [IdPais]      INT          NOT NULL,
    CONSTRAINT [PK_Ciudades] PRIMARY KEY CLUSTERED ([IdCiudad] ASC),
    CONSTRAINT [FK_Ciudades_Paises] FOREIGN KEY ([IdPais]) REFERENCES [dbo].[Paises] ([IdPais]),
    CONSTRAINT [FK_Ciudades_Provincias] FOREIGN KEY ([IdProvincia]) REFERENCES [dbo].[Provincias] ([IdProvincia])
);

