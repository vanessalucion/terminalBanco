CREATE TABLE [dbo].[Lancamento]
(
	[Id]  INT          IDENTITY (1, 1) NOT NULL,	
	[Data] DATE NULL,
	[ContaId] INT NULL,
	[Operacao] VARCHAR (50) NULL,
	[Historico] VARCHAR (50) NULL,
	[Valor] MONEY NULL

);
