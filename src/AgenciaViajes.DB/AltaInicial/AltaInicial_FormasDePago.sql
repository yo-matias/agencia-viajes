SET IDENTITY_INSERT [dbo].[FormasDePago] ON;

INSERT INTO [dbo].[FormasDePago] ([IdFormaPago],[DescripcionFormaPago]) VALUES (1,'Efectivo');
INSERT INTO [dbo].[FormasDePago] ([IdFormaPago],[DescripcionFormaPago]) VALUES (2,'Tarjeta de Crédito');
INSERT INTO [dbo].[FormasDePago] ([IdFormaPago],[DescripcionFormaPago]) VALUES (3,'Tarjeta de Débito');

SET IDENTITY_INSERT [dbo].[FormasDePago] OFF;