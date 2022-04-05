USE [DemoDatabase]
GO

/****** Object:  Table [dbo].[uploadfile]    Script Date: 2022/4/6 上午 12:05:37 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[uploadfile](
	[UploadFileId] [int] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Src] [nvarchar](max) NULL,
	[HouseId] [int] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

