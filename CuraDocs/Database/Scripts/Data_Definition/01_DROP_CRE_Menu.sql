USE [Curaduria]
GO

IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Menu_Estado]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Menu] DROP CONSTRAINT [DF_Menu_Estado]
END

GO

USE [Curaduria]
GO

/****** Object:  Table [dbo].[Menu]    Script Date: 07/10/2015 10:06:42 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Menu]') AND type in (N'U'))
DROP TABLE [dbo].[Menu]
GO

USE [Curaduria]
GO

/****** Object:  Table [dbo].[Menu]    Script Date: 07/10/2015 10:06:42 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Menu](
	[IdMenu] [int] NOT NULL,
	[Menu] [varchar](50) NOT NULL,
	[NombreFormulario] [varchar](50) NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[UserCreacion] [varchar](50) NOT NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK_Menu] PRIMARY KEY CLUSTERED 
(
	[IdMenu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Menu] ADD  CONSTRAINT [DF_Menu_Estado]  DEFAULT ((1)) FOR [Estado]
GO


