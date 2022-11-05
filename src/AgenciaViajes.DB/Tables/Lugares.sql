CREATE TABLE [dbo].[Lugares] (
    [IdLugar]     INT          NOT NULL,
    [NombreLugar] VARCHAR (60) NULL,
    [IdCiudad]    INT          NOT NULL,
    CONSTRAINT [PK_Lugares] PRIMARY KEY CLUSTERED ([IdLugar] ASC),
    CONSTRAINT [FK_Lugares_Ciudades] FOREIGN KEY ([IdCiudad]) REFERENCES [dbo].[Ciudades] ([IdCiudad])
);

