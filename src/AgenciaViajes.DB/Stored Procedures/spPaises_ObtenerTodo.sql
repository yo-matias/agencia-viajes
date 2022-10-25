-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE dbo.[spPaises_ObtenerTodo]
AS
BEGIN
	SET NOCOUNT ON;

	SELECT [IdPais],[Descripcion] FROM [dbo].[Paises];
END
