USE [Curaduria]
GO
/****** Object:  StoredProcedure [dbo].[spGuardarUsuario]    Script Date: 06/30/2015 11:53:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		ANTONY AGUILERA
-- Create date: 2015-06-08
-- Description:	Guarda Usuarios
-- =============================================
ALTER PROCEDURE [dbo].[spGuardarUsuario] 
	-- Add the parameters for the stored procedure here
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

    INSERT INTO Usuarios
    (
    Usuario,
    NombreCompleto,
    PassNormal,
    PassEncrypt,
    idPerfil,
    FechaCreacion,
    UserCreacion,
    Estado
    )
    VALUES
    (
    @user,
    @nombre,
    @pass,
    (SELECT SUBSTRING(master.dbo.fn_varbintohexstr(HASHBYTES('SHA1',@pass)),3,40) AS SHA1),
    @idPerfil,
    GETDATE(),
    @nt,
    1
    )
END
