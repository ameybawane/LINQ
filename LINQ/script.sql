CREATE DATABASE PMS
GO

USE PMS
GO
/****** Object:  Table [dbo].[Departments]    Script Date: 11/4/2022 10:52:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Departments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 11/4/2022 10:52:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[Id] [tinyint] NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[DepartmentId] [int] NOT NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Departments] ON 

INSERT [dbo].[Departments] ([Id], [Name]) VALUES (1, N'Computer Engineering')
INSERT [dbo].[Departments] ([Id], [Name]) VALUES (3, N'Marketing')
INSERT [dbo].[Departments] ([Id], [Name]) VALUES (4, N'Sales')
INSERT [dbo].[Departments] ([Id], [Name]) VALUES (17, N'ITS')
SET IDENTITY_INSERT [dbo].[Departments] OFF
GO
INSERT [dbo].[Employees] ([Id], [FirstName], [LastName], [Email], [DepartmentId]) VALUES (1, N'mahesh', N'patel', N'p@p.com', 1)
INSERT [dbo].[Employees] ([Id], [FirstName], [LastName], [Email], [DepartmentId]) VALUES (2, N'suresh', N'shah', N's@s.com', 1)
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_Departments] FOREIGN KEY([DepartmentId])
REFERENCES [dbo].[Departments] ([Id])
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_Departments]
GO
ALTER TABLE [dbo].[Departments]  WITH CHECK ADD  CONSTRAINT [CK_Departments] CHECK  ((len([name])>=(3)))
GO
ALTER TABLE [dbo].[Departments] CHECK CONSTRAINT [CK_Departments]
GO
