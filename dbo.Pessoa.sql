﻿CREATE TABLE [dbo].[Pessoa]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[Nome] VARCHAR(45) NOT NULL,
	[Cpf] VARCHAR(11) NOT NULL,
	[DataNascimento] DATETIME NOT NULL,
	[Telefone] VARCHAR(13) NULL

)
