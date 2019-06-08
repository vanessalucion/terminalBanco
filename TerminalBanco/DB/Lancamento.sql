CREATE TABLE [dbo].[Lancamento]
(
	[Id]  INT NOT NULL PRIMARY KEY IDENTITY,	
	[Data] DATE NULL,
	[ContaId] INT NULL,
	[Operacao] VARCHAR (50) NULL,
	[Historico] VARCHAR (50) NULL,
	[Valor] MONEY NULL,
	CONSTRAINT [FK_Lancamento_ToConta] FOREIGN KEY ([ContaId]) REFERENCES [Conta]([Id]) 

);
