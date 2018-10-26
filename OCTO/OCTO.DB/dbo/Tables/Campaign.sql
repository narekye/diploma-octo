CREATE TABLE [dbo].[Campaign]
(
	[Id]			INT				NOT NULL IDENTITY(1,1),
	[Name]			NVARCHAR(128)	NOT NULL,
	[Active]		BIT				NOT NULL,
	[BudgetedCost]	DECIMAL			NULL,
	[ActualCost]	DECIMAL			NULL,
	[TypeId]		INT				NOT NULL,
	[StatusId]		INT				NOT NULL,
	[StartDate]		DATETIME		NOT NULL,
	[EndDate]		DATETIME		NOT NULL,
	[Notes]			NVARCHAR(255)	NOT NULL,
	CONSTRAINT [PK_Campaign] PRIMARY KEY CLUSTERED ([Id] ASC)
)
