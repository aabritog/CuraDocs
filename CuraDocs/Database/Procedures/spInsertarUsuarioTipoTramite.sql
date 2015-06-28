USE [Curaduria]
GO
/****** Object:  StoredProcedure [dbo].[spInsertarUsuarioTipoTramite]    Script Date: 06/26/2015 16:44:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*--------------------------------------------------------------------------------- */
/* Nombre    : spInsertarUsuarioTipoTramite                                         */
/* Objetivo  : Insertar un registro en la tabla UsuarioTipoTramite                  */
/* Parametros:  1- @sUsuario: Identificador del usuario                             */
/*              2- @nIdTipoTramite: Código del tipo de tramite		                */
/*    $Author: abrito$                                                              */
/*    $Date: 26/06/15 16:31$                                                        */
/*    $Revision: 1$                                                                 */
/*--------------------------------------------------------------------------------- */ 

ALTER PROCEDURE [dbo].[spInsertarUsuarioTipoTramite] 
	-- Add the parameters for the stored procedure here
	@sUsuario as varchar(50),
	@nIdTipoTramite as int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	INSERT INTO Usuario_TipoTramite
			   (sUsuario,
			    nIdTipoTramite,
			    dFecha,
			    nEstado)
		 VALUES
			   (@sUsuario,
			    @nIdTipoTramite,
			    GETDATE(),
			    1)
END

