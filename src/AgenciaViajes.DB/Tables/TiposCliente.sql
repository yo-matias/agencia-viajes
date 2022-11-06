CREATE TABLE [dbo].[TiposCliente] (
    [IdTipoCliente]          INT          IDENTITY (1, 1) NOT NULL,
    [DescripcionTipoCliente] VARCHAR (60) NOT NULL,
    CONSTRAINT [PK_TiposCliente] PRIMARY KEY CLUSTERED ([IdTipoCliente] ASC)
);





