CREATE TABLE [dbo].[Schedules]
(
	[Id] INT IDENTITY(1, 1) NOT NULL, 
    [Date] DATETIME NOT NULL,
    [SubjectId] INT NOT NULL,
    [SessionId] INT NOT NULL, 
    [GroupId] INT NOT NULL, 
    [TestFormId] INT NOT NULL,
    
    [ExaminerID] INT NOT NULL, 
    CONSTRAINT [FK.Schedules.SubjectId] FOREIGN KEY ([SubjectId]) REFERENCES [dbo].[Subjects]([Id]),
    CONSTRAINT [FK.Schedules.GroupId] FOREIGN KEY ([GroupId]) REFERENCES [dbo].[Groups]([Id]), 
    CONSTRAINT [FK.Schedules.TestFormId] FOREIGN KEY ([TestFormId]) REFERENCES [dbo].[TestForms]([Id]), 
    CONSTRAINT [FK.Schedules.SessionId] FOREIGN KEY ([SessionId]) REFERENCES [dbo].[Sessions]([Id]), 
    CONSTRAINT [PK_Schedules] PRIMARY KEY ([Id]), 
    CONSTRAINT [FK.Schedules.ExaminerID] FOREIGN KEY ([ExaminerID]) REFERENCES [Examiners]([Id]), 



)
