CREATE TABLE [dbo].[TiposDeClientes] (
    [IdTipoCliente] INT           NOT NULL,
    [Descripcion]   VARCHAR (120) NOT NULL,
    CONSTRAINT [PK_TiposDeClientes] PRIMARY KEY CLUSTERED ([IdTipoCliente] ASC)
);

