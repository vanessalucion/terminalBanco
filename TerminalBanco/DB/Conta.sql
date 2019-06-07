CREATE TABLE [dbo].[Conta]
(
	[Id] INT  IDENTITY (1,1 ) NOT NULL,
	[CorrentistaId] INT NULL,
	[LimiteCredito] MONEY NULL,
	[Saldo] MONEY NULL,
	[DataAbertura] DATE NULL
);
