-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spCiudades_ObtenerPorCriterio]
	@IdCiudad int = null,
	@DescripcionCiudad varchar(120) = null,
	@IdProvincia int = null,
	@DescripcionProvincia varchar(120) = null,
	@IdPais int = null,
	@DescripcionPais varchar(120) = null
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT
		ciudad.[IdCiudad] as IdCiudad,
		ciudad.[Descripcion] as DescripcionCiudad,
		provincia.[IdProvincia] as IdProvincia,
		provincia.[Descripcion] as DescripcionProvincia,
		pais.[IdPais] as IdPais,
		pais.[Descripcion] as DescripcionPais
	FROM [dbo].[Ciudades] ciudad
	LEFT JOIN [dbo].[Provincias] provincia on ciudad.IdProvincia = provincia.IdProvincia
	LEFT JOIN [dbo].[Paises] pais ON provincia.IdPais = pais.IdPais
	WHERE (1 = 1)
	-- Ids
	and ( ciudad.[IdCiudad] = @IdCiudad OR (@IdCiudad is null or @IdCiudad = 0) )
	and ( provincia.[IdProvincia] = @IdProvincia OR (@IdProvincia is null or @IdProvincia = 0) )
	and ( pais.[IdPais] = @IdPais OR (@IdPais is null or @IdPais = 0) )
	-- Descripciones
	and ( ciudad.[Descripcion] like CONCAT('%',@DescripcionCiudad,'%') OR Coalesce(@DescripcionCiudad,'') = '' )
	and ( provincia.[Descripcion] like CONCAT('%',@DescripcionProvincia,'%') OR Coalesce(@DescripcionProvincia,'') = '' )
	and ( pais.[Descripcion] like CONCAT('%',@DescripcionPais,'%') OR Coalesce(@DescripcionPais,'') = '' )
END
