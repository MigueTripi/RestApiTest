﻿CREATE PROCEDURE [dbo].[CreateUser](
	@UserId INT,
	@Nombre VARCHAR(50),
	@Apellido VARCHAR(50),
	@Email VARCHAR(50),
	@Password VARCHAR(50)) 
AS
BEGIN
	DECLARE @Result INT = @UserId
	IF(ISNULL(@UserId, 0) = 0)
	BEGIN
		INSERT INTO Users ([Nombre], [Apellido], [Email], [Password])
		VALUES (@Nombre, @Apellido, @Email, @Password) 
		SET @Result = SCOPE_IDENTITY()
	END
	ELSE
	BEGIN
		UPDATE Users SET
			[Nombre] = @Nombre, 
			[Apellido] = @Apellido,
			[Email] = @Email, 
			[Password] = @Password
		WHERE [UserId] = @UserId
	END
	SELECT @UserId
END
