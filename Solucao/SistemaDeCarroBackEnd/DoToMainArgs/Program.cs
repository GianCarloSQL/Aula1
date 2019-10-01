using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoToMainArgs
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = @"-- Cria as tabelas do nosso Sistema de Locacao de Carros
CREATE TABLE [dbo].[Carro] (
    [Id]               INT        IDENTITY (1, 1) NOT NULL,
    [MarcaId]          INT        NOT NULL,
    [Modelo]           NCHAR (50) NOT NULL,
    [Ano]              INT        DEFAULT ((0)) NULL,
    [Cilindradas]      INT        NULL,
    [Portas]           INT        NULL,
    [DataCriacao]      DATETIME   DEFAULT (getdate()) NOT NULL,
    [DataAlteracao]    DATETIME   DEFAULT (getdate()) NOT NULL,
    [UsuarioCriacao]   INT        DEFAULT ((0)) NULL,
    [UsuarioAlteracao] INT        DEFAULT ((0)) NULL,
    [Ativo]            BIT        DEFAULT ((1)) NULL,
    [Placa]            NCHAR (7)  NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
Go
CREATE TABLE [dbo].[Marca] (
    [Id]     INT        IDENTITY (1, 1) NOT NULL,
    [Codigo] INT        NULL,
    [Nome]   NCHAR (20) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

GO
CREATE TABLE [dbo].[Usuario] (
    [Id]               INT         IDENTITY (1, 1) NOT NULL,
    [Nome]             NCHAR (100) NOT NULL,
    [Login]            NCHAR (50)  NOT NULL,
    [Senha]            NCHAR (50)  NOT NULL,
    [Ativo]            BIT         DEFAULT ((1)) NULL,
    [DataCriacao]      DATE        DEFAULT (getdate()) NULL,
    [DataAlteracao]    DATETIME    DEFAULT (getdate()) NULL,
    [UsuarioCriacao]   INT         DEFAULT ((0)) NULL,
    [UsuarioAlteracao] INT         DEFAULT ((0)) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
Go
CREATE TABLE [dbo].[Locacao] (
    [Id]               INT      IDENTITY (1, 1) NOT NULL,
    [UsuarioId]        INT      NOT NULL,
    [CarroId]          INT      NOT NULL,
    [Valor]            MONEY    NOT NULL,
    [DataInicial]      DATETIME DEFAULT (getdate()) NULL,
    [DataDevolucao]    DATETIME DEFAULT (dateadd(day,(5),getdate())) NULL,
    [Ativo]            BIT      DEFAULT ((1)) NULL,
    [UsuarioCriacao]   INT      NULL,
    [UsuarioAlteracao] INT      NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
-- insere os Dados nas tabelas
insert into Usuario (Login,Senha) values ('admin','admin');
insert into Marca (Nome) values ('Fiat'), ('Chevrolet'), ('Toyota'),('Peugeot');

";
            a = a.Replace("[dbo].", "");
            a = a.Replace('[', ' ');
            a = a.Replace(']',' ');
           
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
