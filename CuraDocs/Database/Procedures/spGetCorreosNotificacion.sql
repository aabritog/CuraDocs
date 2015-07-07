-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		ANTONY AGUILERA
-- Create date: 2015-07-05
-- Description:	TRAE LOS CORREOS A LOS CUALES SE VA ENVIAR CORREOS DE ACUERDO AL TIPO DE TRAMITE
-- =============================================
CREATE PROCEDURE spGetCorreosNotificacion
	@IdTipoTramite as int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    SELECT U.Correo FROM Usuarios U
	INNER JOIN Usuario_TipoTramite UT ON UT.sUsuario=U.Usuario 
	WHERE UT.nIdTipoTramite=@IdTipoTramite AND UT.nEstado=1
END
GO
