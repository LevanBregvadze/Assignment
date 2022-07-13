USE [master]
GO

CREATE DATABASE [Task6DatabaseFirst]
GO

USE [Task6DatabaseFirst]
GO

CREATE TABLE [dbo].[Teacher] (
    [Id] INT IDENTITY (1, 1) NOT NULL,
	firstName VARCHAR(50),
	lastName VARCHAR(50),
	sex VARCHAR(50),
	subjectName VARCHAR(50),
    CONSTRAINT [PK_Versions] PRIMARY KEY CLUSTERED ([Id] ASC)
);
Go

CREATE TABLE [dbo].[Pupil] (
    [Id] INT IDENTITY (1, 1) NOT NULL,
	firstName VARCHAR(50),
	lastName VARCHAR(50),
	sex VARCHAR(50),
	class VARCHAR(50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
Go

CREATE TABLE [dbo].[Teacher_Pupil] (
    [Id]      INT IDENTITY(1,1) NOT NULL,
    TeacherId INT NOT NULL,
    PupilId INT NOT NULL,
    FOREIGN KEY(TeacherId) REFERENCES Teacher(Id),
    FOREIGN KEY(PupilId) REFERENCES Pupil(Id),
    PRIMARY KEY CLUSTERED ([Id] ASC)

);
Go




SET IDENTITY_INSERT [dbo].[Teacher] OFF 

GO
INSERT [dbo].[Teacher]  (firstName, lastName, sex, subjectName ) VALUES ('Teacher1', 'Teacher1', 'Female', 'Math')
GO
INSERT [dbo].[Teacher]  (firstName, lastName, sex, subjectName ) VALUES ('Teacher2', 'Teacher2', 'Female', 'English')
GO
INSERT [dbo].[Teacher]  (firstName, lastName, sex, subjectName ) VALUES ('Teacher3', 'Teacher3', 'Female', 'Physics')
GO


SET IDENTITY_INSERT [dbo].[Pupil] OFF 

GO
INSERT [dbo].[Pupil]  (firstName, lastName, sex, class ) VALUES ('Pupil1', 'Pupil1', 'Boy', '1A')
GO
INSERT [dbo].[Pupil]  (firstName, lastName, sex, class ) VALUES ('Pupil2', 'Pupil2', 'Girl', '2A')
GO
INSERT [dbo].[Pupil]  (firstName, lastName, sex, class ) VALUES ('Giorgi', 'Pupil3', 'Boy', '3A')
GO



SET IDENTITY_INSERT [dbo].[Teacher_Pupil] OFF 

GO
INSERT [dbo].[Teacher_Pupil]  (TeacherId, PupilId ) VALUES (1, 1)
GO
INSERT [dbo].[Teacher_Pupil]  (TeacherId, PupilId ) VALUES (1, 2)
GO
INSERT [dbo].[Teacher_Pupil]  (TeacherId, PupilId ) VALUES (1, 3)
GO
INSERT [dbo].[Teacher_Pupil]  (TeacherId, PupilId ) VALUES (2, 1)
GO
INSERT [dbo].[Teacher_Pupil]  (TeacherId, PupilId ) VALUES (2, 2)
GO
INSERT [dbo].[Teacher_Pupil]  (TeacherId, PupilId ) VALUES (2, 3)
GO
INSERT [dbo].[Teacher_Pupil]  (TeacherId, PupilId ) VALUES (3, 1)
GO
INSERT [dbo].[Teacher_Pupil]  (TeacherId, PupilId ) VALUES (3, 2)
GO
INSERT [dbo].[Teacher_Pupil]  (TeacherId, PupilId ) VALUES (3, 3)
GO



select t.* from Teacher t
join Teacher_Pupil tp on t.Id = tp.TeacherId
join Pupil p on p.Id = tp.PupilId 
where p.firstName = 'Giorgi';