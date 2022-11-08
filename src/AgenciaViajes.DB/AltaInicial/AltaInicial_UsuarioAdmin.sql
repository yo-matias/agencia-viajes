DECLARE @Id int;

INSERT INTO [seguridad].[Usuarios] ([Usuario],[Nombre])
	VALUES ('admin','Administrador');
	
SET @Id = SCOPE_IDENTITY();

INSERT INTO [seguridad].[Contraseñas] ([IdUsuario],[Contraseña],[FechaVencimiento])
	 VALUES (@Id, 'admin123', DATEADD(YEAR, 1, GETDATE()));

