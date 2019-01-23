﻿CREATE TABLE [dbo].[Users]
(
	[UserId] INT NOT NULL IDENTITY(1,1),
	[Nombre] VARCHAR(50) NOT NULL,
	[Apellido] VARCHAR(50) NOT NULL,
	[Email] VARCHAR(50) NOT NULL,
	[Password] VARCHAR(50) NOT NULL, 
    CONSTRAINT [PK_Users_UserId] PRIMARY KEY ([UserId])
)
