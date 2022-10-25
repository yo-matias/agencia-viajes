-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spNacionalidades_ObtenerPorId]
	@IdNacionalidad int = 0
AS
BEGIN
	SET NOCOUNT ON;

	SELECT [IdNacionalidad],[Descripcion],[IdPais] FROM [dbo].[Nacionalidades] WHERE [IdNacionalidad] = @IdNacionalidad;
END
