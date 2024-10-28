CREATE DATABASE [Test.Tarek]
GO
USE [Test.Tarek]
GO

/****** Object:  Table [dbo].[Users]    Script Date: 25/10/2024 14:21:34 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Users](
	[ID] [uniqueidentifier] NOT NULL,
	[FirstName] [nvarchar](50) NULL,
	[Surname] [nvarchar](50) NULL,
	[EmailAddress] [nvarchar](50) NULL,
 CONSTRAINT [PK_Users1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

INSERT [dbo].[Users] ([ID], [FirstName], [Surname], [EmailAddress]) VALUES (NEWID(), N'Tarek', N'Baba', N'tarek@test.com')
GO