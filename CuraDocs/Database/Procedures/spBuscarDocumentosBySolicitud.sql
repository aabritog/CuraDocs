USE [Curaduria]
GO
/****** Object:  StoredProcedure [dbo].[spBuscarDocumentosBySolicitud]    Script Date: 06/30/2015 11:48:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		ANTONY AGUILERA
-- Create date: 2015-05-30
-- Description:	BUSCA LOS DOCUMENTOS POR NRO DE SOLICITUD
-- =============================================
ALTER PROCEDURE [dbo].[spBuscarDocumentosBySolicitud] 
	@idSolicitud int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SELECT DS.IdTipoDocumento,
		   TD.Documento,
		   DS.IdSolicitud,
		   DS.Ruta,
		   DS.IdDocumento,
		   DS.FechaCreacion,
		   DS.UsuarioCreacion 
	FROM DocumentoSolicitud DS
	INNER JOIN TipoDocumento TD ON TD.IdTipoDocumento=DS.IdTipoDocumento
	WHERE DS.IdSolicitud=@idSolicitud
END
