CREATE TABLE [dbo].[Clientes] (
    [IdCliente]       INT          IDENTITY (1, 1) NOT NULL,
    [IdCiudad]        INT          NOT NULL,
    [Calle]           VARCHAR (60) NULL,
    [NroCalle]        INT          NULL,
    [Telefono]        BIGINT       NULL,
    [IdTipoCliente]   INT          NOT NULL,
    [RazónSocial]     VARCHAR (60) NULL,
    [NombreCliente]   VARCHAR (60) NULL,
    [ApellidoCliente] VARCHAR (60) NULL,
    [DocumentoTipoId] INT          NULL,
    [DocumentoNro]    VARCHAR (12) NULL,
    [CUIT]            VARCHAR (13) NULL,
    [NacionalidadId]  INT          NOT NULL,
    [Habilitado]      BIT          CONSTRAINT [Clientes_Default_Habilitado] DEFAULT ((1)) NOT NULL,
    [FechaAlta]       DATETIME     CONSTRAINT [Clientes_Default_FechaAlta] DEFAULT (getdate()) NOT NULL,
    [FechaBaja]       DATETIME     NULL,
    CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED ([IdCliente] ASC),
    CONSTRAINT [FK_Clientes_Ciudad] FOREIGN KEY ([IdCiudad]) REFERENCES [dbo].[Ciudades] ([IdCiudad]),
    CONSTRAINT [FK_Clientes_Nacionalidad] FOREIGN KEY ([NacionalidadId]) REFERENCES [dbo].[Paises] ([IdPais]),
    CONSTRAINT [FK_Clientes_Tipo] FOREIGN KEY ([IdTipoCliente]) REFERENCES [dbo].[TiposCliente] ([IdTipoCliente]),
    CONSTRAINT [FK_Clientes_TiposDocumento] FOREIGN KEY ([DocumentoTipoId]) REFERENCES [dbo].[TiposDocumento] ([IdTipoDocumento])
);





