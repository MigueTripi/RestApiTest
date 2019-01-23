CREATE PROCEDURE [dbo].[GetUser]
	@UserId int 
AS
BEGIN

	SELECT 
		U.UserId,
		U.Nombre,
		U.Apellido,
		U.Email,
		U.[Password]
	FROM Users U
	WHERE U.UserId = @UserId
END