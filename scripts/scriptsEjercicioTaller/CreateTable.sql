USE [Taller]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[usuarios](
	[usuario] [varchar](20) NOT NULL,
	[clave] [varchar](20) NOT NULL,
	[n_logins] [int] NOT NULL,
	[ultimo_login] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

INSERT INTO usuarios VALUES('pfernandez','123456',0,'')
INSERT INTO usuarios VALUES('rbenitez','abcdef',0,'')
INSERT INTO usuarios VALUES('arodriguez','987654',0,'')


