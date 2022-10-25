CREATE TABLE [dbo].[Clientes] (
    [IdCliente]         INT           IDENTITY (1, 1) NOT NULL,
    [IdTipoCliente]     INT           NOT NULL,
    [Nombre]            VARCHAR (60)  NOT NULL,
    [Apellido]          VARCHAR (60)  NOT NULL,
    [IdNacionalidad]    INT           NOT NULL,
    [IdTipoDocumento]   INT           NOT NULL,
    [NroDocumento]      VARCHAR (15)  NOT NULL,
    [Calle]             VARCHAR (60)  NOT NULL,
    [Nro]               VARCHAR (10)  NOT NULL,
    [Piso]              VARCHAR (10)  NOT NULL,
    [Depto]             VARCHAR (10)  NOT NULL,
    [IdCiudad]          INT           NOT NULL,
    [Telefono]          VARCHAR (10)  NOT NULL,
    [FechaNacimiento]   DATE          NOT NULL,
    [CorreoElectronico] VARCHAR (120) NOT NULL,
    CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED ([IdCliente] ASC),
    CONSTRAINT [FK_Clientes_Ciudades] FOREIGN KEY ([IdCiudad]) REFERENCES [dbo].[Ciudades] ([IdCiudad]),
    CONSTRAINT [FK_Clientes_Nacionalidades] FOREIGN KEY ([IdNacionalidad]) REFERENCES [dbo].[Nacionalidades] ([IdNacionalidad]),
    CONSTRAINT [FK_Clientes_TiposDeClientes] FOREIGN KEY ([IdTipoCliente]) REFERENCES [dbo].[TiposDeClientes] ([IdTipoCliente]),
    CONSTRAINT [FK_Clientes_TiposDeDocumentos] FOREIGN KEY ([IdTipoDocumento]) REFERENCES [dbo].[TiposDeDocumentos] ([IdTipoDocumento])
);

