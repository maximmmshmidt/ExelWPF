USE [TeacherBook]
GO
/****** Object:  Table [dbo].[FormTime]    Script Date: 17.01.2023 9:52:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FormTime](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_FormTime] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Groups]    Script Date: 17.01.2023 9:52:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Groups](
	[IdGroup] [int] IDENTITY(1,1) NOT NULL,
	[NameGroup] [nvarchar](20) NULL,
 CONSTRAINT [PK_Groups] PRIMARY KEY CLUSTERED 
(
	[IdGroup] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[History]    Script Date: 17.01.2023 9:52:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[History](
	[IdHistory] [int] IDENTITY(1,1) NOT NULL,
	[IdTeacher] [int] NULL,
	[IdStudent] [int] NULL,
	[IdStatus] [int] NULL,
	[DateEvent] [date] NULL,
 CONSTRAINT [PK_History] PRIMARY KEY CLUSTERED 
(
	[IdHistory] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Journals]    Script Date: 17.01.2023 9:52:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Journals](
	[IdJournal] [int] IDENTITY(1,1) NOT NULL,
	[IdStudent] [int] NOT NULL,
	[IdSubject] [int] NULL,
	[Evaluation] [int] NULL,
	[IdGroup] [int] NULL,
 CONSTRAINT [PK_Journal] PRIMARY KEY CLUSTERED 
(
	[IdJournal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Professions]    Script Date: 17.01.2023 9:52:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Professions](
	[IdProfession] [int] IDENTITY(1,1) NOT NULL,
	[NameProfession] [nvarchar](100) NULL,
 CONSTRAINT [PK_Professions] PRIMARY KEY CLUSTERED 
(
	[IdProfession] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 17.01.2023 9:52:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[IdRole] [int] IDENTITY(1,1) NOT NULL,
	[NameRole] [nvarchar](15) NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[IdRole] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Status]    Script Date: 17.01.2023 9:52:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Status](
	[IdStatus] [int] IDENTITY(1,1) NOT NULL,
	[NameStatus] [nvarchar](20) NULL,
 CONSTRAINT [PK_Status] PRIMARY KEY CLUSTERED 
(
	[IdStatus] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 17.01.2023 9:52:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[IdStudent] [int] IDENTITY(1,1) NOT NULL,
	[FiestName] [nvarchar](20) NULL,
	[LastName] [nvarchar](20) NULL,
	[PatronomicName] [nvarchar](20) NULL,
	[IdProfession] [int] NULL,
	[IdFormTime] [int] NULL,
	[IdGroup] [int] NULL,
	[IdYearAdd] [int] NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[IdStudent] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subjects]    Script Date: 17.01.2023 9:52:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subjects](
	[IdSubject] [int] IDENTITY(1,1) NOT NULL,
	[NameSubject] [nvarchar](100) NULL,
 CONSTRAINT [PK_Subjects] PRIMARY KEY CLUSTERED 
(
	[IdSubject] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TeacherHasSubjects]    Script Date: 17.01.2023 9:52:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TeacherHasSubjects](
	[idTD] [int] IDENTITY(1,1) NOT NULL,
	[IdTeacher] [int] NULL,
	[IdSubject] [int] NULL,
	[Duration] [int] NULL,
 CONSTRAINT [PK_TeacherHasSubjects] PRIMARY KEY CLUSTERED 
(
	[idTD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teachers]    Script Date: 17.01.2023 9:52:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teachers](
	[idTeacher] [int] IDENTITY(1,1) NOT NULL,
	[TeacherName] [nvarchar](100) NULL,
 CONSTRAINT [PK_Teachers] PRIMARY KEY CLUSTERED 
(
	[idTeacher] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 17.01.2023 9:52:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[IdUser] [int] IDENTITY(1,1) NOT NULL,
	[Login] [varchar](20) NULL,
	[Password] [varchar](20) NULL,
	[IdRole] [int] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[IdUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[YearAdd]    Script Date: 17.01.2023 9:52:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[YearAdd](
	[idYear] [int] IDENTITY(1,1) NOT NULL,
	[Year] [int] NULL,
 CONSTRAINT [PK_YearAdd] PRIMARY KEY CLUSTERED 
(
	[idYear] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[FormTime] ON 

INSERT [dbo].[FormTime] ([Id], [Name]) VALUES (1, N'очная')
INSERT [dbo].[FormTime] ([Id], [Name]) VALUES (2, N'заочная')
INSERT [dbo].[FormTime] ([Id], [Name]) VALUES (3, N'очно-заочная')
SET IDENTITY_INSERT [dbo].[FormTime] OFF
SET IDENTITY_INSERT [dbo].[Groups] ON 

INSERT [dbo].[Groups] ([IdGroup], [NameGroup]) VALUES (1, N'ИП-02к')
INSERT [dbo].[Groups] ([IdGroup], [NameGroup]) VALUES (2, N'И-71')
INSERT [dbo].[Groups] ([IdGroup], [NameGroup]) VALUES (3, N'ИП-81')
INSERT [dbo].[Groups] ([IdGroup], [NameGroup]) VALUES (4, N'С-02')
INSERT [dbo].[Groups] ([IdGroup], [NameGroup]) VALUES (5, N'С-91')
SET IDENTITY_INSERT [dbo].[Groups] OFF
SET IDENTITY_INSERT [dbo].[Journals] ON 

INSERT [dbo].[Journals] ([IdJournal], [IdStudent], [IdSubject], [Evaluation], [IdGroup]) VALUES (3, 3, 1, 5, 1)
INSERT [dbo].[Journals] ([IdJournal], [IdStudent], [IdSubject], [Evaluation], [IdGroup]) VALUES (4, 4, 1, 4, 1)
INSERT [dbo].[Journals] ([IdJournal], [IdStudent], [IdSubject], [Evaluation], [IdGroup]) VALUES (5, 3, 2, 3, 1)
INSERT [dbo].[Journals] ([IdJournal], [IdStudent], [IdSubject], [Evaluation], [IdGroup]) VALUES (6, 3, 3, 4, 2)
INSERT [dbo].[Journals] ([IdJournal], [IdStudent], [IdSubject], [Evaluation], [IdGroup]) VALUES (7, 4, 1, 3, 2)
SET IDENTITY_INSERT [dbo].[Journals] OFF
SET IDENTITY_INSERT [dbo].[Professions] ON 

INSERT [dbo].[Professions] ([IdProfession], [NameProfession]) VALUES (1, N'Информационные системы и программирование')
INSERT [dbo].[Professions] ([IdProfession], [NameProfession]) VALUES (2, N'Информационные системы')
INSERT [dbo].[Professions] ([IdProfession], [NameProfession]) VALUES (3, N'Строительство и эксплуатация зданий и сооружений')
SET IDENTITY_INSERT [dbo].[Professions] OFF
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([IdRole], [NameRole]) VALUES (1, N'Student')
INSERT [dbo].[Role] ([IdRole], [NameRole]) VALUES (2, N'Teacher')
INSERT [dbo].[Role] ([IdRole], [NameRole]) VALUES (3, N'Admin')
SET IDENTITY_INSERT [dbo].[Role] OFF
SET IDENTITY_INSERT [dbo].[Students] ON 

INSERT [dbo].[Students] ([IdStudent], [FiestName], [LastName], [PatronomicName], [IdProfession], [IdFormTime], [IdGroup], [IdYearAdd]) VALUES (3, N'Петров', N'Алексей', N'Станиславович', 1, 1, 1, 1)
INSERT [dbo].[Students] ([IdStudent], [FiestName], [LastName], [PatronomicName], [IdProfession], [IdFormTime], [IdGroup], [IdYearAdd]) VALUES (4, N'Станисалов', N'Кузьма', N'Петрович', 1, 1, 2, 1)
INSERT [dbo].[Students] ([IdStudent], [FiestName], [LastName], [PatronomicName], [IdProfession], [IdFormTime], [IdGroup], [IdYearAdd]) VALUES (5, N'Роман', N'Николай', N'Олегович', 1, 2, 3, 2)
INSERT [dbo].[Students] ([IdStudent], [FiestName], [LastName], [PatronomicName], [IdProfession], [IdFormTime], [IdGroup], [IdYearAdd]) VALUES (6, N'Зворыгин', N'Тимофей', N'Эдуардович', 2, 1, 1, 2)
SET IDENTITY_INSERT [dbo].[Students] OFF
SET IDENTITY_INSERT [dbo].[Subjects] ON 

INSERT [dbo].[Subjects] ([IdSubject], [NameSubject]) VALUES (1, N'Основы алгоритмизации и программирования')
INSERT [dbo].[Subjects] ([IdSubject], [NameSubject]) VALUES (2, N'Основы проектирования баз данных')
INSERT [dbo].[Subjects] ([IdSubject], [NameSubject]) VALUES (3, N'История')
SET IDENTITY_INSERT [dbo].[Subjects] OFF
SET IDENTITY_INSERT [dbo].[TeacherHasSubjects] ON 

INSERT [dbo].[TeacherHasSubjects] ([idTD], [IdTeacher], [IdSubject], [Duration]) VALUES (1, 1, 1, NULL)
INSERT [dbo].[TeacherHasSubjects] ([idTD], [IdTeacher], [IdSubject], [Duration]) VALUES (2, 1, 2, NULL)
INSERT [dbo].[TeacherHasSubjects] ([idTD], [IdTeacher], [IdSubject], [Duration]) VALUES (3, 2, 1, NULL)
INSERT [dbo].[TeacherHasSubjects] ([idTD], [IdTeacher], [IdSubject], [Duration]) VALUES (4, 1, 3, NULL)
INSERT [dbo].[TeacherHasSubjects] ([idTD], [IdTeacher], [IdSubject], [Duration]) VALUES (5, 3, 2, NULL)
SET IDENTITY_INSERT [dbo].[TeacherHasSubjects] OFF
SET IDENTITY_INSERT [dbo].[Teachers] ON 

INSERT [dbo].[Teachers] ([idTeacher], [TeacherName]) VALUES (1, N'Замоскворецкая Ираида Ивановна')
INSERT [dbo].[Teachers] ([idTeacher], [TeacherName]) VALUES (2, N'Степанова Софья Леоновна')
INSERT [dbo].[Teachers] ([idTeacher], [TeacherName]) VALUES (3, N'Тимофеев Степан Эдуардович')
SET IDENTITY_INSERT [dbo].[Teachers] OFF
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([IdUser], [Login], [Password], [IdRole]) VALUES (3, N'1', N'1', 1)
INSERT [dbo].[Users] ([IdUser], [Login], [Password], [IdRole]) VALUES (4, N'2', N'2', 2)
INSERT [dbo].[Users] ([IdUser], [Login], [Password], [IdRole]) VALUES (1003, N'3', N'3', 1)
SET IDENTITY_INSERT [dbo].[Users] OFF
SET IDENTITY_INSERT [dbo].[YearAdd] ON 

INSERT [dbo].[YearAdd] ([idYear], [Year]) VALUES (1, 2018)
INSERT [dbo].[YearAdd] ([idYear], [Year]) VALUES (2, 2019)
INSERT [dbo].[YearAdd] ([idYear], [Year]) VALUES (3, 2020)
SET IDENTITY_INSERT [dbo].[YearAdd] OFF
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_IdRole]  DEFAULT ((1)) FOR [IdRole]
GO
ALTER TABLE [dbo].[History]  WITH CHECK ADD  CONSTRAINT [FK_History_Status] FOREIGN KEY([IdStatus])
REFERENCES [dbo].[Status] ([IdStatus])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[History] CHECK CONSTRAINT [FK_History_Status]
GO
ALTER TABLE [dbo].[History]  WITH CHECK ADD  CONSTRAINT [FK_History_Students] FOREIGN KEY([IdStudent])
REFERENCES [dbo].[Students] ([IdStudent])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[History] CHECK CONSTRAINT [FK_History_Students]
GO
ALTER TABLE [dbo].[History]  WITH CHECK ADD  CONSTRAINT [FK_History_Teachers] FOREIGN KEY([IdTeacher])
REFERENCES [dbo].[Teachers] ([idTeacher])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[History] CHECK CONSTRAINT [FK_History_Teachers]
GO
ALTER TABLE [dbo].[Journals]  WITH CHECK ADD  CONSTRAINT [FK_Journal_Groups] FOREIGN KEY([IdGroup])
REFERENCES [dbo].[Groups] ([IdGroup])
GO
ALTER TABLE [dbo].[Journals] CHECK CONSTRAINT [FK_Journal_Groups]
GO
ALTER TABLE [dbo].[Journals]  WITH CHECK ADD  CONSTRAINT [FK_Journal_Students] FOREIGN KEY([IdStudent])
REFERENCES [dbo].[Students] ([IdStudent])
GO
ALTER TABLE [dbo].[Journals] CHECK CONSTRAINT [FK_Journal_Students]
GO
ALTER TABLE [dbo].[Journals]  WITH CHECK ADD  CONSTRAINT [FK_Journal_Subjects] FOREIGN KEY([IdSubject])
REFERENCES [dbo].[Subjects] ([IdSubject])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Journals] CHECK CONSTRAINT [FK_Journal_Subjects]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_FormTime] FOREIGN KEY([IdFormTime])
REFERENCES [dbo].[FormTime] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_FormTime]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Groups] FOREIGN KEY([IdGroup])
REFERENCES [dbo].[Groups] ([IdGroup])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_Groups]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Professions] FOREIGN KEY([IdProfession])
REFERENCES [dbo].[Professions] ([IdProfession])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_Professions]
GO
ALTER TABLE [dbo].[Students]  WITH NOCHECK ADD  CONSTRAINT [FK_Students_YearAdd] FOREIGN KEY([IdYearAdd])
REFERENCES [dbo].[YearAdd] ([idYear])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Students] NOCHECK CONSTRAINT [FK_Students_YearAdd]
GO
ALTER TABLE [dbo].[TeacherHasSubjects]  WITH CHECK ADD  CONSTRAINT [FK_TeacherHasSubjects_Subjects] FOREIGN KEY([IdSubject])
REFERENCES [dbo].[Subjects] ([IdSubject])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TeacherHasSubjects] CHECK CONSTRAINT [FK_TeacherHasSubjects_Subjects]
GO
ALTER TABLE [dbo].[TeacherHasSubjects]  WITH CHECK ADD  CONSTRAINT [FK_TeacherHasSubjects_Teachers] FOREIGN KEY([IdTeacher])
REFERENCES [dbo].[Teachers] ([idTeacher])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TeacherHasSubjects] CHECK CONSTRAINT [FK_TeacherHasSubjects_Teachers]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Role] FOREIGN KEY([IdRole])
REFERENCES [dbo].[Role] ([IdRole])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Role]
GO
