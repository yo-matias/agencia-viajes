-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE dbo.[spProvincias_ObtenerTodo]
AS
BEGIN
	SET NOCOUNT ON;

	SELECT [IdProvincia],[Descripcion],[IdPais] FROM [dbo].[Provincias];
END
