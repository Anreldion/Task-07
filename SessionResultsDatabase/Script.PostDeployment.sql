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
INSERT INTO [dbo].[Groups] ([Name],[SpecialtiesID]) VALUES  ('PE',1) 
GO
INSERT INTO [dbo].[Groups] ([Name],[SpecialtiesID]) VALUES  ('PGS',2) 
GO
INSERT INTO [dbo].[Groups] ([Name],[SpecialtiesID]) VALUES  ('ZPE',1) 
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

INSERT INTO [dbo].[SessionPeriods] ([Name]) VALUES  ('Winter period') 
GO
INSERT INTO [dbo].[SessionPeriods] ([Name]) VALUES  ('Spring period') 
GO
INSERT INTO [dbo].[SessionPeriods] ([Name]) VALUES  ('Summer period') 
GO
INSERT INTO [dbo].[SessionPeriods] ([Name]) VALUES  ('Autumn period') 
GO

INSERT INTO [dbo].[Sessions] ([SessionPeriodId],[DateFrom],[DateTo]) VALUES  (1, '2020-1-12', '2020-28-12') 
GO
INSERT INTO [dbo].[Sessions] ([SessionPeriodId],[DateFrom],[DateTo]) VALUES  (3, '2021-1-5', '2021-1-6') 
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

INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2021-10-5', 1, 2, 1, 1,1) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2021-10-5', 2, 2, 1, 2,2) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2021-10-5', 3, 2, 1, 1,3) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2021-1-5', 4, 2, 1, 2,4) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2021-5-5', 5, 2, 1, 1,5) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2021-10-5', 6, 2, 1, 2,6) 
GO

INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2021-10-5', 1, 2, 2, 1,1) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2021-10-5', 2, 2, 2, 2,2) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2021-10-5', 3, 2, 2, 1,3) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2021-1-5', 4, 2, 2, 2,4) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2021-5-5', 5, 2, 2, 1,5) 
GO
INSERT INTO [dbo].[Schedules] ([Date],[SubjectId],[SessionId],[GroupId],[TestFormId],[ExaminerID]) VALUES  ('2021-10-5', 6, 2, 2, 2,6) 
GO

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

INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,1,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,2,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,1,3,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,1,4,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,1,5,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,1,6,9) 
GO

INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,2,1,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,2,2,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,2,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,2,4,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,2,5,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,2,6,4) 
GO

INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,3,1,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,3,2,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,3,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,3,4,7)
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,3,5,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,3,6,7) 
GO

INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,4,1,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,4,2,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,4,3,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,4,4,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,4,5,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,4,6,9) 
GO

INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,5,1,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,5,2,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,5,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,5,4,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,5,5,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,5,6,4) 
GO

INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,6,1,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,6,2,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,6,3,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,6,4,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,6,5,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,6,6,9) 
GO

INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,7,1,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,7,2,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,7,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,7,4,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,7,5,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,7,6,4) 
GO

INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,8,1,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,8,2,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,8,3,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,8,4,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,8,5,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,8,6,9) 
GO

INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,9,1,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,9,2,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,9,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,9,4,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,9,5,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,9,6,4) 
GO

INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,10,1,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,10,2,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,10,3,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,10,4,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,10,5,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,10,6,9) 
GO

INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,11,1,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,11,2,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,11,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,11,4,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,11,5,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,11,6,4) 
GO

INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,12,1,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,12,2,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,12,3,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,12,4,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,12,5,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,12,6,9) 
GO

INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,13,1,9)
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,13,2,8)
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,13,3,7)
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,13,4,6)
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,13,5,5)
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,13,6,4)
GO

INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,14,1,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,14,2,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,14,3,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,14,4,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,14,5,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,14,6,9) 
GO

INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,15,1,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,15,2,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,15,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,15,4,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,15,5,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,15,6,4) 
GO

INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,16,1,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,16,2,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,16,3,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,16,4,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,16,5,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,16,6,9) 
GO

INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,17,1,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,17,2,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,17,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,17,4,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,17,5,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,17,6,4) 
GO

INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,18,1,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,18,2,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,18,3,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,18,4,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,18,5,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,18,6,9) 
GO

INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,19,1,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,19,2,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,19,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,19,4,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,19,5,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,19,6,4) 
GO

INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,20,1,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,20,2,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,20,3,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,20,4,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,20,5,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,20,6,9) 
GO

INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,21,1,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,21,2,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,21,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,21,4,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,21,5,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,21,6,4) 
GO

INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,22,1,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,22,2,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,22,3,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,22,4,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,22,5,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,22,6,9) 
GO

INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,23,1,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,23,2,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,23,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,23,4,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,23,5,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,23,6,4) 
GO

INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,24,1,4)
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,24,2,5)
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,24,3,6)
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,24,4,7)
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,24,5,8)
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,24,6,9)
GO

INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,25,1,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,25,2,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,25,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,25,4,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,25,5,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,25,6,4) 
GO

INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,26,1,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,26,2,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,26,3,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,26,4,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,26,5,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,26,6,9) 
GO

INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,27,1,9)
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,27,2,8)
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,27,3,7)
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,27,4,6)
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,27,5,5)
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,27,6,4)
GO

INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,28,1,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,28,2,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,28,3,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,28,4,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,28,5,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,28,6,9) 
GO

INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,29,1,9) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,29,2,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,29,3,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,29,4,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,29,5,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,29,6,4) 
GO

INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,30,1,4) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,30,2,5) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (1,30,3,6) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,30,4,7) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,30,5,8) 
GO
INSERT INTO [dbo].[Results] ([SessionId],[StudentId],[SubjectId],[Mark]) VALUES (2,30,6,9) 
GO

