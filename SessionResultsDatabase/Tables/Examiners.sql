CREATE TABLE [dbo].[Examiners]
(
	[Id] INT NOT NULL IDENTITY(1, 1), 
    [Name] NVARCHAR(MAX) NOT NULL, 
    [Surname] NVARCHAR(MAX) NOT NULL, 
    [MiddleName] NVARCHAR(MAX) NOT NULL, 
    CONSTRAINT [PK_Examiners] PRIMARY KEY ([Id])
)
