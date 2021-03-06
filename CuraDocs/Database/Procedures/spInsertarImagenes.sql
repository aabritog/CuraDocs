USE [Curaduria]
GO
/****** Object:  StoredProcedure [dbo].[spInsertarImagenes]    Script Date: 06/30/2015 11:54:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		ANTONY AGUILERA
-- Create date: 2015-05-19
-- Description:	INSERTA LAS IMAGENES
-- =============================================
ALTER PROCEDURE [dbo].[spInsertarImagenes] 
	@nroSolicitud as int,
	@ruta as varchar(1000),
	@idTipoDocumento as int,
	@user as varchar(50)
AS
BEGIN
	DECLARE @resul as varchar(1)='0'
	SET NOCOUNT ON;
	
	INSERT INTO DocumentoSolicitud
	(
	IdSolicitud,
	IdTipoDocumento,
	Ruta,
	FechaCreacion,
	UsuarioCreacion
	)
	Values
	(
	@nroSolicitud,
	@idTipoDocumento,
	@ruta,
	GETDATE(),
	@user
	)
	
	IF @@ROWCOUNT>0
		SET @resul=1
	
	SELECT @resul AS resultado
END
