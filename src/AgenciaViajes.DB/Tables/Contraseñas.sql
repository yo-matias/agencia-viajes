CREATE TABLE [seguridad].[Contraseñas] (
    [Id]               INT        IDENTITY (1, 1)   NOT NULL,
    [IdUsuario]        INT           NOT NULL,
    [Contraseña]       VARCHAR (256) NOT NULL,
    [FechaVencimiento] DATETIME      NOT NULL,
    CONSTRAINT [PK_Contraseñas] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Contraseñas_Usuarios] FOREIGN KEY ([IdUsuario]) REFERENCES [seguridad].[Usuarios] ([Id])
);

