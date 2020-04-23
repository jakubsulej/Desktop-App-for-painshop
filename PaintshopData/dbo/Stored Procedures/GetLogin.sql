CREATE PROCEDURE [dbo].[GetLogin]
@User varchar(50)
AS
	SELECT * FROM dbo.PEOPLE Where User = @User;
RETURN 0
