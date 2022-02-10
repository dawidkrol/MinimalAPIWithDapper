CREATE PROCEDURE [dbo].[spUser_Update]
	@id int,
	@firstName varchar(50),
	@lastName varchar(50)
AS
BEGIN
	UPDATE [dbo].[User]
		set FirstName = @firstName, LastName = @lastName 
		WHERE Id = @id
END