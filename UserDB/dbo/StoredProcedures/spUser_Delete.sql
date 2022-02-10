CREATE PROCEDURE [dbo].[spUser_Delete]
	@id int
AS
BEGIN
	DELETE FROM [dbo].[User] where Id = @id
END
