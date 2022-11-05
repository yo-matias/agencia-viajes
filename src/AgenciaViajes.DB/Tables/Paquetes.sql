CREATE TABLE [dbo].[Paquetes] (
    [IdPaquete]     INT            NOT NULL,
    [NombrePaquete] VARCHAR (60)   NULL,
    [Precio]        DECIMAL (8, 2) NULL,
    [Duracion]      INT            NULL,
    [FechaSalida]   DATETIME       NULL,
    [Vigente]       BIT            NULL,
    [IdTipoPaquete] INT            NOT NULL,
    CONSTRAINT [PK_Paquetes] PRIMARY KEY CLUSTERED ([IdPaquete] ASC),
    CONSTRAINT [FK_Paquetes_TiposPaquete] FOREIGN KEY ([IdTipoPaquete]) REFERENCES [dbo].[TiposPaquete] ([IdTipoPaquete])
);

