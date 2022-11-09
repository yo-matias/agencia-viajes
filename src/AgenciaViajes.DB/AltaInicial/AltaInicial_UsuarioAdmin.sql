DECLARE @Id int;

SET @Id = 1;

SET IDENTITY_INSERT [seguridad].[Usuarios] ON;

INSERT INTO [seguridad].[Usuarios] ([Id],[Usuario],[Nombre])
	VALUES (@Id,'admin','Administrador');
INSERT INTO [seguridad].[Contraseñas] ([IdUsuario],[Contraseña],[FechaVencimiento])
	 VALUES (@Id, 'admin123', DATEADD(YEAR, 1, GETDATE()));

SET IDENTITY_INSERT [seguridad].[Usuarios] OFF;