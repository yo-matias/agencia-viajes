CREATE TABLE [dbo].[TiposPaquete] (
    [IdTipoPaquete]      INT            NOT NULL,
    [CotizacionDolar]    DECIMAL (8, 2) NULL,
    [Visa]               BIT            NULL,
    [ImpuestoFijo]       DECIMAL (8, 2) NULL,
    [ImpuestoPorcentaje] INT            NULL,
    CONSTRAINT [PK_TiposPaquete] PRIMARY KEY CLUSTERED ([IdTipoPaquete] ASC)
);

