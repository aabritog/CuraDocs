USE [Curaduria]
GO
/****** Object:  StoredProcedure [dbo].[spBuscarSolicitud]    Script Date: 06/30/2015 11:48:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		ANTONY AGUILERA
-- Create date: 2015-05-16
-- Description:	BUSCA SI EXISTE LA SOLICITUD
-- =============================================
ALTER PROCEDURE [dbo].[spBuscarSolicitud] 
	@IdSolicitud int
AS
BEGIN
	DECLARE @resultado as int
	SET NOCOUNT ON;

    IF (NOT EXISTS(SELECT S.IdSolicitud FROM Solicitud S WHERE S.IdSolicitud=@IdSolicitud))
    BEGIN
		SET @resultado=0
    END
    ELSE
    BEGIN
		SET @resultado=1
    END
    
    SELECT @resultado AS RESULTADO
END
