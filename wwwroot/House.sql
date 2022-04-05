USE [DemoDatabase]
GO

/****** Object:  Table [dbo].[house]    Script Date: 2022/4/6 上午 12:04:07 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[house](
	[id] [int] NOT NULL,
	[estatename] [nvarchar](max) NULL,
	[city] [nvarchar](max) NULL,
	[type] [nchar](10) NULL,
	[floor] [nchar](10) NULL,
	[numberofrooms] [int] NULL,
	[price] [int] NULL,
 CONSTRAINT [PK_house] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO



