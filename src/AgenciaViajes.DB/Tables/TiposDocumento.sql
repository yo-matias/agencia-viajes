CREATE TABLE [dbo].[TiposDocumento] (
    [IdTipoDocumento]          INT          IDENTITY (1, 1) NOT NULL,
    [DescripcionTipoDocumento] VARCHAR (60) NOT NULL,
    CONSTRAINT [PK_TiposDocumento] PRIMARY KEY CLUSTERED ([IdTipoDocumento] ASC)
);





