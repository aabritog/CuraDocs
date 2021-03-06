USE [Curaduria]
GO
/****** Object:  StoredProcedure [dbo].[spGetTipoTramiteBySolicitud]    Script Date: 07/05/2015 18:29:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		ANTONY AGUILERA
-- Create date: 2015-07-05
-- Description:	TRAE EL ID Y EL TIPO DE TRAMITE DE LA SOLICITUD
-- =============================================
CREATE PROCEDURE [dbo].[spGetTipoTramiteBySolicitud]
	@IdSolicitud as int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SELECT S.IdTipoTramite,
		   TT.TipoTramite	
	FROM Solicitud S
	INNER JOIN TipoTramite TT ON TT.IdTipoTramite=S.IdTipoTramite
	WHERE S.IdSolicitud= @IdSolicitud AND TT.Estado=1
END
