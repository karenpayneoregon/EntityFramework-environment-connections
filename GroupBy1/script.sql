USE [ForumExample]
GO
/****** Object:  Table [dbo].[Table_2]    Script Date: 9/29/2020 12:02:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Table_2](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Number] [int] NULL,
	[Quantity1] [int] NULL,
	[Mark2] [int] NULL,
 CONSTRAINT [PK_Table_2] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Table_2] ON 

INSERT [dbo].[Table_2] ([Id], [Number], [Quantity1], [Mark2]) VALUES (1, 10, 100, 200)
INSERT [dbo].[Table_2] ([Id], [Number], [Quantity1], [Mark2]) VALUES (2, 10, 0, 0)
INSERT [dbo].[Table_2] ([Id], [Number], [Quantity1], [Mark2]) VALUES (3, 10, 10, 50)
INSERT [dbo].[Table_2] ([Id], [Number], [Quantity1], [Mark2]) VALUES (4, 10, 200, 2)
INSERT [dbo].[Table_2] ([Id], [Number], [Quantity1], [Mark2]) VALUES (5, 11, 0, 0)
INSERT [dbo].[Table_2] ([Id], [Number], [Quantity1], [Mark2]) VALUES (6, 11, 1, 1)
INSERT [dbo].[Table_2] ([Id], [Number], [Quantity1], [Mark2]) VALUES (7, 11, 0, 0)
SET IDENTITY_INSERT [dbo].[Table_2] OFF
