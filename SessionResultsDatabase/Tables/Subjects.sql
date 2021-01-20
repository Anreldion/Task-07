CREATE TABLE [dbo].[Subjects]
(
	[Id] INT IDENTITY(1, 1) NOT NULL, 
    [Name] NVARCHAR(MAX) NOT NULL, 
    CONSTRAINT [PK_Subjects] PRIMARY KEY ([Id])
	
)
