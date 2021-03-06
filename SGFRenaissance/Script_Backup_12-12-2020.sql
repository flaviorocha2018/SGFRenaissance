USE [SGFRenaissance]
GO
/****** Object:  Table [dbo].[Baixa_Titulos_a_Pagar_Pagamentos]    Script Date: 12/12/2020 11:30:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Baixa_Titulos_a_Pagar_Pagamentos](
	[Cod_Baixa_Titulos_a_Pagar] [int] IDENTITY(1,1) NOT NULL,
	[Data_Pagamento] [datetime] NULL,
	[Cod_Banco_Debitado] [int] NULL,
	[Numero_Cheque] [varchar](15) NULL,
	[Total_Pago] [decimal](18, 0) NULL,
	[Numero_Titulos_Pagos] [numeric](3, 0) NULL,
	[Historico_Pagamentos] [varchar](100) NULL,
	[Observacao] [varchar](100) NULL,
	[Data_Login] [datetime] NULL,
	[Login_Name] [varchar](15) NULL,
 CONSTRAINT [PK_Baixa_Titulos_a_Pagar_Pagamentos] PRIMARY KEY CLUSTERED 
(
	[Cod_Baixa_Titulos_a_Pagar] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Baixa_Titulos_a_Receber]    Script Date: 12/12/2020 11:30:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Baixa_Titulos_a_Receber](
	[Cod_Baixa_Titulo_Recebido] [int] IDENTITY(1,1) NOT NULL,
	[Cod_Cliente] [int] NULL,
	[Numero_NF] [varchar](20) NULL,
	[Data_Pagamento] [datetime] NULL,
	[Valor_NF] [float] NULL,
	[Acrescimos] [float] NULL,
	[Descontos] [float] NULL,
	[Total_Pago] [float] NULL,
	[Creditar_Banco] [int] NULL,
	[Historico] [varchar](100) NULL,
	[Cod_Receita] [int] NULL,
	[Numero_Parcela] [numeric](3, 0) NULL,
	[Data_Login] [datetime] NULL,
	[Login_Name] [varchar](15) NULL,
 CONSTRAINT [PK_Baixa_Titulos_a_Receber] PRIMARY KEY CLUSTERED 
(
	[Cod_Baixa_Titulo_Recebido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Bancos]    Script Date: 12/12/2020 11:30:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Bancos](
	[Cod_Banco] [int] IDENTITY(1,1) NOT NULL,
	[Nome_Banco] [varchar](50) NULL,
	[Numero_Conta] [varchar](20) NULL,
	[Agencia] [varchar](20) NULL,
	[Numero_Banco] [numeric](6, 0) NULL,
	[Saldo] [decimal](18, 2) NULL,
	[Endereco] [varchar](50) NULL,
	[Bairro] [varchar](50) NULL,
	[Municipio] [varchar](50) NULL,
	[Estado] [varchar](2) NULL,
	[Telefone_1] [varchar](15) NULL,
	[Telefone_2] [varchar](15) NULL,
	[Contato] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[data_cadastro] [datetime] NULL,
	[Data_Login] [datetime] NULL,
	[Login_Name] [varchar](15) NULL,
 CONSTRAINT [PK_Bancos_1] PRIMARY KEY CLUSTERED 
(
	[Cod_Banco] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Base_Parcelas_Pagas]    Script Date: 12/12/2020 11:30:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Base_Parcelas_Pagas](
	[Cod_Base_Titulos_Pagos] [int] NOT NULL,
	[Cod_Titulo_a_Pagar] [int] NOT NULL,
	[Cod_Numero_Parc_a_Pagar] [int] NOT NULL,
	[Cod_Fornecedor] [int] NULL,
	[Numero_Documento] [varchar](50) NULL,
	[Numero_Parcela] [int] NULL,
	[Valor_Titulo] [decimal](18, 2) NULL,
	[Data_Documento] [datetime] NULL,
	[Data_Pagamento] [datetime] NULL,
	[Data_Venc_Parcela] [datetime] NULL,
	[Cod_Centro_Custos] [int] NULL,
	[Cod_Despesa] [int] NULL,
	[Valor_Pago_a_Vista] [decimal](18, 2) NULL,
	[Valor_Pago] [decimal](18, 2) NULL,
	[Numero_banco] [int] NULL,
	[Numero_cheque] [varchar](25) NULL,
	[Acrescimos] [decimal](18, 2) NULL,
	[Descontos] [decimal](18, 2) NULL,
	[Saldo] [decimal](18, 2) NULL,
	[StatusTitulo] [int] NULL,
	[Historico] [varchar](200) NULL,
	[Historico_Titulo] [varchar](200) NULL,
 CONSTRAINT [PK_Base_Parcelas_Pagas] PRIMARY KEY CLUSTERED 
(
	[Cod_Numero_Parc_a_Pagar] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Base_Parcelas_Recebidas]    Script Date: 12/12/2020 11:30:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Base_Parcelas_Recebidas](
	[Cod_Base_Titulos_a_Recebidos] [int] NOT NULL,
	[Cod_Entrada_Titulos_a_Receber] [int] NOT NULL,
	[Cod_Numero_Parcelas_Receber] [int] NOT NULL,
	[Cod_Cliente] [int] NULL,
	[Numero_Documento] [varchar](50) NULL,
	[Numero_Parcela] [int] NULL,
	[Valor_Titulo] [decimal](18, 2) NULL,
	[Valor_Pago_a_Vista] [decimal](18, 2) NULL,
	[Data_Documento] [datetime] NULL,
	[Data_Recebimento] [datetime] NULL,
	[Data_Venc_Parcela] [datetime] NULL,
	[Numero_Banco] [int] NULL,
	[Cod_Receita] [int] NULL,
	[Valor_Recebido] [decimal](18, 2) NULL,
	[Acrescimos] [decimal](18, 2) NULL,
	[Desconto] [decimal](18, 2) NULL,
	[Saldo] [decimal](18, 2) NULL,
	[Status_Titulo_a_Receber] [int] NULL,
	[Historico_Titulo] [varchar](200) NULL,
	[Historico_Parcela] [varchar](200) NULL,
 CONSTRAINT [PK_Base_Parcelas_Recebidas] PRIMARY KEY CLUSTERED 
(
	[Cod_Numero_Parcelas_Receber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Base_Titulos_Pagos]    Script Date: 12/12/2020 11:30:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Base_Titulos_Pagos](
	[Cod_Base_Titulos_Pagos] [int] IDENTITY(1,1) NOT NULL,
	[Data_Pagamento] [datetime] NULL,
	[Total_Pago] [decimal](18, 2) NULL,
	[Banco_Debitado] [int] NULL,
	[Numero_Cheque] [varchar](15) NULL,
	[Historico] [varchar](250) NULL,
	[Data_Login] [datetime] NULL,
	[Login_Name] [varchar](15) NULL,
 CONSTRAINT [PK_Base_Titulos_Pagos_1] PRIMARY KEY CLUSTERED 
(
	[Cod_Base_Titulos_Pagos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Base_Titulos_Recebidos]    Script Date: 12/12/2020 11:30:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Base_Titulos_Recebidos](
	[Cod_Base_Titulos_a_Recebidos] [int] IDENTITY(1,1) NOT NULL,
	[Data_Recebimento] [datetime] NULL,
	[Total_Recebido] [decimal](18, 2) NULL,
	[Banco_Creditado] [int] NULL,
	[Historico] [varchar](200) NULL,
	[NumeroNF] [nvarchar](25) NULL,
	[Data_Login] [datetime] NULL,
	[Login_Name] [varchar](15) NULL,
 CONSTRAINT [PK_Base_Titulos_Recebidos] PRIMARY KEY CLUSTERED 
(
	[Cod_Base_Titulos_a_Recebidos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Centro_Custos]    Script Date: 12/12/2020 11:30:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Centro_Custos](
	[Cod_Centro_Custos] [int] IDENTITY(1,1) NOT NULL,
	[Descricao_Centro_Custos] [varchar](50) NULL,
	[Data_Login] [datetime] NULL,
	[Login_Name] [varchar](15) NULL,
 CONSTRAINT [PK_Centro_Custos] PRIMARY KEY CLUSTERED 
(
	[Cod_Centro_Custos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Clientes_Contas_a_Receber]    Script Date: 12/12/2020 11:30:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Clientes_Contas_a_Receber](
	[Cod_Cliente_Contas_a_Receber] [int] IDENTITY(1,1) NOT NULL,
	[Nome_Cliente] [varchar](50) NULL,
	[Endereço_Cliente] [varchar](50) NULL,
	[Bairro_Cliente] [varchar](50) NULL,
	[Municipio_Cliente] [varchar](50) NULL,
	[Estado] [varchar](2) NULL,
	[Telefone] [varchar](15) NULL,
	[Celular] [varchar](15) NULL,
	[Email] [varchar](50) NULL,
	[CNPJ] [varchar](18) NULL,
	[Identificacao] [varchar](25) NULL,
	[Status] [int] NULL,
	[Data_Login] [datetime] NULL,
	[Login_Name] [varchar](15) NULL,
	[Cod_Grupo] [int] NULL,
 CONSTRAINT [PK_Clientes_Contas_a_Receber] PRIMARY KEY CLUSTERED 
(
	[Cod_Cliente_Contas_a_Receber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Contas_Despesas]    Script Date: 12/12/2020 11:30:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Contas_Despesas](
	[Cod_Despesa] [int] IDENTITY(1,1) NOT NULL,
	[Descricao_Despesa] [varchar](50) NULL,
	[Codigo_Despesa_Contab] [numeric](12, 0) NULL,
	[Tipo_Despesa] [varchar](50) NULL,
	[Data_Login] [datetime] NULL,
	[Login_Name] [varchar](15) NULL,
 CONSTRAINT [PK_Contas_Despesas] PRIMARY KEY CLUSTERED 
(
	[Cod_Despesa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Entrada_Titulos_a_Pagar]    Script Date: 12/12/2020 11:30:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Entrada_Titulos_a_Pagar](
	[Cod_Entrada_Titulos_a_Pagar] [int] IDENTITY(1,1) NOT NULL,
	[Cod_Fornecedor] [int] NULL,
	[Numero_Documento] [varchar](50) NULL,
	[Data_Documento] [datetime] NULL,
	[Data_Vencimento] [datetime] NULL,
	[Valor_Titulo] [decimal](18, 2) NULL,
	[Valor_Pago_a_Vista] [decimal](18, 2) NULL,
	[Acrescimos] [decimal](18, 2) NULL,
	[Descontos] [decimal](18, 2) NULL,
	[Saldo] [decimal](18, 2) NULL,
	[Numero_Parcelas] [int] NULL,
	[Cod_Centro_Custos] [int] NULL,
	[Cod_Status_Titulo] [int] NULL,
	[Cod_Despesa] [int] NULL,
	[Historico_Titulo] [varchar](200) NULL,
	[Observacao] [varchar](100) NULL,
	[Data_Login] [datetime] NULL,
	[Login_Name] [varchar](15) NULL,
 CONSTRAINT [PK_Entrada_Titulos_a_Pagar] PRIMARY KEY CLUSTERED 
(
	[Cod_Entrada_Titulos_a_Pagar] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Entrada_Titulos_a_Receber]    Script Date: 12/12/2020 11:30:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Entrada_Titulos_a_Receber](
	[Cod_Entrada_Titulos_a_Receber] [int] IDENTITY(1,1) NOT NULL,
	[Cod_Cliente] [int] NULL,
	[Numero_NF] [varchar](20) NULL,
	[Data_NF] [datetime] NULL,
	[Valor_NF] [decimal](18, 2) NULL,
	[Cod_Receita] [int] NULL,
	[Data_Vencimento] [datetime] NULL,
	[Numero_Parcelas] [numeric](3, 0) NULL,
	[Valor_Pago_a_Vista] [decimal](18, 2) NULL,
	[Cod_Status_Titulo] [int] NULL,
	[Codigo_CV] [int] NULL,
	[Historico] [varchar](200) NULL,
	[Data_Login] [datetime] NULL,
	[Login_Name] [varchar](15) NULL,
 CONSTRAINT [PK_Entrada_Titulos_a_Receber] PRIMARY KEY CLUSTERED 
(
	[Cod_Entrada_Titulos_a_Receber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Fornecedor_Contas_a_Pagar]    Script Date: 12/12/2020 11:30:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Fornecedor_Contas_a_Pagar](
	[Cod_Fornecedor] [int] IDENTITY(1,1) NOT NULL,
	[Nome_Fornecedor] [varchar](50) NULL,
	[Endereco] [varchar](50) NULL,
	[Bairro] [varchar](50) NULL,
	[Cidade] [varchar](50) NULL,
	[Estado] [nchar](2) NULL,
	[CEP] [nchar](10) NULL,
	[Telefone_1] [varchar](15) NULL,
	[Telefone_2] [varchar](15) NULL,
	[Celular] [varchar](15) NULL,
	[Email] [varchar](50) NULL,
	[CNPJ] [varchar](18) NULL,
	[Cod_Status_Fornecedor] [int] NULL,
	[Data_Cadastro] [datetime] NULL,
	[Inscricao_Estadual] [varchar](18) NULL,
	[CPF] [varchar](14) NULL,
	[Identificacao] [varchar](25) NULL,
	[Data_Login] [datetime] NULL,
	[Login_Name] [varchar](15) NULL,
 CONSTRAINT [PK_Fornecedor_Contas_a_Pagar] PRIMARY KEY CLUSTERED 
(
	[Cod_Fornecedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Grupo]    Script Date: 12/12/2020 11:30:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Grupo](
	[Cod_Grupo] [int] IDENTITY(1,1) NOT NULL,
	[Grupo_Descricao] [varchar](20) NULL,
	[Data_Login] [datetime] NULL,
	[Login_Name] [varchar](15) NULL,
 CONSTRAINT [PK_Grupo] PRIMARY KEY CLUSTERED 
(
	[Cod_Grupo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Itens_Pgtos_Baixa_Titulos_a_Pagar]    Script Date: 12/12/2020 11:30:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Itens_Pgtos_Baixa_Titulos_a_Pagar](
	[Cod_Baixa_Titulos_a_Pagar] [int] IDENTITY(1,1) NOT NULL,
	[Cod_Itens_Titulos_a_Pagar] [int] NOT NULL,
	[Cod_Fornecedor] [int] NULL,
	[Documento] [varchar](20) NULL,
	[Data_Pagamento] [datetime] NULL,
	[Valor_Titulo] [decimal](18, 0) NULL,
	[Acrescimos] [decimal](18, 0) NULL,
	[Descontos] [decimal](18, 0) NULL,
	[Total_Pago] [decimal](18, 0) NULL,
	[Historico_Titulo] [varchar](100) NULL,
	[Cod_Status_Titulo] [int] NULL,
	[Numero_Parcela] [numeric](3, 0) NULL,
	[Data_Vencimento] [datetime] NULL,
 CONSTRAINT [PK_Itens_Pgtos_Baixa_Titulos_a_Pagar] PRIMARY KEY CLUSTERED 
(
	[Cod_Baixa_Titulos_a_Pagar] ASC,
	[Cod_Itens_Titulos_a_Pagar] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Lancamentos]    Script Date: 12/12/2020 11:30:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Lancamentos](
	[Cod_Lancamento] [int] IDENTITY(1,1) NOT NULL,
	[Cod_Operacao] [int] NULL,
	[Cod_Base_Tit_Pagos] [int] NULL,
	[Cod_Base_Tit_Recebidos] [int] NULL,
	[Cod_Banco] [int] NULL,
	[Numero_Conta] [varchar](15) NULL,
	[Numero_Chque] [varchar](20) NULL,
	[Data_Lancamento] [datetime] NULL,
	[Descricao_Operacao] [varchar](250) NULL,
	[Recebimento_Titulos] [decimal](18, 2) NULL,
	[Pagamento_Titulos] [decimal](18, 2) NULL,
	[Valor_Movimento] [decimal](18, 2) NULL,
	[Saldo_Anterior] [decimal](18, 2) NULL,
	[Saldo] [decimal](18, 2) NULL,
	[Data_Login] [datetime] NULL,
	[Login_Name] [varchar](15) NULL,
 CONSTRAINT [PK_Lancamentos] PRIMARY KEY CLUSTERED 
(
	[Cod_Lancamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Numero_Parcelas_a_Pagar]    Script Date: 12/12/2020 11:30:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Numero_Parcelas_a_Pagar](
	[Cod_Numero_Parcelas_a_Pagar] [int] IDENTITY(1,1) NOT NULL,
	[Cod_Entrada_Titulos_a_Pagar] [int] NULL,
	[Numero_Parcela] [numeric](3, 0) NULL,
	[Data_Vencimento] [datetime] NULL,
	[Valor_Parcela] [decimal](18, 2) NULL,
	[Historico] [varchar](200) NULL,
	[Cod_Status_Titulo] [int] NULL,
 CONSTRAINT [PK_Numero_Parcelas_a_Pagar_1] PRIMARY KEY CLUSTERED 
(
	[Cod_Numero_Parcelas_a_Pagar] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Numero_Parcelas_a_Receber]    Script Date: 12/12/2020 11:30:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Numero_Parcelas_a_Receber](
	[Cod_Numero_Parcelas_Receber] [int] IDENTITY(1,1) NOT NULL,
	[Cod_Entrada_Titulos_a_Receber] [int] NOT NULL,
	[Numero_Parcela] [int] NULL,
	[Data_Vencimento] [date] NULL,
	[Valor_Parcela] [decimal](18, 2) NULL,
	[Historico] [varchar](200) NULL,
	[Cod_Status_Titulo] [int] NULL,
 CONSTRAINT [PK_Numero_Parcelas_a_Receber_1] PRIMARY KEY CLUSTERED 
(
	[Cod_Numero_Parcelas_Receber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Operacao]    Script Date: 12/12/2020 11:30:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Operacao](
	[Cod_Operacao] [int] IDENTITY(1,1) NOT NULL,
	[Descricao_Op] [varchar](65) NULL,
	[Nome_Login] [varchar](25) NULL,
	[Data_Login] [datetime] NULL,
 CONSTRAINT [PK__Operacao__6BF4D4C33DD636D9] PRIMARY KEY CLUSTERED 
(
	[Cod_Operacao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Pesquisa_Por_Nome]    Script Date: 12/12/2020 11:30:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Pesquisa_Por_Nome](
	[Cod_Pesquisa] [int] IDENTITY(1,1) NOT NULL,
	[Primeiro_Nome] [varchar](20) NULL,
	[Ultimo_Nome] [varchar](20) NULL,
 CONSTRAINT [PK_Pesquisa_Por_Nome] PRIMARY KEY CLUSTERED 
(
	[Cod_Pesquisa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Status_Fornecedor_Cliente]    Script Date: 12/12/2020 11:30:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Status_Fornecedor_Cliente](
	[Cod_Status_Fornecedor] [int] IDENTITY(1,1) NOT NULL,
	[Descricao_Status] [varchar](20) NULL,
	[Data_Login] [datetime] NULL,
	[Login_Name] [varchar](15) NULL,
 CONSTRAINT [PK_Status_Fornecedor] PRIMARY KEY CLUSTERED 
(
	[Cod_Status_Fornecedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Status_Titulo]    Script Date: 12/12/2020 11:30:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Status_Titulo](
	[Cod_Status_Titulo] [int] IDENTITY(1,1) NOT NULL,
	[Descricao_Status_Titulo] [varchar](20) NULL,
	[Data_Login] [datetime] NULL,
	[Login_Name] [varchar](15) NULL,
 CONSTRAINT [PK_Status_Titulo] PRIMARY KEY CLUSTERED 
(
	[Cod_Status_Titulo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Status_Titulos_a_Receber]    Script Date: 12/12/2020 11:30:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Status_Titulos_a_Receber](
	[Codigo_Status_Tit_a_Receber] [int] IDENTITY(1,1) NOT NULL,
	[Descricao_Status] [varchar](25) NULL,
	[data_login] [datetime] NULL,
	[login_name] [varchar](25) NULL,
 CONSTRAINT [PK_Status_Titulos_a_Receber] PRIMARY KEY CLUSTERED 
(
	[Codigo_Status_Tit_a_Receber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tipos_Acesso]    Script Date: 12/12/2020 11:30:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tipos_Acesso](
	[Cod_acesso] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](25) NULL,
	[Nome_Login] [varchar](15) NULL,
	[Data_Login] [datetime] NULL,
 CONSTRAINT [PK_Tipos_Acesso] PRIMARY KEY CLUSTERED 
(
	[Cod_acesso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tipos_Receita]    Script Date: 12/12/2020 11:30:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tipos_Receita](
	[Codigo_Tipo_Receita] [int] IDENTITY(1,1) NOT NULL,
	[Descricao_Receita] [varchar](50) NULL,
	[codigo_contabilidade] [varchar](20) NULL,
	[data_login] [datetime] NULL,
	[login_name] [varchar](25) NULL,
 CONSTRAINT [PK_Tipos_Receita] PRIMARY KEY CLUSTERED 
(
	[Codigo_Tipo_Receita] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Transferencias]    Script Date: 12/12/2020 11:30:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Transferencias](
	[Cod_Transferencia] [int] IDENTITY(1,1) NOT NULL,
	[Documento] [varchar](25) NULL,
	[Data] [datetime] NULL,
	[Descricao_Operacao] [varchar](50) NULL,
	[Valor_Movimento] [float] NULL,
	[Conta_Origem_Banco] [int] NULL,
	[Nome_Banco_Origem] [varchar](50) NULL,
	[Numero_Conta_Origem] [varchar](15) NULL,
	[Conta_Destino_Banco] [int] NULL,
	[Nome_Banco_Destino] [varchar](50) NULL,
	[Numero_Conta_Destino] [varchar](15) NULL,
	[Data_Login] [datetime] NULL,
	[Login_Name] [varchar](15) NULL,
 CONSTRAINT [PK_Transferencias] PRIMARY KEY CLUSTERED 
(
	[Cod_Transferencia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 12/12/2020 11:30:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuarios](
	[Cod_Usuario] [int] IDENTITY(1,1) NOT NULL,
	[Nome_Usuario] [varchar](50) NULL,
	[Login_Name] [varchar](15) NULL,
	[Senha_Usuario] [varchar](10) NULL,
	[Codigo_Acesso] [int] NULL,
	[Data_Login] [datetime] NULL,
	[Nome_Login] [varchar](15) NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[Cod_Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Validade_Pagamentos]    Script Date: 12/12/2020 11:30:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Validade_Pagamentos](
	[Cod_Senha_Pgto] [int] IDENTITY(1,1) NOT NULL,
	[Senha_PGTO] [varchar](8) NULL,
	[data_validade] [datetime] NULL,
 CONSTRAINT [PK_Validade_Pagamentos] PRIMARY KEY CLUSTERED 
(
	[Cod_Senha_Pgto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Bancos] ON 

INSERT [dbo].[Bancos] ([Cod_Banco], [Nome_Banco], [Numero_Conta], [Agencia], [Numero_Banco], [Saldo], [Endereco], [Bairro], [Municipio], [Estado], [Telefone_1], [Telefone_2], [Contato], [email], [data_cadastro], [Data_Login], [Login_Name]) VALUES (1, N'Banco do Brasil S.A. ', N'82080-6', N'2795-2', CAST(1 AS Numeric(6, 0)), CAST(-6424.65 AS Decimal(18, 2)), N'Av. das Américas, 13251 TESTE', N'Recreio dos Bandeirantes', N'Rio de Janeiro - teste', N'RJ', N'2437-8118', N'2437-8999', N'Fernanda Lima', N'atendimento@bb.recreio.com.br', CAST(N'2018-08-17 00:00:00.000' AS DateTime), CAST(N'2020-10-20 13:13:00.313' AS DateTime), N'Flavio')
INSERT [dbo].[Bancos] ([Cod_Banco], [Nome_Banco], [Numero_Conta], [Agencia], [Numero_Banco], [Saldo], [Endereco], [Bairro], [Municipio], [Estado], [Telefone_1], [Telefone_2], [Contato], [email], [data_cadastro], [Data_Login], [Login_Name]) VALUES (3, N'Banco Bradesco S/A', N'226046-8', N'551', CAST(237 AS Numeric(6, 0)), CAST(856.74 AS Decimal(18, 2)), N'Rua Ataulfo de Paiva, 983', N'Leblon', N'Rio de Janeiro', N'RJ', N'3003-8018', NULL, N'Vinícius', N'0551.gerencia@bradesco.com.br', CAST(N'2020-03-25 00:00:00.000' AS DateTime), CAST(N'2020-11-30 14:46:08.370' AS DateTime), N'Flavio')
SET IDENTITY_INSERT [dbo].[Bancos] OFF
INSERT [dbo].[Base_Parcelas_Pagas] ([Cod_Base_Titulos_Pagos], [Cod_Titulo_a_Pagar], [Cod_Numero_Parc_a_Pagar], [Cod_Fornecedor], [Numero_Documento], [Numero_Parcela], [Valor_Titulo], [Data_Documento], [Data_Pagamento], [Data_Venc_Parcela], [Cod_Centro_Custos], [Cod_Despesa], [Valor_Pago_a_Vista], [Valor_Pago], [Numero_banco], [Numero_cheque], [Acrescimos], [Descontos], [Saldo], [StatusTitulo], [Historico], [Historico_Titulo]) VALUES (1096, 1063, 135, 3, N'238828', 1, CAST(14772.56 AS Decimal(18, 2)), CAST(N'2020-07-24 00:00:00.000' AS DateTime), CAST(N'2020-07-27 00:00:00.000' AS DateTime), CAST(N'2020-09-07 00:00:00.000' AS DateTime), 3, 12, CAST(0.00 AS Decimal(18, 2)), CAST(14772.56 AS Decimal(18, 2)), 3, N'Transf.Daniella', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, N'Nota Fiscal Material Trauma - Referente a Empenho HFB/HFA', N'Compra de Mercadoria para Empenhos')
INSERT [dbo].[Base_Parcelas_Pagas] ([Cod_Base_Titulos_Pagos], [Cod_Titulo_a_Pagar], [Cod_Numero_Parc_a_Pagar], [Cod_Fornecedor], [Numero_Documento], [Numero_Parcela], [Valor_Titulo], [Data_Documento], [Data_Pagamento], [Data_Venc_Parcela], [Cod_Centro_Custos], [Cod_Despesa], [Valor_Pago_a_Vista], [Valor_Pago], [Numero_banco], [Numero_cheque], [Acrescimos], [Descontos], [Saldo], [StatusTitulo], [Historico], [Historico_Titulo]) VALUES (1096, 1064, 136, 3, N'239123', 1, CAST(1713.92 AS Decimal(18, 2)), CAST(N'2020-07-31 00:00:00.000' AS DateTime), CAST(N'2020-07-27 00:00:00.000' AS DateTime), CAST(N'2020-09-14 11:40:52.000' AS DateTime), 3, 12, CAST(0.00 AS Decimal(18, 2)), CAST(1713.92 AS Decimal(18, 2)), 3, N'Transf.Daniella', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, N' Material de Trauma para HFB/HFA - Empenhos', N'Material de Trauma para HFB/HFA')
INSERT [dbo].[Base_Parcelas_Pagas] ([Cod_Base_Titulos_Pagos], [Cod_Titulo_a_Pagar], [Cod_Numero_Parc_a_Pagar], [Cod_Fornecedor], [Numero_Documento], [Numero_Parcela], [Valor_Titulo], [Data_Documento], [Data_Pagamento], [Data_Venc_Parcela], [Cod_Centro_Custos], [Cod_Despesa], [Valor_Pago_a_Vista], [Valor_Pago], [Numero_banco], [Numero_cheque], [Acrescimos], [Descontos], [Saldo], [StatusTitulo], [Historico], [Historico_Titulo]) VALUES (2100, 1065, 137, 3, N'239173', 1, CAST(1668.24 AS Decimal(18, 2)), CAST(N'2020-07-31 00:00:00.000' AS DateTime), CAST(N'2020-10-06 00:00:00.000' AS DateTime), CAST(N'2020-09-14 11:40:52.000' AS DateTime), 3, 12, CAST(0.00 AS Decimal(18, 2)), CAST(1668.24 AS Decimal(18, 2)), 3, N'DOC/TED', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, N'Material de Trauma para Emepenhos - HFA/HFB', N'Material de Trauma para Empenhos - HFA/HFB')
INSERT [dbo].[Base_Parcelas_Pagas] ([Cod_Base_Titulos_Pagos], [Cod_Titulo_a_Pagar], [Cod_Numero_Parc_a_Pagar], [Cod_Fornecedor], [Numero_Documento], [Numero_Parcela], [Valor_Titulo], [Data_Documento], [Data_Pagamento], [Data_Venc_Parcela], [Cod_Centro_Custos], [Cod_Despesa], [Valor_Pago_a_Vista], [Valor_Pago], [Numero_banco], [Numero_cheque], [Acrescimos], [Descontos], [Saldo], [StatusTitulo], [Historico], [Historico_Titulo]) VALUES (1095, 1066, 138, 12, N'5128316', 1, CAST(242.55 AS Decimal(18, 2)), CAST(N'2020-08-05 00:00:00.000' AS DateTime), CAST(N'2020-08-21 00:00:00.000' AS DateTime), CAST(N'2020-08-31 11:58:31.000' AS DateTime), 3, 9, CAST(0.00 AS Decimal(18, 2)), CAST(242.55 AS Decimal(18, 2)), 3, N'Transf.Bruna', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, N' Frete SP/RJ - Ortosintese - Material de Trauma HFB - Empenho', N'Frete SP/RJ - Ortosintese - Material de Empenho HFB')
INSERT [dbo].[Base_Parcelas_Pagas] ([Cod_Base_Titulos_Pagos], [Cod_Titulo_a_Pagar], [Cod_Numero_Parc_a_Pagar], [Cod_Fornecedor], [Numero_Documento], [Numero_Parcela], [Valor_Titulo], [Data_Documento], [Data_Pagamento], [Data_Venc_Parcela], [Cod_Centro_Custos], [Cod_Despesa], [Valor_Pago_a_Vista], [Valor_Pago], [Numero_banco], [Numero_cheque], [Acrescimos], [Descontos], [Saldo], [StatusTitulo], [Historico], [Historico_Titulo]) VALUES (2102, 1067, 139, 3, N'240833', 1, CAST(20455.06 AS Decimal(18, 2)), CAST(N'2020-09-16 00:00:00.000' AS DateTime), CAST(N'2020-10-19 00:00:00.000' AS DateTime), CAST(N'2020-10-31 12:21:58.000' AS DateTime), 3, 12, CAST(0.00 AS Decimal(18, 2)), CAST(20455.06 AS Decimal(18, 2)), 3, N'TED/4455847', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, N' Nota Fiscal - Materia de Trauma - Empenho HFB ', N'Faturado para entrega  referente a empenho')
INSERT [dbo].[Base_Parcelas_Pagas] ([Cod_Base_Titulos_Pagos], [Cod_Titulo_a_Pagar], [Cod_Numero_Parc_a_Pagar], [Cod_Fornecedor], [Numero_Documento], [Numero_Parcela], [Valor_Titulo], [Data_Documento], [Data_Pagamento], [Data_Venc_Parcela], [Cod_Centro_Custos], [Cod_Despesa], [Valor_Pago_a_Vista], [Valor_Pago], [Numero_banco], [Numero_cheque], [Acrescimos], [Descontos], [Saldo], [StatusTitulo], [Historico], [Historico_Titulo]) VALUES (2102, 1068, 140, 3, N'240282', 1, CAST(73771.18 AS Decimal(18, 2)), CAST(N'2020-09-08 00:00:00.000' AS DateTime), CAST(N'2020-10-19 00:00:00.000' AS DateTime), CAST(N'2020-10-15 12:33:41.000' AS DateTime), 3, 12, CAST(0.00 AS Decimal(18, 2)), CAST(73771.18 AS Decimal(18, 2)), 3, N'TED/4455847', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, N'Material de Trauma - referente a Empenho no HFB', N'Material de Trauma referente a empenho no HFB - Entregue em 15/10.')
INSERT [dbo].[Base_Parcelas_Pagas] ([Cod_Base_Titulos_Pagos], [Cod_Titulo_a_Pagar], [Cod_Numero_Parc_a_Pagar], [Cod_Fornecedor], [Numero_Documento], [Numero_Parcela], [Valor_Titulo], [Data_Documento], [Data_Pagamento], [Data_Venc_Parcela], [Cod_Centro_Custos], [Cod_Despesa], [Valor_Pago_a_Vista], [Valor_Pago], [Numero_banco], [Numero_cheque], [Acrescimos], [Descontos], [Saldo], [StatusTitulo], [Historico], [Historico_Titulo]) VALUES (2102, 1069, 141, 3, N'240281', 1, CAST(3056.09 AS Decimal(18, 2)), CAST(N'2020-09-08 00:00:00.000' AS DateTime), CAST(N'2020-10-19 00:00:00.000' AS DateTime), CAST(N'2020-10-15 12:55:21.000' AS DateTime), 3, 12, CAST(0.00 AS Decimal(18, 2)), CAST(3056.09 AS Decimal(18, 2)), 3, N'TED/4455847', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, N' Material  referente ao Empenho HFB - Entrega em 15/09.', N'Material  referente ao Empenho HFB - Entrega em 15/09.')
INSERT [dbo].[Base_Parcelas_Pagas] ([Cod_Base_Titulos_Pagos], [Cod_Titulo_a_Pagar], [Cod_Numero_Parc_a_Pagar], [Cod_Fornecedor], [Numero_Documento], [Numero_Parcela], [Valor_Titulo], [Data_Documento], [Data_Pagamento], [Data_Venc_Parcela], [Cod_Centro_Custos], [Cod_Despesa], [Valor_Pago_a_Vista], [Valor_Pago], [Numero_banco], [Numero_cheque], [Acrescimos], [Descontos], [Saldo], [StatusTitulo], [Historico], [Historico_Titulo]) VALUES (2102, 1070, 142, 3, N'240283', 1, CAST(821.19 AS Decimal(18, 2)), CAST(N'2020-09-08 00:00:00.000' AS DateTime), CAST(N'2020-10-19 00:00:00.000' AS DateTime), CAST(N'2020-10-15 13:07:20.000' AS DateTime), 3, 12, CAST(0.00 AS Decimal(18, 2)), CAST(821.19 AS Decimal(18, 2)), 3, N'TED/4455847', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, N' Material referente a empenho - Entregue no HFB - 15/09.', N'Material referente a empenho - Entregue no HFB')
INSERT [dbo].[Base_Parcelas_Pagas] ([Cod_Base_Titulos_Pagos], [Cod_Titulo_a_Pagar], [Cod_Numero_Parc_a_Pagar], [Cod_Fornecedor], [Numero_Documento], [Numero_Parcela], [Valor_Titulo], [Data_Documento], [Data_Pagamento], [Data_Venc_Parcela], [Cod_Centro_Custos], [Cod_Despesa], [Valor_Pago_a_Vista], [Valor_Pago], [Numero_banco], [Numero_cheque], [Acrescimos], [Descontos], [Saldo], [StatusTitulo], [Historico], [Historico_Titulo]) VALUES (1094, 1071, 143, 13, N'1371118', 1, CAST(103.87 AS Decimal(18, 2)), CAST(N'2020-08-06 00:00:00.000' AS DateTime), CAST(N'2020-09-12 00:00:00.000' AS DateTime), CAST(N'2020-09-06 14:57:59.000' AS DateTime), 2, 9, CAST(0.00 AS Decimal(18, 2)), CAST(103.87 AS Decimal(18, 2)), 3, N'DOC', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, N'Frete Material Empenho HFB - SP/RJ', N'Frete Material Ortosintese - SP / RJ - Empenho HFB')
INSERT [dbo].[Base_Parcelas_Pagas] ([Cod_Base_Titulos_Pagos], [Cod_Titulo_a_Pagar], [Cod_Numero_Parc_a_Pagar], [Cod_Fornecedor], [Numero_Documento], [Numero_Parcela], [Valor_Titulo], [Data_Documento], [Data_Pagamento], [Data_Venc_Parcela], [Cod_Centro_Custos], [Cod_Despesa], [Valor_Pago_a_Vista], [Valor_Pago], [Numero_banco], [Numero_cheque], [Acrescimos], [Descontos], [Saldo], [StatusTitulo], [Historico], [Historico_Titulo]) VALUES (1094, 1072, 144, 13, N'1643651', 1, CAST(1144.70 AS Decimal(18, 2)), CAST(N'2020-09-08 00:00:00.000' AS DateTime), CAST(N'2020-09-12 00:00:00.000' AS DateTime), CAST(N'2020-09-15 14:57:59.000' AS DateTime), 2, 9, CAST(0.00 AS Decimal(18, 2)), CAST(1144.70 AS Decimal(18, 2)), 3, N'DOC', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, N' Frete Material HFB - SP/RJ', N'Frete Material HFB - SP/RJ')
INSERT [dbo].[Base_Parcelas_Pagas] ([Cod_Base_Titulos_Pagos], [Cod_Titulo_a_Pagar], [Cod_Numero_Parc_a_Pagar], [Cod_Fornecedor], [Numero_Documento], [Numero_Parcela], [Valor_Titulo], [Data_Documento], [Data_Pagamento], [Data_Venc_Parcela], [Cod_Centro_Custos], [Cod_Despesa], [Valor_Pago_a_Vista], [Valor_Pago], [Numero_banco], [Numero_cheque], [Acrescimos], [Descontos], [Saldo], [StatusTitulo], [Historico], [Historico_Titulo]) VALUES (1097, 1073, 145, 13, N'1238475', 1, CAST(329.55 AS Decimal(18, 2)), CAST(N'2020-07-24 00:00:00.000' AS DateTime), CAST(N'2020-07-28 00:00:00.000' AS DateTime), CAST(N'2020-09-28 12:55:55.000' AS DateTime), 2, 9, CAST(0.00 AS Decimal(18, 2)), CAST(329.55 AS Decimal(18, 2)), 3, N'Transf.Dani', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, N'Material de Empenho - Frete SP x RJ ', N'Material de Empenho - Frete SP x RJ ')
INSERT [dbo].[Base_Parcelas_Pagas] ([Cod_Base_Titulos_Pagos], [Cod_Titulo_a_Pagar], [Cod_Numero_Parc_a_Pagar], [Cod_Fornecedor], [Numero_Documento], [Numero_Parcela], [Valor_Titulo], [Data_Documento], [Data_Pagamento], [Data_Venc_Parcela], [Cod_Centro_Custos], [Cod_Despesa], [Valor_Pago_a_Vista], [Valor_Pago], [Numero_banco], [Numero_cheque], [Acrescimos], [Descontos], [Saldo], [StatusTitulo], [Historico], [Historico_Titulo]) VALUES (1098, 1074, 146, 14, N'0001', 1, CAST(18000.00 AS Decimal(18, 2)), CAST(N'2020-07-31 00:00:00.000' AS DateTime), CAST(N'2020-08-31 00:00:00.000' AS DateTime), CAST(N'2020-08-31 10:53:54.000' AS DateTime), 1, 1, CAST(0.00 AS Decimal(18, 2)), CAST(1500.00 AS Decimal(18, 2)), 3, N'doc', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, N'1ª parcela repactuação de dívida de aluguel - Marcelo Araújo Advogado', N'Repactuação de dívida de Aluguel - Marcelo Araújo Advogado')
INSERT [dbo].[Base_Parcelas_Pagas] ([Cod_Base_Titulos_Pagos], [Cod_Titulo_a_Pagar], [Cod_Numero_Parc_a_Pagar], [Cod_Fornecedor], [Numero_Documento], [Numero_Parcela], [Valor_Titulo], [Data_Documento], [Data_Pagamento], [Data_Venc_Parcela], [Cod_Centro_Custos], [Cod_Despesa], [Valor_Pago_a_Vista], [Valor_Pago], [Numero_banco], [Numero_cheque], [Acrescimos], [Descontos], [Saldo], [StatusTitulo], [Historico], [Historico_Titulo]) VALUES (1100, 1074, 147, 14, N'0001', 2, CAST(18000.00 AS Decimal(18, 2)), CAST(N'2020-07-31 00:00:00.000' AS DateTime), CAST(N'2020-09-29 00:00:00.000' AS DateTime), CAST(N'2020-09-30 10:53:54.000' AS DateTime), 1, 1, CAST(0.00 AS Decimal(18, 2)), CAST(1500.00 AS Decimal(18, 2)), 3, N'TED-Digital', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, N'2ª parcela repactuação de dívida aluguel - Marcelo Araújo Advogado', N'Repactuação de dívida de Aluguel - Marcelo Araújo Advogado')
INSERT [dbo].[Base_Parcelas_Pagas] ([Cod_Base_Titulos_Pagos], [Cod_Titulo_a_Pagar], [Cod_Numero_Parc_a_Pagar], [Cod_Fornecedor], [Numero_Documento], [Numero_Parcela], [Valor_Titulo], [Data_Documento], [Data_Pagamento], [Data_Venc_Parcela], [Cod_Centro_Custos], [Cod_Despesa], [Valor_Pago_a_Vista], [Valor_Pago], [Numero_banco], [Numero_cheque], [Acrescimos], [Descontos], [Saldo], [StatusTitulo], [Historico], [Historico_Titulo]) VALUES (2103, 1074, 148, 14, N'0001', 3, CAST(18000.00 AS Decimal(18, 2)), CAST(N'2020-07-31 00:00:00.000' AS DateTime), CAST(N'2020-11-04 00:00:00.000' AS DateTime), CAST(N'2020-10-31 10:53:54.000' AS DateTime), 1, 1, CAST(0.00 AS Decimal(18, 2)), CAST(1650.00 AS Decimal(18, 2)), 3, N'TED 2', CAST(150.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, N'3ª parcela repactuação de dívida aluguel - Marcelo Araújo Advogado', N'Repactuação de dívida de Aluguel - Marcelo Araújo Advogado')
INSERT [dbo].[Base_Parcelas_Pagas] ([Cod_Base_Titulos_Pagos], [Cod_Titulo_a_Pagar], [Cod_Numero_Parc_a_Pagar], [Cod_Fornecedor], [Numero_Documento], [Numero_Parcela], [Valor_Titulo], [Data_Documento], [Data_Pagamento], [Data_Venc_Parcela], [Cod_Centro_Custos], [Cod_Despesa], [Valor_Pago_a_Vista], [Valor_Pago], [Numero_banco], [Numero_cheque], [Acrescimos], [Descontos], [Saldo], [StatusTitulo], [Historico], [Historico_Titulo]) VALUES (2111, 1074, 149, 14, N'0001', 4, CAST(18000.00 AS Decimal(18, 2)), CAST(N'2020-07-31 00:00:00.000' AS DateTime), CAST(N'2020-11-13 00:00:00.000' AS DateTime), CAST(N'2020-11-30 10:53:54.000' AS DateTime), 1, 1, CAST(0.00 AS Decimal(18, 2)), CAST(1500.00 AS Decimal(18, 2)), 3, N'TED4', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, N'4ª parcela repactuação de dívida aluguel - Marcelo Araújo Advogado', N'Repactuação de dívida de Aluguel - Marcelo Araújo Advogado')
INSERT [dbo].[Base_Parcelas_Pagas] ([Cod_Base_Titulos_Pagos], [Cod_Titulo_a_Pagar], [Cod_Numero_Parc_a_Pagar], [Cod_Fornecedor], [Numero_Documento], [Numero_Parcela], [Valor_Titulo], [Data_Documento], [Data_Pagamento], [Data_Venc_Parcela], [Cod_Centro_Custos], [Cod_Despesa], [Valor_Pago_a_Vista], [Valor_Pago], [Numero_banco], [Numero_cheque], [Acrescimos], [Descontos], [Saldo], [StatusTitulo], [Historico], [Historico_Titulo]) VALUES (1099, 1076, 159, 13, N'1760231', 1, CAST(364.75 AS Decimal(18, 2)), CAST(N'2020-09-18 00:00:00.000' AS DateTime), CAST(N'2020-09-22 00:00:00.000' AS DateTime), CAST(N'2020-09-24 11:36:04.000' AS DateTime), 2, 9, CAST(0.00 AS Decimal(18, 2)), CAST(364.75 AS Decimal(18, 2)), 3, N'DOC', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, N'Frete Azul Cargo - SP X RJ - Material de Empenho', N'Frete Azul Cargo - SP X RJ - Material de Empenho')
INSERT [dbo].[Base_Parcelas_Pagas] ([Cod_Base_Titulos_Pagos], [Cod_Titulo_a_Pagar], [Cod_Numero_Parc_a_Pagar], [Cod_Fornecedor], [Numero_Documento], [Numero_Parcela], [Valor_Titulo], [Data_Documento], [Data_Pagamento], [Data_Venc_Parcela], [Cod_Centro_Custos], [Cod_Despesa], [Valor_Pago_a_Vista], [Valor_Pago], [Numero_banco], [Numero_cheque], [Acrescimos], [Descontos], [Saldo], [StatusTitulo], [Historico], [Historico_Titulo]) VALUES (2108, 1077, 160, 3, N'241445', 1, CAST(7050.13 AS Decimal(18, 2)), CAST(N'2020-09-30 00:00:00.000' AS DateTime), CAST(N'2020-11-11 00:00:00.000' AS DateTime), CAST(N'2020-11-14 11:34:36.000' AS DateTime), 3, 12, CAST(0.00 AS Decimal(18, 2)), CAST(7050.13 AS Decimal(18, 2)), 3, N'TED ', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, N' Material de Trauma - Empenho HFB ', N'Material de Trauma - HFB ')
INSERT [dbo].[Base_Parcelas_Pagas] ([Cod_Base_Titulos_Pagos], [Cod_Titulo_a_Pagar], [Cod_Numero_Parc_a_Pagar], [Cod_Fornecedor], [Numero_Documento], [Numero_Parcela], [Valor_Titulo], [Data_Documento], [Data_Pagamento], [Data_Venc_Parcela], [Cod_Centro_Custos], [Cod_Despesa], [Valor_Pago_a_Vista], [Valor_Pago], [Numero_banco], [Numero_cheque], [Acrescimos], [Descontos], [Saldo], [StatusTitulo], [Historico], [Historico_Titulo]) VALUES (2108, 1079, 162, 3, N'241270', 1, CAST(8254.75 AS Decimal(18, 2)), CAST(N'2020-09-29 00:00:00.000' AS DateTime), CAST(N'2020-11-11 00:00:00.000' AS DateTime), CAST(N'2020-11-13 11:43:26.000' AS DateTime), 3, 12, CAST(0.00 AS Decimal(18, 2)), CAST(8254.75 AS Decimal(18, 2)), 3, N'TED ', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, N'Material de Empenho Trauma HFB - Faturado N.F. 060', N'Material de Empenho Trauma HFB - Faturado N.F. 060')
INSERT [dbo].[Base_Parcelas_Pagas] ([Cod_Base_Titulos_Pagos], [Cod_Titulo_a_Pagar], [Cod_Numero_Parc_a_Pagar], [Cod_Fornecedor], [Numero_Documento], [Numero_Parcela], [Valor_Titulo], [Data_Documento], [Data_Pagamento], [Data_Venc_Parcela], [Cod_Centro_Custos], [Cod_Despesa], [Valor_Pago_a_Vista], [Valor_Pago], [Numero_banco], [Numero_cheque], [Acrescimos], [Descontos], [Saldo], [StatusTitulo], [Historico], [Historico_Titulo]) VALUES (2101, 1080, 163, 12, N'1917145', 1, CAST(174.91 AS Decimal(18, 2)), CAST(N'2020-10-06 00:00:00.000' AS DateTime), CAST(N'2020-10-08 00:00:00.000' AS DateTime), CAST(N'2020-10-10 11:43:26.000' AS DateTime), 2, 9, CAST(0.00 AS Decimal(18, 2)), CAST(174.91 AS Decimal(18, 2)), 3, N'DOC/TED', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, N'Frete Material SPXRJ Empenho Trauma  - Ortosintese ', N'Frete Material SPXRJ Empenho Trauma ')
INSERT [dbo].[Base_Parcelas_Pagas] ([Cod_Base_Titulos_Pagos], [Cod_Titulo_a_Pagar], [Cod_Numero_Parc_a_Pagar], [Cod_Fornecedor], [Numero_Documento], [Numero_Parcela], [Valor_Titulo], [Data_Documento], [Data_Pagamento], [Data_Venc_Parcela], [Cod_Centro_Custos], [Cod_Despesa], [Valor_Pago_a_Vista], [Valor_Pago], [Numero_banco], [Numero_cheque], [Acrescimos], [Descontos], [Saldo], [StatusTitulo], [Historico], [Historico_Titulo]) VALUES (2101, 1081, 164, 12, N'1879144', 1, CAST(190.81 AS Decimal(18, 2)), CAST(N'2020-10-01 00:00:00.000' AS DateTime), CAST(N'2020-10-08 00:00:00.000' AS DateTime), CAST(N'2020-10-10 11:43:26.000' AS DateTime), 2, 9, CAST(0.00 AS Decimal(18, 2)), CAST(190.81 AS Decimal(18, 2)), 3, N'DOC/TED', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, N'Frete SPXRJ - Material Empenho', N'Frete SPXRJ - Material Empenho')
INSERT [dbo].[Base_Parcelas_Pagas] ([Cod_Base_Titulos_Pagos], [Cod_Titulo_a_Pagar], [Cod_Numero_Parc_a_Pagar], [Cod_Fornecedor], [Numero_Documento], [Numero_Parcela], [Valor_Titulo], [Data_Documento], [Data_Pagamento], [Data_Venc_Parcela], [Cod_Centro_Custos], [Cod_Despesa], [Valor_Pago_a_Vista], [Valor_Pago], [Numero_banco], [Numero_cheque], [Acrescimos], [Descontos], [Saldo], [StatusTitulo], [Historico], [Historico_Titulo]) VALUES (2105, 1082, 165, 15, N'0001', 1, CAST(2750.00 AS Decimal(18, 2)), CAST(N'2020-10-21 00:00:00.000' AS DateTime), CAST(N'2020-11-04 00:00:00.000' AS DateTime), CAST(N'2020-10-31 09:36:14.000' AS DateTime), 1, 11, CAST(0.00 AS Decimal(18, 2)), CAST(2750.00 AS Decimal(18, 2)), 3, N'TED7496340', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, N'Acréscimo da Taxa Judicial - Processo B.Brasil - Pgto por Flávio Rocha', N'Acréscimo da Taxa Judicial - Decisão Judicial - Processo Banco do Brasil')
INSERT [dbo].[Base_Parcelas_Pagas] ([Cod_Base_Titulos_Pagos], [Cod_Titulo_a_Pagar], [Cod_Numero_Parc_a_Pagar], [Cod_Fornecedor], [Numero_Documento], [Numero_Parcela], [Valor_Titulo], [Data_Documento], [Data_Pagamento], [Data_Venc_Parcela], [Cod_Centro_Custos], [Cod_Despesa], [Valor_Pago_a_Vista], [Valor_Pago], [Numero_banco], [Numero_cheque], [Acrescimos], [Descontos], [Saldo], [StatusTitulo], [Historico], [Historico_Titulo]) VALUES (2110, 1083, 166, 15, N'0002', 1, CAST(4974.63 AS Decimal(18, 2)), CAST(N'2020-10-22 00:00:00.000' AS DateTime), CAST(N'2020-11-12 00:00:00.000' AS DateTime), CAST(N'2020-11-10 09:36:14.000' AS DateTime), 1, 11, CAST(0.00 AS Decimal(18, 2)), CAST(4974.63 AS Decimal(18, 2)), 3, N'Transf.Caixa', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, N'Adiantamentos de Taxas Judiciais efetuado por Dr. Jonas ', N'Adiantamentos feito por Dr. Jonas de Taxas Judiciais.')
INSERT [dbo].[Base_Parcelas_Pagas] ([Cod_Base_Titulos_Pagos], [Cod_Titulo_a_Pagar], [Cod_Numero_Parc_a_Pagar], [Cod_Fornecedor], [Numero_Documento], [Numero_Parcela], [Valor_Titulo], [Data_Documento], [Data_Pagamento], [Data_Venc_Parcela], [Cod_Centro_Custos], [Cod_Despesa], [Valor_Pago_a_Vista], [Valor_Pago], [Numero_banco], [Numero_cheque], [Acrescimos], [Descontos], [Saldo], [StatusTitulo], [Historico], [Historico_Titulo]) VALUES (2104, 1084, 167, 16, N'001', 1, CAST(12000.00 AS Decimal(18, 2)), CAST(N'2020-10-26 00:00:00.000' AS DateTime), CAST(N'2020-11-05 00:00:00.000' AS DateTime), CAST(N'2020-12-01 22:00:48.000' AS DateTime), 1, 11, CAST(0.00 AS Decimal(18, 2)), CAST(12000.00 AS Decimal(18, 2)), 3, N'Boleto', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, N'Serviços de Contabilidade - Marcelo Araújo para Renaissance Medical', N'Serviços de Contabilidade - Marcelo Araújo para Renaissance Medical')
INSERT [dbo].[Base_Parcelas_Pagas] ([Cod_Base_Titulos_Pagos], [Cod_Titulo_a_Pagar], [Cod_Numero_Parc_a_Pagar], [Cod_Fornecedor], [Numero_Documento], [Numero_Parcela], [Valor_Titulo], [Data_Documento], [Data_Pagamento], [Data_Venc_Parcela], [Cod_Centro_Custos], [Cod_Despesa], [Valor_Pago_a_Vista], [Valor_Pago], [Numero_banco], [Numero_cheque], [Acrescimos], [Descontos], [Saldo], [StatusTitulo], [Historico], [Historico_Titulo]) VALUES (2107, 1085, 168, 17, N'001', 1, CAST(12000.00 AS Decimal(18, 2)), CAST(N'2020-10-26 00:00:00.000' AS DateTime), CAST(N'2020-11-11 00:00:00.000' AS DateTime), CAST(N'2020-12-01 22:00:48.000' AS DateTime), 1, 11, CAST(0.00 AS Decimal(18, 2)), CAST(12000.00 AS Decimal(18, 2)), 3, N'TED ', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, N'Serviço de Responsabilidade Técnica - Andrea - 36 meses', N'Serviço de Responsabilidade Técnica - Andrea - 36 meses')
INSERT [dbo].[Base_Parcelas_Pagas] ([Cod_Base_Titulos_Pagos], [Cod_Titulo_a_Pagar], [Cod_Numero_Parc_a_Pagar], [Cod_Fornecedor], [Numero_Documento], [Numero_Parcela], [Valor_Titulo], [Data_Documento], [Data_Pagamento], [Data_Venc_Parcela], [Cod_Centro_Custos], [Cod_Despesa], [Valor_Pago_a_Vista], [Valor_Pago], [Numero_banco], [Numero_cheque], [Acrescimos], [Descontos], [Saldo], [StatusTitulo], [Historico], [Historico_Titulo]) VALUES (2106, 1087, 170, 13, N'2118563', 1, CAST(206.54 AS Decimal(18, 2)), CAST(N'2020-10-30 00:00:00.000' AS DateTime), CAST(N'2020-11-09 00:00:00.000' AS DateTime), CAST(N'2020-11-09 13:53:33.000' AS DateTime), 2, 9, CAST(0.00 AS Decimal(18, 2)), CAST(206.54 AS Decimal(18, 2)), 3, N'TED', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, N'Frete SP X RIO - Material de Empenho - Implantes e Instrumental HFB/HFA', N'Frete SP X RIO - Material de Empenho - Implantes e Instrumental HFB/HFA')
INSERT [dbo].[Base_Parcelas_Pagas] ([Cod_Base_Titulos_Pagos], [Cod_Titulo_a_Pagar], [Cod_Numero_Parc_a_Pagar], [Cod_Fornecedor], [Numero_Documento], [Numero_Parcela], [Valor_Titulo], [Data_Documento], [Data_Pagamento], [Data_Venc_Parcela], [Cod_Centro_Custos], [Cod_Despesa], [Valor_Pago_a_Vista], [Valor_Pago], [Numero_banco], [Numero_cheque], [Acrescimos], [Descontos], [Saldo], [StatusTitulo], [Historico], [Historico_Titulo]) VALUES (2109, 1088, 171, 3, N'242420', 1, CAST(4877.69 AS Decimal(18, 2)), CAST(N'2020-10-28 00:00:00.000' AS DateTime), CAST(N'2020-11-12 00:00:00.000' AS DateTime), CAST(N'2020-12-12 14:00:00.000' AS DateTime), 3, 12, CAST(0.00 AS Decimal(18, 2)), CAST(4877.69 AS Decimal(18, 2)), 3, N'DOC', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, N'Material de Trauma - Empenho HFB', N'Material de Trauma - Empenho HFB')
INSERT [dbo].[Base_Parcelas_Pagas] ([Cod_Base_Titulos_Pagos], [Cod_Titulo_a_Pagar], [Cod_Numero_Parc_a_Pagar], [Cod_Fornecedor], [Numero_Documento], [Numero_Parcela], [Valor_Titulo], [Data_Documento], [Data_Pagamento], [Data_Venc_Parcela], [Cod_Centro_Custos], [Cod_Despesa], [Valor_Pago_a_Vista], [Valor_Pago], [Numero_banco], [Numero_cheque], [Acrescimos], [Descontos], [Saldo], [StatusTitulo], [Historico], [Historico_Titulo]) VALUES (2109, 1089, 172, 3, N'242421', 1, CAST(4658.16 AS Decimal(18, 2)), CAST(N'2020-10-28 00:00:00.000' AS DateTime), CAST(N'2020-11-12 00:00:00.000' AS DateTime), CAST(N'2020-11-27 14:00:00.000' AS DateTime), 3, 12, CAST(0.00 AS Decimal(18, 2)), CAST(4568.16 AS Decimal(18, 2)), 3, N'DOC', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, N'Instrumental placas de Punho Volar - Hospitais HFA / HFB ', N'Instrumental placas de Punho Volar - Hospitais HFA / HFB ')
INSERT [dbo].[Base_Parcelas_Pagas] ([Cod_Base_Titulos_Pagos], [Cod_Titulo_a_Pagar], [Cod_Numero_Parc_a_Pagar], [Cod_Fornecedor], [Numero_Documento], [Numero_Parcela], [Valor_Titulo], [Data_Documento], [Data_Pagamento], [Data_Venc_Parcela], [Cod_Centro_Custos], [Cod_Despesa], [Valor_Pago_a_Vista], [Valor_Pago], [Numero_banco], [Numero_cheque], [Acrescimos], [Descontos], [Saldo], [StatusTitulo], [Historico], [Historico_Titulo]) VALUES (2112, 1090, 173, 18, N'XYZ - S/Nº', 1, CAST(164.89 AS Decimal(18, 2)), CAST(N'2020-11-12 00:00:00.000' AS DateTime), CAST(N'2020-11-16 00:00:00.000' AS DateTime), CAST(N'2020-11-27 14:26:49.000' AS DateTime), 1, 2, CAST(0.00 AS Decimal(18, 2)), CAST(164.89 AS Decimal(18, 2)), 3, N'DOC5969777', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, N'Acordo NET-Claro - boletos R$49,22 + R$115,67 (Telefone + Internet)', N'Acordo Pagamento - NET Claro -Rescisão Contrato - 16/11/2020')
INSERT [dbo].[Base_Parcelas_Recebidas] ([Cod_Base_Titulos_a_Recebidos], [Cod_Entrada_Titulos_a_Receber], [Cod_Numero_Parcelas_Receber], [Cod_Cliente], [Numero_Documento], [Numero_Parcela], [Valor_Titulo], [Valor_Pago_a_Vista], [Data_Documento], [Data_Recebimento], [Data_Venc_Parcela], [Numero_Banco], [Cod_Receita], [Valor_Recebido], [Acrescimos], [Desconto], [Saldo], [Status_Titulo_a_Receber], [Historico_Titulo], [Historico_Parcela]) VALUES (60, 2032, 1006, 7, N'42', 1, CAST(77142.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(N'2020-03-29 00:00:00.000' AS DateTime), CAST(N'2020-05-19 00:00:00.000' AS DateTime), CAST(N'2020-04-29 00:00:00.000' AS DateTime), 1, 1, CAST(77142.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, N'Nota Fiscal de Empenho HFB - 2020NE800333', N'Nota de Empenho 2020NE800333 - Material de Trauma HFB')
INSERT [dbo].[Base_Parcelas_Recebidas] ([Cod_Base_Titulos_a_Recebidos], [Cod_Entrada_Titulos_a_Receber], [Cod_Numero_Parcelas_Receber], [Cod_Cliente], [Numero_Documento], [Numero_Parcela], [Valor_Titulo], [Valor_Pago_a_Vista], [Data_Documento], [Data_Recebimento], [Data_Venc_Parcela], [Numero_Banco], [Cod_Receita], [Valor_Recebido], [Acrescimos], [Desconto], [Saldo], [Status_Titulo_a_Receber], [Historico_Titulo], [Historico_Parcela]) VALUES (62, 2033, 1007, 1007, N'44', 1, CAST(3290.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(N'2020-06-30 00:00:00.000' AS DateTime), CAST(N'2020-08-24 00:00:00.000' AS DateTime), CAST(N'2020-07-30 00:00:00.000' AS DateTime), 3, 1, CAST(3290.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, N'Cirurgia Ortopédica de Trauma - ref. a empenho: 2020NE800617', N'Cirurgia de Trauma - Nota de Empenho 2020NE800617')
INSERT [dbo].[Base_Parcelas_Recebidas] ([Cod_Base_Titulos_a_Recebidos], [Cod_Entrada_Titulos_a_Receber], [Cod_Numero_Parcelas_Receber], [Cod_Cliente], [Numero_Documento], [Numero_Parcela], [Valor_Titulo], [Valor_Pago_a_Vista], [Data_Documento], [Data_Recebimento], [Data_Venc_Parcela], [Numero_Banco], [Cod_Receita], [Valor_Recebido], [Acrescimos], [Desconto], [Saldo], [Status_Titulo_a_Receber], [Historico_Titulo], [Historico_Parcela]) VALUES (61, 2034, 1008, 7, N'50', 1, CAST(12982.50 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(N'2020-07-20 00:00:00.000' AS DateTime), CAST(N'2020-08-20 00:00:00.000' AS DateTime), CAST(N'2020-08-20 00:00:00.000' AS DateTime), 3, 1, CAST(12982.50 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, N'Material de Trauma Empenho Nº 2020NE800333', N'Material de Empenho Nº 2020NE800617')
INSERT [dbo].[Base_Parcelas_Recebidas] ([Cod_Base_Titulos_a_Recebidos], [Cod_Entrada_Titulos_a_Receber], [Cod_Numero_Parcelas_Receber], [Cod_Cliente], [Numero_Documento], [Numero_Parcela], [Valor_Titulo], [Valor_Pago_a_Vista], [Data_Documento], [Data_Recebimento], [Data_Venc_Parcela], [Numero_Banco], [Cod_Receita], [Valor_Recebido], [Acrescimos], [Desconto], [Saldo], [Status_Titulo_a_Receber], [Historico_Titulo], [Historico_Parcela]) VALUES (63, 2035, 1009, 7, N'51', 1, CAST(19780.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(N'2020-07-28 00:00:00.000' AS DateTime), CAST(N'2020-09-04 00:00:00.000' AS DateTime), CAST(N'2020-08-28 00:00:00.000' AS DateTime), 3, 1, CAST(19780.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, N'Material de Trauma Empenho Nº 800855', N'Material de Empenho  Nº 2020NE800855')
INSERT [dbo].[Base_Parcelas_Recebidas] ([Cod_Base_Titulos_a_Recebidos], [Cod_Entrada_Titulos_a_Receber], [Cod_Numero_Parcelas_Receber], [Cod_Cliente], [Numero_Documento], [Numero_Parcela], [Valor_Titulo], [Valor_Pago_a_Vista], [Data_Documento], [Data_Recebimento], [Data_Venc_Parcela], [Numero_Banco], [Cod_Receita], [Valor_Recebido], [Acrescimos], [Desconto], [Saldo], [Status_Titulo_a_Receber], [Historico_Titulo], [Historico_Parcela]) VALUES (72, 2036, 1010, 1007, N'52', 1, CAST(27955.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(N'2020-07-29 00:00:00.000' AS DateTime), CAST(N'2020-11-12 00:00:00.000' AS DateTime), CAST(N'2020-08-31 00:00:00.000' AS DateTime), 3, 1, CAST(27955.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, N'Material de Trauma - Empenho Nº 2020NE800617', N'Material de Empenho Nº 2020NE800617')
INSERT [dbo].[Base_Parcelas_Recebidas] ([Cod_Base_Titulos_a_Recebidos], [Cod_Entrada_Titulos_a_Receber], [Cod_Numero_Parcelas_Receber], [Cod_Cliente], [Numero_Documento], [Numero_Parcela], [Valor_Titulo], [Valor_Pago_a_Vista], [Data_Documento], [Data_Recebimento], [Data_Venc_Parcela], [Numero_Banco], [Cod_Receita], [Valor_Recebido], [Acrescimos], [Desconto], [Saldo], [Status_Titulo_a_Receber], [Historico_Titulo], [Historico_Parcela]) VALUES (67, 2037, 1011, 7, N'54', 1, CAST(6038.50 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(N'2020-08-12 00:00:00.000' AS DateTime), CAST(N'2020-10-05 00:00:00.000' AS DateTime), CAST(N'2020-09-14 00:00:00.000' AS DateTime), 3, 1, CAST(6038.50 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, N'Material de Trauma - Empenho Nº 2020NE800855', N'Material de Trauma - Empenho Nº 2020NE800855')
INSERT [dbo].[Base_Parcelas_Recebidas] ([Cod_Base_Titulos_a_Recebidos], [Cod_Entrada_Titulos_a_Receber], [Cod_Numero_Parcelas_Receber], [Cod_Cliente], [Numero_Documento], [Numero_Parcela], [Valor_Titulo], [Valor_Pago_a_Vista], [Data_Documento], [Data_Recebimento], [Data_Venc_Parcela], [Numero_Banco], [Cod_Receita], [Valor_Recebido], [Acrescimos], [Desconto], [Saldo], [Status_Titulo_a_Receber], [Historico_Titulo], [Historico_Parcela]) VALUES (68, 2053, 1014, 7, N'55', 1, CAST(86245.90 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(N'2020-09-14 00:00:00.000' AS DateTime), CAST(N'2020-10-15 00:00:00.000' AS DateTime), CAST(N'2020-10-14 00:00:00.000' AS DateTime), 3, 1, CAST(86245.90 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, N'Materia de Trauma - Empenho 2020NE800333', N'Materia de Trauma - Empenho 2020NE800333')
INSERT [dbo].[Base_Parcelas_Recebidas] ([Cod_Base_Titulos_a_Recebidos], [Cod_Entrada_Titulos_a_Receber], [Cod_Numero_Parcelas_Receber], [Cod_Cliente], [Numero_Documento], [Numero_Parcela], [Valor_Titulo], [Valor_Pago_a_Vista], [Data_Documento], [Data_Recebimento], [Data_Venc_Parcela], [Numero_Banco], [Cod_Receita], [Valor_Recebido], [Acrescimos], [Desconto], [Saldo], [Status_Titulo_a_Receber], [Historico_Titulo], [Historico_Parcela]) VALUES (69, 2054, 1015, 7, N'56', 1, CAST(22129.90 AS Decimal(18, 2)), CAST(1.00 AS Decimal(18, 2)), CAST(N'2020-09-14 00:00:00.000' AS DateTime), CAST(N'2020-10-01 00:00:00.000' AS DateTime), CAST(N'2020-10-14 00:00:00.000' AS DateTime), 3, 1, CAST(22129.90 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, N'Material de Trauma - Empenho 2020NE800855', N'Material de Trauma - Empenho 2020NE800855')
INSERT [dbo].[Base_Parcelas_Recebidas] ([Cod_Base_Titulos_a_Recebidos], [Cod_Entrada_Titulos_a_Receber], [Cod_Numero_Parcelas_Receber], [Cod_Cliente], [Numero_Documento], [Numero_Parcela], [Valor_Titulo], [Valor_Pago_a_Vista], [Data_Documento], [Data_Recebimento], [Data_Venc_Parcela], [Numero_Banco], [Cod_Receita], [Valor_Recebido], [Acrescimos], [Desconto], [Saldo], [Status_Titulo_a_Receber], [Historico_Titulo], [Historico_Parcela]) VALUES (71, 2055, 1016, 7, N'57', 1, CAST(37400.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(N'2020-09-15 00:00:00.000' AS DateTime), CAST(N'2020-11-11 00:00:00.000' AS DateTime), CAST(N'2020-10-15 00:00:00.000' AS DateTime), 3, 1, CAST(37400.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, N'Material de Empenho - 2020NE800333', N'Material de Empenho - 2020NE800333')
INSERT [dbo].[Base_Parcelas_Recebidas] ([Cod_Base_Titulos_a_Recebidos], [Cod_Entrada_Titulos_a_Receber], [Cod_Numero_Parcelas_Receber], [Cod_Cliente], [Numero_Documento], [Numero_Parcela], [Valor_Titulo], [Valor_Pago_a_Vista], [Data_Documento], [Data_Recebimento], [Data_Venc_Parcela], [Numero_Banco], [Cod_Receita], [Valor_Recebido], [Acrescimos], [Desconto], [Saldo], [Status_Titulo_a_Receber], [Historico_Titulo], [Historico_Parcela]) VALUES (70, 2056, 1017, 7, N'58', 1, CAST(31325.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(N'2020-09-15 00:00:00.000' AS DateTime), CAST(N'2020-11-04 00:00:00.000' AS DateTime), CAST(N'2020-10-15 00:00:00.000' AS DateTime), 3, 1, CAST(31325.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, N'Material de Empenho - 2020NE800855', N'Material de Empenho - 2020NE800855')
INSERT [dbo].[Base_Parcelas_Recebidas] ([Cod_Base_Titulos_a_Recebidos], [Cod_Entrada_Titulos_a_Receber], [Cod_Numero_Parcelas_Receber], [Cod_Cliente], [Numero_Documento], [Numero_Parcela], [Valor_Titulo], [Valor_Pago_a_Vista], [Data_Documento], [Data_Recebimento], [Data_Venc_Parcela], [Numero_Banco], [Cod_Receita], [Valor_Recebido], [Acrescimos], [Desconto], [Saldo], [Status_Titulo_a_Receber], [Historico_Titulo], [Historico_Parcela]) VALUES (73, 2057, 1018, 7, N'60', 1, CAST(81279.40 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(N'2020-10-09 00:00:00.000' AS DateTime), CAST(N'2020-12-03 00:00:00.000' AS DateTime), CAST(N'2020-11-09 00:00:00.000' AS DateTime), 3, 1, CAST(81279.40 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, N'Material de Empenho Nº 800855 - Entregue 09/10. HFB', N'Material de Empenho Nº 800855 - Entregue 09/10. HFB')
INSERT [dbo].[Base_Parcelas_Recebidas] ([Cod_Base_Titulos_a_Recebidos], [Cod_Entrada_Titulos_a_Receber], [Cod_Numero_Parcelas_Receber], [Cod_Cliente], [Numero_Documento], [Numero_Parcela], [Valor_Titulo], [Valor_Pago_a_Vista], [Data_Documento], [Data_Recebimento], [Data_Venc_Parcela], [Numero_Banco], [Cod_Receita], [Valor_Recebido], [Acrescimos], [Desconto], [Saldo], [Status_Titulo_a_Receber], [Historico_Titulo], [Historico_Parcela]) VALUES (74, 2058, 1019, 7, N'61', 1, CAST(17060.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(N'2020-10-19 00:00:00.000' AS DateTime), CAST(N'2020-12-11 00:00:00.000' AS DateTime), CAST(N'2020-11-17 00:00:00.000' AS DateTime), 3, 1, CAST(17060.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, N'Nota Fiscal Material Trauma - Empenho 2020NE800333', N'Nota Fiscal Material Trauma - Empenho 2020NE800333')
INSERT [dbo].[Base_Parcelas_Recebidas] ([Cod_Base_Titulos_a_Recebidos], [Cod_Entrada_Titulos_a_Receber], [Cod_Numero_Parcelas_Receber], [Cod_Cliente], [Numero_Documento], [Numero_Parcela], [Valor_Titulo], [Valor_Pago_a_Vista], [Data_Documento], [Data_Recebimento], [Data_Venc_Parcela], [Numero_Banco], [Cod_Receita], [Valor_Recebido], [Acrescimos], [Desconto], [Saldo], [Status_Titulo_a_Receber], [Historico_Titulo], [Historico_Parcela]) VALUES (75, 2059, 1020, 7, N'62', 1, CAST(28883.50 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(N'2020-10-19 00:00:00.000' AS DateTime), CAST(N'2020-12-11 00:00:00.000' AS DateTime), CAST(N'2020-11-17 00:00:00.000' AS DateTime), 3, 1, CAST(28883.50 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, N'Nota Fiscal Material Trauma - Empenho 2020NE800855', N'Nota Fiscal Material Trauma - Empenho 2020NE800855')
INSERT [dbo].[Base_Parcelas_Recebidas] ([Cod_Base_Titulos_a_Recebidos], [Cod_Entrada_Titulos_a_Receber], [Cod_Numero_Parcelas_Receber], [Cod_Cliente], [Numero_Documento], [Numero_Parcela], [Valor_Titulo], [Valor_Pago_a_Vista], [Data_Documento], [Data_Recebimento], [Data_Venc_Parcela], [Numero_Banco], [Cod_Receita], [Valor_Recebido], [Acrescimos], [Desconto], [Saldo], [Status_Titulo_a_Receber], [Historico_Titulo], [Historico_Parcela]) VALUES (79, 2061, 1022, 7, N'064', 1, CAST(9870.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(N'2020-12-03 00:00:00.000' AS DateTime), CAST(N'2020-12-11 00:00:00.000' AS DateTime), CAST(N'2020-12-31 00:00:00.000' AS DateTime), 3, 1, CAST(9870.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, N'Nota Fiscal Material Trauma - Empenho: 2020NE800333', N'Material Trauma - Empenho: 2020NE800333')
INSERT [dbo].[Base_Parcelas_Recebidas] ([Cod_Base_Titulos_a_Recebidos], [Cod_Entrada_Titulos_a_Receber], [Cod_Numero_Parcelas_Receber], [Cod_Cliente], [Numero_Documento], [Numero_Parcela], [Valor_Titulo], [Valor_Pago_a_Vista], [Data_Documento], [Data_Recebimento], [Data_Venc_Parcela], [Numero_Banco], [Cod_Receita], [Valor_Recebido], [Acrescimos], [Desconto], [Saldo], [Status_Titulo_a_Receber], [Historico_Titulo], [Historico_Parcela]) VALUES (75, 2063, 1024, 7, N'61', 1, CAST(17060.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(N'2020-10-18 00:00:00.000' AS DateTime), CAST(N'2020-12-11 00:00:00.000' AS DateTime), CAST(N'2020-11-17 00:00:00.000' AS DateTime), 3, 1, CAST(17060.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, N'Material de Empenho - HFB - 2020NE800333', N'Parcela N.F. 061 - HFB - Material Empenho - 2020NE800333')
INSERT [dbo].[Base_Parcelas_Recebidas] ([Cod_Base_Titulos_a_Recebidos], [Cod_Entrada_Titulos_a_Receber], [Cod_Numero_Parcelas_Receber], [Cod_Cliente], [Numero_Documento], [Numero_Parcela], [Valor_Titulo], [Valor_Pago_a_Vista], [Data_Documento], [Data_Recebimento], [Data_Venc_Parcela], [Numero_Banco], [Cod_Receita], [Valor_Recebido], [Acrescimos], [Desconto], [Saldo], [Status_Titulo_a_Receber], [Historico_Titulo], [Historico_Parcela]) VALUES (76, 2064, 1025, 7, N'61', 1, CAST(17060.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(N'2020-10-18 00:00:00.000' AS DateTime), CAST(N'2020-12-11 00:00:00.000' AS DateTime), CAST(N'2020-11-17 00:00:00.000' AS DateTime), 3, 1, CAST(17060.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, N'Material Trauma - Empenho HFB - 2020NE800333', N'NF. 061 - HFB - Material Trauma - Empenho 2020NE800333')
INSERT [dbo].[Base_Parcelas_Recebidas] ([Cod_Base_Titulos_a_Recebidos], [Cod_Entrada_Titulos_a_Receber], [Cod_Numero_Parcelas_Receber], [Cod_Cliente], [Numero_Documento], [Numero_Parcela], [Valor_Titulo], [Valor_Pago_a_Vista], [Data_Documento], [Data_Recebimento], [Data_Venc_Parcela], [Numero_Banco], [Cod_Receita], [Valor_Recebido], [Acrescimos], [Desconto], [Saldo], [Status_Titulo_a_Receber], [Historico_Titulo], [Historico_Parcela]) VALUES (77, 2065, 1026, 7, N'62', 1, CAST(28883.50 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(N'2020-10-18 00:00:00.000' AS DateTime), CAST(N'2020-12-11 00:00:00.000' AS DateTime), CAST(N'2020-11-17 00:00:00.000' AS DateTime), 3, 1, CAST(28883.50 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, N'Material Trauma HFB - Empenho - 2020NE800855', N'NF. 062 - HFB - Material Empenho 2020NE800855')
INSERT [dbo].[Base_Parcelas_Recebidas] ([Cod_Base_Titulos_a_Recebidos], [Cod_Entrada_Titulos_a_Receber], [Cod_Numero_Parcelas_Receber], [Cod_Cliente], [Numero_Documento], [Numero_Parcela], [Valor_Titulo], [Valor_Pago_a_Vista], [Data_Documento], [Data_Recebimento], [Data_Venc_Parcela], [Numero_Banco], [Cod_Receita], [Valor_Recebido], [Acrescimos], [Desconto], [Saldo], [Status_Titulo_a_Receber], [Historico_Titulo], [Historico_Parcela]) VALUES (80, 2067, 1028, 1007, N'00789', 1, CAST(33567.98 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(N'2020-12-08 00:00:00.000' AS DateTime), CAST(N'2020-12-25 00:00:00.000' AS DateTime), CAST(N'2020-12-24 00:00:00.000' AS DateTime), 3, 2, CAST(15789.99 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, N'Teste Recebimento de Título - Numero da NF ', N'Teste Recebimento do Título')
INSERT [dbo].[Base_Parcelas_Recebidas] ([Cod_Base_Titulos_a_Recebidos], [Cod_Entrada_Titulos_a_Receber], [Cod_Numero_Parcelas_Receber], [Cod_Cliente], [Numero_Documento], [Numero_Parcela], [Valor_Titulo], [Valor_Pago_a_Vista], [Data_Documento], [Data_Recebimento], [Data_Venc_Parcela], [Numero_Banco], [Cod_Receita], [Valor_Recebido], [Acrescimos], [Desconto], [Saldo], [Status_Titulo_a_Receber], [Historico_Titulo], [Historico_Parcela]) VALUES (81, 2067, 1029, 1007, N'00789', 2, CAST(33567.98 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(N'2020-12-08 00:00:00.000' AS DateTime), CAST(N'2020-12-25 00:00:00.000' AS DateTime), CAST(N'2020-12-28 00:00:00.000' AS DateTime), 3, 2, CAST(17895.35 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, N'Teste Recebimento de Título - Numero da NF ', N'Teste inserir Parcela 2 - Recebimento do Título')
INSERT [dbo].[Base_Parcelas_Recebidas] ([Cod_Base_Titulos_a_Recebidos], [Cod_Entrada_Titulos_a_Receber], [Cod_Numero_Parcelas_Receber], [Cod_Cliente], [Numero_Documento], [Numero_Parcela], [Valor_Titulo], [Valor_Pago_a_Vista], [Data_Documento], [Data_Recebimento], [Data_Venc_Parcela], [Numero_Banco], [Cod_Receita], [Valor_Recebido], [Acrescimos], [Desconto], [Saldo], [Status_Titulo_a_Receber], [Historico_Titulo], [Historico_Parcela]) VALUES (82, 2068, 1030, 1007, N'003689A', 1, CAST(45789.22 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(N'2020-12-02 00:00:00.000' AS DateTime), CAST(N'2020-12-31 00:00:00.000' AS DateTime), CAST(N'2020-12-19 00:00:00.000' AS DateTime), 3, 2, CAST(47893.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, N'Teste de Recebimento de Título - Numero_NF', N'Teste Recebimento de Título - Número_NF')
INSERT [dbo].[Base_Parcelas_Recebidas] ([Cod_Base_Titulos_a_Recebidos], [Cod_Entrada_Titulos_a_Receber], [Cod_Numero_Parcelas_Receber], [Cod_Cliente], [Numero_Documento], [Numero_Parcela], [Valor_Titulo], [Valor_Pago_a_Vista], [Data_Documento], [Data_Recebimento], [Data_Venc_Parcela], [Numero_Banco], [Cod_Receita], [Valor_Recebido], [Acrescimos], [Desconto], [Saldo], [Status_Titulo_a_Receber], [Historico_Titulo], [Historico_Parcela]) VALUES (83, 2068, 1031, 1007, N'003689A', 2, CAST(45789.22 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(N'2020-12-02 00:00:00.000' AS DateTime), CAST(N'2020-12-31 00:00:00.000' AS DateTime), CAST(N'2020-12-31 00:00:00.000' AS DateTime), 3, 2, CAST(35987.11 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, N'Teste de Recebimento de Título - Numero_NF', N'Teste inserir Numero_NF - Recebimento de Títulos')
INSERT [dbo].[Base_Parcelas_Recebidas] ([Cod_Base_Titulos_a_Recebidos], [Cod_Entrada_Titulos_a_Receber], [Cod_Numero_Parcelas_Receber], [Cod_Cliente], [Numero_Documento], [Numero_Parcela], [Valor_Titulo], [Valor_Pago_a_Vista], [Data_Documento], [Data_Recebimento], [Data_Venc_Parcela], [Numero_Banco], [Cod_Receita], [Valor_Recebido], [Acrescimos], [Desconto], [Saldo], [Status_Titulo_a_Receber], [Historico_Titulo], [Historico_Parcela]) VALUES (84, 2069, 1032, 1007, N'01234A', 1, CAST(12568.89 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(N'2020-12-01 00:00:00.000' AS DateTime), CAST(N'2020-12-31 00:00:00.000' AS DateTime), CAST(N'2020-12-31 00:00:00.000' AS DateTime), 3, 2, CAST(12879.22 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, N'Teste Inserir Recebimento - Numero NF', N'Teste Recebimento - Número NF na Base ')
INSERT [dbo].[Base_Parcelas_Recebidas] ([Cod_Base_Titulos_a_Recebidos], [Cod_Entrada_Titulos_a_Receber], [Cod_Numero_Parcelas_Receber], [Cod_Cliente], [Numero_Documento], [Numero_Parcela], [Valor_Titulo], [Valor_Pago_a_Vista], [Data_Documento], [Data_Recebimento], [Data_Venc_Parcela], [Numero_Banco], [Cod_Receita], [Valor_Recebido], [Acrescimos], [Desconto], [Saldo], [Status_Titulo_a_Receber], [Historico_Titulo], [Historico_Parcela]) VALUES (84, 2069, 1033, 1007, N'01234A', 2, CAST(12568.89 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(N'2020-12-01 00:00:00.000' AS DateTime), CAST(N'2020-12-25 00:00:00.000' AS DateTime), CAST(N'2020-12-30 00:00:00.000' AS DateTime), 3, 2, CAST(36897.25 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, N'Teste Inserir Recebimento - Numero NF', N'Teste Inserir Numero_NF - Recebimento Títulos - na Base')
INSERT [dbo].[Base_Parcelas_Recebidas] ([Cod_Base_Titulos_a_Recebidos], [Cod_Entrada_Titulos_a_Receber], [Cod_Numero_Parcelas_Receber], [Cod_Cliente], [Numero_Documento], [Numero_Parcela], [Valor_Titulo], [Valor_Pago_a_Vista], [Data_Documento], [Data_Recebimento], [Data_Venc_Parcela], [Numero_Banco], [Cod_Receita], [Valor_Recebido], [Acrescimos], [Desconto], [Saldo], [Status_Titulo_a_Receber], [Historico_Titulo], [Historico_Parcela]) VALUES (85, 2070, 1034, 1007, N'4567B', 1, CAST(123456.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(N'2020-12-24 00:00:00.000' AS DateTime), CAST(N'2020-12-31 00:00:00.000' AS DateTime), CAST(N'2020-12-31 00:00:00.000' AS DateTime), 3, 2, CAST(123456.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, N'Teste Recebimento de Títulos - Número NF', N'Teste Recebmento Título - NumeroNF - 4567B Teste')
INSERT [dbo].[Base_Parcelas_Recebidas] ([Cod_Base_Titulos_a_Recebidos], [Cod_Entrada_Titulos_a_Receber], [Cod_Numero_Parcelas_Receber], [Cod_Cliente], [Numero_Documento], [Numero_Parcela], [Valor_Titulo], [Valor_Pago_a_Vista], [Data_Documento], [Data_Recebimento], [Data_Venc_Parcela], [Numero_Banco], [Cod_Receita], [Valor_Recebido], [Acrescimos], [Desconto], [Saldo], [Status_Titulo_a_Receber], [Historico_Titulo], [Historico_Parcela]) VALUES (86, 2071, 1035, 1007, N'7894CD', 1, CAST(23567.25 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(N'2020-12-23 00:00:00.000' AS DateTime), CAST(N'2020-12-25 00:00:00.000' AS DateTime), CAST(N'2020-12-31 00:00:00.000' AS DateTime), 3, 2, CAST(23567.25 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, N'Teste Recebimento Título - NumeroNF', N'Teste Recebimento Título - Número NF 7894CD Teste')
SET IDENTITY_INSERT [dbo].[Base_Titulos_Pagos] ON 

INSERT [dbo].[Base_Titulos_Pagos] ([Cod_Base_Titulos_Pagos], [Data_Pagamento], [Total_Pago], [Banco_Debitado], [Numero_Cheque], [Historico], [Data_Login], [Login_Name]) VALUES (1094, CAST(N'2000-09-12 00:00:00.000' AS DateTime), CAST(1248.57 AS Decimal(18, 2)), 3, N'DOC', N'Frete Azul - SP X RIO - Material Empenho', CAST(N'2020-09-19 12:27:21.307' AS DateTime), N'Flavio')
INSERT [dbo].[Base_Titulos_Pagos] ([Cod_Base_Titulos_Pagos], [Data_Pagamento], [Total_Pago], [Banco_Debitado], [Numero_Cheque], [Historico], [Data_Login], [Login_Name]) VALUES (1095, CAST(N'2000-08-21 00:00:00.000' AS DateTime), CAST(242.55 AS Decimal(18, 2)), 3, N'Transf.Bruna', N'Pagamento JAMEF - Frete SPXRJ', CAST(N'2020-09-19 12:47:26.260' AS DateTime), N'Flavio')
INSERT [dbo].[Base_Titulos_Pagos] ([Cod_Base_Titulos_Pagos], [Data_Pagamento], [Total_Pago], [Banco_Debitado], [Numero_Cheque], [Historico], [Data_Login], [Login_Name]) VALUES (1096, CAST(N'2000-09-14 00:00:00.000' AS DateTime), CAST(16486.48 AS Decimal(18, 2)), 3, N'Transf.Daniella', N'Pagamento Ortosintese - Material Empenho ', CAST(N'2020-09-19 12:55:17.893' AS DateTime), N'Flavio')
INSERT [dbo].[Base_Titulos_Pagos] ([Cod_Base_Titulos_Pagos], [Data_Pagamento], [Total_Pago], [Banco_Debitado], [Numero_Cheque], [Historico], [Data_Login], [Login_Name]) VALUES (1097, CAST(N'2000-07-28 00:00:00.000' AS DateTime), CAST(329.55 AS Decimal(18, 2)), 3, N'Transf.Dani', N'Frete SP X RJ - Reembolso Victor e Flávio', CAST(N'2020-09-19 13:03:46.490' AS DateTime), N'Flavio')
INSERT [dbo].[Base_Titulos_Pagos] ([Cod_Base_Titulos_Pagos], [Data_Pagamento], [Total_Pago], [Banco_Debitado], [Numero_Cheque], [Historico], [Data_Login], [Login_Name]) VALUES (1098, CAST(N'2020-08-31 00:00:00.000' AS DateTime), CAST(1500.00 AS Decimal(18, 2)), 3, N'doc', N'Pagamento Repactuação de dívida de aluguel - Marcelo Araújo Advogado', CAST(N'2020-09-24 11:11:41.613' AS DateTime), N'Flavio')
INSERT [dbo].[Base_Titulos_Pagos] ([Cod_Base_Titulos_Pagos], [Data_Pagamento], [Total_Pago], [Banco_Debitado], [Numero_Cheque], [Historico], [Data_Login], [Login_Name]) VALUES (1099, CAST(N'2020-09-22 00:00:00.000' AS DateTime), CAST(364.75 AS Decimal(18, 2)), 3, N'DOC', N'Frete Azul Cargo - SP X RJ - Material de Empenho', CAST(N'2020-09-24 11:45:02.847' AS DateTime), N'Flavio')
INSERT [dbo].[Base_Titulos_Pagos] ([Cod_Base_Titulos_Pagos], [Data_Pagamento], [Total_Pago], [Banco_Debitado], [Numero_Cheque], [Historico], [Data_Login], [Login_Name]) VALUES (1100, CAST(N'2000-09-29 00:00:00.000' AS DateTime), CAST(1500.00 AS Decimal(18, 2)), 3, N'TED-Digital', N'Pagamento de Boleto - Acordo Repactuação Aluguel ', CAST(N'2020-09-30 11:06:57.403' AS DateTime), N'Flavio')
INSERT [dbo].[Base_Titulos_Pagos] ([Cod_Base_Titulos_Pagos], [Data_Pagamento], [Total_Pago], [Banco_Debitado], [Numero_Cheque], [Historico], [Data_Login], [Login_Name]) VALUES (2100, CAST(N'2000-10-06 00:00:00.000' AS DateTime), CAST(1668.24 AS Decimal(18, 2)), 3, N'DOC/TED', N'Pagamento Nota Fiscal Ortosintese - NF. 54', CAST(N'2020-10-07 11:29:13.867' AS DateTime), N'Flavio')
INSERT [dbo].[Base_Titulos_Pagos] ([Cod_Base_Titulos_Pagos], [Data_Pagamento], [Total_Pago], [Banco_Debitado], [Numero_Cheque], [Historico], [Data_Login], [Login_Name]) VALUES (2101, CAST(N'2020-10-08 00:00:00.000' AS DateTime), CAST(365.72 AS Decimal(18, 2)), 3, N'DOC/TED', N'Pagamento Frete SPXRJ - Azul Cargo', CAST(N'2020-10-09 14:51:23.253' AS DateTime), N'Flavio')
INSERT [dbo].[Base_Titulos_Pagos] ([Cod_Base_Titulos_Pagos], [Data_Pagamento], [Total_Pago], [Banco_Debitado], [Numero_Cheque], [Historico], [Data_Login], [Login_Name]) VALUES (2102, CAST(N'2020-10-19 00:00:00.000' AS DateTime), CAST(98103.52 AS Decimal(18, 2)), 3, N'TED/4455847', N'Pagamento de N.F''s. 240281, 240282, 240283 e 240833', CAST(N'2020-10-20 12:59:14.543' AS DateTime), N'Flavio')
INSERT [dbo].[Base_Titulos_Pagos] ([Cod_Base_Titulos_Pagos], [Data_Pagamento], [Total_Pago], [Banco_Debitado], [Numero_Cheque], [Historico], [Data_Login], [Login_Name]) VALUES (2103, CAST(N'2020-11-04 00:00:00.000' AS DateTime), CAST(1650.00 AS Decimal(18, 2)), 3, N'TED 2', N'Pagamento 3ª Parcela de dívida aluguel - 04/11/2020 ', CAST(N'2020-11-09 15:39:46.003' AS DateTime), N'Flavio')
INSERT [dbo].[Base_Titulos_Pagos] ([Cod_Base_Titulos_Pagos], [Data_Pagamento], [Total_Pago], [Banco_Debitado], [Numero_Cheque], [Historico], [Data_Login], [Login_Name]) VALUES (2104, CAST(N'2020-11-05 00:00:00.000' AS DateTime), CAST(12000.00 AS Decimal(18, 2)), 3, N'Boleto', N'Pagamento Marcelo Araújo - Boleto - Serviço de Contabilidade', CAST(N'2020-11-10 13:07:44.943' AS DateTime), N'Flavio')
INSERT [dbo].[Base_Titulos_Pagos] ([Cod_Base_Titulos_Pagos], [Data_Pagamento], [Total_Pago], [Banco_Debitado], [Numero_Cheque], [Historico], [Data_Login], [Login_Name]) VALUES (2105, CAST(N'2020-11-04 00:00:00.000' AS DateTime), CAST(2750.00 AS Decimal(18, 2)), 3, N'TED7496340', N'Pagamento Acréscimos - Banco do Brasil - Ressarcimento Flávio Rocha', CAST(N'2020-11-10 13:10:12.973' AS DateTime), N'Flavio')
INSERT [dbo].[Base_Titulos_Pagos] ([Cod_Base_Titulos_Pagos], [Data_Pagamento], [Total_Pago], [Banco_Debitado], [Numero_Cheque], [Historico], [Data_Login], [Login_Name]) VALUES (2106, CAST(N'2020-11-09 00:00:00.000' AS DateTime), CAST(206.54 AS Decimal(18, 2)), 3, N'TED', N'Reembolso de Frete SPXRJ - Material de Trauma HFB/HFA - Azul Cargo', CAST(N'2020-11-10 13:12:53.850' AS DateTime), N'Flavio')
INSERT [dbo].[Base_Titulos_Pagos] ([Cod_Base_Titulos_Pagos], [Data_Pagamento], [Total_Pago], [Banco_Debitado], [Numero_Cheque], [Historico], [Data_Login], [Login_Name]) VALUES (2107, CAST(N'2020-11-11 00:00:00.000' AS DateTime), CAST(12000.00 AS Decimal(18, 2)), 3, N'TED ', N'Pagamento Responsável Técnica - 11/11/2020', CAST(N'2020-11-11 16:58:44.527' AS DateTime), N'Flavio')
INSERT [dbo].[Base_Titulos_Pagos] ([Cod_Base_Titulos_Pagos], [Data_Pagamento], [Total_Pago], [Banco_Debitado], [Numero_Cheque], [Historico], [Data_Login], [Login_Name]) VALUES (2108, CAST(N'2020-11-11 00:00:00.000' AS DateTime), CAST(15304.88 AS Decimal(18, 2)), 3, N'TED ', N'Pagamento N.F.''s Ortosintese - (241270 e 241445)', CAST(N'2020-11-11 17:01:18.630' AS DateTime), N'Flavio')
INSERT [dbo].[Base_Titulos_Pagos] ([Cod_Base_Titulos_Pagos], [Data_Pagamento], [Total_Pago], [Banco_Debitado], [Numero_Cheque], [Historico], [Data_Login], [Login_Name]) VALUES (2109, CAST(N'2020-11-12 00:00:00.000' AS DateTime), CAST(9445.85 AS Decimal(18, 2)), 3, N'DOC', N'Pagamento N.F. 242420 e 242421 - Ortosintese', CAST(N'2020-11-12 22:03:01.083' AS DateTime), N'Flavio')
INSERT [dbo].[Base_Titulos_Pagos] ([Cod_Base_Titulos_Pagos], [Data_Pagamento], [Total_Pago], [Banco_Debitado], [Numero_Cheque], [Historico], [Data_Login], [Login_Name]) VALUES (2110, CAST(N'2020-11-12 00:00:00.000' AS DateTime), CAST(4974.63 AS Decimal(18, 2)), 3, N'Transf.Caixa', N'Depósitio Efetuado Dr. Jonas - Poupança Caixa - Adiantamento Dep. Judicial', CAST(N'2020-11-12 22:06:10.427' AS DateTime), N'Flavio')
INSERT [dbo].[Base_Titulos_Pagos] ([Cod_Base_Titulos_Pagos], [Data_Pagamento], [Total_Pago], [Banco_Debitado], [Numero_Cheque], [Historico], [Data_Login], [Login_Name]) VALUES (2111, CAST(N'2020-11-13 00:00:00.000' AS DateTime), CAST(1500.00 AS Decimal(18, 2)), 3, N'TED4', N'Pagamento 4ª Parcela - Repactuação Aluguel - 13/11/2020', CAST(N'2020-11-30 14:21:26.110' AS DateTime), N'Flavio')
INSERT [dbo].[Base_Titulos_Pagos] ([Cod_Base_Titulos_Pagos], [Data_Pagamento], [Total_Pago], [Banco_Debitado], [Numero_Cheque], [Historico], [Data_Login], [Login_Name]) VALUES (2112, CAST(N'2020-11-16 00:00:00.000' AS DateTime), CAST(164.89 AS Decimal(18, 2)), 3, N'DOC5969777', N'Acordo Rescisão NET-Claro (Telefone + Internet) Total 164,89', CAST(N'2020-11-30 14:35:06.750' AS DateTime), N'Flavio')
SET IDENTITY_INSERT [dbo].[Base_Titulos_Pagos] OFF
SET IDENTITY_INSERT [dbo].[Base_Titulos_Recebidos] ON 

INSERT [dbo].[Base_Titulos_Recebidos] ([Cod_Base_Titulos_a_Recebidos], [Data_Recebimento], [Total_Recebido], [Banco_Creditado], [Historico], [NumeroNF], [Data_Login], [Login_Name]) VALUES (60, CAST(N'2020-08-20 12:07:26.323' AS DateTime), CAST(77142.00 AS Decimal(18, 2)), 1, N'Pagamento N.F. Bonsucesso - Banco do Brasil -', N'42', CAST(N'2020-08-20 00:00:00.000' AS DateTime), N'Flavio')
INSERT [dbo].[Base_Titulos_Recebidos] ([Cod_Base_Titulos_a_Recebidos], [Data_Recebimento], [Total_Recebido], [Banco_Creditado], [Historico], [NumeroNF], [Data_Login], [Login_Name]) VALUES (61, CAST(N'2020-08-20 12:12:39.187' AS DateTime), CAST(12982.50 AS Decimal(18, 2)), 3, N'Pagamento N.F. Bonsucesso - Banco Bradesco - 20/08/2020', N'50', CAST(N'2020-08-20 00:00:00.000' AS DateTime), N'Flavio')
INSERT [dbo].[Base_Titulos_Recebidos] ([Cod_Base_Titulos_a_Recebidos], [Data_Recebimento], [Total_Recebido], [Banco_Creditado], [Historico], [NumeroNF], [Data_Login], [Login_Name]) VALUES (62, CAST(N'2020-08-24 07:49:17.000' AS DateTime), CAST(3290.00 AS Decimal(18, 2)), 3, N'Nota Fiscal referente a Cirurgia de Trauma - HFA', N'44', CAST(N'2020-08-27 00:00:00.000' AS DateTime), N'Flavio')
INSERT [dbo].[Base_Titulos_Recebidos] ([Cod_Base_Titulos_a_Recebidos], [Data_Recebimento], [Total_Recebido], [Banco_Creditado], [Historico], [NumeroNF], [Data_Login], [Login_Name]) VALUES (63, CAST(N'2020-09-04 15:44:28.517' AS DateTime), CAST(19780.00 AS Decimal(18, 2)), 3, N'Pagamento Nota Fiscal HFB - Material de Empenho', N'51', CAST(N'2020-09-19 00:00:00.000' AS DateTime), N'Flavio')
INSERT [dbo].[Base_Titulos_Recebidos] ([Cod_Base_Titulos_a_Recebidos], [Data_Recebimento], [Total_Recebido], [Banco_Creditado], [Historico], [NumeroNF], [Data_Login], [Login_Name]) VALUES (67, CAST(N'2020-10-05 11:12:00.000' AS DateTime), CAST(6038.50 AS Decimal(18, 2)), 3, N'Pagamento N.F. HFB - Material de Trauma', N'54', CAST(N'2020-10-07 00:00:00.000' AS DateTime), N'Flavio')
INSERT [dbo].[Base_Titulos_Recebidos] ([Cod_Base_Titulos_a_Recebidos], [Data_Recebimento], [Total_Recebido], [Banco_Creditado], [Historico], [NumeroNF], [Data_Login], [Login_Name]) VALUES (68, CAST(N'2020-10-15 12:50:08.000' AS DateTime), CAST(86245.90 AS Decimal(18, 2)), 3, N'Pagamento HFB - Empenho de Trauma', N'55', CAST(N'2020-10-20 00:00:00.000' AS DateTime), N'Flavio')
INSERT [dbo].[Base_Titulos_Recebidos] ([Cod_Base_Titulos_a_Recebidos], [Data_Recebimento], [Total_Recebido], [Banco_Creditado], [Historico], [NumeroNF], [Data_Login], [Login_Name]) VALUES (69, CAST(N'2020-10-01 14:15:09.300' AS DateTime), CAST(22129.90 AS Decimal(18, 2)), 3, N'Recebimento HFB - TED Eletr. Material Trauma - Empenho', N'56', CAST(N'2020-10-22 00:00:00.000' AS DateTime), N'Flavio')
INSERT [dbo].[Base_Titulos_Recebidos] ([Cod_Base_Titulos_a_Recebidos], [Data_Recebimento], [Total_Recebido], [Banco_Creditado], [Historico], [NumeroNF], [Data_Login], [Login_Name]) VALUES (70, CAST(N'2020-11-04 15:26:44.000' AS DateTime), CAST(31325.00 AS Decimal(18, 2)), 3, N'Recebimento N.F. 058 - HFB ', N'58', CAST(N'2020-11-09 00:00:00.000' AS DateTime), N'Flavio')
INSERT [dbo].[Base_Titulos_Recebidos] ([Cod_Base_Titulos_a_Recebidos], [Data_Recebimento], [Total_Recebido], [Banco_Creditado], [Historico], [NumeroNF], [Data_Login], [Login_Name]) VALUES (71, CAST(N'2020-11-11 17:22:48.293' AS DateTime), CAST(37400.00 AS Decimal(18, 2)), 3, N'Recebimento de Nota Fiscal - 057 HFB', N'57', CAST(N'2020-11-11 00:00:00.000' AS DateTime), N'Flavio')
INSERT [dbo].[Base_Titulos_Recebidos] ([Cod_Base_Titulos_a_Recebidos], [Data_Recebimento], [Total_Recebido], [Banco_Creditado], [Historico], [NumeroNF], [Data_Login], [Login_Name]) VALUES (72, CAST(N'2020-11-12 21:54:27.000' AS DateTime), CAST(27955.00 AS Decimal(18, 2)), 3, N'Recebimento N.F. 052 - H.F. Andaraí', N'52', CAST(N'2020-11-12 00:00:00.000' AS DateTime), N'Flavio')
INSERT [dbo].[Base_Titulos_Recebidos] ([Cod_Base_Titulos_a_Recebidos], [Data_Recebimento], [Total_Recebido], [Banco_Creditado], [Historico], [NumeroNF], [Data_Login], [Login_Name]) VALUES (73, CAST(N'2020-12-03 11:39:50.000' AS DateTime), CAST(81279.40 AS Decimal(18, 2)), 3, N'Nota Fiscal 060 - Recebido HFB - 03/12/2020.', N'60', CAST(N'2020-12-04 00:00:00.000' AS DateTime), N'Flavio')
INSERT [dbo].[Base_Titulos_Recebidos] ([Cod_Base_Titulos_a_Recebidos], [Data_Recebimento], [Total_Recebido], [Banco_Creditado], [Historico], [NumeroNF], [Data_Login], [Login_Name]) VALUES (76, CAST(N'2020-12-11 15:21:29.573' AS DateTime), CAST(17060.00 AS Decimal(18, 2)), 3, N'Recebimento N.F. 061 - HFB - Material de Empenho 2020NE800333', N'61', CAST(N'2020-12-11 00:00:00.000' AS DateTime), N'Flavio')
INSERT [dbo].[Base_Titulos_Recebidos] ([Cod_Base_Titulos_a_Recebidos], [Data_Recebimento], [Total_Recebido], [Banco_Creditado], [Historico], [NumeroNF], [Data_Login], [Login_Name]) VALUES (77, CAST(N'2020-12-11 15:32:52.210' AS DateTime), CAST(28883.50 AS Decimal(18, 2)), 3, N'Recebimento N.F.062 - HFB - Empenho 2020NE800855', N'62', CAST(N'2020-12-11 00:00:00.000' AS DateTime), N'Flavio')
SET IDENTITY_INSERT [dbo].[Base_Titulos_Recebidos] OFF
SET IDENTITY_INSERT [dbo].[Centro_Custos] ON 

INSERT [dbo].[Centro_Custos] ([Cod_Centro_Custos], [Descricao_Centro_Custos], [Data_Login], [Login_Name]) VALUES (1, N'Administração Geral', CAST(N'2018-09-22 11:19:05.000' AS DateTime), N'Flavio')
INSERT [dbo].[Centro_Custos] ([Cod_Centro_Custos], [Descricao_Centro_Custos], [Data_Login], [Login_Name]) VALUES (2, N'Produção / Operacional', CAST(N'2018-08-27 23:25:32.000' AS DateTime), N'Flavio')
INSERT [dbo].[Centro_Custos] ([Cod_Centro_Custos], [Descricao_Centro_Custos], [Data_Login], [Login_Name]) VALUES (3, N'Vendas - Ortopedia', CAST(N'2018-08-27 23:26:10.000' AS DateTime), N'Flavio')
INSERT [dbo].[Centro_Custos] ([Cod_Centro_Custos], [Descricao_Centro_Custos], [Data_Login], [Login_Name]) VALUES (4, N'Vendas - Marketing', CAST(N'2018-09-22 00:00:00.000' AS DateTime), N'Daniella')
INSERT [dbo].[Centro_Custos] ([Cod_Centro_Custos], [Descricao_Centro_Custos], [Data_Login], [Login_Name]) VALUES (5, N'Almoxarifado - Distribuição', CAST(N'2019-01-01 10:59:31.000' AS DateTime), N'Flavio')
SET IDENTITY_INSERT [dbo].[Centro_Custos] OFF
SET IDENTITY_INSERT [dbo].[Clientes_Contas_a_Receber] ON 

INSERT [dbo].[Clientes_Contas_a_Receber] ([Cod_Cliente_Contas_a_Receber], [Nome_Cliente], [Endereço_Cliente], [Bairro_Cliente], [Municipio_Cliente], [Estado], [Telefone], [Celular], [Email], [CNPJ], [Identificacao], [Status], [Data_Login], [Login_Name], [Cod_Grupo]) VALUES (7, N'Hospital Federal de Bonsucesso', N'Av. Londres 616, 4º Andar   - Cep: 21041-000', N'Bonsucesso', N'Rio de Janeiro', N'RJ', N'(21)3977-9551', NULL, NULL, N'00.394.544/0202-91', NULL, 1, CAST(N'2020-04-03 16:52:30.000' AS DateTime), N'Flavio', 2)
INSERT [dbo].[Clientes_Contas_a_Receber] ([Cod_Cliente_Contas_a_Receber], [Nome_Cliente], [Endereço_Cliente], [Bairro_Cliente], [Municipio_Cliente], [Estado], [Telefone], [Celular], [Email], [CNPJ], [Identificacao], [Status], [Data_Login], [Login_Name], [Cod_Grupo]) VALUES (1007, N'Hospital Federal do Andaraí ', N'Rua Gastão Penalva, 119 - Cep:20540-220', N'Andaraí', N'Rio de Janeiro', N'RJ', N'2575-7046', NULL, NULL, N'00.394.544/0201-00', NULL, 1, CAST(N'2020-08-18 11:09:13.000' AS DateTime), N'Flavio', 2)
INSERT [dbo].[Clientes_Contas_a_Receber] ([Cod_Cliente_Contas_a_Receber], [Nome_Cliente], [Endereço_Cliente], [Bairro_Cliente], [Municipio_Cliente], [Estado], [Telefone], [Celular], [Email], [CNPJ], [Identificacao], [Status], [Data_Login], [Login_Name], [Cod_Grupo]) VALUES (1008, N'Hospital Federal de Ipanema', N'Rua Antônio Parreiras, 67', N'Ipanema', N'Rio de Janeiro', N'RJ', NULL, NULL, NULL, N'00.394.544/0210-00', N'Hospital de Ipanema', 1, CAST(N'2020-12-04 11:25:44.000' AS DateTime), N'Flavio', 2)
SET IDENTITY_INSERT [dbo].[Clientes_Contas_a_Receber] OFF
SET IDENTITY_INSERT [dbo].[Contas_Despesas] ON 

INSERT [dbo].[Contas_Despesas] ([Cod_Despesa], [Descricao_Despesa], [Codigo_Despesa_Contab], [Tipo_Despesa], [Data_Login], [Login_Name]) VALUES (1, N'Despesa de Aluguel + Condomínio', CAST(1211 AS Numeric(12, 0)), N'Despesa Administrativa', CAST(N'2019-08-16 15:35:18.000' AS DateTime), N'Flavio')
INSERT [dbo].[Contas_Despesas] ([Cod_Despesa], [Descricao_Despesa], [Codigo_Despesa_Contab], [Tipo_Despesa], [Data_Login], [Login_Name]) VALUES (2, N'Desepesa de Telefonia e Internet', CAST(1312 AS Numeric(12, 0)), N'Despesa Administrativa', CAST(N'2019-08-16 15:35:39.000' AS DateTime), N'Flavio')
INSERT [dbo].[Contas_Despesas] ([Cod_Despesa], [Descricao_Despesa], [Codigo_Despesa_Contab], [Tipo_Despesa], [Data_Login], [Login_Name]) VALUES (3, N'Despesa de Combustível - Produção', CAST(1019 AS Numeric(12, 0)), N'Despesa Operacional', CAST(N'2019-08-16 15:26:39.000' AS DateTime), N'Flavio')
INSERT [dbo].[Contas_Despesas] ([Cod_Despesa], [Descricao_Despesa], [Codigo_Despesa_Contab], [Tipo_Despesa], [Data_Login], [Login_Name]) VALUES (4, N'Despesas de Cópias e papelaria', CAST(1245 AS Numeric(12, 0)), N'Despesa Administrativa', CAST(N'2019-08-16 15:36:56.000' AS DateTime), N'Flavio')
INSERT [dbo].[Contas_Despesas] ([Cod_Despesa], [Descricao_Despesa], [Codigo_Despesa_Contab], [Tipo_Despesa], [Data_Login], [Login_Name]) VALUES (5, N'Despesas de Luz - Ligth', CAST(1396 AS Numeric(12, 0)), N'Despesa Administrativa', CAST(N'2019-08-16 15:37:15.000' AS DateTime), N'Flavio')
INSERT [dbo].[Contas_Despesas] ([Cod_Despesa], [Descricao_Despesa], [Codigo_Despesa_Contab], [Tipo_Despesa], [Data_Login], [Login_Name]) VALUES (6, N'Despesa de Manutenção de Veículo - Produção', CAST(1795 AS Numeric(12, 0)), N'Despesa Operacional', CAST(N'2019-08-16 15:38:48.000' AS DateTime), N'Flavio')
INSERT [dbo].[Contas_Despesas] ([Cod_Despesa], [Descricao_Despesa], [Codigo_Despesa_Contab], [Tipo_Despesa], [Data_Login], [Login_Name]) VALUES (7, N'Despesa de Eventos - Vendas/ Marketing', CAST(1874 AS Numeric(12, 0)), N'Despesa Operacional', CAST(N'2019-08-16 15:39:07.000' AS DateTime), N'Flavio')
INSERT [dbo].[Contas_Despesas] ([Cod_Despesa], [Descricao_Despesa], [Codigo_Despesa_Contab], [Tipo_Despesa], [Data_Login], [Login_Name]) VALUES (8, N'Despesas de Pagamento de Impostos s/Venda', CAST(1975 AS Numeric(12, 0)), N'Despesa Operacional', CAST(N'2019-08-16 15:20:32.000' AS DateTime), N'Flavio')
INSERT [dbo].[Contas_Despesas] ([Cod_Despesa], [Descricao_Despesa], [Codigo_Despesa_Contab], [Tipo_Despesa], [Data_Login], [Login_Name]) VALUES (9, N'Despesa de Fretes -FOB-Fabricantes ', CAST(14897 AS Numeric(12, 0)), N'Despesa Operacional', CAST(N'2019-08-16 15:41:22.000' AS DateTime), N'Flavio')
INSERT [dbo].[Contas_Despesas] ([Cod_Despesa], [Descricao_Despesa], [Codigo_Despesa_Contab], [Tipo_Despesa], [Data_Login], [Login_Name]) VALUES (10, N'Despesa de Manutenção de Equipamentos / Prod.', CAST(15987 AS Numeric(12, 0)), N'Despesa Operacional', CAST(N'2019-08-16 15:34:53.000' AS DateTime), N'Flavio')
INSERT [dbo].[Contas_Despesas] ([Cod_Despesa], [Descricao_Despesa], [Codigo_Despesa_Contab], [Tipo_Despesa], [Data_Login], [Login_Name]) VALUES (11, N'Despesa de Pagamento de Taxas e Consultorias', CAST(17965 AS Numeric(12, 0)), N'Despesa Administrativa', CAST(N'2019-08-16 15:42:58.000' AS DateTime), N'Flavio')
INSERT [dbo].[Contas_Despesas] ([Cod_Despesa], [Descricao_Despesa], [Codigo_Despesa_Contab], [Tipo_Despesa], [Data_Login], [Login_Name]) VALUES (12, N'Despesa Compra de Mercadoria p/ Venda - CMV', CAST(1313 AS Numeric(12, 0)), N'Despesa Operacional', CAST(N'2019-11-17 00:00:00.000' AS DateTime), N'Flavio')
SET IDENTITY_INSERT [dbo].[Contas_Despesas] OFF
SET IDENTITY_INSERT [dbo].[Entrada_Titulos_a_Pagar] ON 

INSERT [dbo].[Entrada_Titulos_a_Pagar] ([Cod_Entrada_Titulos_a_Pagar], [Cod_Fornecedor], [Numero_Documento], [Data_Documento], [Data_Vencimento], [Valor_Titulo], [Valor_Pago_a_Vista], [Acrescimos], [Descontos], [Saldo], [Numero_Parcelas], [Cod_Centro_Custos], [Cod_Status_Titulo], [Cod_Despesa], [Historico_Titulo], [Observacao], [Data_Login], [Login_Name]) VALUES (1074, 14, N'0001', CAST(N'2020-07-31 00:00:00.000' AS DateTime), CAST(N'2020-08-31 00:00:00.000' AS DateTime), CAST(18000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(18000.00 AS Decimal(18, 2)), 12, 1, 1, 1, N'Repactuação de dívida de Aluguel - Marcelo Araújo Advogado', N'Repactuação de dívida do Aluguel', CAST(N'2020-09-24 00:00:00.000' AS DateTime), N'Flavio')
INSERT [dbo].[Entrada_Titulos_a_Pagar] ([Cod_Entrada_Titulos_a_Pagar], [Cod_Fornecedor], [Numero_Documento], [Data_Documento], [Data_Vencimento], [Valor_Titulo], [Valor_Pago_a_Vista], [Acrescimos], [Descontos], [Saldo], [Numero_Parcelas], [Cod_Centro_Custos], [Cod_Status_Titulo], [Cod_Despesa], [Historico_Titulo], [Observacao], [Data_Login], [Login_Name]) VALUES (1077, 3, N'241445', CAST(N'2020-09-30 00:00:00.000' AS DateTime), CAST(N'2020-11-14 00:00:00.000' AS DateTime), CAST(7050.13 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(7050.13 AS Decimal(18, 2)), 1, 3, 1, 12, N'Material de Trauma - HFB ', N'Material de Empenho HFB', CAST(N'2020-10-07 00:00:00.000' AS DateTime), N'Flavio')
INSERT [dbo].[Entrada_Titulos_a_Pagar] ([Cod_Entrada_Titulos_a_Pagar], [Cod_Fornecedor], [Numero_Documento], [Data_Documento], [Data_Vencimento], [Valor_Titulo], [Valor_Pago_a_Vista], [Acrescimos], [Descontos], [Saldo], [Numero_Parcelas], [Cod_Centro_Custos], [Cod_Status_Titulo], [Cod_Despesa], [Historico_Titulo], [Observacao], [Data_Login], [Login_Name]) VALUES (1084, 16, N'001', CAST(N'2020-10-26 00:00:00.000' AS DateTime), CAST(N'2020-12-01 00:00:00.000' AS DateTime), CAST(12000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(12000.00 AS Decimal(18, 2)), 1, 1, 1, 11, N'Serviços de Contabilidade - Marcelo Araújo para Renaissance Medical', N'Serviços de Contabilidade - 60 meses', CAST(N'2020-10-26 00:00:00.000' AS DateTime), N'Flavio')
INSERT [dbo].[Entrada_Titulos_a_Pagar] ([Cod_Entrada_Titulos_a_Pagar], [Cod_Fornecedor], [Numero_Documento], [Data_Documento], [Data_Vencimento], [Valor_Titulo], [Valor_Pago_a_Vista], [Acrescimos], [Descontos], [Saldo], [Numero_Parcelas], [Cod_Centro_Custos], [Cod_Status_Titulo], [Cod_Despesa], [Historico_Titulo], [Observacao], [Data_Login], [Login_Name]) VALUES (1085, 17, N'001', CAST(N'2020-10-26 00:00:00.000' AS DateTime), CAST(N'2020-12-01 00:00:00.000' AS DateTime), CAST(12000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(12000.00 AS Decimal(18, 2)), 1, 1, 1, 11, N'Serviço de Responsabilidade Técnica - Andrea - 36 meses', N'Serviço de Responsabilidade Técnica', CAST(N'2020-10-26 00:00:00.000' AS DateTime), N'Flavio')
INSERT [dbo].[Entrada_Titulos_a_Pagar] ([Cod_Entrada_Titulos_a_Pagar], [Cod_Fornecedor], [Numero_Documento], [Data_Documento], [Data_Vencimento], [Valor_Titulo], [Valor_Pago_a_Vista], [Acrescimos], [Descontos], [Saldo], [Numero_Parcelas], [Cod_Centro_Custos], [Cod_Status_Titulo], [Cod_Despesa], [Historico_Titulo], [Observacao], [Data_Login], [Login_Name]) VALUES (1086, 15, N'002', CAST(N'2020-10-26 00:00:00.000' AS DateTime), CAST(N'2020-12-01 00:00:00.000' AS DateTime), CAST(7500.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(7500.00 AS Decimal(18, 2)), 1, 1, 1, 11, N'Honorários Advocatícios - Dr. Jonas (Estimado)', N'Honorários Advocatícios - Dr. Jonas', CAST(N'2020-10-26 00:00:00.000' AS DateTime), N'Flavio')
INSERT [dbo].[Entrada_Titulos_a_Pagar] ([Cod_Entrada_Titulos_a_Pagar], [Cod_Fornecedor], [Numero_Documento], [Data_Documento], [Data_Vencimento], [Valor_Titulo], [Valor_Pago_a_Vista], [Acrescimos], [Descontos], [Saldo], [Numero_Parcelas], [Cod_Centro_Custos], [Cod_Status_Titulo], [Cod_Despesa], [Historico_Titulo], [Observacao], [Data_Login], [Login_Name]) VALUES (1091, 3, N'243676', CAST(N'2020-11-30 00:00:00.000' AS DateTime), CAST(N'2020-12-30 00:00:00.000' AS DateTime), CAST(391.18 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(391.18 AS Decimal(18, 2)), 1, 3, 1, 12, N'Instrumental Volar - HFI e HFB ', N'Instrumental Volar - HFI', CAST(N'2020-12-04 00:00:00.000' AS DateTime), N'Flavio')
INSERT [dbo].[Entrada_Titulos_a_Pagar] ([Cod_Entrada_Titulos_a_Pagar], [Cod_Fornecedor], [Numero_Documento], [Data_Documento], [Data_Vencimento], [Valor_Titulo], [Valor_Pago_a_Vista], [Acrescimos], [Descontos], [Saldo], [Numero_Parcelas], [Cod_Centro_Custos], [Cod_Status_Titulo], [Cod_Despesa], [Historico_Titulo], [Observacao], [Data_Login], [Login_Name]) VALUES (1092, 3, N'243462', CAST(N'2020-11-25 00:00:00.000' AS DateTime), CAST(N'2020-12-30 00:00:00.000' AS DateTime), CAST(66417.86 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(66417.86 AS Decimal(18, 2)), 1, 3, 1, 12, N'Material de Trauma - Empenho - HFI - N.F. 063 - 03/12/2020.', N'Material Trauma - HFI - Empenho', CAST(N'2020-12-04 00:00:00.000' AS DateTime), N'Flavio')
INSERT [dbo].[Entrada_Titulos_a_Pagar] ([Cod_Entrada_Titulos_a_Pagar], [Cod_Fornecedor], [Numero_Documento], [Data_Documento], [Data_Vencimento], [Valor_Titulo], [Valor_Pago_a_Vista], [Acrescimos], [Descontos], [Saldo], [Numero_Parcelas], [Cod_Centro_Custos], [Cod_Status_Titulo], [Cod_Despesa], [Historico_Titulo], [Observacao], [Data_Login], [Login_Name]) VALUES (1093, 13, N'2331725', CAST(N'2020-12-01 00:00:00.000' AS DateTime), CAST(N'2020-12-15 00:00:00.000' AS DateTime), CAST(983.05 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(983.05 AS Decimal(18, 2)), 1, 2, 1, 9, N'Frete Material Trauma - HFI ', N'Frete SPXRJ - Azul Cargo', CAST(N'2020-12-04 00:00:00.000' AS DateTime), N'Flavio')
SET IDENTITY_INSERT [dbo].[Entrada_Titulos_a_Pagar] OFF
SET IDENTITY_INSERT [dbo].[Entrada_Titulos_a_Receber] ON 

INSERT [dbo].[Entrada_Titulos_a_Receber] ([Cod_Entrada_Titulos_a_Receber], [Cod_Cliente], [Numero_NF], [Data_NF], [Valor_NF], [Cod_Receita], [Data_Vencimento], [Numero_Parcelas], [Valor_Pago_a_Vista], [Cod_Status_Titulo], [Codigo_CV], [Historico], [Data_Login], [Login_Name]) VALUES (2060, 1008, N'063', CAST(N'2020-12-03 00:00:00.000' AS DateTime), CAST(220065.00 AS Decimal(18, 2)), 1, CAST(N'2020-12-30 00:00:00.000' AS DateTime), CAST(1 AS Numeric(3, 0)), CAST(0.00 AS Decimal(18, 2)), 1, 0, N'Material de Trauma - HFI - Empenho - Data da Entrega:04/12/2020.', CAST(N'2020-12-04 00:00:00.000' AS DateTime), N'Flavio')
INSERT [dbo].[Entrada_Titulos_a_Receber] ([Cod_Entrada_Titulos_a_Receber], [Cod_Cliente], [Numero_NF], [Data_NF], [Valor_NF], [Cod_Receita], [Data_Vencimento], [Numero_Parcelas], [Valor_Pago_a_Vista], [Cod_Status_Titulo], [Codigo_CV], [Historico], [Data_Login], [Login_Name]) VALUES (2062, 7, N'065', CAST(N'2020-12-03 00:00:00.000' AS DateTime), CAST(15240.00 AS Decimal(18, 2)), 1, CAST(N'2020-12-31 00:00:00.000' AS DateTime), CAST(1 AS Numeric(3, 0)), CAST(0.00 AS Decimal(18, 2)), 1, 0, N'Material de Trauma - Empenho 2020NE800855 - Data da Entrega:04/12/2020.', CAST(N'2020-12-04 00:00:00.000' AS DateTime), N'Flavio')
INSERT [dbo].[Entrada_Titulos_a_Receber] ([Cod_Entrada_Titulos_a_Receber], [Cod_Cliente], [Numero_NF], [Data_NF], [Valor_NF], [Cod_Receita], [Data_Vencimento], [Numero_Parcelas], [Valor_Pago_a_Vista], [Cod_Status_Titulo], [Codigo_CV], [Historico], [Data_Login], [Login_Name]) VALUES (2066, 7, N'064', CAST(N'2020-12-03 00:00:00.000' AS DateTime), CAST(9870.00 AS Decimal(18, 2)), 1, CAST(N'2020-12-30 00:00:00.000' AS DateTime), CAST(1 AS Numeric(3, 0)), CAST(0.00 AS Decimal(18, 2)), 1, 0, N'Material Trauma - HFB - Empenho 2020NE800333', CAST(N'2020-12-11 00:00:00.000' AS DateTime), N'Flavio')
SET IDENTITY_INSERT [dbo].[Entrada_Titulos_a_Receber] OFF
SET IDENTITY_INSERT [dbo].[Fornecedor_Contas_a_Pagar] ON 

INSERT [dbo].[Fornecedor_Contas_a_Pagar] ([Cod_Fornecedor], [Nome_Fornecedor], [Endereco], [Bairro], [Cidade], [Estado], [CEP], [Telefone_1], [Telefone_2], [Celular], [Email], [CNPJ], [Cod_Status_Fornecedor], [Data_Cadastro], [Inscricao_Estadual], [CPF], [Identificacao], [Data_Login], [Login_Name]) VALUES (3, N'Ortosintese Ind. & Com. Ltda.', N'Rua Professor Affonso José Fioravanti, 63', N'Loteamento City Jaraguá', N'São Paul', N'SP', N'02998-010 ', N'(11)3948-4000', N'1139484010', N'11999564870', N'cristina.ortopedia@ortosintese.com.br', N'48.240.709/0001-90', 1, CAST(N'2018-02-20 00:00:00.000' AS DateTime), N'110367370110', NULL, N'ORTOSINTESE', CAST(N'2018-11-11 12:20:24.000' AS DateTime), N'Flavio')
INSERT [dbo].[Fornecedor_Contas_a_Pagar] ([Cod_Fornecedor], [Nome_Fornecedor], [Endereco], [Bairro], [Cidade], [Estado], [CEP], [Telefone_1], [Telefone_2], [Celular], [Email], [CNPJ], [Cod_Status_Fornecedor], [Data_Cadastro], [Inscricao_Estadual], [CPF], [Identificacao], [Data_Login], [Login_Name]) VALUES (12, N'Jamef Transportes EIRELI - SAO', N'Rua Miguel Mentem, 600', N'Vila Guilherme', N'São Paulo ', N'SP', N'02050-010 ', N'1121216161', NULL, NULL, NULL, N'20.147.617/0022-76', NULL, NULL, N'114387171114', NULL, N'JAMEF', CAST(N'2020-08-18 11:16:28.000' AS DateTime), N'Flavio')
INSERT [dbo].[Fornecedor_Contas_a_Pagar] ([Cod_Fornecedor], [Nome_Fornecedor], [Endereco], [Bairro], [Cidade], [Estado], [CEP], [Telefone_1], [Telefone_2], [Celular], [Email], [CNPJ], [Cod_Status_Fornecedor], [Data_Cadastro], [Inscricao_Estadual], [CPF], [Identificacao], [Data_Login], [Login_Name]) VALUES (13, N'Azul Linhas Aéreas Brasileiras S.A.', N'Rodovia Santos Dumont S/N.', N'Parque Viracopos', N'Campinas', N'SP', N'13052-448 ', NULL, NULL, NULL, NULL, N'09.296.295/0002-40', NULL, NULL, N'206265026118', NULL, N'AZUL ', CAST(N'2020-08-18 11:21:34.000' AS DateTime), N'Flavio')
INSERT [dbo].[Fornecedor_Contas_a_Pagar] ([Cod_Fornecedor], [Nome_Fornecedor], [Endereco], [Bairro], [Cidade], [Estado], [CEP], [Telefone_1], [Telefone_2], [Celular], [Email], [CNPJ], [Cod_Status_Fornecedor], [Data_Cadastro], [Inscricao_Estadual], [CPF], [Identificacao], [Data_Login], [Login_Name]) VALUES (14, N'Repactuação de Dívida - Marcelo Araújo Advogado', N'Rua Roberval Cordeiro de Farias, 230 Sl. 105', N'Recreio dos Bandeirantes', N'Rio de Janeiro', N'RJ', N'22795-325 ', NULL, NULL, N'21991568008', N'ojuara53.2@gmail.com', N'15.111.975/0001-64', NULL, NULL, NULL, N'467.512.547-6', N'Repactuação ', CAST(N'2020-09-24 10:43:39.000' AS DateTime), N'Flavio')
INSERT [dbo].[Fornecedor_Contas_a_Pagar] ([Cod_Fornecedor], [Nome_Fornecedor], [Endereco], [Bairro], [Cidade], [Estado], [CEP], [Telefone_1], [Telefone_2], [Celular], [Email], [CNPJ], [Cod_Status_Fornecedor], [Data_Cadastro], [Inscricao_Estadual], [CPF], [Identificacao], [Data_Login], [Login_Name]) VALUES (15, N'JTN-Consultoria (Dr.Jonas - Advogado)', N'Rua Amaury Monteiro, 35 - Sala 214', N'Recreio dos Bandeirantes', N'Rio de Janeiro', N'RJ', N'22790-110 ', N'2124374247', N'2124376447', NULL, N'j.t.n.advogados@uol.com.br', N'13.809.388/0001-18', NULL, NULL, NULL, NULL, N'JTN-Consultoria', CAST(N'2020-10-22 09:35:59.000' AS DateTime), N'Flavio')
INSERT [dbo].[Fornecedor_Contas_a_Pagar] ([Cod_Fornecedor], [Nome_Fornecedor], [Endereco], [Bairro], [Cidade], [Estado], [CEP], [Telefone_1], [Telefone_2], [Celular], [Email], [CNPJ], [Cod_Status_Fornecedor], [Data_Cadastro], [Inscricao_Estadual], [CPF], [Identificacao], [Data_Login], [Login_Name]) VALUES (16, N'M.Araújo Consultoria', N'Av. das Américas,', N'Recreio dos Bandeirantes', N'Rio de Janeiro', N'RJ', N'22790-100 ', N'2132597930', N'2132597947', N'21970042414', N'marcelo@maraujo.com.br', NULL, NULL, NULL, NULL, NULL, N'Marcelo Araújo - Contador', CAST(N'2020-10-26 21:59:12.000' AS DateTime), N'Flavio')
INSERT [dbo].[Fornecedor_Contas_a_Pagar] ([Cod_Fornecedor], [Nome_Fornecedor], [Endereco], [Bairro], [Cidade], [Estado], [CEP], [Telefone_1], [Telefone_2], [Celular], [Email], [CNPJ], [Cod_Status_Fornecedor], [Data_Cadastro], [Inscricao_Estadual], [CPF], [Identificacao], [Data_Login], [Login_Name]) VALUES (17, N'Responsável Técnica - Enfa. Andréa ', NULL, N'Cascatinha', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Responsável Técnica', CAST(N'2020-10-26 22:00:31.000' AS DateTime), N'Flavio')
INSERT [dbo].[Fornecedor_Contas_a_Pagar] ([Cod_Fornecedor], [Nome_Fornecedor], [Endereco], [Bairro], [Cidade], [Estado], [CEP], [Telefone_1], [Telefone_2], [Celular], [Email], [CNPJ], [Cod_Status_Fornecedor], [Data_Cadastro], [Inscricao_Estadual], [CPF], [Identificacao], [Data_Login], [Login_Name]) VALUES (18, N'NET - Claro', NULL, N'Barra da Tijuca', NULL, NULL, NULL, N'  10621', NULL, NULL, NULL, NULL, NULL, CAST(N'2020-11-30 00:00:00.000' AS DateTime), NULL, NULL, NULL, CAST(N'2020-11-30 14:26:37.000' AS DateTime), N'Flavio')
SET IDENTITY_INSERT [dbo].[Fornecedor_Contas_a_Pagar] OFF
SET IDENTITY_INSERT [dbo].[Grupo] ON 

INSERT [dbo].[Grupo] ([Cod_Grupo], [Grupo_Descricao], [Data_Login], [Login_Name]) VALUES (2, N'Hospital Público', CAST(N'2018-11-02 20:46:41.000' AS DateTime), N'Flavio')
INSERT [dbo].[Grupo] ([Cod_Grupo], [Grupo_Descricao], [Data_Login], [Login_Name]) VALUES (3, N'Hospital Privado', CAST(N'2018-08-27 23:27:53.000' AS DateTime), N'Flavio')
INSERT [dbo].[Grupo] ([Cod_Grupo], [Grupo_Descricao], [Data_Login], [Login_Name]) VALUES (4, N'Plano de Saúde', CAST(N'2018-08-27 23:28:14.000' AS DateTime), N'Flavio')
SET IDENTITY_INSERT [dbo].[Grupo] OFF
SET IDENTITY_INSERT [dbo].[Lancamentos] ON 

INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (34, 1, 0, 61, 3, N'226046-8', N'', CAST(N'2020-08-14 00:00:00.000' AS DateTime), N'Recebimento de Nota fiscal - HFB -N.F. 50 - Com.Victor OK', CAST(12982.50 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(12982.50 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(12982.50 AS Decimal(18, 2)), CAST(N'2020-11-02 21:48:33.037' AS DateTime), N'Flavio')
INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (35, 5, 0, 0, 3, N'226046-8', N'   ', CAST(N'2020-08-20 00:00:00.000' AS DateTime), N'Tarifa Bancária - Dcto.10420', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(82.70 AS Decimal(18, 2)), CAST(12982.50 AS Decimal(18, 2)), CAST(12899.80 AS Decimal(18, 2)), CAST(N'2020-11-02 21:50:02.180' AS DateTime), N'Flavio')
INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (36, 5, 0, 0, 3, N'226046-8', N'   ', CAST(N'2020-08-20 00:00:00.000' AS DateTime), N'Tarifa Bancária - R$86,70 x 4 = 346,80', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(346.80 AS Decimal(18, 2)), CAST(12899.80 AS Decimal(18, 2)), CAST(12553.00 AS Decimal(18, 2)), CAST(N'2020-09-24 12:03:50.237' AS DateTime), N'Flavio')
INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (37, 3, 0, 0, 3, N'226046-8', N'DOC', CAST(N'2020-08-20 00:00:00.000' AS DateTime), N'Depósito Ressarcimento de terceiros - DOC p/ Victor(Barbara+Amigos+Victor+Bira)', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(6250.00 AS Decimal(18, 2)), CAST(12553.00 AS Decimal(18, 2)), CAST(6303.00 AS Decimal(18, 2)), CAST(N'2020-10-22 14:19:53.997' AS DateTime), N'Flavio')
INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (38, 3, 0, 0, 3, N'226046-8', N'DOC', CAST(N'2020-08-20 00:00:00.000' AS DateTime), N'DOC p/ Daniella - Pagamentos Diversos e Ressarcimento Flávio', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(6250.00 AS Decimal(18, 2)), CAST(6303.00 AS Decimal(18, 2)), CAST(53.00 AS Decimal(18, 2)), CAST(N'2020-09-24 12:08:44.490' AS DateTime), N'Flavio')
INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (39, 1, 0, 62, 3, N'226046-8', N'', CAST(N'2020-08-24 00:00:00.000' AS DateTime), N'Pagamento Nota Fiscal - HFA - Cirurgia Trauma - Material Aço N;F.44 ', CAST(3290.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(3290.00 AS Decimal(18, 2)), CAST(53.00 AS Decimal(18, 2)), CAST(3343.00 AS Decimal(18, 2)), CAST(N'2020-11-02 22:09:15.247' AS DateTime), N'Flavio')
INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (40, 4, 0, 0, 3, N'226046-8', N'DOC', CAST(N'2020-08-31 00:00:00.000' AS DateTime), N'DOC Victor - Retorno de Retirada - DOC 20/08.', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(3641.12 AS Decimal(18, 2)), CAST(3343.00 AS Decimal(18, 2)), CAST(6984.12 AS Decimal(18, 2)), CAST(N'2020-09-24 12:15:38.783' AS DateTime), N'Flavio')
INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (41, 4, 0, 0, 3, N'226046-8', N'DOC', CAST(N'2020-08-31 00:00:00.000' AS DateTime), N'Depósito do Saque DOC 20/08 - após vários pagamentos - Antônio/Frete Etc. (Saldo restante)', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(1912.28 AS Decimal(18, 2)), CAST(6984.12 AS Decimal(18, 2)), CAST(8896.40 AS Decimal(18, 2)), CAST(N'2020-11-02 22:21:15.720' AS DateTime), N'Flavio')
INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (42, 1, 0, 63, 3, N'226046-8', N'', CAST(N'2020-09-04 00:00:00.000' AS DateTime), N'Pagamento Nota Fiscal HFB - N.F. 51', CAST(19780.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(19780.00 AS Decimal(18, 2)), CAST(8896.40 AS Decimal(18, 2)), CAST(28676.40 AS Decimal(18, 2)), CAST(N'2020-11-02 22:23:12.990' AS DateTime), N'Flavio')
INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (43, 2, 1096, 0, 3, N'226046-8', N'DOC', CAST(N'2020-09-09 00:00:00.000' AS DateTime), N'Pagamento Ortosintese (duas N.F.''s 238828 e 239123) Vários Pagamentos (31/08, 01/09, 08/09 e 09/09)', CAST(0.00 AS Decimal(18, 2)), CAST(16486.48 AS Decimal(18, 2)), CAST(16486.48 AS Decimal(18, 2)), CAST(28676.40 AS Decimal(18, 2)), CAST(12189.92 AS Decimal(18, 2)), CAST(N'2020-11-02 22:27:29.763' AS DateTime), N'Flavio')
INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (44, 3, 0, 0, 3, N'226046-8', N'DOC8889371', CAST(N'2020-09-04 00:00:00.000' AS DateTime), N'Saque Dani (R$4.000. + 397.) + reembolso de Frete Azul', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(4397.00 AS Decimal(18, 2)), CAST(12189.92 AS Decimal(18, 2)), CAST(7792.92 AS Decimal(18, 2)), CAST(N'2020-10-22 15:06:41.970' AS DateTime), N'Flavio')
INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (45, 3, 0, 0, 3, N'226046-8', N'DOC551204', CAST(N'2020-09-04 00:00:00.000' AS DateTime), N'Saque Bira(R$4.000,00) + 1000,00(Daisy) + 132,00(Victor - Frete Azul)', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(5132.00 AS Decimal(18, 2)), CAST(7792.92 AS Decimal(18, 2)), CAST(2660.92 AS Decimal(18, 2)), CAST(N'2020-09-24 14:16:48.567' AS DateTime), N'Flavio')
INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (46, 5, 0, 0, 3, N'226046-8', N'   ', CAST(N'2020-09-09 00:00:00.000' AS DateTime), N'Tarifa DOC', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(10.45 AS Decimal(18, 2)), CAST(2660.92 AS Decimal(18, 2)), CAST(2650.47 AS Decimal(18, 2)), CAST(N'2020-09-24 14:17:54.517' AS DateTime), N'Flavio')
INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (47, 2, 1094, 0, 3, N'226046-8', N'DOC', CAST(N'2020-09-10 00:00:00.000' AS DateTime), N'DOC p/ Daniella (R$1.200,00) Pagto de Frete Azul - Galeão', CAST(0.00 AS Decimal(18, 2)), CAST(1248.57 AS Decimal(18, 2)), CAST(1248.57 AS Decimal(18, 2)), CAST(2650.47 AS Decimal(18, 2)), CAST(1401.90 AS Decimal(18, 2)), CAST(N'2020-10-22 15:09:21.933' AS DateTime), N'Flavio')
INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (48, 5, 0, 0, 3, N'226046-8', N'   ', CAST(N'2020-09-10 00:00:00.000' AS DateTime), N'Tarifa DOC', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(10.45 AS Decimal(18, 2)), CAST(1401.90 AS Decimal(18, 2)), CAST(1391.45 AS Decimal(18, 2)), CAST(N'2020-09-24 14:27:49.937' AS DateTime), N'Flavio')
INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (49, 5, 0, 0, 3, N'226046-8', N'   ', CAST(N'2020-09-15 00:00:00.000' AS DateTime), N'Débito de Tarifa mensal', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(86.70 AS Decimal(18, 2)), CAST(1391.45 AS Decimal(18, 2)), CAST(1304.75 AS Decimal(18, 2)), CAST(N'2020-09-24 14:29:08.007' AS DateTime), N'Flavio')
INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (50, 1, 0, 60, 1, N'82080-6', N'', CAST(N'2020-05-19 00:00:00.000' AS DateTime), N'Depósito Banco do Brasil - HFB (Depósito confiscado) N.F.42 ', CAST(77142.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(77142.90 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(77142.90 AS Decimal(18, 2)), CAST(N'2020-11-02 22:36:26.280' AS DateTime), N'Flavio')
INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (51, 5, 0, 0, 1, N'82080-6', N'   ', CAST(N'2020-05-19 00:00:00.000' AS DateTime), N'Tarifas de Pacote de Serviços atrasados de 06/02/2017 a 10/04/2019 - Banco do Brasil', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(6424.65 AS Decimal(18, 2)), CAST(77142.90 AS Decimal(18, 2)), CAST(70718.25 AS Decimal(18, 2)), CAST(N'2020-09-24 14:35:36.867' AS DateTime), N'Flavio')
INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (52, 4, 0, 0, 3, N'226046-8', N'DOC', CAST(N'2020-09-29 00:00:00.000' AS DateTime), N'Depósito em c.c. (Flávio R$400,00 e Victor R$350,00) para pagamento de aluguel.', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(750.00 AS Decimal(18, 2)), CAST(1304.75 AS Decimal(18, 2)), CAST(2054.75 AS Decimal(18, 2)), CAST(N'2020-09-30 11:03:11.783' AS DateTime), N'Flavio')
INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (53, 2, 1100, 0, 3, N'226046-8', N'TED-Digital', CAST(N'2020-09-29 00:00:00.000' AS DateTime), N'Pagamento acordo judicial - Aluguel 2ª parcela', CAST(0.00 AS Decimal(18, 2)), CAST(1500.00 AS Decimal(18, 2)), CAST(1500.00 AS Decimal(18, 2)), CAST(2054.75 AS Decimal(18, 2)), CAST(554.75 AS Decimal(18, 2)), CAST(N'2020-09-30 11:08:54.220' AS DateTime), N'Flavio')
INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (1054, 5, 0, 0, 3, N'226046-8', N'   ', CAST(N'2020-09-04 00:00:00.000' AS DateTime), N'Tarifa DOC.', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(10.45 AS Decimal(18, 2)), CAST(554.75 AS Decimal(18, 2)), CAST(544.30 AS Decimal(18, 2)), CAST(N'2020-11-02 22:41:11.097' AS DateTime), N'Flavio')
INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (1055, 5, 0, 0, 3, N'226046-8', N'   ', CAST(N'2020-09-08 00:00:00.000' AS DateTime), N'Tarifa DOC.', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(10.45 AS Decimal(18, 2)), CAST(544.30 AS Decimal(18, 2)), CAST(533.85 AS Decimal(18, 2)), CAST(N'2020-11-02 22:43:46.587' AS DateTime), N'Flavio')
INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (1056, 3, 0, 0, 3, N'226046-8', N'DOC2207571', CAST(N'2020-09-21 00:00:00.000' AS DateTime), N'Reembolso Frete + Combustível e Pedágio', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(505.00 AS Decimal(18, 2)), CAST(533.85 AS Decimal(18, 2)), CAST(28.85 AS Decimal(18, 2)), CAST(N'2020-11-02 22:49:24.177' AS DateTime), N'Flavio')
INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (1057, 5, 0, 0, 3, N'226046-8', N'   ', CAST(N'2020-09-21 00:00:00.000' AS DateTime), N'Tarifa de DOC.', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(10.45 AS Decimal(18, 2)), CAST(28.85 AS Decimal(18, 2)), CAST(18.40 AS Decimal(18, 2)), CAST(N'2020-11-02 22:50:42.170' AS DateTime), N'Flavio')
INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (1058, 1, 0, 69, 3, N'226046-8', N'', CAST(N'2020-10-01 00:00:00.000' AS DateTime), N'Pagamento N.F. 56 - HFB - Material Empenho', CAST(22129.90 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(22129.90 AS Decimal(18, 2)), CAST(18.40 AS Decimal(18, 2)), CAST(22148.30 AS Decimal(18, 2)), CAST(N'2020-11-02 23:20:47.693' AS DateTime), N'Flavio')
INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (1059, 3, 0, 0, 3, N'226046-8', N'DOC4067463', CAST(N'2020-10-01 00:00:00.000' AS DateTime), N'Saque Daniella (4.999,99)', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(4999.99 AS Decimal(18, 2)), CAST(22148.30 AS Decimal(18, 2)), CAST(17148.31 AS Decimal(18, 2)), CAST(N'2020-11-02 23:29:13.133' AS DateTime), N'Flavio')
INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (1060, 3, 0, 0, 3, N'226046-8', N'DOC551559', CAST(N'2020-10-01 00:00:00.000' AS DateTime), N'Bira(5000.+1.200.Barbara+2.744,62 Com. Victor = 54.892,40)(N.F.50,51 e  56)', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(8944.62 AS Decimal(18, 2)), CAST(17148.31 AS Decimal(18, 2)), CAST(8203.69 AS Decimal(18, 2)), CAST(N'2020-11-02 23:43:45.297' AS DateTime), N'Flavio')
INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (1061, 2, 2100, 0, 3, N'226046-8', N'DOC/TED', CAST(N'2020-10-02 00:00:00.000' AS DateTime), N'Pagamento N.F. Ortosintese', CAST(0.00 AS Decimal(18, 2)), CAST(1668.24 AS Decimal(18, 2)), CAST(1668.24 AS Decimal(18, 2)), CAST(8203.69 AS Decimal(18, 2)), CAST(6535.45 AS Decimal(18, 2)), CAST(N'2020-11-02 23:47:00.713' AS DateTime), N'Flavio')
INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (1062, 3, 0, 0, 3, N'226046-8', N'TED7649931', CAST(N'2020-10-02 00:00:00.000' AS DateTime), N'Reembolso Despesas - Frete Rio X SP', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(164.51 AS Decimal(18, 2)), CAST(6535.45 AS Decimal(18, 2)), CAST(6370.94 AS Decimal(18, 2)), CAST(N'2020-11-10 14:56:06.963' AS DateTime), N'Flavio')
INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (1063, 3, 0, 0, 3, N'226046-8', N'TED551309', CAST(N'2020-10-02 00:00:00.000' AS DateTime), N'Reembolso Despesas - Uber HFI', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(109.33 AS Decimal(18, 2)), CAST(6370.94 AS Decimal(18, 2)), CAST(6261.61 AS Decimal(18, 2)), CAST(N'2020-11-10 14:57:54.247' AS DateTime), N'Flavio')
INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (1064, 5, 0, 0, 3, N'226046-8', N'   ', CAST(N'2020-10-02 00:00:00.000' AS DateTime), N'Débito Tarifa DOC/TED', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(11.05 AS Decimal(18, 2)), CAST(6261.61 AS Decimal(18, 2)), CAST(6250.56 AS Decimal(18, 2)), CAST(N'2020-11-10 15:00:45.983' AS DateTime), N'Flavio')
INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (1065, 5, 0, 0, 3, N'226046-8', N'   ', CAST(N'2020-10-02 00:00:00.000' AS DateTime), N'Tarifa DOC/TED ', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(11.05 AS Decimal(18, 2)), CAST(6250.56 AS Decimal(18, 2)), CAST(6239.51 AS Decimal(18, 2)), CAST(N'2020-11-10 15:02:09.123' AS DateTime), N'Flavio')
INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (1066, 1, 0, 67, 3, N'226046-8', N'', CAST(N'2020-10-05 00:00:00.000' AS DateTime), N'Recebimento N.F. 054 - HFB', CAST(6038.50 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(6038.50 AS Decimal(18, 2)), CAST(6239.51 AS Decimal(18, 2)), CAST(12278.01 AS Decimal(18, 2)), CAST(N'2020-11-10 15:05:03.107' AS DateTime), N'Flavio')
INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (1067, 3, 0, 0, 3, N'226046-8', N'TED3530547', CAST(N'2020-10-08 00:00:00.000' AS DateTime), N'Reembolso de Despesas de Frete SPxRJ - Azul Cargo', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(365.72 AS Decimal(18, 2)), CAST(12278.01 AS Decimal(18, 2)), CAST(11912.29 AS Decimal(18, 2)), CAST(N'2020-11-10 15:07:23.490' AS DateTime), N'Flavio')
INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (1068, 3, 0, 0, 3, N'226046-8', N'TED551327', CAST(N'2020-10-08 00:00:00.000' AS DateTime), N'Pagamento Comissão Victor N.F. 054 - (6.038,50) - 05/10', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(301.92 AS Decimal(18, 2)), CAST(11912.29 AS Decimal(18, 2)), CAST(11610.37 AS Decimal(18, 2)), CAST(N'2020-11-10 15:09:48.060' AS DateTime), N'Flavio')
INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (1069, 5, 0, 0, 3, N'226046-8', N'   ', CAST(N'2020-10-08 00:00:00.000' AS DateTime), N'Tarifa DOC/TED', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(11.05 AS Decimal(18, 2)), CAST(11610.37 AS Decimal(18, 2)), CAST(11599.32 AS Decimal(18, 2)), CAST(N'2020-11-10 15:10:56.123' AS DateTime), N'Flavio')
INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (1070, 1, 0, 68, 3, N'226046-8', N'', CAST(N'2020-10-15 00:00:00.000' AS DateTime), N'Recebimento de N.F.055 - HFB ', CAST(86245.90 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(86245.90 AS Decimal(18, 2)), CAST(11599.32 AS Decimal(18, 2)), CAST(97845.22 AS Decimal(18, 2)), CAST(N'2020-11-10 15:14:24.213' AS DateTime), N'Flavio')
INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (1071, 5, 0, 0, 3, N'226046-8', N'   ', CAST(N'2020-10-15 00:00:00.000' AS DateTime), N'Débito Tarifa bancárias - 15/10/2020 ', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(86.70 AS Decimal(18, 2)), CAST(97845.22 AS Decimal(18, 2)), CAST(97758.52 AS Decimal(18, 2)), CAST(N'2020-11-10 15:16:31.767' AS DateTime), N'Flavio')
INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (1072, 4, 0, 0, 3, N'226046-8', N'TED551321/03', CAST(N'2020-10-19 00:00:00.000' AS DateTime), N'Depósito Victor - Complemento para pagamento de N.F. Ortosintese', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(310.00 AS Decimal(18, 2)), CAST(97758.52 AS Decimal(18, 2)), CAST(98068.52 AS Decimal(18, 2)), CAST(N'2020-11-10 15:18:49.330' AS DateTime), N'Flavio')
INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (1073, 2, 2102, 0, 3, N'226046-8', N'TED/4455847', CAST(N'2020-10-19 00:00:00.000' AS DateTime), N'Pagamento de Notas Fiscais Ortosintese - N.F. 240281 e 240282', CAST(0.00 AS Decimal(18, 2)), CAST(98103.52 AS Decimal(18, 2)), CAST(98103.52 AS Decimal(18, 2)), CAST(98068.52 AS Decimal(18, 2)), CAST(-35.00 AS Decimal(18, 2)), CAST(N'2020-11-10 15:27:52.670' AS DateTime), N'Flavio')
INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (1074, 5, 0, 0, 3, N'226046-8', N'   ', CAST(N'2020-10-19 00:00:00.000' AS DateTime), N'Débito Tarifa DOC/TED', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(11.05 AS Decimal(18, 2)), CAST(-35.00 AS Decimal(18, 2)), CAST(-46.05 AS Decimal(18, 2)), CAST(N'2020-11-10 15:31:11.663' AS DateTime), N'Flavio')
INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (1075, 4, 0, 0, 3, N'226046-8', N'DOC 10990', CAST(N'2020-11-03 00:00:00.000' AS DateTime), N'DOC Daniella Peccei - Para pagamento de Acordo de Aluguel', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(905.00 AS Decimal(18, 2)), CAST(-46.05 AS Decimal(18, 2)), CAST(858.95 AS Decimal(18, 2)), CAST(N'2020-11-10 15:36:21.517' AS DateTime), N'Flavio')
INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (1076, 4, 0, 0, 3, N'226046-8', N'TED551531', CAST(N'2020-11-04 00:00:00.000' AS DateTime), N'TED Victor Melo - Para complemento de Pagamento de Acordo de Aluguel', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(825.00 AS Decimal(18, 2)), CAST(858.95 AS Decimal(18, 2)), CAST(1683.95 AS Decimal(18, 2)), CAST(N'2020-11-10 15:38:07.137' AS DateTime), N'Flavio')
INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (1077, 1, 0, 70, 3, N'226046-8', N'', CAST(N'2020-11-04 00:00:00.000' AS DateTime), N'Recebimento HFB - N.F. 058', CAST(31325.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(31325.00 AS Decimal(18, 2)), CAST(1683.95 AS Decimal(18, 2)), CAST(33008.95 AS Decimal(18, 2)), CAST(N'2020-11-10 15:40:23.390' AS DateTime), N'Flavio')
INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (1078, 2, 2103, 0, 3, N'226046-8', N'TED 2', CAST(N'2020-11-04 00:00:00.000' AS DateTime), N'Pagamento 3ª Parcela Acordo repactuação Aluguel', CAST(0.00 AS Decimal(18, 2)), CAST(1650.00 AS Decimal(18, 2)), CAST(1650.00 AS Decimal(18, 2)), CAST(33008.95 AS Decimal(18, 2)), CAST(31358.95 AS Decimal(18, 2)), CAST(N'2020-11-10 15:50:07.730' AS DateTime), N'Flavio')
INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (1079, 3, 0, 0, 3, N'226046-8', N'TED551104', CAST(N'2020-11-04 00:00:00.000' AS DateTime), N'TED Victor Comissão + Retirada+retornoDepósito(1135,00+5878,54+4000,00)N.F.55 e 58', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(11013.54 AS Decimal(18, 2)), CAST(31358.95 AS Decimal(18, 2)), CAST(20345.41 AS Decimal(18, 2)), CAST(N'2020-11-10 15:59:19.460' AS DateTime), N'Flavio')
INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (1080, 3, 0, 0, 3, N'226046-8', N'DOC7496340', CAST(N'2020-11-04 00:00:00.000' AS DateTime), N'Reembolso de Despesas+Retorno DOC+Retirada(905,00+2750,00+4000,00)', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(7655.00 AS Decimal(18, 2)), CAST(20345.41 AS Decimal(18, 2)), CAST(12690.41 AS Decimal(18, 2)), CAST(N'2020-11-10 16:02:52.377' AS DateTime), N'Flavio')
INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (1081, 2, 2104, 0, 3, N'226046-8', N'Boleto', CAST(N'2020-11-05 00:00:00.000' AS DateTime), N'Pagamento de Boleto - Marcelo Araújo - Contatabilidade', CAST(0.00 AS Decimal(18, 2)), CAST(12000.00 AS Decimal(18, 2)), CAST(12000.00 AS Decimal(18, 2)), CAST(12690.41 AS Decimal(18, 2)), CAST(690.41 AS Decimal(18, 2)), CAST(N'2020-11-10 16:04:46.353' AS DateTime), N'Flavio')
INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (1082, 3, 0, 0, 3, N'226046-8', N'DOC7257563', CAST(N'2020-11-09 00:00:00.000' AS DateTime), N'Reembolso de Frete p/ Daniella Seikel - Azul Cargo - SPxRJ ', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(206.54 AS Decimal(18, 2)), CAST(690.41 AS Decimal(18, 2)), CAST(483.87 AS Decimal(18, 2)), CAST(N'2020-11-10 16:55:58.490' AS DateTime), N'Flavio')
INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (1083, 5, 0, 0, 3, N'226046-8', N'   ', CAST(N'2020-11-09 00:00:00.000' AS DateTime), N'Tarifa DOC - Daniella', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(11.05 AS Decimal(18, 2)), CAST(483.87 AS Decimal(18, 2)), CAST(472.82 AS Decimal(18, 2)), CAST(N'2020-11-10 16:56:48.087' AS DateTime), N'Flavio')
INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (1084, 6, 0, 0, 3, N'226046-8', N'   ', CAST(N'2020-09-10 00:00:00.000' AS DateTime), N'Lançamento errado (dia 10/09 - 1248,57 - débito correto seria 1200,00) conforme Extrato.', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(48.57 AS Decimal(18, 2)), CAST(472.82 AS Decimal(18, 2)), CAST(521.39 AS Decimal(18, 2)), CAST(N'2020-11-10 23:07:09.023' AS DateTime), N'Flavio')
INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (1085, 1, 0, 71, 3, N'226046-8', N'', CAST(N'2020-11-11 00:00:00.000' AS DateTime), N'Recebimento de N.F. 057 - HFB', CAST(37400.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(37400.00 AS Decimal(18, 2)), CAST(521.39 AS Decimal(18, 2)), CAST(37921.39 AS Decimal(18, 2)), CAST(N'2020-11-11 17:36:52.307' AS DateTime), N'Flavio')
INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (1086, 2, 2108, 0, 3, N'226046-8', N'TED ', CAST(N'2020-11-11 00:00:00.000' AS DateTime), N'Pagamento de N.F.''s Ortosintese (241.270 e 241.445) - TED 7653528', CAST(0.00 AS Decimal(18, 2)), CAST(15304.88 AS Decimal(18, 2)), CAST(15304.88 AS Decimal(18, 2)), CAST(37921.39 AS Decimal(18, 2)), CAST(22616.51 AS Decimal(18, 2)), CAST(N'2020-11-11 17:40:04.460' AS DateTime), N'Flavio')
INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (1087, 3, 0, 0, 3, N'226046-8', N'TED551396', CAST(N'2020-11-11 00:00:00.000' AS DateTime), N'Saque Bira (R$4.000,00 + R$1.870,00) Comissão Victor N.F.057', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(5870.00 AS Decimal(18, 2)), CAST(22616.51 AS Decimal(18, 2)), CAST(16746.51 AS Decimal(18, 2)), CAST(N'2020-11-11 17:43:31.707' AS DateTime), N'Flavio')
INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (1088, 5, 0, 0, 3, N'226046-8', N'   ', CAST(N'2020-11-11 00:00:00.000' AS DateTime), N'Tarifa DOC 11/11/2020', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(11.05 AS Decimal(18, 2)), CAST(16746.51 AS Decimal(18, 2)), CAST(16735.46 AS Decimal(18, 2)), CAST(N'2020-11-11 17:44:44.007' AS DateTime), N'Flavio')
INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (1089, 3, 0, 0, 3, N'226046-8', N'DOC7653585', CAST(N'2020-11-11 00:00:00.000' AS DateTime), N'Pagamento Resp. Técnica(R$12.000,00+R$4000,00+R$224,00) + Saque + Certisign', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(16224.00 AS Decimal(18, 2)), CAST(16735.46 AS Decimal(18, 2)), CAST(511.46 AS Decimal(18, 2)), CAST(N'2020-11-11 17:48:18.637' AS DateTime), N'Flavio')
INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (1090, 5, 0, 0, 3, N'226046-8', N'   ', CAST(N'2020-11-11 00:00:00.000' AS DateTime), N'Débito Tarifa DOC - 11/11/2020', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(11.05 AS Decimal(18, 2)), CAST(511.46 AS Decimal(18, 2)), CAST(500.41 AS Decimal(18, 2)), CAST(N'2020-11-11 17:49:25.427' AS DateTime), N'Flavio')
INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (1092, 1, 0, 72, 3, N'226046-8', N'', CAST(N'2020-11-12 00:00:00.000' AS DateTime), N'Recebimento NF. 052 - HFA', CAST(27955.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(27955.00 AS Decimal(18, 2)), CAST(500.41 AS Decimal(18, 2)), CAST(28455.41 AS Decimal(18, 2)), CAST(N'2020-11-30 12:29:41.207' AS DateTime), N'Flavio')
INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (1093, 3, 0, 0, 3, N'226046-8', N'DOC9740584', CAST(N'2020-11-12 00:00:00.000' AS DateTime), N'Saque(Comissão Flávio 1397,75+Dr.Jonas 4974,63+Retirada 5.000,00)', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(11372.38 AS Decimal(18, 2)), CAST(28455.41 AS Decimal(18, 2)), CAST(17083.03 AS Decimal(18, 2)), CAST(N'2020-11-30 12:32:33.090' AS DateTime), N'Flavio')
INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (1094, 2, 2109, 0, 3, N'226046-8', N'DOC', CAST(N'2020-11-12 00:00:00.000' AS DateTime), N'Pagamento NF''s 242420 e 242421 - DOC9888737', CAST(0.00 AS Decimal(18, 2)), CAST(9445.85 AS Decimal(18, 2)), CAST(9445.85 AS Decimal(18, 2)), CAST(17083.03 AS Decimal(18, 2)), CAST(7637.18 AS Decimal(18, 2)), CAST(N'2020-11-30 14:12:07.403' AS DateTime), N'Flavio')
INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (1095, 3, 0, 0, 3, N'226046-8', N'TED551891', CAST(N'2020-11-12 00:00:00.000' AS DateTime), N'Saque Bira (-R$ 5.000,00)', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(5000.00 AS Decimal(18, 2)), CAST(7637.18 AS Decimal(18, 2)), CAST(2637.18 AS Decimal(18, 2)), CAST(N'2020-11-30 14:14:30.610' AS DateTime), N'Flavio')
INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (1096, 5, 0, 0, 3, N'226046-8', N'   ', CAST(N'2020-11-12 00:00:00.000' AS DateTime), N'Tarifa DOC/TED Daniella', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(11.05 AS Decimal(18, 2)), CAST(2637.18 AS Decimal(18, 2)), CAST(2626.13 AS Decimal(18, 2)), CAST(N'2020-11-30 14:15:55.753' AS DateTime), N'Flavio')
INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (1097, 5, 0, 0, 3, N'226046-8', N'   ', CAST(N'2020-11-12 00:00:00.000' AS DateTime), N'Tarifa DOC/TED - Ortosintese ', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(11.05 AS Decimal(18, 2)), CAST(2626.13 AS Decimal(18, 2)), CAST(2615.08 AS Decimal(18, 2)), CAST(N'2020-11-30 14:17:16.317' AS DateTime), N'Flavio')
INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (1098, 2, 2111, 0, 3, N'226046-8', N'TED4', CAST(N'2020-11-13 00:00:00.000' AS DateTime), N'Pagto. 4ª parcela - Repactuação Aluguel - Advogado Marcelo Araújo - 13/11/2020.', CAST(0.00 AS Decimal(18, 2)), CAST(1500.00 AS Decimal(18, 2)), CAST(1500.00 AS Decimal(18, 2)), CAST(2615.08 AS Decimal(18, 2)), CAST(1115.08 AS Decimal(18, 2)), CAST(N'2020-11-30 14:23:26.237' AS DateTime), N'Flavio')
INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (1099, 2, 2112, 0, 3, N'226046-8', N'DOC5969777', CAST(N'2020-11-16 00:00:00.000' AS DateTime), N'Pagto Acordo NET-Claro (Telefone R$49,22 + Internet R$115,67)', CAST(0.00 AS Decimal(18, 2)), CAST(164.89 AS Decimal(18, 2)), CAST(164.89 AS Decimal(18, 2)), CAST(1115.08 AS Decimal(18, 2)), CAST(950.19 AS Decimal(18, 2)), CAST(N'2020-11-30 14:37:13.850' AS DateTime), N'Flavio')
INSERT [dbo].[Lancamentos] ([Cod_Lancamento], [Cod_Operacao], [Cod_Base_Tit_Pagos], [Cod_Base_Tit_Recebidos], [Cod_Banco], [Numero_Conta], [Numero_Chque], [Data_Lancamento], [Descricao_Operacao], [Recebimento_Titulos], [Pagamento_Titulos], [Valor_Movimento], [Saldo_Anterior], [Saldo], [Data_Login], [Login_Name]) VALUES (1100, 5, 0, 0, 3, N'226046-8', N'   ', CAST(N'2020-11-17 00:00:00.000' AS DateTime), N'Tarifa bancária - Max Empresarial - Dcto. 31120', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(93.45 AS Decimal(18, 2)), CAST(950.19 AS Decimal(18, 2)), CAST(856.74 AS Decimal(18, 2)), CAST(N'2020-11-30 14:46:06.543' AS DateTime), N'Flavio')
SET IDENTITY_INSERT [dbo].[Lancamentos] OFF
SET IDENTITY_INSERT [dbo].[Numero_Parcelas_a_Pagar] ON 

INSERT [dbo].[Numero_Parcelas_a_Pagar] ([Cod_Numero_Parcelas_a_Pagar], [Cod_Entrada_Titulos_a_Pagar], [Numero_Parcela], [Data_Vencimento], [Valor_Parcela], [Historico], [Cod_Status_Titulo]) VALUES (150, 1074, CAST(5 AS Numeric(3, 0)), CAST(N'2020-12-30 10:53:54.000' AS DateTime), CAST(1500.00 AS Decimal(18, 2)), N'5ª parcela repactuação de dívida aluguel - Marcelo Araújo Advogado', 1)
INSERT [dbo].[Numero_Parcelas_a_Pagar] ([Cod_Numero_Parcelas_a_Pagar], [Cod_Entrada_Titulos_a_Pagar], [Numero_Parcela], [Data_Vencimento], [Valor_Parcela], [Historico], [Cod_Status_Titulo]) VALUES (151, 1074, CAST(6 AS Numeric(3, 0)), CAST(N'2021-01-31 10:53:54.000' AS DateTime), CAST(1500.00 AS Decimal(18, 2)), N'6ª parcela repactuação de dívida aluguel - Marcelo Araújo Advogado', 1)
INSERT [dbo].[Numero_Parcelas_a_Pagar] ([Cod_Numero_Parcelas_a_Pagar], [Cod_Entrada_Titulos_a_Pagar], [Numero_Parcela], [Data_Vencimento], [Valor_Parcela], [Historico], [Cod_Status_Titulo]) VALUES (152, 1074, CAST(7 AS Numeric(3, 0)), CAST(N'2021-02-28 10:53:54.000' AS DateTime), CAST(1500.00 AS Decimal(18, 2)), N'7ª parcela repactuação de dívida aluguel - Marcelo Araújo Advogado', 1)
INSERT [dbo].[Numero_Parcelas_a_Pagar] ([Cod_Numero_Parcelas_a_Pagar], [Cod_Entrada_Titulos_a_Pagar], [Numero_Parcela], [Data_Vencimento], [Valor_Parcela], [Historico], [Cod_Status_Titulo]) VALUES (153, 1074, CAST(8 AS Numeric(3, 0)), CAST(N'2021-03-31 10:53:54.000' AS DateTime), CAST(1500.00 AS Decimal(18, 2)), N'8ª parcela repactuação de dívida aluguel - Marcelo Araújo Advogado', 1)
INSERT [dbo].[Numero_Parcelas_a_Pagar] ([Cod_Numero_Parcelas_a_Pagar], [Cod_Entrada_Titulos_a_Pagar], [Numero_Parcela], [Data_Vencimento], [Valor_Parcela], [Historico], [Cod_Status_Titulo]) VALUES (154, 1074, CAST(9 AS Numeric(3, 0)), CAST(N'2021-04-30 10:53:54.000' AS DateTime), CAST(1500.00 AS Decimal(18, 2)), N'9ª parcela repactuação de dívida aluguel - Marcelo Araújo Advogado', 1)
INSERT [dbo].[Numero_Parcelas_a_Pagar] ([Cod_Numero_Parcelas_a_Pagar], [Cod_Entrada_Titulos_a_Pagar], [Numero_Parcela], [Data_Vencimento], [Valor_Parcela], [Historico], [Cod_Status_Titulo]) VALUES (155, 1074, CAST(10 AS Numeric(3, 0)), CAST(N'2021-05-31 10:53:54.000' AS DateTime), CAST(1500.00 AS Decimal(18, 2)), N'10ª parcela repactuação de dívida aluguel - Marcelo Araújo Advogado', 1)
INSERT [dbo].[Numero_Parcelas_a_Pagar] ([Cod_Numero_Parcelas_a_Pagar], [Cod_Entrada_Titulos_a_Pagar], [Numero_Parcela], [Data_Vencimento], [Valor_Parcela], [Historico], [Cod_Status_Titulo]) VALUES (156, 1074, CAST(11 AS Numeric(3, 0)), CAST(N'2021-06-30 10:53:54.000' AS DateTime), CAST(1500.00 AS Decimal(18, 2)), N'11ª parcela repactuação de dívida aluguel - Marcelo Araújo Advogado', 1)
INSERT [dbo].[Numero_Parcelas_a_Pagar] ([Cod_Numero_Parcelas_a_Pagar], [Cod_Entrada_Titulos_a_Pagar], [Numero_Parcela], [Data_Vencimento], [Valor_Parcela], [Historico], [Cod_Status_Titulo]) VALUES (157, 1074, CAST(12 AS Numeric(3, 0)), CAST(N'2021-07-31 10:53:54.000' AS DateTime), CAST(1500.00 AS Decimal(18, 2)), N'12ª parcela repactuação de dívida aluguel - Marcelo Araújo Advogado', 1)
INSERT [dbo].[Numero_Parcelas_a_Pagar] ([Cod_Numero_Parcelas_a_Pagar], [Cod_Entrada_Titulos_a_Pagar], [Numero_Parcela], [Data_Vencimento], [Valor_Parcela], [Historico], [Cod_Status_Titulo]) VALUES (169, 1086, CAST(1 AS Numeric(3, 0)), CAST(N'2020-12-01 22:00:48.000' AS DateTime), CAST(7500.00 AS Decimal(18, 2)), N'Honorários Advocatícios - Dr. Jonas (Estimado)', 1)
INSERT [dbo].[Numero_Parcelas_a_Pagar] ([Cod_Numero_Parcelas_a_Pagar], [Cod_Entrada_Titulos_a_Pagar], [Numero_Parcela], [Data_Vencimento], [Valor_Parcela], [Historico], [Cod_Status_Titulo]) VALUES (174, 1091, CAST(1 AS Numeric(3, 0)), CAST(N'2020-12-30 11:04:25.000' AS DateTime), CAST(391.18 AS Decimal(18, 2)), N'Instrumental Volar - HFI e HFB ', 1)
INSERT [dbo].[Numero_Parcelas_a_Pagar] ([Cod_Numero_Parcelas_a_Pagar], [Cod_Entrada_Titulos_a_Pagar], [Numero_Parcela], [Data_Vencimento], [Valor_Parcela], [Historico], [Cod_Status_Titulo]) VALUES (175, 1092, CAST(1 AS Numeric(3, 0)), CAST(N'2020-12-30 11:04:25.000' AS DateTime), CAST(66417.86 AS Decimal(18, 2)), N'Material de Trauma - Empenho - HFI - N.F. 063 - 03/12/2020.', 1)
INSERT [dbo].[Numero_Parcelas_a_Pagar] ([Cod_Numero_Parcelas_a_Pagar], [Cod_Entrada_Titulos_a_Pagar], [Numero_Parcela], [Data_Vencimento], [Valor_Parcela], [Historico], [Cod_Status_Titulo]) VALUES (176, 1093, CAST(1 AS Numeric(3, 0)), CAST(N'2020-12-15 11:04:25.000' AS DateTime), CAST(983.05 AS Decimal(18, 2)), N'Frete Material Trauma - HFI - Empenho', 1)
SET IDENTITY_INSERT [dbo].[Numero_Parcelas_a_Pagar] OFF
SET IDENTITY_INSERT [dbo].[Numero_Parcelas_a_Receber] ON 

INSERT [dbo].[Numero_Parcelas_a_Receber] ([Cod_Numero_Parcelas_Receber], [Cod_Entrada_Titulos_a_Receber], [Numero_Parcela], [Data_Vencimento], [Valor_Parcela], [Historico], [Cod_Status_Titulo]) VALUES (1021, 2060, 1, CAST(N'2020-12-30' AS Date), CAST(220065.00 AS Decimal(18, 2)), N'NF. 063 - Material de Trauma - HFI - Empenho - Data da Entrega:04/12/2020.', 1)
INSERT [dbo].[Numero_Parcelas_a_Receber] ([Cod_Numero_Parcelas_Receber], [Cod_Entrada_Titulos_a_Receber], [Numero_Parcela], [Data_Vencimento], [Valor_Parcela], [Historico], [Cod_Status_Titulo]) VALUES (1023, 2062, 1, CAST(N'2020-12-31' AS Date), CAST(15240.00 AS Decimal(18, 2)), N'NF. 065 - Material de Trauma - Empenho 2020NE800855 - Data da Entrega:04/12/2020.', 1)
INSERT [dbo].[Numero_Parcelas_a_Receber] ([Cod_Numero_Parcelas_Receber], [Cod_Entrada_Titulos_a_Receber], [Numero_Parcela], [Data_Vencimento], [Valor_Parcela], [Historico], [Cod_Status_Titulo]) VALUES (1027, 2066, 1, CAST(N'2020-12-23' AS Date), CAST(9870.00 AS Decimal(18, 2)), N'NF. 064 - Material Empenho 2020NE800333', 1)
SET IDENTITY_INSERT [dbo].[Numero_Parcelas_a_Receber] OFF
SET IDENTITY_INSERT [dbo].[Operacao] ON 

INSERT [dbo].[Operacao] ([Cod_Operacao], [Descricao_Op], [Nome_Login], [Data_Login]) VALUES (1, N'Crédito / Recebimento Títulos', N'Flavio', CAST(N'2018-11-02 00:00:00.000' AS DateTime))
INSERT [dbo].[Operacao] ([Cod_Operacao], [Descricao_Op], [Nome_Login], [Data_Login]) VALUES (2, N'Saque / Pagamento Títulos / Cheque', N'Flavio', CAST(N'2018-11-02 00:00:00.000' AS DateTime))
INSERT [dbo].[Operacao] ([Cod_Operacao], [Descricao_Op], [Nome_Login], [Data_Login]) VALUES (3, N'Saque - Cheque / Dinheiro/DOC', N'Flavio ', CAST(N'2019-06-14 00:00:00.000' AS DateTime))
INSERT [dbo].[Operacao] ([Cod_Operacao], [Descricao_Op], [Nome_Login], [Data_Login]) VALUES (4, N'Depósito - Cheque / Dinheiro/DOC', N'Flavio', CAST(N'2019-06-14 00:00:00.000' AS DateTime))
INSERT [dbo].[Operacao] ([Cod_Operacao], [Descricao_Op], [Nome_Login], [Data_Login]) VALUES (5, N'Débito Tarifa /Desp.Financeiras / Juros / Empréstimo', N'Flavio', CAST(N'2019-06-16 00:00:00.000' AS DateTime))
INSERT [dbo].[Operacao] ([Cod_Operacao], [Descricao_Op], [Nome_Login], [Data_Login]) VALUES (6, N'Crédito / Estorno / C/C', N'Flavio', CAST(N'2019-08-16 00:00:00.000' AS DateTime))
INSERT [dbo].[Operacao] ([Cod_Operacao], [Descricao_Op], [Nome_Login], [Data_Login]) VALUES (7, N'Cheque/Folha de Pagamento/Despesas de Pessoal', N'Flavio', CAST(N'2019-11-17 00:00:00.000' AS DateTime))
INSERT [dbo].[Operacao] ([Cod_Operacao], [Descricao_Op], [Nome_Login], [Data_Login]) VALUES (8, N'Saque/Pagamento Comissões/Cheque', N'Flavio', CAST(N'2019-11-17 00:00:00.000' AS DateTime))
INSERT [dbo].[Operacao] ([Cod_Operacao], [Descricao_Op], [Nome_Login], [Data_Login]) VALUES (9, N'Saque/Pagamento Impostos/Cheque', N'Flavio', CAST(N'2019-11-17 00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Operacao] OFF
SET IDENTITY_INSERT [dbo].[Pesquisa_Por_Nome] ON 

INSERT [dbo].[Pesquisa_Por_Nome] ([Cod_Pesquisa], [Primeiro_Nome], [Ultimo_Nome]) VALUES (1, N'Primeiro Nome', N'Último Nome')
INSERT [dbo].[Pesquisa_Por_Nome] ([Cod_Pesquisa], [Primeiro_Nome], [Ultimo_Nome]) VALUES (2, N'Último Nome', N'Último Nome')
SET IDENTITY_INSERT [dbo].[Pesquisa_Por_Nome] OFF
SET IDENTITY_INSERT [dbo].[Status_Fornecedor_Cliente] ON 

INSERT [dbo].[Status_Fornecedor_Cliente] ([Cod_Status_Fornecedor], [Descricao_Status], [Data_Login], [Login_Name]) VALUES (1, N'Ativo', CAST(N'2018-08-20 00:00:00.000' AS DateTime), N'Flavio')
INSERT [dbo].[Status_Fornecedor_Cliente] ([Cod_Status_Fornecedor], [Descricao_Status], [Data_Login], [Login_Name]) VALUES (2, N'Inativo', CAST(N'2018-08-20 00:00:00.000' AS DateTime), N'Daniella')
SET IDENTITY_INSERT [dbo].[Status_Fornecedor_Cliente] OFF
SET IDENTITY_INSERT [dbo].[Status_Titulo] ON 

INSERT [dbo].[Status_Titulo] ([Cod_Status_Titulo], [Descricao_Status_Titulo], [Data_Login], [Login_Name]) VALUES (1, N'Em Aberto', CAST(N'2018-08-30 00:00:00.000' AS DateTime), N'Flavio')
INSERT [dbo].[Status_Titulo] ([Cod_Status_Titulo], [Descricao_Status_Titulo], [Data_Login], [Login_Name]) VALUES (2, N'Quitado', CAST(N'2018-08-30 00:00:00.000' AS DateTime), N'Daniella')
INSERT [dbo].[Status_Titulo] ([Cod_Status_Titulo], [Descricao_Status_Titulo], [Data_Login], [Login_Name]) VALUES (3, N'Saldo Pendente', CAST(N'2018-08-30 00:00:00.000' AS DateTime), N'Flavio')
SET IDENTITY_INSERT [dbo].[Status_Titulo] OFF
SET IDENTITY_INSERT [dbo].[Status_Titulos_a_Receber] ON 

INSERT [dbo].[Status_Titulos_a_Receber] ([Codigo_Status_Tit_a_Receber], [Descricao_Status], [data_login], [login_name]) VALUES (1, N'Em Aberto', CAST(N'2018-12-24 00:00:00.000' AS DateTime), N'Flavio')
INSERT [dbo].[Status_Titulos_a_Receber] ([Codigo_Status_Tit_a_Receber], [Descricao_Status], [data_login], [login_name]) VALUES (2, N'Quitado', CAST(N'2018-12-24 00:00:00.000' AS DateTime), N'Daniella')
INSERT [dbo].[Status_Titulos_a_Receber] ([Codigo_Status_Tit_a_Receber], [Descricao_Status], [data_login], [login_name]) VALUES (3, N'Saldo Pendente', CAST(N'2018-12-24 00:00:00.000' AS DateTime), N'Flavio')
SET IDENTITY_INSERT [dbo].[Status_Titulos_a_Receber] OFF
SET IDENTITY_INSERT [dbo].[Tipos_Acesso] ON 

INSERT [dbo].[Tipos_Acesso] ([Cod_acesso], [Descricao], [Nome_Login], [Data_Login]) VALUES (1, N'Acesso Geral ', N'Flavio', CAST(N'2018-10-30 17:08:26.000' AS DateTime))
INSERT [dbo].[Tipos_Acesso] ([Cod_acesso], [Descricao], [Nome_Login], [Data_Login]) VALUES (2, N'Acesso a Consultas', N'Flavio', CAST(N'2018-10-30 17:09:18.000' AS DateTime))
INSERT [dbo].[Tipos_Acesso] ([Cod_acesso], [Descricao], [Nome_Login], [Data_Login]) VALUES (3, N'Acesso a Relatórios', N'Flavio', CAST(N'2018-10-30 17:09:57.000' AS DateTime))
INSERT [dbo].[Tipos_Acesso] ([Cod_acesso], [Descricao], [Nome_Login], [Data_Login]) VALUES (4, N'Acesso a Cadastros', N'Daniella', CAST(N'2018-10-26 00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Tipos_Acesso] OFF
SET IDENTITY_INSERT [dbo].[Tipos_Receita] ON 

INSERT [dbo].[Tipos_Receita] ([Codigo_Tipo_Receita], [Descricao_Receita], [codigo_contabilidade], [data_login], [login_name]) VALUES (1, N'Venda Mercadoria à Vista', N'23456-6', CAST(N'2018-12-24 00:00:00.000' AS DateTime), N'Flavio')
INSERT [dbo].[Tipos_Receita] ([Codigo_Tipo_Receita], [Descricao_Receita], [codigo_contabilidade], [data_login], [login_name]) VALUES (2, N'Venda Mercadoria à Prazo', N'23457-9', CAST(N'2018-12-24 00:00:00.000' AS DateTime), N'Daniella')
INSERT [dbo].[Tipos_Receita] ([Codigo_Tipo_Receita], [Descricao_Receita], [codigo_contabilidade], [data_login], [login_name]) VALUES (3, N'Venda Mercadoria Parcelado', N'23657-0', CAST(N'2018-12-24 00:00:00.000' AS DateTime), N'Flavio')
SET IDENTITY_INSERT [dbo].[Tipos_Receita] OFF
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([Cod_Usuario], [Nome_Usuario], [Login_Name], [Senha_Usuario], [Codigo_Acesso], [Data_Login], [Nome_Login]) VALUES (1, N'Flavio Rocha', N'Flavio', N'123', 1, CAST(N'2018-10-30 18:31:28.000' AS DateTime), N'Flavio')
INSERT [dbo].[Usuarios] ([Cod_Usuario], [Nome_Usuario], [Login_Name], [Senha_Usuario], [Codigo_Acesso], [Data_Login], [Nome_Login]) VALUES (2, N'Daniella Seikel', N'Daniella', N'123', 1, CAST(N'2018-10-30 19:26:52.000' AS DateTime), N'Flavio')
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
ALTER TABLE [dbo].[Baixa_Titulos_a_Pagar_Pagamentos]  WITH CHECK ADD  CONSTRAINT [FK_Baixa_Titulos_a_Pagar_ItensPagamento] FOREIGN KEY([Cod_Baixa_Titulos_a_Pagar])
REFERENCES [dbo].[Baixa_Titulos_a_Pagar_Pagamentos] ([Cod_Baixa_Titulos_a_Pagar])
GO
ALTER TABLE [dbo].[Baixa_Titulos_a_Pagar_Pagamentos] CHECK CONSTRAINT [FK_Baixa_Titulos_a_Pagar_ItensPagamento]
GO
ALTER TABLE [dbo].[Baixa_Titulos_a_Receber]  WITH CHECK ADD  CONSTRAINT [FK_Baixa_Titulos_a_Receber_Baixa_Bancos] FOREIGN KEY([Creditar_Banco])
REFERENCES [dbo].[Bancos] ([Cod_Banco])
GO
ALTER TABLE [dbo].[Baixa_Titulos_a_Receber] CHECK CONSTRAINT [FK_Baixa_Titulos_a_Receber_Baixa_Bancos]
GO
ALTER TABLE [dbo].[Baixa_Titulos_a_Receber]  WITH CHECK ADD  CONSTRAINT [FK_Baixa_Titulos_a_Receber_Clientes] FOREIGN KEY([Cod_Cliente])
REFERENCES [dbo].[Clientes_Contas_a_Receber] ([Cod_Cliente_Contas_a_Receber])
GO
ALTER TABLE [dbo].[Baixa_Titulos_a_Receber] CHECK CONSTRAINT [FK_Baixa_Titulos_a_Receber_Clientes]
GO
ALTER TABLE [dbo].[Clientes_Contas_a_Receber]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_Contas_a_Receber_Grupo] FOREIGN KEY([Cod_Grupo])
REFERENCES [dbo].[Grupo] ([Cod_Grupo])
GO
ALTER TABLE [dbo].[Clientes_Contas_a_Receber] CHECK CONSTRAINT [FK_Clientes_Contas_a_Receber_Grupo]
GO
ALTER TABLE [dbo].[Fornecedor_Contas_a_Pagar]  WITH CHECK ADD  CONSTRAINT [FK_Fornecedor_Contas_a_Pagar_Status_Fornecedor] FOREIGN KEY([Cod_Status_Fornecedor])
REFERENCES [dbo].[Status_Fornecedor_Cliente] ([Cod_Status_Fornecedor])
GO
ALTER TABLE [dbo].[Fornecedor_Contas_a_Pagar] CHECK CONSTRAINT [FK_Fornecedor_Contas_a_Pagar_Status_Fornecedor]
GO
ALTER TABLE [dbo].[Grupo]  WITH CHECK ADD  CONSTRAINT [FK_Grupo_Fornecedor] FOREIGN KEY([Cod_Grupo])
REFERENCES [dbo].[Grupo] ([Cod_Grupo])
GO
ALTER TABLE [dbo].[Grupo] CHECK CONSTRAINT [FK_Grupo_Fornecedor]
GO
ALTER TABLE [dbo].[Itens_Pgtos_Baixa_Titulos_a_Pagar]  WITH CHECK ADD  CONSTRAINT [FK_Itens_Pgtos_Baixa_Titulos_a_Pagar] FOREIGN KEY([Cod_Baixa_Titulos_a_Pagar])
REFERENCES [dbo].[Baixa_Titulos_a_Pagar_Pagamentos] ([Cod_Baixa_Titulos_a_Pagar])
GO
ALTER TABLE [dbo].[Itens_Pgtos_Baixa_Titulos_a_Pagar] CHECK CONSTRAINT [FK_Itens_Pgtos_Baixa_Titulos_a_Pagar]
GO
ALTER TABLE [dbo].[Status_Titulo]  WITH CHECK ADD  CONSTRAINT [FK_Status_Titulo_Status_Entrada_Titulos_a_Pagar] FOREIGN KEY([Cod_Status_Titulo])
REFERENCES [dbo].[Status_Titulo] ([Cod_Status_Titulo])
GO
ALTER TABLE [dbo].[Status_Titulo] CHECK CONSTRAINT [FK_Status_Titulo_Status_Entrada_Titulos_a_Pagar]
GO
ALTER TABLE [dbo].[Transferencias]  WITH CHECK ADD  CONSTRAINT [FK_Transferencias_Bancos_Destino] FOREIGN KEY([Conta_Destino_Banco])
REFERENCES [dbo].[Bancos] ([Cod_Banco])
GO
ALTER TABLE [dbo].[Transferencias] CHECK CONSTRAINT [FK_Transferencias_Bancos_Destino]
GO
ALTER TABLE [dbo].[Transferencias]  WITH CHECK ADD  CONSTRAINT [FK_Transferencias_Bancos_Origem] FOREIGN KEY([Conta_Origem_Banco])
REFERENCES [dbo].[Bancos] ([Cod_Banco])
GO
ALTER TABLE [dbo].[Transferencias] CHECK CONSTRAINT [FK_Transferencias_Bancos_Origem]
GO
/****** Object:  StoredProcedure [dbo].[InsertQuery]    Script Date: 12/12/2020 11:30:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertQuery]
(
	@Cod_Titulo_a_Pagar int,
	@Cod_Numero_Parcela_a_Pagar int,
	@Data_Pagamento datetime,
	@Numero_Parcela_Paga numeric(3, 0),
	@Valor_Pago decimal(18, 2),
	@Banco_Debitado int,
	@Numero_Cheque varchar(15),
	@Historico varchar(150),
	@Acrescimos decimal(18, 2),
	@Descontos decimal(18, 2),
	@Saldo decimal(18, 2),
	@Cod_Status_Titulo int,
	@Data_Login datetime,
	@Login_Name varchar(15)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [dbo].[Base_Titulos_Pagos] ([Cod_Titulo_a_Pagar], [Cod_Numero_Parcela_a_Pagar], [Data_Pagamento], [Numero_Parcela_Paga], [Valor_Pago], [Banco_Debitado], [Numero_Cheque], [Historico], [Acrescimos], [Descontos], [Saldo], [Cod_Status_Titulo], [Data_Login], [Login_Name]) VALUES (@Cod_Titulo_a_Pagar, @Cod_Numero_Parcela_a_Pagar, @Data_Pagamento, @Numero_Parcela_Paga, @Valor_Pago, @Banco_Debitado, @Numero_Cheque, @Historico, @Acrescimos, @Descontos, @Saldo, @Cod_Status_Titulo, @Data_Login, @Login_Name);
	
SELECT Cod_Base_Titulos_Pagos, Cod_Titulo_a_Pagar, Cod_Numero_Parcela_a_Pagar, Data_Pagamento, Numero_Parcela_Paga, Valor_Pago, Banco_Debitado, Numero_Cheque, Historico, Acrescimos, Descontos, Saldo, Cod_Status_Titulo, Data_Login, Login_Name FROM Base_Titulos_Pagos WHERE (Cod_Base_Titulos_Pagos = SCOPE_IDENTITY())
GO
/****** Object:  StoredProcedure [dbo].[SelectQueryComNomedoBanco]    Script Date: 12/12/2020 11:30:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectQueryComNomedoBanco]
AS
	SET NOCOUNT ON;
SELECT        Cod_Base_Titulos_a_Recebidos, Data_Recebimento, Total_Recebido, Banco_Creditado, Historico,                      Data_Login, Login_Name
FROM          Base_Titulos_Recebidos
GO
