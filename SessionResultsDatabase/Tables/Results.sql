CREATE TABLE [dbo].[Results]
(
	[Id] INT IDENTITY(1, 1) NOT NULL, 
    [SessionId] INT NOT NULL, 
    [SubjectId] INT NOT NULL, 
    [StudentId] INT NOT NULL, 
    [Mark] INT NOT NULL,

    CONSTRAINT [FK_SessionId] FOREIGN KEY ([SessionId]) REFERENCES [dbo].[Sessions]([Id]),
    CONSTRAINT [FK_SubjectId] FOREIGN KEY ([SubjectId]) REFERENCES [dbo].[Subjects]([Id]),
    CONSTRAINT [FK_StudentId] FOREIGN KEY ([StudentId]) REFERENCES [dbo].[Students]([Id]), 
    CONSTRAINT [PK_Results] PRIMARY KEY ([Id]),
)
