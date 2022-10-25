CREATE TABLE [dbo].[TiposDeDocumentos] (
    [IdTipoDocumento] INT           NOT NULL,
    [Descripcion]     VARCHAR (120) NOT NULL,
    CONSTRAINT [PK_TiposDeDocumentos] PRIMARY KEY CLUSTERED ([IdTipoDocumento] ASC)
);

