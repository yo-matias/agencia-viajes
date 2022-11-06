CREATE TABLE [dbo].[TiposPaquete] (
    [IdTipoPaquete]      INT            IDENTITY (1, 1) NOT NULL,
    [CotizacionDolar]    DECIMAL (8, 2) NOT NULL,
    [Visa]               BIT            NOT NULL,
    [ImpuestoFijo]       DECIMAL (8, 2) NOT NULL,
    [ImpuestoPorcentaje] INT            NOT NULL,
    CONSTRAINT [PK_TiposPaquete] PRIMARY KEY CLUSTERED ([IdTipoPaquete] ASC)
);





