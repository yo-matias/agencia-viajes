CREATE TABLE [dbo].[Nacionalidades] (
    [IdNacionalidad] INT           IDENTITY (1, 1) NOT NULL,
    [Descripcion]    VARCHAR (120) NOT NULL,
    [IdPais]         INT           NOT NULL,
    CONSTRAINT [PK_Nacionalidades] PRIMARY KEY CLUSTERED ([IdNacionalidad] ASC),
    CONSTRAINT [FK_Nacionalidades_Paises] FOREIGN KEY ([IdPais]) REFERENCES [dbo].[Paises] ([IdPais])
);

