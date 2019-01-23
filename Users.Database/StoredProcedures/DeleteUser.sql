CREATE PROCEDURE [dbo].[DeleteUser]
	@UserId int 
AS
BEGIN
	DELETE FROM Users 
	WHERE UserId = @UserId
END