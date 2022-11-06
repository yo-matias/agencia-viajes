CREATE TABLE [dbo].[Facturas] (
    [NroFactura]   INT            NOT NULL,
    [IdCliente]    INT            NOT NULL,
    [Total]        DECIMAL (8, 2) NOT NULL,
    [FechaEmision] DATETIME       NOT NULL,
    [IdFormaPago]  INT            NOT NULL,
    CONSTRAINT [PK_Facturas] PRIMARY KEY CLUSTERED ([NroFactura] ASC),
    CONSTRAINT [FK_Facturas_Clientes] FOREIGN KEY ([IdCliente]) REFERENCES [dbo].[Clientes] ([IdCliente]),
    CONSTRAINT [FK_Facturas_FormasPago] FOREIGN KEY ([IdFormaPago]) REFERENCES [dbo].[FormasDePago] ([IdFormaPago])
);



