USE [Taller]
GO
/****** Object:  StoredProcedure [dbo].[GetClientes]    Script Date: 2020-05-12 2:41:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateUsuario]
	@usuario nvarchar(50),
	@ultimo varchar(50),
	@login int,
	@clave varchar(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE usuarios SET ultimo_login = @ultimo, n_logins=@login WHERE usuario = @usuario
	AND clave=@clave
END
