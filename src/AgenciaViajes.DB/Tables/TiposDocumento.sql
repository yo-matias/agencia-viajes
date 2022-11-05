CREATE TABLE [dbo].[TiposDocumento] (
    [IdTipoDocumento]          INT          NOT NULL,
    [DescripcionTipoDocumento] VARCHAR (60) NULL,
    CONSTRAINT [PK_TiposDocumento] PRIMARY KEY CLUSTERED ([IdTipoDocumento] ASC)
);

