CREATE TABLE [seguridad].[Usuarios] (
    [Id]      INT          IDENTITY (1, 1) NOT NULL,
    [Usuario] VARCHAR (50) NOT NULL,
    [Nombre]  VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED ([Id] ASC)
);

