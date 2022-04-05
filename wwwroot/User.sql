USE [DemoDatabase]
GO

/****** Object:  Table [dbo].[user]    Script Date: 2022/4/6 上午 12:06:48 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[user](
	[id] [nchar](10) NOT NULL,
	[userID] [varchar](50) NULL,
	[firstName] [varchar](50) NULL,
	[middleName] [varchar](50) NULL,
	[lastName] [varchar](50) NULL,
	[mobile] [varchar](50) NULL,
	[Password] [varchar](max) NULL,
	[HashSaltedPwd] [varchar](max) NULL,
	[admin] [nchar](10) NULL,
	[vender] [nchar](10) NULL,
	[role] [nchar](10) NULL,
	[registeredDate] [datetime] NULL,
	[lastLogin] [datetime] NULL,
	[intro] [varchar](max) NULL,
	[profile] [varchar](max) NULL,
 CONSTRAINT [PK_user] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

