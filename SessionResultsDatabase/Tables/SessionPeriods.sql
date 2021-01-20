CREATE TABLE [dbo].[SessionPeriods]
(
	[Id] INT IDENTITY(1, 1) NOT NULL, 
    [Name] NVARCHAR(MAX) NOT NULL, 
    CONSTRAINT [PK_SessionPeriods] PRIMARY KEY ([Id]),
)
