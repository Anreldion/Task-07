﻿CREATE TABLE [dbo].[Groups]
(
	[Id] INT IDENTITY(1, 1) NOT NULL, 
    [Name] NVARCHAR(MAX) NOT NULL, 
    CONSTRAINT [PK_Groups] PRIMARY KEY ([Id]),
)
