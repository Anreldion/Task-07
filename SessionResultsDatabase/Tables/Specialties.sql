CREATE TABLE [dbo].[Specialties]
(
	[Id] INT IDENTITY(1, 1) NOT NULL, 
    [Name] NVARCHAR(MAX) NOT NULL, 
    CONSTRAINT [PK_Specialty] PRIMARY KEY ([Id])
)
