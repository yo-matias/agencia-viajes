CREATE TABLE [dbo].[DetallesFactura] (
    [NroFactura] INT            NOT NULL,
    [IdPaquete]  INT            NOT NULL,
    [Cantidad]   INT            NOT NULL,
    [Precio]     DECIMAL (8, 2) NOT NULL,
    CONSTRAINT [PK_DetallesFactura] PRIMARY KEY CLUSTERED ([NroFactura] ASC, [IdPaquete] ASC),
    CONSTRAINT [FK_DetallesFactura_Facturas] FOREIGN KEY ([NroFactura]) REFERENCES [dbo].[Facturas] ([NroFactura]),
    CONSTRAINT [FK_DetallesFactura_Paquetes] FOREIGN KEY ([IdPaquete]) REFERENCES [dbo].[Paquetes] ([IdPaquete])
);



