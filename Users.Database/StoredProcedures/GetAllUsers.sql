CREATE PROCEDURE [dbo].[GetAllUsers]
AS
BEGIN
	SELECT 
		U.UserId,
		U.Nombre,
		U.Apellido,
		U.Email,
		U.[Password]
	FROM Users U
END
