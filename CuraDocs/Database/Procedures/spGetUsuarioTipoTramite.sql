USE [Curaduria]
GO
/****** Object:  StoredProcedure [dbo].[spGetUsuarioTipoTramite]    Script Date: 06/30/2015 11:50:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*--------------------------------------------------------------------------------- */
/* Nombre    : spGetUsuarioTipoTramite						                        */
/* Objetivo  : Leer los registros de la tabla Usuario_TipoTramite para el usuario   */
/*			   especificado.														*/
/* Parametros:  1- @sUsuario: Identificador del usuario                             */
/*    $Author: abrito$                                                              */
/*    $Date: 29/06/15 16:31$                                                        */
/*    $Revision: 1$                                                                 */
/*--------------------------------------------------------------------------------- */ 
ALTER PROCEDURE [dbo].[spGetUsuarioTipoTramite]
	-- Add the parameters for the stored procedure here
	@sUsuario as varchar(50)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	SELECT UTT.sUsuario,
		   UTT.nIdTipoTramite,
		   TT.TipoTramite,
		   UTT.dFecha,
		   UTT.nEstado
	  FROM Usuario_TipoTramite UTT
INNER JOIN TipoTramite TT
        ON UTT.nIdTipoTramite = TT.IdTipoTramite
	 WHERE UTT.sUsuario = @sUsuario
  ORDER BY UTT.nIdTipoTramite ASC
	 
END
