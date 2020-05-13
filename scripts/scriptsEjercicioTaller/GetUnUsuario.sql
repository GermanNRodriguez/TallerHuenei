USE [Taller]
GO
/****** Object:  StoredProcedure [dbo].[GetUsuarios]    Script Date: 2020-05-12 4:16:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetUnUsuarios]
(
	@usuario nvarchar(50)
)
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM usuarios WHERE usuario=@usuario
END
