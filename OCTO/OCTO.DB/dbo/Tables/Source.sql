﻿CREATE TABLE [dbo].[Source]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[Name] VARCHAR(64) NOT NULL,

	CONSTRAINT [PK_Source] PRIMARY KEY CLUSTERED ([Id] DESC)
)
