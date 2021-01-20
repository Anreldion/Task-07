CREATE TABLE [dbo].[Students]
(
	[Id] INT IDENTITY(1, 1) NOT NULL, 
    [Name] NVARCHAR(MAX) NOT NULL, 
    [Surname] NVARCHAR(MAX) NOT NULL,
    [MiddleName] NVARCHAR(MAX) NOT NULL,
    [GenderId] INT NOT NULL,
    [DateofBirth] DATETIME NOT NULL, 
    [GroupId] INT NOT NULL,
    [EducationFormId] INT NOT NULL
    

    CONSTRAINT [FK_GenderId] FOREIGN KEY ([GenderId]) REFERENCES [dbo].[Genders]([Id]), 
    CONSTRAINT [FK_GroupId] FOREIGN KEY ([GroupId]) REFERENCES [dbo].[Groups]([Id]), 
    CONSTRAINT [FK_EducationFormId] FOREIGN KEY ([EducationFormId]) REFERENCES [dbo].[EducationForms]([Id]), 
    CONSTRAINT [PK_Students] PRIMARY KEY ([Id])
)
