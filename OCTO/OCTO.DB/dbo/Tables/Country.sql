﻿CREATE TABLE [dbo].[Country]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[Name] VARCHAR(64) NOT NULL

	CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED ([Id])
)
