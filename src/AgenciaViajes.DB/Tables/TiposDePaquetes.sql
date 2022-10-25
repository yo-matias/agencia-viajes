CREATE TABLE [dbo].[TiposDePaquetes] (
    [IdTipoPaquete] INT           NOT NULL,
    [Descripcion]   VARCHAR (120) NOT NULL,
    CONSTRAINT [PK_TiposDePaquetes] PRIMARY KEY CLUSTERED ([IdTipoPaquete] ASC)
);

