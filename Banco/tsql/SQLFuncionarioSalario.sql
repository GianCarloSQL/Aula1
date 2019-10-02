Create database SistemaRH
Go
Using SistemaRH
GO
CREATE TABLE [dbo].[Salarios]
(
	[Id] INT NOT NULL PRIMARY KEY identity(1,1), 
    [Funcionario] INT NULL, 
    [Valor] MONEY NULL,
	[Ativo]            BIT        DEFAULT ((1)) NULL,
    [UsuarioCriacao]   INT        DEFAULT ((0)) NULL,
    [UsuarioAlteracao] INT        DEFAULT ((0)) NULL,
    [DataCriacao]      DATETIME   DEFAULT (getdate()) NULL,
    [DataAlteracao]    DATETIME       DEFAULT (getdate()) NULL,
)
GO
CREATE TABLE [dbo].[Funcionario]
(
	[Id] INT NOT NULL PRIMARY KEY identity (1,1), 
    [Nome] NCHAR(10) NULL, 
	[Ativo]            BIT        DEFAULT ((1)) NULL,
    [DataInicio] DATETIME NULL DEFAULT getdate(), 
    [DataSaida] DATETIME NULL,
	[UsuarioCriacao]   INT        DEFAULT ((0)) NULL,
    [UsuarioAlteracao] INT        DEFAULT ((0)) NULL,
    [DataCriacao]      DATETIME   DEFAULT (getdate()) NULL,
    [DataAlteracao]    DATETIME       DEFAULT (getdate()) NULL,
)
GO

insert into Funcionario (Nome) values ('Gian C','Pedro H','Antue B','Jean Jacques Rousell');
GO
insert into Salarios (Funcionario,Valor) values (1,100,GETDATE()),(1,100,GETDATE()),(1,100,GETDATE()) ;