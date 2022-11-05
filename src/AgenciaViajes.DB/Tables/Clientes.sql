CREATE TABLE [dbo].[Clientes] (
    [IdCliente]       INT          NOT NULL,
    [IdCiudad]        INT          NOT NULL,
    [Calle]           VARCHAR (60) NULL,
    [NroCalle]        INT          NULL,
    [Telefono]        BIGINT       NULL,
    [IdTipoCliente]   INT          NOT NULL,
    [NombreCliente]   VARCHAR (60) NULL,
    [ApellidoCliente] VARCHAR (60) NULL,
    [Nacionalidad]    VARCHAR (60) NULL,
    CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED ([IdCliente] ASC),
    CONSTRAINT [FK_Clientes_Ciudades] FOREIGN KEY ([IdCiudad]) REFERENCES [dbo].[Ciudades] ([IdCiudad]),
    CONSTRAINT [FK_Clientes_TiposCliente] FOREIGN KEY ([IdTipoCliente]) REFERENCES [dbo].[TiposCliente] ([IdTipoCliente])
);

