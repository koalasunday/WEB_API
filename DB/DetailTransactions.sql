USE [Electro]
GO

/****** Object:  Table [dbo].[DetailTransactions]    Script Date: 11/12/2018 15:58:18 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[DetailTransactions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Quantity] [int] NULL,
	[Price] [int] NULL,
	[Transactions_Id] [int] NULL,
	[Items_Id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[DetailTransactions]  WITH CHECK ADD  CONSTRAINT [FK_DetailTransaction_Item] FOREIGN KEY([Items_Id])
REFERENCES [dbo].[Items] ([Id])
GO

ALTER TABLE [dbo].[DetailTransactions] CHECK CONSTRAINT [FK_DetailTransaction_Item]
GO

ALTER TABLE [dbo].[DetailTransactions]  WITH CHECK ADD  CONSTRAINT [FK_DetailTransaction_Transaction] FOREIGN KEY([Transactions_Id])
REFERENCES [dbo].[Transactions] ([Id])
GO

ALTER TABLE [dbo].[DetailTransactions] CHECK CONSTRAINT [FK_DetailTransaction_Transaction]
GO


