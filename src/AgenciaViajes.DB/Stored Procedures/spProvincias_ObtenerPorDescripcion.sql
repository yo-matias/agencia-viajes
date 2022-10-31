-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spProvincias_ObtenerPorDescripcion]
	@Descripcion varchar(60) = ''
AS
BEGIN
	SET NOCOUNT ON;

	SELECT [IdCiudad],[Descripcion],[IdProvincia] FROM [dbo].[Ciudades]
	WHERE [Descripcion] like '%' + @Descripcion + '%';
END
