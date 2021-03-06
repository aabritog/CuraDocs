USE [Curaduria]
GO
/****** Object:  StoredProcedure [dbo].[spGetMenuPerfil]    Script Date: 06/30/2015 11:49:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		ANTONY AGUILERA
-- Create date: 2015-06-10
-- Description:	TRAE LOS MENU QUE PUEDE ENTRAR UN USUARIO DE ACUERDO A SU PERFIL
-- =============================================
ALTER PROCEDURE [dbo].[spGetMenuPerfil]
	@user as varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	SELECT M.Menu
			,M.NombreFormulario
	FROM Usuarios U
	INNER JOIN Perfil P ON P.IdPerfil=U.idPerfil
	INNER JOIN PerfilMenu PM ON PM.IdPerfil=P.IdPerfil
	INNER JOIN Menu M ON M.IdMenu=PM.idMenu
	WHERE U.Usuario=@user
END
