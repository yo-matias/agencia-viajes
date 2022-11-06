CREATE TABLE [dbo].[Paquetes] (
    [IdPaquete]     INT            IDENTITY (1, 1) NOT NULL,
    [NombrePaquete] VARCHAR (60)   NOT NULL,
    [Precio]        DECIMAL (8, 2) NOT NULL,
    [Duracion]      INT            NOT NULL,
    [FechaSalida]   DATETIME       NOT NULL,
    [Vigente]       BIT            NOT NULL,
    [IdTipoPaquete] INT            NOT NULL,
    CONSTRAINT [PK_Paquetes] PRIMARY KEY CLUSTERED ([IdPaquete] ASC),
    CONSTRAINT [FK_Paquetes_TiposPaquete] FOREIGN KEY ([IdTipoPaquete]) REFERENCES [dbo].[TiposPaquete] ([IdTipoPaquete])
);



