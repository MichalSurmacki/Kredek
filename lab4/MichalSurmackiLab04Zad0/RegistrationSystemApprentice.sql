CREATE DATABASE RegistrationSystemApprentice 

USE [RegistrationSystemApprentice]
GO
/****** Object:  Table [dbo].[InformationAboutStudent]    Script Date: 25.11.2018 20:08:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InformationAboutStudent](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](20) NOT NULL,
	[Surnname] [nvarchar](20) NOT NULL,
	[StudentIndex] [nvarchar](20) NOT NULL,
	[Email] [nvarchar](30) NOT NULL,
	[UserNameId] [int] NOT NULL,
 CONSTRAINT [PK_InformationAboutStudent] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudentLogInSystem]    Script Date: 25.11.2018 20:08:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentLogInSystem](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](20) NOT NULL,
	[Password] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_StudentLogInSystem] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[InformationAboutStudent] ON 

INSERT [dbo].[InformationAboutStudent] ([Id], [Name], [Surnname], [StudentIndex], [Email], [UserNameId]) VALUES (1, N'Jules', N'Verne', N'182828', N'verne@gmail.com', 1)
INSERT [dbo].[InformationAboutStudent] ([Id], [Name], [Surnname], [StudentIndex], [Email], [UserNameId]) VALUES (2, N'Wisława', N'Szymborska', N'192372', N'wisława@gmail.com', 2)
SET IDENTITY_INSERT [dbo].[InformationAboutStudent] OFF
SET IDENTITY_INSERT [dbo].[StudentLogInSystem] ON 

INSERT [dbo].[StudentLogInSystem] ([Id], [UserName], [Password]) VALUES (1, N'jules', N'jules')
INSERT [dbo].[StudentLogInSystem] ([Id], [UserName], [Password]) VALUES (2, N'wisława', N'wisława')
SET IDENTITY_INSERT [dbo].[StudentLogInSystem] OFF
ALTER TABLE [dbo].[InformationAboutStudent]  WITH CHECK ADD  CONSTRAINT [FK_InformationAboutStudent_StudentLogInSystem1] FOREIGN KEY([UserNameId])
REFERENCES [dbo].[StudentLogInSystem] ([Id])
GO
ALTER TABLE [dbo].[InformationAboutStudent] CHECK CONSTRAINT [FK_InformationAboutStudent_StudentLogInSystem1]
GO
