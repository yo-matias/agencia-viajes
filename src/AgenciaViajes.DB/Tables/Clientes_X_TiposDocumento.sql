CREATE TABLE [dbo].[Clientes_X_TiposDocumento] (
    [IdCliente]       INT          NOT NULL,
    [IdTipoDocumento] INT          NOT NULL,
    [NroDocumento]    BIGINT       NULL,
    [RazonSocial]     VARCHAR (60) NULL,
    CONSTRAINT [PK_Clientes_X_TiposDocumento] PRIMARY KEY CLUSTERED ([IdCliente] ASC, [IdTipoDocumento] ASC)
);

