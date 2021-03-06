USE [student]
GO
/****** Object:  Table [dbo].[grade]    Script Date: 4/16/2019 4:24:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[grade](
	[id] [nvarchar](50) NOT NULL,
	[grades] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_grade] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[progress]    Script Date: 4/16/2019 4:24:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[progress](
	[id] [int] NOT NULL,
	[progress] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[studentinfo]    Script Date: 4/16/2019 4:24:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[studentinfo](
	[id] [nvarchar](50) NOT NULL,
	[namesurname] [nvarchar](50) NOT NULL,
	[thesis] [nvarchar](50) NOT NULL,
	[startdate] [datetime] NOT NULL,
	[languages] [nvarchar](50) NOT NULL,
	[framework] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_studentinfo] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[grade] ([id], [grades]) VALUES (N'1', N'3')
INSERT [dbo].[grade] ([id], [grades]) VALUES (N'2', N'7')
INSERT [dbo].[progress] ([id], [progress]) VALUES (1, 70)
INSERT [dbo].[progress] ([id], [progress]) VALUES (2, 30)
INSERT [dbo].[progress] ([id], [progress]) VALUES (3, 90)
INSERT [dbo].[studentinfo] ([id], [namesurname], [thesis], [startdate], [languages], [framework]) VALUES (N'1', N'Nikos Lenidis', N'Injections', CAST(N'2019-10-10T00:00:00.000' AS DateTime), N'Java', N'dot net')
INSERT [dbo].[studentinfo] ([id], [namesurname], [thesis], [startdate], [languages], [framework]) VALUES (N'2', N'Dimitris Tsaruxas', N'b', CAST(N'2019-04-13T16:52:18.863' AS DateTime), N'C#', N'Oracle')
INSERT [dbo].[studentinfo] ([id], [namesurname], [thesis], [startdate], [languages], [framework]) VALUES (N'3', N'Stathis Panaris', N'Databases', CAST(N'2019-04-12T00:00:00.000' AS DateTime), N'Python', N'Web framework')
ALTER TABLE [dbo].[grade]  WITH CHECK ADD  CONSTRAINT [FK_grade_studentinfo] FOREIGN KEY([id])
REFERENCES [dbo].[studentinfo] ([id])
GO
ALTER TABLE [dbo].[grade] CHECK CONSTRAINT [FK_grade_studentinfo]
GO
