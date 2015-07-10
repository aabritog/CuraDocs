USE [Curaduria]
GO

/****** Object:  Table [dbo].[OpcSistema]    Script Date: 07/10/2015 11:05:07 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[OpcSistema]') AND type in (N'U'))
DROP TABLE [dbo].[OpcSistema]
GO

USE [Curaduria]
GO

/****** Object:  Table [dbo].[OpcSistema]    Script Date: 07/10/2015 11:05:07 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[OpcSistema](
	[nId] [int] NOT NULL,
	[nNotificacionMail] [int],
	[sFromMail] [varchar](100),
	[sCcMail] [varchar](100),	
	[sSubjectMail] [varchar](100),
	[sBodyMail] [varchar](1000),
	[sUserNameCredentialsMail] [varchar](100),
	[sPasswordCredentialsMail] [varchar](100),
	[sHostMail] [varchar](50),
	[nPortMail] [int],
	[bEnableSsl] [bit]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Opciones del sistema' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OpcSistema'
GO


