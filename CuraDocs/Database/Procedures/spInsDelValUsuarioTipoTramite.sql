USE [Curaduria]
GO
/****** Object:  StoredProcedure [dbo].[spInsDelValUsuarioTipoTramite]    Script Date: 07/02/2015 10:04:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*--------------------------------------------------------------------------------- */
/* Nombre    : spInsDelValUsuarioTipoTramite                                        */
/* Objetivo  : Valida e inserta un nuevo registro en la tabla UsuarioTipoTramite y  */
/*			   elimina un registro especifico segun la acción especificada.			*/
/* Parametros:  1- @sUsuario: Identificador del usuario                             */
/*              2- @nIdTipoTramite: Código del tipo de tramite		                */
/*              3- @nAccion: Código de la acción a ajecutar.		                */
/*                 1. Insertar. 2. Eliminar. 3. Validar.			                */
/*    $Author: abrito$                                                              */
/*    $Date: 26/06/15 16:31$                                                        */
/*    $Revision: 1$                                                                 */
/*--------------------------------------------------------------------------------- */ 

ALTER PROCEDURE [dbo].[spInsDelValUsuarioTipoTramite] 
	-- Add the parameters for the stored procedure here
	@sUsuario as varchar(50),
	@nIdTipoTramite as int,
	@nAction as int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements. aabg
	SET NOCOUNT ON;
	DECLARE @nResultado as int

/*Agrega un nuevo registro*/
IF @nAction = 1 
	BEGIN
		INSERT INTO Usuario_TipoTramite
				   (sUsuario,
				    nIdTipoTramite,
					dFecha,
					nEstado)
			VALUES (@sUsuario,
					@nIdTipoTramite,
					GETDATE(),
					1)
		SET @nResultado = 0;
		
		SELECT @nResultado AS nResult					
	END


/*Elimina un registro especifico*/
IF @nAction = 2
	BEGIN
		DELETE Usuario_TipoTramite
		 WHERE sUsuario = @sUsuario
		   AND nIdTipoTramite = @nIdTipoTramite		
		
		SET @nResultado = 0;
		
		SELECT @nResultado AS nResult
	END


/*Valida que no exista un registro con la misma PK*/
IF @nAction = 3
	BEGIN
		SELECT COUNT(*) nResult
		  FROM Usuario_TipoTramite UTT
	INNER JOIN TipoTramite TT
			ON UTT.nIdTipoTramite = TT.IdTipoTramite
		 WHERE UTT.sUsuario = @sUsuario
		   AND UTT.nIdTipoTramite = @nIdTipoTramite

	END
END

