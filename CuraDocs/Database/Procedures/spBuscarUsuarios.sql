USE [Curaduria]
GO
/****** Object:  StoredProcedure [dbo].[spBuscarUsuarios]    Script Date: 06/29/2015 14:36:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		ANTONY AGUILERA
-- Create date: 2015-06-02
-- Description:	BUSCA TODOS LOS USUARIOS
-- =============================================
ALTER PROCEDURE [dbo].[spBuscarUsuarios] 
	@sUsuario as varchar(50)  
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SELECT U.Usuario AS Usuario
		  ,U.NombreCompleto AS [Nombre Completo]
		  ,P.Perfil AS Perfil
		  ,U.FechaCreacion AS [Fecha Creacion]
		  ,P.IdPerfil
	FROM Usuarios U
    INNER JOIN Perfil P ON P.IdPerfil = U.idPerfil
    WHERE U.Usuario = ISNULL(@sUsuario,U.Usuario)
      AND U.Estado=1
END
