CREATE TABLE [dbo].[Lugares] (
    [IdLugar]     INT          IDENTITY (1, 1) NOT NULL,
    [NombreLugar] VARCHAR (60) NOT NULL,
    [IdCiudad]    INT          NOT NULL,
    CONSTRAINT [PK_Lugares] PRIMARY KEY CLUSTERED ([IdLugar] ASC),
    CONSTRAINT [FK_Lugares_Ciudades] FOREIGN KEY ([IdCiudad]) REFERENCES [dbo].[Ciudades] ([IdCiudad])
);





