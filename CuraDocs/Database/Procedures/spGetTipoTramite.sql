USE [Curaduria]
GO
/****** Object:  StoredProcedure [dbo].[spGetTipoTramite]    Script Date: 06/30/2015 11:50:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*--------------------------------------------------------------------------------- */
/* Nombre    : spGetTipoTramite				                                        */
/* Objetivo  : Leer los datos de la tabla TipoTramite			                    */
/*    $Author: abrito$                                                              */
/*    $Date: 29/06/15 11:33$                                                        */
/*    $Revision: 1$                                                                 */
/*--------------------------------------------------------------------------------- */ 
ALTER PROCEDURE [dbo].[spGetTipoTramite]

AS

BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT TT.IdTipoTramite,
		   TT.TipoTramite,
		   TT.Estado
	  FROM TipoTramite TT
	 WHERE TT.Estado = 1
 
END
