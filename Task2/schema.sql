USE [SSISDB]
GO
/****** Object:  Table [dbo].[Articles]    Script Date: 2/28/2020 7:00:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Articles](
	[ArticleId] [bigint] IDENTITY(1,1) NOT NULL,
	[ArticleName] [nvarchar](500) NOT NULL,
	[ArticleDate] [datetime2](7) NOT NULL,
	[ArticleText] [nvarchar](max) NULL,
 CONSTRAINT [PK_articles] PRIMARY KEY CLUSTERED 
(
	[ArticleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ArticleTags]    Script Date: 2/28/2020 7:00:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ArticleTags](
	[ArticleTagId] [bigint] IDENTITY(1,1) NOT NULL,
	[ArticleId] [bigint] NOT NULL,
	[TagId] [bigint] NOT NULL,
 CONSTRAINT [PK_ArticleTags] PRIMARY KEY CLUSTERED 
(
	[ArticleTagId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tags]    Script Date: 2/28/2020 7:00:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tags](
	[TagId] [bigint] IDENTITY(1,1) NOT NULL,
	[TagName] [nvarchar](500) NULL,
 CONSTRAINT [PK_tags] PRIMARY KEY CLUSTERED 
(
	[TagId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Articles] ADD  CONSTRAINT [DF_Articles_ArticleDate]  DEFAULT (sysutcdatetime()) FOR [ArticleDate]
GO
ALTER TABLE [dbo].[ArticleTags]  WITH CHECK ADD  CONSTRAINT [FK_ArticleTags_Articles] FOREIGN KEY([ArticleId])
REFERENCES [dbo].[Articles] ([ArticleId])
GO
ALTER TABLE [dbo].[ArticleTags] CHECK CONSTRAINT [FK_ArticleTags_Articles]
GO
ALTER TABLE [dbo].[ArticleTags]  WITH CHECK ADD  CONSTRAINT [FK_ArticleTags_Tags] FOREIGN KEY([TagId])
REFERENCES [dbo].[Tags] ([TagId])
GO
ALTER TABLE [dbo].[ArticleTags] CHECK CONSTRAINT [FK_ArticleTags_Tags]
GO
