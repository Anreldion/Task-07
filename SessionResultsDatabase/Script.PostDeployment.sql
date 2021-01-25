INSERT INTO [dbo].[Genders] ([Name]) VALUES  ('Man') 
GO
INSERT INTO [dbo].[Genders] ([Name]) VALUES  ('Woman') 
GO

INSERT INTO [dbo].[EducationForms] ([Name]) VALUES  ('Daytime') 
GO
INSERT INTO [dbo].[EducationForms] ([Name]) VALUES  ('Extramural') 
GO

INSERT INTO [dbo].[Specialties] ([Name]) VALUES  ('Electronic engineer') 
GO
INSERT INTO [dbo].[Specialties] ([Name]) VALUES  ('Building engineer') 
GO
INSERT INTO [dbo].[Specialties] ([Name]) VALUES  ('Economist') 
GO


INSERT INTO [dbo].[Groups] ([Name],[SpecialtiesID]) VALUES  ('PE',1) 
GO
INSERT INTO [dbo].[Groups] ([Name],[SpecialtiesID]) VALUES  ('PGS',2) 
GO
INSERT INTO [dbo].[Groups] ([Name],[SpecialtiesID]) VALUES  ('E',3) 
GO

INSERT INTO [dbo].[Subjects] ([Name]) VALUES  ('Math') 
GO
INSERT INTO [dbo].[Subjects] ([Name]) VALUES  ('Physics') 
GO
INSERT INTO [dbo].[Subjects] ([Name]) VALUES  ('Economy') 
GO
INSERT INTO [dbo].[Subjects] ([Name]) VALUES  ('Computer networks') 
GO
INSERT INTO [dbo].[Subjects] ([Name]) VALUES  ('Information Technology') 
GO
INSERT INTO [dbo].[Subjects] ([Name]) VALUES  ('Database') 
GO

INSERT INTO [dbo].[TestForms] ([Name]) VALUES  ('Exam')
GO
INSERT INTO [dbo].[TestForms] ([Name]) VALUES  ('Offset') 
GO

INSERT INTO [dbo].[SessionPeriods] ([Name]) VALUES  ('Winter') 
GO
INSERT INTO [dbo].[SessionPeriods] ([Name]) VALUES  ('Spring') 
GO
INSERT INTO [dbo].[SessionPeriods] ([Name]) VALUES  ('Summer') 
GO
INSERT INTO [dbo].[SessionPeriods] ([Name]) VALUES  ('Autumn') 
GO

INSERT INTO [dbo].[Sessions] ([SessionPeriodId],[DateFrom],[DateTo]) VALUES  (1, '2020-1-12', '2020-28-12') 
GO
INSERT INTO [dbo].[Sessions] ([SessionPeriodId],[DateFrom],[DateTo]) VALUES  (3, '2021-1-5', '2021-1-6') 
GO
INSERT INTO [dbo].[Sessions] ([SessionPeriodId],[DateFrom],[DateTo]) VALUES  (1, '2021-1-12', '2021-28-12') 
GO
INSERT INTO [dbo].[Sessions] ([SessionPeriodId],[DateFrom],[DateTo]) VALUES  (3, '2022-1-5', '2022-1-6') 
GO
INSERT INTO [dbo].[Sessions] ([SessionPeriodId],[DateFrom],[DateTo]) VALUES  (1, '2022-1-12', '2022-28-12') 
GO
INSERT INTO [dbo].[Sessions] ([SessionPeriodId],[DateFrom],[DateTo]) VALUES  (3, '2023-1-5', '2023-1-6') 
GO

INSERT INTO [dbo]. [Examiners] ([Surname], [Name], [MiddleName]) VALUES ('Borisov', 'Alexander', 'Alexandrovich')
GO
INSERT INTO [dbo]. [Examiners] ([Surname], [Name], [MiddleName]) VALUES ('Krasnova', 'Angelina', 'Romanovna')
GO
INSERT INTO [dbo]. [Examiners] ([Surname], [Name], [MiddleName]) VALUES ('Mayorov', 'Nikolay', 'Daniilovich')
GO
INSERT INTO [dbo]. [Examiners] ([Surname], [Name], [MiddleName]) VALUES ('Makarov', 'Artyom', 'Demidovich')
GO
INSERT INTO [dbo]. [Examiners] ([Surname], [Name], [MiddleName]) VALUES ('Ponomareva', 'Alisa', 'Semyonovna')
GO
INSERT INTO [dbo]. [Examiners] ([Surname], [Name], [MiddleName]) VALUES ('Kharitonova', 'Vera', 'Dmitrievna')
GO
--1
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2020-1-12', 1, 1, 1, 1,1) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2020-5-12', 2, 1, 1, 2,2) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2020-10-12', 3, 1, 1, 1,3) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2020-15-12', 4, 1, 1, 2,4) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2020-20-12', 5, 1, 1, 1,5) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2020-25-12', 6, 1, 1, 2,6) 
GO

INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2020-1-12', 1, 1, 2, 1,1) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2020-5-12', 2, 1, 2, 2,2) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2020-10-12', 3, 1, 2, 1,3) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2020-15-12', 4, 1, 2, 2,4) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2020-20-12', 5, 1, 2, 1,5) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2020-25-12', 6, 1, 2, 2,6) 
GO
--2
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2021-1-5', 1, 2, 1, 1,1) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2021-5-5', 2, 2, 1, 2,2) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2021-10-5', 3, 2, 1, 1,3) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2021-15-5', 4, 2, 1, 2,4) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2021-20-5', 5, 2, 1, 1,5) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2021-25-5', 6, 2, 1, 2,6) 
GO

INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2021-1-5', 1, 2, 2, 1,1) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2021-5-5', 2, 2, 2, 2,2) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2021-10-5', 3, 2, 2, 1,3) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2021-15-5', 4, 2, 2, 2,4) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2021-20-5', 5, 2, 2, 1,5) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2021-25-5', 6, 2, 2, 2,6) 
GO
--3
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2021-1-12', 1, 3, 1, 1,1) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2021-5-12', 2, 3, 1, 2,2) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2021-10-12', 3, 3, 1, 1,3) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2021-15-12', 4, 3, 1, 2,4) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2021-20-12', 5, 3, 1, 1,5) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2021-25-12', 6, 3, 1, 2,6) 
GO

INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2021-1-12', 1, 3, 2, 1,1) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2021-5-12', 2, 3, 2, 2,2) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2021-10-12', 3, 3, 2, 1,3) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2021-15-12', 4, 3, 2, 2,4) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2021-20-12', 5, 3, 2, 1,5) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2021-25-12', 6, 3, 2, 2,6) 
GO
--4
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2022-1-5', 1, 4, 1, 1,1) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2022-5-5', 2, 4, 1, 2,2) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2022-10-5', 3, 4, 1, 1,3) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2022-15-5', 4, 4, 1, 2,4) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2022-20-5', 5, 4, 1, 1,5) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2022-25-5', 6, 4, 1, 2,6) 
GO

INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2022-1-5', 1, 4, 2, 1,1) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2022-5-5', 2, 4, 2, 2,2) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2022-10-5', 3, 4, 2, 1,3) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2022-15-5', 4, 4, 2, 2,4) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2022-20-5', 5, 4, 2, 1,5) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2022-25-5', 6, 4, 2, 2,6) 
GO
--5
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2022-1-12', 1, 5, 1, 1,1) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2022-5-12', 2, 5, 1, 2,2) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2022-10-12', 3, 5, 1, 1,3) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2022-15-12', 4, 5, 1, 2,4) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2022-20-12', 5, 5, 1, 1,5) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2022-25-12', 6, 5, 1, 2,6) 
GO

INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2022-1-12', 1, 5, 2, 1,1) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2022-5-12', 2, 5, 2, 2,2) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2022-10-12', 3, 5, 2, 1,3) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2022-15-12', 4, 5, 2, 2,4) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2022-20-12', 5, 5, 2, 1,5) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2022-25-12', 6, 5, 2, 2,6) 
GO
--6
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2023-1-5', 1, 6, 1, 1,1) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2023-5-5', 2, 6, 1, 2,2) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2023-10-5', 3, 6, 1, 1,3) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2023-15-5', 4, 6, 1, 2,4) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2023-20-5', 5, 6, 1, 1,5) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2023-25-5', 6, 6, 1, 2,6) 
GO

INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2023-1-5', 1, 6, 2, 1,1) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2023-5-5', 2, 6, 2, 2,2) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2023-10-5', 3, 6, 2, 1,3) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2023-15-5', 4, 6, 2, 2,4) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2023-20-5', 5, 6, 2, 1,5) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2023-25-5', 6, 6, 2, 2,6) 
GO
--
INSERT INTO [dbo]. [Students] ([Name], [Surname], [MiddleName], [GenderId], [DateofBirth], [GroupId], [EducationFormId]) VALUES ('Yuri', 'Belozerov', 'Aleksandrovich ', 1,' 2000-1-1 ', 1, 1)
GO
INSERT INTO [dbo]. [Students] ([Name], [Surname], [MiddleName], [GenderId], [DateofBirth], [GroupId], [EducationFormId]) VALUES ('Timofey', 'Nikolaev', 'Vitalievich ', 1,' 2000-1-7 ', 1, 1)
GO
INSERT INTO [dbo]. [Students] ([Name], [Surname], [MiddleName], [GenderId], [DateofBirth], [GroupId], [EducationFormId]) VALUES ('Savely', 'Nikitin', 'Davidovich ', 1,' 2000-1-4 ', 1, 1)
GO
INSERT INTO [dbo]. [Students] ([Name], [Surname], [MiddleName], [GenderId], [DateofBirth], [GroupId], [EducationFormId]) VALUES ('Egor', 'Emelyanov', 'Fedotovich ', 1,' 2000-1-6 ', 1, 1)
GO
INSERT INTO [dbo]. [Students] ([Name], [Surname], [MiddleName], [GenderId], [DateofBirth], [GroupId], [EducationFormId]) VALUES ('Ermolai', 'Belozerov', 'Rostislavovich ', 1,' 2000-1-10 ', 1, 1)
GO
INSERT INTO [dbo]. [Students] ([Name], [Surname], [MiddleName], [GenderId], [DateofBirth], [GroupId], [EducationFormId]) VALUES ('Vladlen', 'Lukin', 'Rostislavovich ', 1,' 2000-2-12 ', 1, 1)
GO
INSERT INTO [dbo]. [Students] ([Name], [Surname], [MiddleName], [GenderId], [DateofBirth], [GroupId], [EducationFormId]) VALUES ('Rosalina', 'Karpova', 'Protasyevna ', 2,' 2001-1-1 ', 1, 1)
GO
INSERT INTO [dbo]. [Students] ([Name], [Surname], [MiddleName], [GenderId], [DateofBirth], [GroupId], [EducationFormId]) VALUES ('Kharitina', 'Gorbunova', 'Fedorovna ', 2,' 2001-1-4 ', 1, 1)
GO
INSERT INTO [dbo]. [Students] ([Name], [Surname], [MiddleName], [GenderId], [DateofBirth], [GroupId], [EducationFormId]) VALUES ('Genevieve', 'Romanova', 'Petrovna ', 2,' 2001-1-7 ', 1, 1)
GO
INSERT INTO [dbo]. [Students] ([Name], [Surname], [MiddleName], [GenderId], [DateofBirth], [GroupId], [EducationFormId]) VALUES ('Fiya', 'Noskova', 'Sergeevna ', 2,' 2001-1-10 ', 1, 1)
GO

INSERT INTO [dbo]. [Students] ([Name], [Surname], [MiddleName], [GenderId], [DateofBirth], [GroupId], [EducationFormId]) VALUES ('Gerasim', 'Mukhin', 'Arsenievich ', 1,' 2000-1-2 ', 2, 1)
GO
INSERT INTO [dbo]. [Students] ([Name], [Surname], [MiddleName], [GenderId], [DateofBirth], [GroupId], [EducationFormId]) VALUES ('Alexey', 'Maksimov', 'Iosifovich ', 1,' 2000-1-5 ', 2, 1)
GO
INSERT INTO [dbo]. [Students] ([Name], [Surname], [MiddleName], [GenderId], [DateofBirth], [GroupId], [EducationFormId]) VALUES ('Gennady', 'Mamontov', 'Robertovich ', 1,' 2000-1-8 ', 2, 1)
GO
INSERT INTO [dbo]. [Students] ([Name], [Surname], [MiddleName], [GenderId], [DateofBirth], [GroupId], [EducationFormId]) VALUES ('Vasily', 'Panov', 'Rudolfovich ', 1,' 2000-1-11 ', 2, 1)
GO
INSERT INTO [dbo]. [Students] ([Name], [Surname], [MiddleName], [GenderId], [DateofBirth], [GroupId], [EducationFormId]) VALUES ('Valery', 'Shestakov', 'Natanovich ', 1,' 2000-3-12 ', 2, 1)
GO
INSERT INTO [dbo]. [Students] ([Name], [Surname], [MiddleName], [GenderId], [DateofBirth], [GroupId], [EducationFormId]) VALUES ('Milena', 'Komissarova', 'Rostislavovna ', 2,' 2001-1-2 ', 2, 1)
GO
INSERT INTO [dbo]. [Students] ([Name], [Surname], [MiddleName], [GenderId], [DateofBirth], [GroupId], [EducationFormId]) VALUES ('Verona', 'Larionova', 'Vasilievna ', 2,' 2001-1-5 ', 2, 1)
GO
INSERT INTO [dbo]. [Students] ([Name], [Surname], [MiddleName], [GenderId], [DateofBirth], [GroupId], [EducationFormId]) VALUES ('Juno', 'Vladimirova', 'Yakunovna ', 2,' 2001-1-8 ', 2, 1)
GO
INSERT INTO [dbo]. [Students] ([Name], [Surname], [MiddleName], [GenderId], [DateofBirth], [GroupId], [EducationFormId]) VALUES ('Lika', 'Khokhlova', 'Donatovna ', 2,' 2001-1-11 ', 2, 1)
GO
INSERT INTO [dbo]. [Students] ([Name], [Surname], [MiddleName], [GenderId], [DateofBirth], [GroupId], [EducationFormId]) VALUES ('Bella', 'Likhacheva', 'Yakovlevna ', 2,' 2001-4-12 ', 2, 1)
GO

INSERT INTO [dbo]. [Students] ([Name], [Surname], [MiddleName], [GenderId], [DateofBirth], [GroupId], [EducationFormId]) VALUES ('Oleg', 'Kononov', 'Ilyaovich ', 1,' 2000-1-3 ', 3, 2)
GO
INSERT INTO [dbo]. [Students] ([Name], [Surname], [MiddleName], [GenderId], [DateofBirth], [GroupId], [EducationFormId]) VALUES ('Vitaly', 'Ryabov', 'Bogdanovich ', 1,' 2000-1-9 ', 3, 2)
GO
INSERT INTO [dbo]. [Students] ([Name], [Surname], [MiddleName], [GenderId], [DateofBirth], [GroupId], [EducationFormId]) VALUES ('Rostislav', 'Potapov', 'Konstantinovich ', 1,' 2000-1-12 ', 3, 2)
GO
INSERT INTO [dbo]. [Students] ([Name], [Surname], [MiddleName], [GenderId], [DateofBirth], [GroupId], [EducationFormId]) VALUES ('Rudolf', 'Pestov', 'Evgenievich ', 1,' 2000-1-12 ', 3, 2)
GO
INSERT INTO [dbo]. [Students] ([Name], [Surname], [MiddleName], [GenderId], [DateofBirth], [GroupId], [EducationFormId]) VALUES ('Solomon', 'Bespalov', 'Semenovich ', 1,' 2000-1-12 ', 3, 2)
GO
INSERT INTO [dbo]. [Students] ([Name], [Surname], [MiddleName], [GenderId], [DateofBirth], [GroupId], [EducationFormId]) VALUES ('Gloria', 'Kulagina', 'Sergeevna ', 2,' 2001-1-3 ', 3, 2)
GO
INSERT INTO [dbo]. [Students] ([Name], [Surname], [MiddleName], [GenderId], [DateofBirth], [GroupId], [EducationFormId]) VALUES ('Larisa', 'Evdokimova', 'Gennadievna ', 2,' 2001-1-6 ', 3, 2)
GO
INSERT INTO [dbo]. [Students] ([Name], [Surname], [MiddleName], [GenderId], [DateofBirth], [GroupId], [EducationFormId]) VALUES ('Augusta', 'Shubina', 'Svyatoslavovna ', 2,' 2001-1-9 ', 3, 2)
GO
INSERT INTO [dbo]. [Students] ([Name], [Surname], [MiddleName], [GenderId], [DateofBirth], [GroupId], [EducationFormId]) VALUES ('Juliet', 'Blokhin', 'Martynovna ', 2,' 2001-1-12 ', 3, 2)
GO
INSERT INTO [dbo]. [Students] ([Name], [Surname], [MiddleName], [GenderId], [DateofBirth], [GroupId], [EducationFormId]) VALUES ('Kharitina', 'Koroleva', 'Gelasyevna ', 2,' 2001-3-12 ', 3, 2)
GO


INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,1,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,2,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,4,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,5,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,6,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,2,1,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,2,2,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,2,3,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,2,4,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,2,5,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,2,6,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,3,1,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,3,2,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,3,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,3,4,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,3,5,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,3,6,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,4,1,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,4,2,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,4,3,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,4,4,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,4,5,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,4,6,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,5,1,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,5,2,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,5,3,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,5,4,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,5,5,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,5,6,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,6,1,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,6,2,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,6,3,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,6,4,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,6,5,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,6,6,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,7,1,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,7,2,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,7,3,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,7,4,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,7,5,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,7,6,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,8,1,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,8,2,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,8,3,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,8,4,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,8,5,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,8,6,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,9,1,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,9,2,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,9,3,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,9,4,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,9,5,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,9,6,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,10,1,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,10,2,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,10,3,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,10,4,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,10,5,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,10,6,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,11,1,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,11,2,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,11,3,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,11,4,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,11,5,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,11,6,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,12,1,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,12,2,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,12,3,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,12,4,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,12,5,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,12,6,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,13,1,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,13,2,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,13,3,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,13,4,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,13,5,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,13,6,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,14,1,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,14,2,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,14,3,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,14,4,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,14,5,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,14,6,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,15,1,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,15,2,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,15,3,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,15,4,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,15,5,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,15,6,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,16,1,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,16,2,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,16,3,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,16,4,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,16,5,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,16,6,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,17,1,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,17,2,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,17,3,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,17,4,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,17,5,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,17,6,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,18,1,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,18,2,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,18,3,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,18,4,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,18,5,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,18,6,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,19,1,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,19,2,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,19,3,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,19,4,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,19,5,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,19,6,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,20,1,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,20,2,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,20,3,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,20,4,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,20,5,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,20,6,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,21,1,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,21,2,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,21,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,21,4,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,21,5,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,21,6,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,22,1,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,22,2,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,22,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,22,4,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,22,5,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,22,6,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,23,1,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,23,2,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,23,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,23,4,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,23,5,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,23,6,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,24,1,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,24,2,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,24,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,24,4,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,24,5,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,24,6,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,25,1,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,25,2,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,25,3,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,25,4,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,25,5,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,25,6,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,26,1,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,26,2,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,26,3,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,26,4,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,26,5,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,26,6,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,27,1,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,27,2,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,27,3,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,27,4,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,27,5,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,27,6,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,28,1,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,28,2,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,28,3,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,28,4,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,28,5,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,28,6,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,29,1,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,29,2,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,29,3,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,29,4,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,29,5,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,29,6,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,30,1,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,30,2,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,30,3,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,30,4,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,30,5,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,30,6,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,1,1,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,1,2,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,1,3,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,1,4,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,1,5,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,1,6,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,2,1,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,2,2,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,2,3,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,2,4,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,2,5,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,2,6,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,3,1,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,3,2,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,3,3,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,3,4,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,3,5,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,3,6,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,4,1,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,4,2,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,4,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,4,4,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,4,5,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,4,6,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,5,1,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,5,2,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,5,3,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,5,4,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,5,5,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,5,6,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,6,1,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,6,2,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,6,3,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,6,4,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,6,5,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,6,6,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,7,1,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,7,2,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,7,3,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,7,4,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,7,5,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,7,6,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,8,1,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,8,2,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,8,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,8,4,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,8,5,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,8,6,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,9,1,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,9,2,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,9,3,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,9,4,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,9,5,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,9,6,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,10,1,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,10,2,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,10,3,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,10,4,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,10,5,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,10,6,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,11,1,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,11,2,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,11,3,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,11,4,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,11,5,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,11,6,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,12,1,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,12,2,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,12,3,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,12,4,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,12,5,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,12,6,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,13,1,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,13,2,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,13,3,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,13,4,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,13,5,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,13,6,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,14,1,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,14,2,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,14,3,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,14,4,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,14,5,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,14,6,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,15,1,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,15,2,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,15,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,15,4,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,15,5,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,15,6,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,16,1,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,16,2,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,16,3,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,16,4,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,16,5,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,16,6,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,17,1,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,17,2,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,17,3,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,17,4,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,17,5,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,17,6,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,18,1,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,18,2,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,18,3,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,18,4,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,18,5,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,18,6,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,19,1,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,19,2,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,19,3,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,19,4,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,19,5,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,19,6,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,20,1,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,20,2,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,20,3,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,20,4,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,20,5,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,20,6,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,21,1,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,21,2,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,21,3,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,21,4,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,21,5,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,21,6,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,22,1,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,22,2,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,22,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,22,4,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,22,5,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,22,6,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,23,1,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,23,2,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,23,3,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,23,4,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,23,5,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,23,6,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,24,1,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,24,2,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,24,3,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,24,4,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,24,5,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,24,6,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,25,1,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,25,2,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,25,3,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,25,4,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,25,5,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,25,6,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,26,1,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,26,2,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,26,3,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,26,4,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,26,5,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,26,6,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,27,1,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,27,2,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,27,3,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,27,4,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,27,5,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,27,6,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,28,1,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,28,2,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,28,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,28,4,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,28,5,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,28,6,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,29,1,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,29,2,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,29,3,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,29,4,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,29,5,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,29,6,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,30,1,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,30,2,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,30,3,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,30,4,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,30,5,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,30,6,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,1,1,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,1,2,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,1,3,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,1,4,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,1,5,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,1,6,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,2,1,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,2,2,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,2,3,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,2,4,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,2,5,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,2,6,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,3,1,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,3,2,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,3,3,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,3,4,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,3,5,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,3,6,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,4,1,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,4,2,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,4,3,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,4,4,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,4,5,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,4,6,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,5,1,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,5,2,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,5,3,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,5,4,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,5,5,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,5,6,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,6,1,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,6,2,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,6,3,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,6,4,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,6,5,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,6,6,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,7,1,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,7,2,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,7,3,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,7,4,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,7,5,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,7,6,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,8,1,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,8,2,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,8,3,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,8,4,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,8,5,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,8,6,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,9,1,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,9,2,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,9,3,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,9,4,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,9,5,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,9,6,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,10,1,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,10,2,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,10,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,10,4,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,10,5,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,10,6,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,11,1,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,11,2,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,11,3,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,11,4,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,11,5,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,11,6,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,12,1,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,12,2,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,12,3,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,12,4,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,12,5,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,12,6,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,13,1,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,13,2,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,13,3,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,13,4,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,13,5,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,13,6,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,14,1,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,14,2,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,14,3,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,14,4,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,14,5,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,14,6,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,15,1,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,15,2,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,15,3,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,15,4,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,15,5,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,15,6,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,16,1,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,16,2,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,16,3,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,16,4,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,16,5,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,16,6,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,17,1,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,17,2,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,17,3,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,17,4,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,17,5,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,17,6,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,18,1,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,18,2,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,18,3,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,18,4,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,18,5,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,18,6,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,19,1,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,19,2,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,19,3,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,19,4,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,19,5,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,19,6,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,20,1,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,20,2,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,20,3,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,20,4,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,20,5,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,20,6,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,21,1,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,21,2,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,21,3,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,21,4,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,21,5,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,21,6,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,22,1,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,22,2,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,22,3,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,22,4,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,22,5,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,22,6,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,23,1,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,23,2,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,23,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,23,4,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,23,5,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,23,6,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,24,1,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,24,2,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,24,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,24,4,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,24,5,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,24,6,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,25,1,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,25,2,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,25,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,25,4,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,25,5,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,25,6,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,26,1,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,26,2,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,26,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,26,4,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,26,5,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,26,6,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,27,1,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,27,2,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,27,3,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,27,4,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,27,5,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,27,6,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,28,1,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,28,2,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,28,3,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,28,4,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,28,5,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,28,6,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,29,1,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,29,2,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,29,3,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,29,4,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,29,5,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,29,6,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,30,1,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,30,2,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,30,3,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,30,4,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,30,5,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (3,30,6,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,1,1,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,1,2,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,1,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,1,4,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,1,5,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,1,6,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,2,1,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,2,2,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,2,3,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,2,4,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,2,5,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,2,6,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,3,1,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,3,2,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,3,3,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,3,4,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,3,5,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,3,6,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,4,1,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,4,2,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,4,3,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,4,4,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,4,5,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,4,6,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,5,1,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,5,2,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,5,3,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,5,4,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,5,5,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,5,6,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,6,1,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,6,2,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,6,3,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,6,4,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,6,5,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,6,6,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,7,1,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,7,2,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,7,3,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,7,4,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,7,5,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,7,6,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,8,1,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,8,2,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,8,3,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,8,4,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,8,5,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,8,6,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,9,1,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,9,2,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,9,3,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,9,4,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,9,5,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,9,6,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,10,1,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,10,2,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,10,3,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,10,4,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,10,5,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,10,6,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,11,1,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,11,2,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,11,3,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,11,4,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,11,5,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,11,6,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,12,1,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,12,2,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,12,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,12,4,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,12,5,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,12,6,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,13,1,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,13,2,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,13,3,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,13,4,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,13,5,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,13,6,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,14,1,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,14,2,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,14,3,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,14,4,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,14,5,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,14,6,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,15,1,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,15,2,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,15,3,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,15,4,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,15,5,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,15,6,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,16,1,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,16,2,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,16,3,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,16,4,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,16,5,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,16,6,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,17,1,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,17,2,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,17,3,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,17,4,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,17,5,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,17,6,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,18,1,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,18,2,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,18,3,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,18,4,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,18,5,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,18,6,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,19,1,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,19,2,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,19,3,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,19,4,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,19,5,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,19,6,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,20,1,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,20,2,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,20,3,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,20,4,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,20,5,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,20,6,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,21,1,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,21,2,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,21,3,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,21,4,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,21,5,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,21,6,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,22,1,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,22,2,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,22,3,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,22,4,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,22,5,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,22,6,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,23,1,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,23,2,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,23,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,23,4,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,23,5,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,23,6,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,24,1,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,24,2,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,24,3,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,24,4,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,24,5,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,24,6,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,25,1,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,25,2,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,25,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,25,4,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,25,5,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,25,6,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,26,1,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,26,2,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,26,3,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,26,4,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,26,5,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,26,6,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,27,1,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,27,2,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,27,3,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,27,4,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,27,5,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,27,6,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,28,1,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,28,2,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,28,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,28,4,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,28,5,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,28,6,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,29,1,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,29,2,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,29,3,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,29,4,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,29,5,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,29,6,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,30,1,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,30,2,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,30,3,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,30,4,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,30,5,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (4,30,6,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,1,1,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,1,2,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,1,3,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,1,4,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,1,5,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,1,6,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,2,1,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,2,2,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,2,3,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,2,4,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,2,5,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,2,6,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,3,1,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,3,2,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,3,3,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,3,4,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,3,5,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,3,6,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,4,1,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,4,2,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,4,3,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,4,4,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,4,5,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,4,6,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,5,1,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,5,2,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,5,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,5,4,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,5,5,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,5,6,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,6,1,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,6,2,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,6,3,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,6,4,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,6,5,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,6,6,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,7,1,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,7,2,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,7,3,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,7,4,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,7,5,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,7,6,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,8,1,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,8,2,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,8,3,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,8,4,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,8,5,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,8,6,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,9,1,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,9,2,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,9,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,9,4,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,9,5,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,9,6,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,10,1,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,10,2,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,10,3,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,10,4,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,10,5,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,10,6,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,11,1,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,11,2,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,11,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,11,4,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,11,5,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,11,6,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,12,1,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,12,2,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,12,3,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,12,4,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,12,5,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,12,6,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,13,1,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,13,2,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,13,3,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,13,4,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,13,5,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,13,6,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,14,1,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,14,2,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,14,3,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,14,4,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,14,5,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,14,6,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,15,1,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,15,2,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,15,3,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,15,4,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,15,5,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,15,6,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,16,1,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,16,2,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,16,3,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,16,4,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,16,5,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,16,6,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,17,1,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,17,2,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,17,3,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,17,4,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,17,5,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,17,6,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,18,1,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,18,2,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,18,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,18,4,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,18,5,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,18,6,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,19,1,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,19,2,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,19,3,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,19,4,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,19,5,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,19,6,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,20,1,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,20,2,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,20,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,20,4,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,20,5,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,20,6,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,21,1,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,21,2,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,21,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,21,4,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,21,5,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,21,6,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,22,1,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,22,2,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,22,3,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,22,4,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,22,5,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,22,6,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,23,1,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,23,2,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,23,3,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,23,4,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,23,5,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,23,6,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,24,1,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,24,2,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,24,3,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,24,4,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,24,5,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,24,6,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,25,1,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,25,2,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,25,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,25,4,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,25,5,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,25,6,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,26,1,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,26,2,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,26,3,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,26,4,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,26,5,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,26,6,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,27,1,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,27,2,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,27,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,27,4,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,27,5,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,27,6,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,28,1,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,28,2,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,28,3,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,28,4,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,28,5,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,28,6,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,29,1,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,29,2,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,29,3,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,29,4,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,29,5,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,29,6,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,30,1,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,30,2,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,30,3,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,30,4,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,30,5,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (5,30,6,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,1,1,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,1,2,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,1,3,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,1,4,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,1,5,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,1,6,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,2,1,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,2,2,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,2,3,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,2,4,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,2,5,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,2,6,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,3,1,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,3,2,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,3,3,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,3,4,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,3,5,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,3,6,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,4,1,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,4,2,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,4,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,4,4,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,4,5,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,4,6,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,5,1,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,5,2,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,5,3,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,5,4,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,5,5,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,5,6,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,6,1,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,6,2,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,6,3,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,6,4,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,6,5,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,6,6,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,7,1,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,7,2,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,7,3,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,7,4,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,7,5,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,7,6,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,8,1,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,8,2,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,8,3,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,8,4,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,8,5,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,8,6,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,9,1,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,9,2,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,9,3,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,9,4,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,9,5,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,9,6,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,10,1,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,10,2,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,10,3,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,10,4,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,10,5,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,10,6,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,11,1,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,11,2,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,11,3,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,11,4,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,11,5,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,11,6,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,12,1,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,12,2,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,12,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,12,4,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,12,5,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,12,6,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,13,1,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,13,2,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,13,3,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,13,4,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,13,5,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,13,6,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,14,1,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,14,2,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,14,3,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,14,4,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,14,5,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,14,6,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,15,1,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,15,2,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,15,3,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,15,4,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,15,5,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,15,6,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,16,1,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,16,2,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,16,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,16,4,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,16,5,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,16,6,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,17,1,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,17,2,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,17,3,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,17,4,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,17,5,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,17,6,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,18,1,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,18,2,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,18,3,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,18,4,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,18,5,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,18,6,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,19,1,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,19,2,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,19,3,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,19,4,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,19,5,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,19,6,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,20,1,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,20,2,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,20,3,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,20,4,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,20,5,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,20,6,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,21,1,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,21,2,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,21,3,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,21,4,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,21,5,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,21,6,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,22,1,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,22,2,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,22,3,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,22,4,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,22,5,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,22,6,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,23,1,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,23,2,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,23,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,23,4,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,23,5,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,23,6,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,24,1,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,24,2,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,24,3,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,24,4,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,24,5,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,24,6,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,25,1,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,25,2,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,25,3,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,25,4,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,25,5,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,25,6,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,26,1,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,26,2,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,26,3,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,26,4,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,26,5,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,26,6,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,27,1,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,27,2,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,27,3,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,27,4,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,27,5,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,27,6,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,28,1,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,28,2,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,28,3,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,28,4,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,28,5,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,28,6,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,29,1,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,29,2,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,29,3,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,29,4,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,29,5,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,29,6,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,30,1,3) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,30,2,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,30,3,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,30,4,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,30,5,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (6,30,6,9) 
GO

