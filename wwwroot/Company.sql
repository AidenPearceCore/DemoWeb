USE [DemoDatabase]
GO

/****** Object:  Table [dbo].[company]    Script Date: 2022/4/6 上午 12:08:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[company](
	[id] [nchar](10) NOT NULL,
	[name] [nvarchar](max) NULL,
	[tel] [nvarchar](50) NULL,
	[address] [nvarchar](max) NULL,
	[contect] [nvarchar](max) NULL,
 CONSTRAINT [PK_company] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

