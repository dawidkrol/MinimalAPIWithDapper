CREATE PROCEDURE [dbo].[spUser_Insert]
	@firstName varchar(50),
	@lastName varchar(50)
AS
BEGIN
	INSERT INTO [dbo].[User](FirstName,LastName)
		VALUES (@firstName,@lastName)
END
