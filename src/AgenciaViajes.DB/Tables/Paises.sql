CREATE TABLE [dbo].[Paises] (
    [IdPais]      INT           IDENTITY (1, 1) NOT NULL,
    [Descripcion] VARCHAR (120) NOT NULL,
    CONSTRAINT [PK_Paises] PRIMARY KEY CLUSTERED ([IdPais] ASC)
);

