CREATE TABLE [seguridad].[Usuarios] (
    [Id]      INT          IDENTITY (1, 1) NOT NULL,
    [Usuario] VARCHAR (50) NOT NULL,
    [Nombre]  VARCHAR (50) NOT NULL,
    [Habilitado] BIT NOT NULL CONSTRAINT Usuarios_ActivoPredeterminado DEFAULT 1, 
    [FechaAlta] DATETIME NOT NULL CONSTRAINT Usuarios_FechaAltaPredeterminado DEFAULT GETDATE(), 
    [FechaBaja] DATETIME NULL,
    CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED ([Id] ASC)
);

