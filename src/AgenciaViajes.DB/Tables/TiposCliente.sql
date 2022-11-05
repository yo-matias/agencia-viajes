CREATE TABLE [dbo].[TiposCliente] (
    [IdTipoCliente]          INT          NOT NULL,
    [DescripcionTipoCliente] VARCHAR (60) NULL,
    CONSTRAINT [PK_TiposCliente] PRIMARY KEY CLUSTERED ([IdTipoCliente] ASC)
);

