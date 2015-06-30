USE [Curaduria]
GO
/****** Object:  StoredProcedure [dbo].[spEditarUsuarios]    Script Date: 06/30/2015 11:49:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		ANTONY AGUILERA
-- Create date: 2015-06-08
-- Description:	EDITAR USUARIOS
-- =============================================
ALTER PROCEDURE [dbo].[spEditarUsuarios] 
	@user as varchar(50),
	@nombre as varchar(100),
	@idPerfil as int,
	@pass as varchar(20),
	@nt as varchar(50),
	@estado as bit
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

   UPDATE usuarios
   SET 
    NombreCompleto=@nombre,
    PassNormal=@pass,
    PassEncrypt= (SELECT SUBSTRING(master.dbo.fn_varbintohexstr(HASHBYTES('SHA1',@pass)),3,40)),
    idPerfil=@idPerfil,
    FechaCreacion=GETDATE(),
    UserCreacion=@nt,
    Estado=@estado
    WHERE Usuario = @user
END
