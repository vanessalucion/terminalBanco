CREATE TABLE [dbo].[Conta]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[CorrentistaId] INT NULL,
	[LimiteCredito] MONEY NULL,
	[Saldo] MONEY NULL,
	[DataAbertura] DATE NULL,
	CONSTRAINT [FK_Conta_ToCorrentista] FOREIGN KEY ([CorrentistaId]) REFERENCES [Correntista]([Id]) 
);
