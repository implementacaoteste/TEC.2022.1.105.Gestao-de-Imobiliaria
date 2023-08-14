USE [master]
GO
/****** Object:  Database [Imobiliaria]    Script Date: 14/08/2023 15:22:50 ******/
CREATE DATABASE [Imobiliaria]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Imobiliaria', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Imobiliaria.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Imobiliaria_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Imobiliaria_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Imobiliaria] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Imobiliaria].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Imobiliaria] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Imobiliaria] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Imobiliaria] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Imobiliaria] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Imobiliaria] SET ARITHABORT OFF 
GO
ALTER DATABASE [Imobiliaria] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Imobiliaria] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Imobiliaria] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Imobiliaria] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Imobiliaria] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Imobiliaria] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Imobiliaria] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Imobiliaria] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Imobiliaria] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Imobiliaria] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Imobiliaria] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Imobiliaria] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Imobiliaria] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Imobiliaria] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Imobiliaria] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Imobiliaria] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Imobiliaria] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Imobiliaria] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Imobiliaria] SET  MULTI_USER 
GO
ALTER DATABASE [Imobiliaria] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Imobiliaria] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Imobiliaria] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Imobiliaria] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Imobiliaria] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Imobiliaria] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Imobiliaria] SET QUERY_STORE = OFF
GO
USE [Imobiliaria]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 14/08/2023 15:22:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
	[Renda] [varchar](100) NULL,
	[CPFConjuge] [varchar](100) NULL,
	[RGConjuge] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Corretores]    Script Date: 14/08/2023 15:22:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Corretores](
	[IDCorretor] [int] NOT NULL,
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
/****** Object:  Table [dbo].[Empreendimentos]    Script Date: 14/08/2023 15:22:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empreendimentos](
	[IDEmpreendimento] [int] NOT NULL,
	[TotalTerrenos] [int] NOT NULL,
	[CNPJEmpresaResponsavel] [varchar](20) NOT NULL,
	[TamanhoArea] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDEmpreendimento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GrupoUsuario]    Script Date: 14/08/2023 15:22:50 ******/
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
/****** Object:  Table [dbo].[Permissao]    Script Date: 14/08/2023 15:22:50 ******/
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
/****** Object:  Table [dbo].[PermissaoGrupoUsuario]    Script Date: 14/08/2023 15:22:50 ******/
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
/****** Object:  Table [dbo].[Reservas]    Script Date: 14/08/2023 15:22:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reservas](
	[IDReserva] [int] NOT NULL,
	[IDTerreno] [int] NOT NULL,
	[IDCorretor] [int] NOT NULL,
	[DataReserva] [date] NOT NULL,
	[PrazoRenovacao] [int] NOT NULL,
	[StatusReserva] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDReserva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Terrenos]    Script Date: 14/08/2023 15:22:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Terrenos](
	[IDTerreno] [int] NOT NULL,
	[IDEmpreendimento] [int] NOT NULL,
	[PrecoAVista] [float] NOT NULL,
	[PrecoParcelado] [float] NOT NULL,
	[MetragemFrente] [float] NOT NULL,
	[MetragemFundo] [float] NOT NULL,
	[TamanhoTotalTerreno] [float] NOT NULL,
	[ConfrontacoesTerreno] [varchar](100) NOT NULL,
	[Endereco] [varchar](100) NOT NULL,
	[NumeroMatricula] [varchar](100) NOT NULL,
	[MetragemEsquerda] [varchar](100) NULL,
	[MetragemDireita] [varchar](100) NULL,
	[RedeAgua] [varchar](100) NULL,
	[RedeEnergia] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[IDTerreno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 14/08/2023 15:22:50 ******/
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
/****** Object:  Table [dbo].[UsuarioGrupoUsuario]    Script Date: 14/08/2023 15:22:50 ******/
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
/****** Object:  Table [dbo].[Vendas]    Script Date: 14/08/2023 15:22:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vendas](
	[IDVenda] [int] NOT NULL,
	[IDTerreno] [int] NOT NULL,
	[IDCliente] [int] NOT NULL,
	[IDCorretor] [int] NOT NULL,
	[DataVenda] [date] NOT NULL,
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
USE [master]
GO
ALTER DATABASE [Imobiliaria] SET  READ_WRITE 
GO
