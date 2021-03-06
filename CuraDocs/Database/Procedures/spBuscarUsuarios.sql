USE [Curaduria]
GO
/****** Object:  StoredProcedure [dbo].[spBuscarUsuarios]    Script Date: 07/05/2015 15:41:19 ******/
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
	@sUsuario as varchar(50)=NULL  
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
		  ,U.Correo
	FROM Usuarios U
    INNER JOIN Perfil P ON P.IdPerfil = U.idPerfil
    WHERE U.Usuario = ISNULL(@sUsuario,U.Usuario)
      AND U.Estado=1
END
