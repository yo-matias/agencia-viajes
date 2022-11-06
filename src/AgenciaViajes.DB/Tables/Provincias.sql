CREATE TABLE [dbo].[Provincias] (
    [IdProvincia] INT          IDENTITY (1, 1) NOT NULL,
    [Provincia]   VARCHAR (60) NOT NULL,
    [IdPais]      INT          NOT NULL,
    CONSTRAINT [PK_Provincias] PRIMARY KEY CLUSTERED ([IdProvincia] ASC),
    CONSTRAINT [FK_Provincias_Paises] FOREIGN KEY ([IdPais]) REFERENCES [dbo].[Paises] ([IdPais])
);





