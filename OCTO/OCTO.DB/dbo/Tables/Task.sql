CREATE TABLE [dbo].[Task]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[AllDay] BIT NULL,
	[PriorityId] INT NOT NULL,
	[TypeId] INT NOT NULL,
	[Description] VARCHAR(256) NULL
)
