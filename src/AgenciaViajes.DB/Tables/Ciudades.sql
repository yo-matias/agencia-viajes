﻿CREATE TABLE [dbo].[Ciudades] (
    [IdCiudad]    INT           IDENTITY (1, 1) NOT NULL,
    [Descripcion] VARCHAR (120) NOT NULL,
    [IdProvincia] INT           NOT NULL,
    CONSTRAINT [PK_Ciudades] PRIMARY KEY CLUSTERED ([IdCiudad] ASC),
    CONSTRAINT [FK_Ciudades_Provincias] FOREIGN KEY ([IdProvincia]) REFERENCES [dbo].[Provincias] ([IdProvincia])
);

