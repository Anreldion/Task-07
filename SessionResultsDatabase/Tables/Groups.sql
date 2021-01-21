CREATE TABLE [dbo].[Groups]
(
	[Id] INT IDENTITY(1, 1) NOT NULL, 
    [Name] NVARCHAR(MAX) NOT NULL, 
    [SpecialtiesID] INT NOT NULL, 
    CONSTRAINT [PK_Groups] PRIMARY KEY ([Id]), 
    CONSTRAINT [FK_SpecialtyID] FOREIGN KEY ([SpecialtiesID]) REFERENCES [Specialties]([Id]),
)
