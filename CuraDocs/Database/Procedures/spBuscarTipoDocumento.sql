USE [Curaduria]
GO
/****** Object:  StoredProcedure [dbo].[spBuscarTipoDocumento]    Script Date: 06/30/2015 11:48:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		ANTONY AGUILERA
-- Create date: 2015-05-17
-- Description:	BUSCA TODOS LOS TIPOS DE DOCUMENTO
-- =============================================
ALTER PROCEDURE [dbo].[spBuscarTipoDocumento] 
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SELECT TD.IdTipoDocumento AS id
		,TD.Documento AS documento
	FROM TipoDocumento TD
	WHERE TD.Estado=1
END
