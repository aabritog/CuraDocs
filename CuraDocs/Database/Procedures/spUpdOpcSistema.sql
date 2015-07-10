USE [Curaduria]
GO
/****** Object:  StoredProcedure [dbo].[spUpdOpcSistema]    Script Date: 07/10/2015 12:17:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*--------------------------------------------------------------------------------- */
/* Nombre    : spUpdOpcSistema				                                        */
/* Objetivo  : Modificar las opciones de configuración del sistema CuraDocs         */
/*    $Author: abrito$                                                              */
/*    $Date: 09/07/15 15:10$                                                        */
/*    $Revision: 1$                                                                 */
/*--------------------------------------------------------------------------------- */ 
CREATE PROCEDURE [dbo].[spUpdOpcSistema] 
	@nNotificacionMail as int 
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	UPDATE OpcSistema 
	   SET nNotificacionMail = @nNotificacionMail

END
