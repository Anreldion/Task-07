CREATE TABLE [dbo].[Sessions]
(
	[Id] INT IDENTITY(1, 1) NOT NULL,
	[SessionPeriodId] INT NOT NULL,
    [DateFrom] DATETIME NOT NULL, 
    [DateTo] DATETIME NOT NULL, 
    CONSTRAINT [PK_Sessions] PRIMARY KEY ([Id]),

)
