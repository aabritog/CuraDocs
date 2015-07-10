USE [Curaduria]
GO

IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PerfilMenu_Menu]') AND parent_object_id = OBJECT_ID(N'[dbo].[PerfilMenu]'))
ALTER TABLE [dbo].[PerfilMenu] DROP CONSTRAINT [FK_PerfilMenu_Menu]
GO

IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PerfilMenu_Perfil]') AND parent_object_id = OBJECT_ID(N'[dbo].[PerfilMenu]'))
ALTER TABLE [dbo].[PerfilMenu] DROP CONSTRAINT [FK_PerfilMenu_Perfil]
GO

IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_PerfilMenu_Estado]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[PerfilMenu] DROP CONSTRAINT [DF_PerfilMenu_Estado]
END

GO

USE [Curaduria]
GO

/****** Object:  Table [dbo].[PerfilMenu]    Script Date: 07/10/2015 09:45:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PerfilMenu]') AND type in (N'U'))
DROP TABLE [dbo].[PerfilMenu]
GO

USE [Curaduria]
GO

/****** Object:  Table [dbo].[PerfilMenu]    Script Date: 07/10/2015 09:45:50 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[PerfilMenu](
	[idPerfilMenu] [int] NOT NULL,
	[IdPerfil] [int] NOT NULL,
	[idMenu] [int] NOT NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK_PerfilMenu] PRIMARY KEY CLUSTERED 
(
	[idPerfilMenu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[PerfilMenu]  WITH CHECK ADD  CONSTRAINT [FK_PerfilMenu_Menu] FOREIGN KEY([idMenu])
REFERENCES [dbo].[Menu] ([IdMenu])
GO

ALTER TABLE [dbo].[PerfilMenu] CHECK CONSTRAINT [FK_PerfilMenu_Menu]
GO

ALTER TABLE [dbo].[PerfilMenu]  WITH CHECK ADD  CONSTRAINT [FK_PerfilMenu_Perfil] FOREIGN KEY([IdPerfil])
REFERENCES [dbo].[Perfil] ([IdPerfil])
GO

ALTER TABLE [dbo].[PerfilMenu] CHECK CONSTRAINT [FK_PerfilMenu_Perfil]
GO

ALTER TABLE [dbo].[PerfilMenu] ADD  CONSTRAINT [DF_PerfilMenu_Estado]  DEFAULT ((1)) FOR [Estado]
GO


