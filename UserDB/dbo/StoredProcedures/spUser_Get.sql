CREATE PROCEDURE [dbo].[spUser_Get]
	@id int
AS
BEGIN
	SELECT * FROM [dbo].[User] WHERE Id = @id
END
