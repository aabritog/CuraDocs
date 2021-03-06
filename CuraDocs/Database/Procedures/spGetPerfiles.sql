USE [Curaduria]
GO
/****** Object:  StoredProcedure [dbo].[spGetPerfiles]    Script Date: 06/30/2015 11:50:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		ANTONY AGUILERA
-- Create date: 2015-06-08
-- Description:	SELECCIONA LOS PERFILES QUE ESTEN ACTIVOS
-- =============================================
ALTER PROCEDURE [dbo].[spGetPerfiles]
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    SELECT P.IdPerfil,P.Perfil
    FROM Perfil P
    WHERE P.Estado=1
END
