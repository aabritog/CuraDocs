USE [Curaduria]
GO

/****** Object:  Table [dbo].[Usuario_TipoTramite]    Script Date: 06/27/2015 23:43:57 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Usuario_TipoTramite](
	[sUsuario] [varchar](50) NOT NULL,
	[nIdTipoTramite] [int] NOT NULL,
	[dFecha] [datetime] NOT NULL,
	[nEstado] [int] NOT NULL,
 CONSTRAINT [PK_Usuario_TipoTramite_1] PRIMARY KEY CLUSTERED 
(
	[sUsuario] ASC,
	[nIdTipoTramite] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Usuario_TipoTramite]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_TipoTramite_TipoTramite] FOREIGN KEY([nIdTipoTramite])
REFERENCES [dbo].[TipoTramite] ([IdTipoTramite])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Usuario_TipoTramite] CHECK CONSTRAINT [FK_Usuario_TipoTramite_TipoTramite]
GO

ALTER TABLE [dbo].[Usuario_TipoTramite]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_TipoTramite_Usuario_Usuario] FOREIGN KEY([sUsuario])
REFERENCES [dbo].[Usuarios] ([Usuario])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Usuario_TipoTramite] CHECK CONSTRAINT [FK_Usuario_TipoTramite_Usuario_Usuario]
GO

