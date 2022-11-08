/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

begin
    :r .\AltaInicial_FormasDePago.sql
    :r .\AltaInicial_Localidades.sql
    :r .\AltaInicial_TiposDeClientes.sql
    :r .\AltaInicial_TiposDeDocumento.sql
    :r .\AltaInicial_UsuarioAdmin.sql
end