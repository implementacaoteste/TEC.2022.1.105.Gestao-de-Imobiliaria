USE master
GO

ALTER DATABASE Imobiliaria SET  SINGLE_USER WITH ROLLBACK IMMEDIATE
GO

DROP DATABASE Imobiliaria
GO

CREATE DATABASE Imobiliaria
GO

USE Imobiliaria
GO

CREATE TABLE [dbo].[Cliente](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](150) NULL,
	[CPF] [varchar](15) NULL,
	[RG] [varchar](15) NULL,
	[Email] [varchar](200) NULL,
	[Fone] [varchar](15) NULL,
	[Endereco] [varchar](200) NULL,
	[EstadoCivil] [varchar](100) NULL,
	[Renda] [float] NULL,
	[CPFConjuge] [varchar](100) NULL,
	[RGConjuge] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Corretores]    Script Date: 26/09/2023 20:36:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Corretores](
	[IDCorretor] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](100) NOT NULL,
	[CRECI] [varchar](20) NOT NULL,
	[Endereco] [varchar](200) NULL,
	[RG] [varchar](20) NULL,
	[CPF] [varchar](20) NULL,
	[Fone] [varchar](20) NULL,
	[Email] [varchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[IDCorretor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empreendimentos]    Script Date: 26/09/2023 20:36:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empreendimentos](
	[IDEmpreendimento] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](200) NOT NULL,
	[CNPJEmpresaResponsavel] [varchar](20) NOT NULL,
	
PRIMARY KEY CLUSTERED 
(
	[IDEmpreendimento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GrupoUsuario]    Script Date: 26/09/2023 20:36:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GrupoUsuario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NomeGrupo] [varchar](150) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permissao]    Script Date: 26/09/2023 20:36:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permissao](
	[Id] [int] NOT NULL,
	[Descricao] [varchar](250) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PermissaoGrupoUsuario]    Script Date: 26/09/2023 20:36:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PermissaoGrupoUsuario](
	[IdPermissao] [int] NOT NULL,
	[IdGrupoUsuario] [int] NOT NULL,
 CONSTRAINT [PK_PermissaoGrupoUsuario] PRIMARY KEY CLUSTERED 
(
	[IdPermissao] ASC,
	[IdGrupoUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reservas]    Script Date: 26/09/2023 20:36:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reservas](
	[IDReserva] [int] IDENTITY(1,1) NOT NULL,
	[IDTerreno] [int] NOT NULL,
	[IDCorretor] [int] NOT NULL,
	[DataReserva] [date] NOT NULL,
	[Prazo] [date] NOT NULL,
	[StatusReserva] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDReserva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Status_Terrenos]    Script Date: 26/09/2023 20:36:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Status_Terrenos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Status_Atual] [varchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Terrenos]    Script Date: 26/09/2023 20:36:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Terrenos](
	[IDTerreno] [int] IDENTITY(1,1) NOT NULL,
	[IDEmpreendimento] [int] NOT NULL,
	[PrecoAVista] [float] NOT NULL,
	[PrecoParcelado] [float] NOT NULL,
	[MetragemFrente] [float] NOT NULL,
	[MetragemFundo] [float] NOT NULL,
	[TamanhoTotalTerreno] [float] NOT NULL,
	[Endereco] [varchar](100) NOT NULL,
	[NumeroMatricula] [varchar](100) NOT NULL,
	[MetragemEsquerda] [varchar](100) NULL,
	[MetragemDireita] [varchar](100) NULL,
	[RedeAgua] [bit] NULL,
	[RedeEnergia] [bit] NULL,
	[Esquina] [varchar](15) NULL,
	[IdStatus_Terrenos] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDTerreno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 26/09/2023 20:36:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](150) NULL,
	[NomeUsuario] [varchar](50) NULL,
	[Email] [varchar](150) NULL,
	[CPF] [varchar](15) NULL,
	[Ativo] [bit] NULL,
	[Senha] [varchar](50) NULL,
	[DataCadastro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsuarioGrupoUsuario]    Script Date: 26/09/2023 20:36:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsuarioGrupoUsuario](
	[IdUsuario] [int] NOT NULL,
	[IdGrupoUsuario] [int] NOT NULL,
 CONSTRAINT [PK_UsuarioGrupoUsuario] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC,
	[IdGrupoUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vendas]    Script Date: 26/09/2023 20:36:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vendas](
	[IDVenda] [int] IDENTITY(1,1) NOT NULL,
	[IDTerreno] [int] NOT NULL,
	[IDCliente] [int] NOT NULL,
	[IDCorretor] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDVenda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Usuario] ADD  DEFAULT (getdate()) FOR [DataCadastro]
GO
ALTER TABLE [dbo].[PermissaoGrupoUsuario]  WITH CHECK ADD  CONSTRAINT [FK_PermissaoGrupoUsuario_GrupoUsuario] FOREIGN KEY([IdGrupoUsuario])
REFERENCES [dbo].[GrupoUsuario] ([Id])
GO
ALTER TABLE [dbo].[PermissaoGrupoUsuario] CHECK CONSTRAINT [FK_PermissaoGrupoUsuario_GrupoUsuario]
GO
ALTER TABLE [dbo].[PermissaoGrupoUsuario]  WITH CHECK ADD  CONSTRAINT [FK_PermissaoGrupoUsuario_Permissao] FOREIGN KEY([IdPermissao])
REFERENCES [dbo].[Permissao] ([Id])
GO
ALTER TABLE [dbo].[PermissaoGrupoUsuario] CHECK CONSTRAINT [FK_PermissaoGrupoUsuario_Permissao]
GO
ALTER TABLE [dbo].[Reservas]  WITH CHECK ADD  CONSTRAINT [FK_Reservas_Corretores] FOREIGN KEY([IDCorretor])
REFERENCES [dbo].[Corretores] ([IDCorretor])
GO
ALTER TABLE [dbo].[Reservas] CHECK CONSTRAINT [FK_Reservas_Corretores]
GO
ALTER TABLE [dbo].[Reservas]  WITH CHECK ADD  CONSTRAINT [FK_Reservas_Terrenos] FOREIGN KEY([IDTerreno])
REFERENCES [dbo].[Terrenos] ([IDTerreno])
GO
ALTER TABLE [dbo].[Reservas] CHECK CONSTRAINT [FK_Reservas_Terrenos]
GO
ALTER TABLE [dbo].[Terrenos]  WITH CHECK ADD  CONSTRAINT [FK_Terrenos_Empreendimentos] FOREIGN KEY([IDEmpreendimento])
REFERENCES [dbo].[Empreendimentos] ([IDEmpreendimento])
GO
ALTER TABLE [dbo].[Terrenos] CHECK CONSTRAINT [FK_Terrenos_Empreendimentos]
GO
ALTER TABLE [dbo].[Terrenos]  WITH CHECK ADD  CONSTRAINT [FK_Terrenos_StatusTerrenos] FOREIGN KEY([IdStatus_Terrenos])
REFERENCES [dbo].[Status_Terrenos] ([Id])
GO
ALTER TABLE [dbo].[Terrenos] CHECK CONSTRAINT [FK_Terrenos_StatusTerrenos]
GO
ALTER TABLE [dbo].[UsuarioGrupoUsuario]  WITH CHECK ADD  CONSTRAINT [FK_UsuarioGrupoUsuario_GrupoUsuario] FOREIGN KEY([IdGrupoUsuario])
REFERENCES [dbo].[GrupoUsuario] ([Id])
GO
ALTER TABLE [dbo].[UsuarioGrupoUsuario] CHECK CONSTRAINT [FK_UsuarioGrupoUsuario_GrupoUsuario]
GO
ALTER TABLE [dbo].[UsuarioGrupoUsuario]  WITH CHECK ADD  CONSTRAINT [FK_UsuarioGrupoUsuario_Usuario] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuario] ([Id])
GO
ALTER TABLE [dbo].[UsuarioGrupoUsuario] CHECK CONSTRAINT [FK_UsuarioGrupoUsuario_Usuario]
GO
ALTER TABLE [dbo].[Vendas]  WITH CHECK ADD  CONSTRAINT [FK_Venda_Cliente] FOREIGN KEY([IDCliente])
REFERENCES [dbo].[Cliente] ([Id])
GO
ALTER TABLE [dbo].[Vendas] CHECK CONSTRAINT [FK_Venda_Cliente]
GO
ALTER TABLE [dbo].[Vendas]  WITH CHECK ADD  CONSTRAINT [FK_Vendas_Corretores] FOREIGN KEY([IDCorretor])
REFERENCES [dbo].[Corretores] ([IDCorretor])
GO
ALTER TABLE [dbo].[Vendas] CHECK CONSTRAINT [FK_Vendas_Corretores]
GO
ALTER TABLE [dbo].[Vendas]  WITH CHECK ADD  CONSTRAINT [FK_Vendas_Terrenos] FOREIGN KEY([IDTerreno])
REFERENCES [dbo].[Terrenos] ([IDTerreno])
GO
ALTER TABLE [dbo].[Vendas] CHECK CONSTRAINT [FK_Vendas_Terrenos]
GO

USE [Imobiliaria]
GO
ALTER DATABASE [Imobiliaria] SET  READ_WRITE 
GO


IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 1))INSERT INTO Permissao(Id, Descricao)VALUES(1,'Visualizar usuário')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 2))INSERT INTO Permissao(Id, Descricao)VALUES(2,'Visualizar cliente')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 3))INSERT INTO Permissao(Id, Descricao)VALUES(3,'Visualizar corretor')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 4))INSERT INTO Permissao(Id, Descricao)VALUES(4,'Visualizar empreendimento')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 5))INSERT INTO Permissao(Id, Descricao)VALUES(5,'Visualizar terreno')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 6))INSERT INTO Permissao(Id, Descricao)VALUES(6,'Visualizar venda')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 7))INSERT INTO Permissao(Id, Descricao)VALUES(7,'Visualizar reserva')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 8))INSERT INTO Permissao(Id, Descricao)VALUES(8,'Cadastrar usuário')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 9))INSERT INTO Permissao(Id, Descricao)VALUES(9,'Cadastrar cliente')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 10))INSERT INTO Permissao(Id, Descricao)VALUES(10,'Cadastrar corretor')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 11))INSERT INTO Permissao(Id, Descricao)VALUES(11,'Cadastrar empreendimento')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 12))INSERT INTO Permissao(Id, Descricao)VALUES(12,'Cadastrar terreno')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 13))INSERT INTO Permissao(Id, Descricao)VALUES(13,'Cadastrar venda')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 14))INSERT INTO Permissao(Id, Descricao)VALUES(14,'Cadastrar reserva')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 15))INSERT INTO Permissao(Id, Descricao)VALUES(15,'Alterar usuário')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 16))INSERT INTO Permissao(Id, Descricao)VALUES(16,'Alterar cliente')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 17))INSERT INTO Permissao(Id, Descricao)VALUES(17,'Alterar corretor')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 18))INSERT INTO Permissao(Id, Descricao)VALUES(18,'Alterar empreendimento')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 19))INSERT INTO Permissao(Id, Descricao)VALUES(19,'Alterar terreno')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 20))INSERT INTO Permissao(Id, Descricao)VALUES(20,'Alterar venda')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 21))INSERT INTO Permissao(Id, Descricao)VALUES(21,'Alterar reserva')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 22))INSERT INTO Permissao(Id, Descricao)VALUES(22,'Excluir usuário')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 23))INSERT INTO Permissao(Id, Descricao)VALUES(23,'Excluir cliente')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 24))INSERT INTO Permissao(Id, Descricao)VALUES(24,'Excluir corretor')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 25))INSERT INTO Permissao(Id, Descricao)VALUES(25,'Excluir empreedimento')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 26))INSERT INTO Permissao(Id, Descricao)VALUES(26,'Excluir terreno')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 27))INSERT INTO Permissao(Id, Descricao)VALUES(27,'Excluir venda')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 28))INSERT INTO Permissao(Id, Descricao)VALUES(28,'Excluir reserva')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 29))INSERT INTO Permissao(Id, Descricao)VALUES(29,'Visualizar grupo de usuário')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 30))INSERT INTO Permissao(Id, Descricao)VALUES(30,'Cadastrar grupo de usuário')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 31))INSERT INTO Permissao(Id, Descricao)VALUES(31,'Alterar grupo de usuário')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 32))INSERT INTO Permissao(Id, Descricao)VALUES(32,'Excluir grupo de usuário')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 33))INSERT INTO Permissao(Id, Descricao)VALUES(33,'Adicionar permissão a um grupo de usuário')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 34))INSERT INTO Permissao(Id, Descricao)VALUES(34,'Remover permissão de um grupo de usuário')
GO

IF(NOT EXISTS(SELECT 1 FROM Usuario WHERE NomeUsuario = 'Administrador'))INSERT INTO Usuario(Nome, NomeUsuario, Senha, Ativo)VALUES('Administrador ', 'Administrador', '123', 1)
GO

INSERT INTO GrupoUsuario(NomeGrupo)VALUES('Administrador')



GO
INSERT INTO UsuarioGrupoUsuario VALUES(1,1)
GO

INSERT INTO PermissaoGrupoUsuario(IdGrupoUsuario, IdPermissao) VALUES(1,1)
INSERT INTO PermissaoGrupoUsuario(IdGrupoUsuario, IdPermissao) VALUES(1,2)
INSERT INTO PermissaoGrupoUsuario(IdGrupoUsuario, IdPermissao) VALUES(1,3)
INSERT INTO PermissaoGrupoUsuario(IdGrupoUsuario, IdPermissao) VALUES(1,4)
INSERT INTO PermissaoGrupoUsuario(IdGrupoUsuario, IdPermissao) VALUES(1,5)
INSERT INTO PermissaoGrupoUsuario(IdGrupoUsuario, IdPermissao) VALUES(1,6)
INSERT INTO PermissaoGrupoUsuario(IdGrupoUsuario, IdPermissao) VALUES(1,7)
INSERT INTO PermissaoGrupoUsuario (IdGrupoUsuario, IdPermissao)VALUES(1,8)
INSERT INTO PermissaoGrupoUsuario (IdGrupoUsuario, IdPermissao)VALUES(1,9)
INSERT INTO PermissaoGrupoUsuario (IdGrupoUsuario, IdPermissao)VALUES(1,10)
INSERT INTO PermissaoGrupoUsuario(IdGrupoUsuario, IdPermissao) VALUES(1,11)
INSERT INTO PermissaoGrupoUsuario(IdGrupoUsuario, IdPermissao) VALUES(1,12)
INSERT INTO PermissaoGrupoUsuario(IdGrupoUsuario, IdPermissao) VALUES(1,13)
INSERT INTO PermissaoGrupoUsuario(IdGrupoUsuario, IdPermissao) VALUES(1,14)
INSERT INTO PermissaoGrupoUsuario(IdGrupoUsuario, IdPermissao) VALUES(1,15)
INSERT INTO PermissaoGrupoUsuario(IdGrupoUsuario, IdPermissao) VALUES(1,16)
INSERT INTO PermissaoGrupoUsuario(IdGrupoUsuario, IdPermissao) VALUES(1,17)
INSERT INTO PermissaoGrupoUsuario (IdGrupoUsuario, IdPermissao)VALUES(1,18)
INSERT INTO PermissaoGrupoUsuario (IdGrupoUsuario, IdPermissao)VALUES(1,19)
INSERT INTO PermissaoGrupoUsuario (IdGrupoUsuario, IdPermissao)VALUES(1,20)
INSERT INTO PermissaoGrupoUsuario(IdGrupoUsuario, IdPermissao) VALUES(1,21)
INSERT INTO PermissaoGrupoUsuario(IdGrupoUsuario, IdPermissao) VALUES(1,22)
INSERT INTO PermissaoGrupoUsuario(IdGrupoUsuario, IdPermissao) VALUES(1,23)
INSERT INTO PermissaoGrupoUsuario(IdGrupoUsuario, IdPermissao) VALUES(1,24)
INSERT INTO PermissaoGrupoUsuario(IdGrupoUsuario, IdPermissao) VALUES(1,25)
INSERT INTO PermissaoGrupoUsuario(IdGrupoUsuario, IdPermissao) VALUES(1,26)
INSERT INTO PermissaoGrupoUsuario(IdGrupoUsuario, IdPermissao) VALUES(1,27)
INSERT INTO PermissaoGrupoUsuario (IdGrupoUsuario, IdPermissao)VALUES(1,28)
INSERT INTO PermissaoGrupoUsuario (IdGrupoUsuario, IdPermissao)VALUES(1,29)
INSERT INTO PermissaoGrupoUsuario (IdGrupoUsuario, IdPermissao)VALUES(1,30)
INSERT INTO PermissaoGrupoUsuario(IdGrupoUsuario, IdPermissao) VALUES(1,31)
INSERT INTO PermissaoGrupoUsuario (IdGrupoUsuario, IdPermissao)VALUES(1,32)
INSERT INTO PermissaoGrupoUsuario (IdGrupoUsuario, IdPermissao)VALUES(1,33)
INSERT INTO PermissaoGrupoUsuario (IdGrupoUsuario, IdPermissao)VALUES(1,34)
 
 go

Insert into Cliente (Nome, CPF, RG, Email, Fone, Endereco, EstadoCivil, Renda, CPFConjuge, RGConjuge ) 
Values ('Nalberth', '3333333','4444444','nalberth@gmail.com','40028922', 'Rua 321', 'Solteiro', 1200, NULL, NULL);


go 

Insert into Corretores (Nome, CRECI,  Endereco, RG, CPF, Fone, Email)
Values('Lucas','5555555','Rua Ipiranga N° 123', '55555555555', '40028922','1111111111', 'lucas@gmail.com') 

go

Insert into Usuario (Nome, NomeUsuario, Email, CPF, Ativo, Senha)
Values ('Cristiano Ramos Ribeiro Júnior', 'Júnior', 'cristiano@gmail.com', '1111111', 1, '1234')

go

Insert into Empreendimentos (Nome, CNPJEmpresaResponsavel)
Values ('Járdim américa', '1111111')
Insert into Empreendimentos (Nome, CNPJEmpresaResponsavel )
Values ('Gless', '2222222')


go

Insert into Terrenos (IDEmpreendimento, PrecoAVista, PrecoParcelado, MetragemFrente, MetragemFundo, TamanhoTotalTerreno, Endereco, NumeroMatricula, MetragemEsquerda, MetragemDireita, RedeAgua, RedeEnergia, Esquina)
Values (1, 28000, 500, 25, 25, 1500, 'Rua Ipiranga', '1111111', '30', '30', 1, 0, '2')
Insert into Terrenos (IDEmpreendimento, PrecoAVista, PrecoParcelado, MetragemFrente, MetragemFundo, TamanhoTotalTerreno, Endereco, NumeroMatricula, MetragemEsquerda, MetragemDireita, RedeAgua, RedeEnergia, Esquina)
Values (1, 30000, 500, 20, 20, 1200, 'Rua Caxias', '2222222', '30', '30', 1, 0, '4')
Insert into Terrenos (IDEmpreendimento, PrecoAVista, PrecoParcelado, MetragemFrente, MetragemFundo, TamanhoTotalTerreno, Endereco, NumeroMatricula, MetragemEsquerda, MetragemDireita, RedeAgua, RedeEnergia, Esquina)
Values (2, 35000, 500, 30, 30, 2400, 'Rua Tira Dentes', '3333333', '40', '40', 1, 0, '6')
Insert into Terrenos (IDEmpreendimento, PrecoAVista, PrecoParcelado, MetragemFrente, MetragemFundo, TamanhoTotalTerreno, Endereco, NumeroMatricula, MetragemEsquerda, MetragemDireita, RedeAgua, RedeEnergia, Esquina)
Values (2, 36000, 500, 40, 40, 4000, 'Rua Principal', '4444444', '50', '50', 1, 0, '8')

go
insert into Status_Terrenos(Status_Atual)values('Disponível')
insert into Status_Terrenos(Status_Atual)values('Vendido')
insert into Status_Terrenos(Status_Atual)values('Reservado')


update Terrenos set idstatus_terrenos=1
update Terrenos set idstatus_terrenos=3 where IDTerreno = 3;
update Terrenos set idstatus_terrenos=2 where IDTerreno = 4;




Insert into Vendas ( IDCliente, IDCorretor, IDTerreno) Values (1,1,4);



Insert into Reservas(IDCorretor, IDTerreno, StatusReserva, DataReserva, Prazo)Values(1,3,'Reservado','2023-10-24','2023-10-27')
