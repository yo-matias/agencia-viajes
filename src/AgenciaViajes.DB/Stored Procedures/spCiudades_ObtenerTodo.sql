-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spCiudades_ObtenerTodo]
AS
BEGIN
	SET NOCOUNT ON;

	SELECT [IdCiudad],[Descripcion],[IdProvincia] FROM [dbo].[Ciudades];
END
