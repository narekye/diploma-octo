﻿CREATE TABLE [dbo].[Account]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[Name] VARCHAR(64) NOT NULL,
	[AddressLine] VARCHAR(64) NULL,
	[CountryId] INT NOT NULL,
	[Zip] VARCHAR(16) NULL,
	[Phone] VARCHAR(64) NULL,
	[Site] VARCHAR(128) NULL,
	[CampaignId] INT NULL,
	[Notes] VARCHAR(255) NULL,

	CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED ([Id] ASC),
	CONSTRAINT [FK_Account_Country] FOREIGN KEY ([CountryId]) REFERENCES [dbo].[Country]([Id]),
	CONSTRAINT [FK_Account_Campaign] FOREIGN KEY ([CampaignId]) REFERENCES [dbo].[Campaign]([Id])
)

GO
CREATE UNIQUE INDEX [IX_Account_Name] ON [dbo].[Account]([Name])
GO

CREATE NONCLUSTERED INDEX [IX_Account_Campaign] ON [dbo].[Account] ([CampaignId] ASC)
GO
