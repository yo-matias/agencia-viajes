-- =============================================
-- Author:		Matías F
-- Create date: 06/11/2022
-- Description:	Elimina todos los registros de todas las tablas
-- =============================================
CREATE PROCEDURE spLimpiarTodasLasTablas
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	-- disable all constraints
	EXEC sp_MSforeachtable "ALTER TABLE ? NOCHECK CONSTRAINT all"

	-- delete data in all tables
	EXEC sp_MSforeachtable "DELETE FROM ?"

	-- reseeds identity fields
	EXEC sp_MSforeachtable "DBCC CHECKIDENT ( '?', RESEED, 0)"

	-- enable all constraints
	exec sp_MSforeachtable "ALTER TABLE ? WITH CHECK CHECK CONSTRAINT all"
END