USE [Electro]
GO

/****** Object:  Table [dbo].[Items]    Script Date: 11/12/2018 15:58:57 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Items](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Price] [int] NULL,
	[Stock] [int] NULL,
	[CreateDate] [datetimeoffset](7) NULL,
	[UpdateDate] [datetimeoffset](7) NULL,
	[Deletedate] [datetimeoffset](7) NULL,
	[IsDelete] [bit] NOT NULL,
	[Suppliers_Id] [int] NULL,
 CONSTRAINT [PK__Item__3214EC07B527823A] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

ALTER TABLE [dbo].[Items]  WITH CHECK ADD  CONSTRAINT [FK_Item_Suppliers] FOREIGN KEY([Suppliers_Id])
REFERENCES [dbo].[Suppliers] ([Id])
GO

ALTER TABLE [dbo].[Items] CHECK CONSTRAINT [FK_Item_Suppliers]
GO


