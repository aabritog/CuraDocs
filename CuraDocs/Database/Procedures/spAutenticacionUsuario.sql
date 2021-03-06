USE [Curaduria]
GO
/****** Object:  StoredProcedure [dbo].[spAutenticacionUsuario]    Script Date: 06/30/2015 11:48:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		ANTONY AGUILERA
-- Create date: 2015-06-10
-- Description:	VALIDA INGRESO USUARIOS
-- =============================================
ALTER PROCEDURE [dbo].[spAutenticacionUsuario]
	@user as varchar(50),
	@pass as varchar(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	

    DECLARE @resul as int=0
    
    SELECT U.Usuario
		  ,P.Perfil
	FROM Usuarios U 
	INNER JOIN Perfil P ON P.IdPerfil= U.idPerfil
    WHERE U.Usuario=@user 
    AND U.PassEncrypt= (SELECT SUBSTRING(master.dbo.fn_varbintohexstr(HASHBYTES('SHA1',@pass)),3,40))
    AND U.Estado=1
    
    IF @@ROWCOUNT>0
		SET @resul=1
		
	SELECT @resul AS RESULTADO
END
