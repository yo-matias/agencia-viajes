CREATE TABLE [dbo].[Provincias] (
    [IdProvincia] INT          NOT NULL,
    [Provincia]   VARCHAR (60) NULL,
    [IdPais]      INT          NULL,
    CONSTRAINT [PK_Provincias] PRIMARY KEY CLUSTERED ([IdProvincia] ASC),
    CONSTRAINT [FK_Provincias_Paises] FOREIGN KEY ([IdPais]) REFERENCES [dbo].[Paises] ([IdPais])
);

