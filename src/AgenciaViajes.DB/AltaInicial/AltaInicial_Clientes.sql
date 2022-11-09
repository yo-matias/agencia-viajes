SET IDENTITY_INSERT [dbo].[Clientes] ON;

INSERT INTO [dbo].[Clientes]
([IdCliente],[IdCiudad],[Calle],[NroCalle],[Telefono],[IdTipoCliente],[RazónSocial],[NombreCliente],[ApellidoCliente],[DocumentoTipoId],[DocumentoNro],[CUIT],[NacionalidadId],[Habilitado],[FechaAlta],[FechaBaja])
VALUES (1,1,'Calle 1', '111', '123456',1,null,'Nombre 1', 'Apellido 1', 1, '11222333', null, 1, 1, GETDATE(), null);

INSERT INTO [dbo].[Clientes]
([IdCliente],[IdCiudad],[Calle],[NroCalle],[Telefono],[IdTipoCliente],[RazónSocial],[NombreCliente],[ApellidoCliente],[DocumentoTipoId],[DocumentoNro],[CUIT],[NacionalidadId],[Habilitado],[FechaAlta],[FechaBaja])
VALUES (2,2,'Calle 2', '222', '654321',1,null,'Nombre 1', 'Apellido 1', 1, '11222333', null, 1, 1, GETDATE(), null);

INSERT INTO [dbo].[Clientes]
([IdCliente],[IdCiudad],[Calle],[NroCalle],[Telefono],[IdTipoCliente],[RazónSocial],[NombreCliente],[ApellidoCliente],[DocumentoTipoId],[DocumentoNro],[CUIT],[NacionalidadId],[Habilitado],[FechaAlta],[FechaBaja])
VALUES (3,3,'Calle 3', '333', '112233',1,null,'Nombre 1', 'Apellido 1', 1, '11222333', null, 1, 1, GETDATE(), null);

INSERT INTO [dbo].[Clientes]
([IdCliente],[IdCiudad],[Calle],[NroCalle],[Telefono],[IdTipoCliente],[RazónSocial],[NombreCliente],[ApellidoCliente],[DocumentoTipoId],[DocumentoNro],[CUIT],[NacionalidadId],[Habilitado],[FechaAlta],[FechaBaja])
VALUES (4,3,'Calle 4', '444', '332211',2,'Amoblamiento Pérez',null,null, null,null, '11222333', 1, 1, GETDATE(), null);

INSERT INTO [dbo].[Clientes]
([IdCliente],[IdCiudad],[Calle],[NroCalle],[Telefono],[IdTipoCliente],[RazónSocial],[NombreCliente],[ApellidoCliente],[DocumentoTipoId],[DocumentoNro],[CUIT],[NacionalidadId],[Habilitado],[FechaAlta],[FechaBaja])
VALUES (5,4,'Calle 5', '555', '778899',2,'El Coso',null,null, null,null, '11222333', 1, 1, GETDATE(), null);

INSERT INTO [dbo].[Clientes]
([IdCliente],[IdCiudad],[Calle],[NroCalle],[Telefono],[IdTipoCliente],[RazónSocial],[NombreCliente],[ApellidoCliente],[DocumentoTipoId],[DocumentoNro],[CUIT],[NacionalidadId],[Habilitado],[FechaAlta],[FechaBaja])
VALUES (6,5,'Calle 6', '666', '995511',2,'La Chiquitita',null,null, null,null, '11222333', 1, 1, GETDATE(), null);

SET IDENTITY_INSERT [dbo].[Clientes] OFF;