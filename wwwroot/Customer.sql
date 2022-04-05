USE [DemoDatabase]
GO

/****** Object:  Table [dbo].[customer]    Script Date: 2022/4/6 上午 12:07:21 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[customer](
	[id] [nchar](10) NOT NULL,
	[gender] [nvarchar](50) NULL,
	[name] [nvarchar](max) NULL,
	[phone] [nvarchar](50) NULL,
	[email] [nvarchar](max) NULL,
	[street] [nvarchar](max) NULL,
	[city] [nvarchar](max) NULL,
	[company] [nvarchar](max) NULL,
 CONSTRAINT [PK_customer] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[customer]  WITH CHECK ADD  CONSTRAINT [FK_customer_company1] FOREIGN KEY([id])
REFERENCES [dbo].[company] ([id])
GO

ALTER TABLE [dbo].[customer] CHECK CONSTRAINT [FK_customer_company1]
GO

