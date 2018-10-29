CREATE TABLE [dbo].[Contact]
(
	[Id]			INT				NOT NULL IDENTITY(1,1),
	[SalutationId]	INT				NOT NULL,
	[AccountId]		INT				NOT NULL,
	[FirstName]		NVARCHAR(64)	NOT NULL,
	[MiddleName]	NVARCHAR(64)	NULL,
	[LastName]		NVARCHAR(64)	NOT NULL,
	[JobTitle]		VARCHAR(64)		NULL,
	[Department]	VARCHAR(64)		NULL,
	[Manager]		VARCHAR(64)		NULL,
	[Assistant]		VARCHAR(64)		NULL,
	[Phone]			VARCHAR(64)		NULL,
	[HomePhone]		VARCHAR(64)		NULL,
	[MobilePhone]	VARCHAR(64)		NULL,
	[Email]			VARCHAR(64)		NULL,
	[Notes]			VARCHAR(64)		NULL,
	[DecisionMaker] BIT				NOT NULL CONSTRAINT [DF_Contact_DecisionMaker] DEFAULT (0), 
	[Hold]			BIT				NOT NULL CONSTRAINT [DF_Contact_Hold]		   DEFAULT (0),
	[CountryId]		INT				NOT NULL,
	[City]			VARCHAR(64)		NOT NULL,

	CONSTRAINT [PK_Contact] PRIMARY KEY CLUSTERED ([Id] ASC),
	CONSTRAINT [FK_Contact_Salutation] FOREIGN KEY ([SalutationId]) REFERENCES [dbo].[Salutation]([Id]),
	CONSTRAINT [FK_Contact_City] FOREIGN KEY ([CountryId]) REFERENCES [dbo].[Country]([Id]),
	CONSTRAINT [FK_Contact_Account] FOREIGN KEY ([AccountId]) REFERENCES [dbo].[Account]([Id])
)

GO
CREATE NONCLUSTERED INDEX [IX_Contact_AccountId] ON [dbo].[Contact] ([AccountId] ASC) INCLUDE ([FirstName],[LastName], [Email])
Go
