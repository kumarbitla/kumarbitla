USE [WillAide]
GO
/****** Object:  Table [dbo].[tbl_User]    Script Date: 07-05-2022 15:37:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[First_Name] [varchar](100) NOT NULL,
	[Last_Name] [varchar](100) NOT NULL,
	[Date_Of_Birth] [date] NOT NULL,
	[Address_Line1] [varchar](250) NOT NULL,
	[Address_Line2] [varchar](250) NOT NULL,
	[State_Of_Residence] [varchar](100) NOT NULL,
	[Postal_Code] [varchar](50) NOT NULL,
	[City_Of_Residence] [varchar](250) NOT NULL,
	[Personal_Contact] [varchar](50) NOT NULL,
	[Office_Contact] [varchar](50) NOT NULL,
	[Personal_Email] [varchar](100) NOT NULL,
	[Office_Email] [varchar](100) NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tbl_User] ON 
GO
INSERT [dbo].[tbl_User] ([Id], [First_Name], [Last_Name], [Date_Of_Birth], [Address_Line1], [Address_Line2], [State_Of_Residence], [Postal_Code], [City_Of_Residence], [Personal_Contact], [Office_Contact], [Personal_Email], [Office_Email]) VALUES (1, N'Joe', N'Smith', CAST(N'1970-01-01' AS Date), N'123 Main Street', N'Apt No 111', N'Texas', N'1234-4556', N'Dallas', N'1111-222-3333-444', N'555-444-333-111', N'abc@domain.com', N'xyz@domain.com')
GO
INSERT [dbo].[tbl_User] ([Id], [First_Name], [Last_Name], [Date_Of_Birth], [Address_Line1], [Address_Line2], [State_Of_Residence], [Postal_Code], [City_Of_Residence], [Personal_Contact], [Office_Contact], [Personal_Email], [Office_Email]) VALUES (2, N'Mark', N'Nicolas', CAST(N'1950-05-04' AS Date), N'456 Wall Street', N'Hous No 333', N'Texas', N'1234-4444', N'Dallas', N'3334-444-4444', N'5555-66-5555-444', N'123@gmail.com', N'erw@officedomain.com')
GO
SET IDENTITY_INSERT [dbo].[tbl_User] OFF
GO
