USE [Curaduria]
GO
/****** Object:  StoredProcedure [dbo].[spGetOpcSistema]    Script Date: 07/10/2015 12:18:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spGetOpcSistema] 
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
SELECT nId, nNotificacionMail, sFromMail,
       sSubjectMail, sBodyMail, sUserNameCredentialsMail,
       sPasswordCredentialsMail, sHostMail, nPortMail,
       bEnableSsl, sCcMail
  FROM OpcSistema
  
END
