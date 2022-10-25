CREATE TABLE [dbo].[Paquetes] (
    [Id]            INT           NOT NULL,
    [Descripcion]   VARCHAR (120) NOT NULL,
    [Precio]        MONEY         NOT NULL,
    [Duracion]      VARCHAR (50)  NOT NULL,
    [FechaSalida]   DATETIME      NOT NULL,
    [Vigente]       BIT           NOT NULL,
    [IdTipoPaquete] INT           NOT NULL,
    CONSTRAINT [PK_Paquetes] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Paquetes_TiposDePaquetes] FOREIGN KEY ([IdTipoPaquete]) REFERENCES [dbo].[TiposDePaquetes] ([IdTipoPaquete])
);

