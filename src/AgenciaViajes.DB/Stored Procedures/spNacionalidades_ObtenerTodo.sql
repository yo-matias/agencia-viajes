-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spNacionalidades_ObtenerTodo]
AS
BEGIN
	SET NOCOUNT ON;

	SELECT [IdNacionalidad],[Descripcion],[IdPais] FROM [dbo].[Nacionalidades]
END
