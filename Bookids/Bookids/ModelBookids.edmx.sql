
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/16/2019 19:24:20
-- Generated from EDMX file: C:\Users\ASUS\OneDrive - IPLeiria\TESP-PSI\2º Semestre\DAplic\Projeto Final - Bookids\Bookids\Bookids\ModelBookids.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [BookidsDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'PessoasSet'
CREATE TABLE [dbo].[PessoasSet] (
    [IdPessoa] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Morada] nvarchar(max)  NOT NULL,
    [Localidade] nvarchar(max)  NOT NULL,
    [CodPostal] nvarchar(max)  NOT NULL,
    [Telefone] nvarchar(max)  NOT NULL,
    [Telemovel] nvarchar(max)  NOT NULL,
    [Mail] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'EventosSet'
CREATE TABLE [dbo].[EventosSet] (
    [NrEvento] int IDENTITY(1,1) NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL,
    [Local] nvarchar(max)  NOT NULL,
    [DataHora] nvarchar(max)  NOT NULL,
    [LimiteParticipacoes] nvarchar(max)  NOT NULL,
    [IdadeInferior] nvarchar(max)  NOT NULL,
    [IdadeSuperior] nvarchar(max)  NOT NULL,
    [TipoEvento] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'InscricoesSet'
CREATE TABLE [dbo].[InscricoesSet] (
    [Confirmada] nvarchar(max)  NOT NULL,
    [FilhosIdPessoa] int  NOT NULL,
    [EventosNrEvento] int  NOT NULL
);
GO

-- Creating table 'EscolasSet'
CREATE TABLE [dbo].[EscolasSet] (
    [IdEscola] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Morada] nvarchar(max)  NOT NULL,
    [Telefone] nvarchar(max)  NOT NULL,
    [Mail] nvarchar(max)  NOT NULL,
    [CodPostal] nvarchar(max)  NOT NULL,
    [Localidade] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ParticipacoesSet'
CREATE TABLE [dbo].[ParticipacoesSet] (
    [EscolasIdEscola] int  NOT NULL,
    [EventosNrEvento] int  NOT NULL
);
GO

-- Creating table 'ColaboracoesSet'
CREATE TABLE [dbo].[ColaboracoesSet] (
    [AnimadoresIdPessoa] int  NOT NULL,
    [EventosNrEvento] int  NOT NULL
);
GO

-- Creating table 'ComprasSet'
CREATE TABLE [dbo].[ComprasSet] (
    [NrCompra] int IDENTITY(1,1) NOT NULL,
    [ClientesIdPessoa] int  NOT NULL,
    [Data] nvarchar(max)  NOT NULL,
    [UtilizouCartao] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'DetalheComprasSet'
CREATE TABLE [dbo].[DetalheComprasSet] (
    [Quantidade] nvarchar(max)  NOT NULL,
    [ComprasNrCompra] int  NOT NULL,
    [ProdutosCodProduto] int  NOT NULL
);
GO

-- Creating table 'ProdutosSet'
CREATE TABLE [dbo].[ProdutosSet] (
    [CodProduto] int IDENTITY(1,1) NOT NULL,
    [Designacao] nvarchar(max)  NOT NULL,
    [Preco] nvarchar(max)  NOT NULL,
    [TipoProdutoCodTipoProduto] int  NOT NULL,
    [StockExistente] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'TipoProdutoSet'
CREATE TABLE [dbo].[TipoProdutoSet] (
    [CodTipoProduto] int IDENTITY(1,1) NOT NULL,
    [Tipo] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PessoasSet_Filhos'
CREATE TABLE [dbo].[PessoasSet_Filhos] (
    [Sexo] nvarchar(max)  NOT NULL,
    [DataNascicmento] nvarchar(max)  NOT NULL,
    [EscolasIdEscola] int  NOT NULL,
    [ClientesIdPessoa] int  NOT NULL,
    [IdPessoa] int  NOT NULL
);
GO

-- Creating table 'PessoasSet_Clientes'
CREATE TABLE [dbo].[PessoasSet_Clientes] (
    [NrCartao] nvarchar(max)  NOT NULL,
    [ValorOferta] nvarchar(max)  NOT NULL,
    [IdPessoa] int  NOT NULL
);
GO

-- Creating table 'PessoasSet_Animadores'
CREATE TABLE [dbo].[PessoasSet_Animadores] (
    [Especialidade] nvarchar(max)  NOT NULL,
    [IdPessoa] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdPessoa] in table 'PessoasSet'
ALTER TABLE [dbo].[PessoasSet]
ADD CONSTRAINT [PK_PessoasSet]
    PRIMARY KEY CLUSTERED ([IdPessoa] ASC);
GO

-- Creating primary key on [NrEvento] in table 'EventosSet'
ALTER TABLE [dbo].[EventosSet]
ADD CONSTRAINT [PK_EventosSet]
    PRIMARY KEY CLUSTERED ([NrEvento] ASC);
GO

-- Creating primary key on [FilhosIdPessoa], [EventosNrEvento] in table 'InscricoesSet'
ALTER TABLE [dbo].[InscricoesSet]
ADD CONSTRAINT [PK_InscricoesSet]
    PRIMARY KEY CLUSTERED ([FilhosIdPessoa], [EventosNrEvento] ASC);
GO

-- Creating primary key on [IdEscola] in table 'EscolasSet'
ALTER TABLE [dbo].[EscolasSet]
ADD CONSTRAINT [PK_EscolasSet]
    PRIMARY KEY CLUSTERED ([IdEscola] ASC);
GO

-- Creating primary key on [EscolasIdEscola], [EventosNrEvento] in table 'ParticipacoesSet'
ALTER TABLE [dbo].[ParticipacoesSet]
ADD CONSTRAINT [PK_ParticipacoesSet]
    PRIMARY KEY CLUSTERED ([EscolasIdEscola], [EventosNrEvento] ASC);
GO

-- Creating primary key on [AnimadoresIdPessoa], [EventosNrEvento] in table 'ColaboracoesSet'
ALTER TABLE [dbo].[ColaboracoesSet]
ADD CONSTRAINT [PK_ColaboracoesSet]
    PRIMARY KEY CLUSTERED ([AnimadoresIdPessoa], [EventosNrEvento] ASC);
GO

-- Creating primary key on [NrCompra] in table 'ComprasSet'
ALTER TABLE [dbo].[ComprasSet]
ADD CONSTRAINT [PK_ComprasSet]
    PRIMARY KEY CLUSTERED ([NrCompra] ASC);
GO

-- Creating primary key on [ComprasNrCompra], [ProdutosCodProduto] in table 'DetalheComprasSet'
ALTER TABLE [dbo].[DetalheComprasSet]
ADD CONSTRAINT [PK_DetalheComprasSet]
    PRIMARY KEY CLUSTERED ([ComprasNrCompra], [ProdutosCodProduto] ASC);
GO

-- Creating primary key on [CodProduto] in table 'ProdutosSet'
ALTER TABLE [dbo].[ProdutosSet]
ADD CONSTRAINT [PK_ProdutosSet]
    PRIMARY KEY CLUSTERED ([CodProduto] ASC);
GO

-- Creating primary key on [CodTipoProduto] in table 'TipoProdutoSet'
ALTER TABLE [dbo].[TipoProdutoSet]
ADD CONSTRAINT [PK_TipoProdutoSet]
    PRIMARY KEY CLUSTERED ([CodTipoProduto] ASC);
GO

-- Creating primary key on [IdPessoa] in table 'PessoasSet_Filhos'
ALTER TABLE [dbo].[PessoasSet_Filhos]
ADD CONSTRAINT [PK_PessoasSet_Filhos]
    PRIMARY KEY CLUSTERED ([IdPessoa] ASC);
GO

-- Creating primary key on [IdPessoa] in table 'PessoasSet_Clientes'
ALTER TABLE [dbo].[PessoasSet_Clientes]
ADD CONSTRAINT [PK_PessoasSet_Clientes]
    PRIMARY KEY CLUSTERED ([IdPessoa] ASC);
GO

-- Creating primary key on [IdPessoa] in table 'PessoasSet_Animadores'
ALTER TABLE [dbo].[PessoasSet_Animadores]
ADD CONSTRAINT [PK_PessoasSet_Animadores]
    PRIMARY KEY CLUSTERED ([IdPessoa] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [FilhosIdPessoa] in table 'InscricoesSet'
ALTER TABLE [dbo].[InscricoesSet]
ADD CONSTRAINT [FK_FilhosInscricoes]
    FOREIGN KEY ([FilhosIdPessoa])
    REFERENCES [dbo].[PessoasSet_Filhos]
        ([IdPessoa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [EventosNrEvento] in table 'InscricoesSet'
ALTER TABLE [dbo].[InscricoesSet]
ADD CONSTRAINT [FK_EventosInscricoes]
    FOREIGN KEY ([EventosNrEvento])
    REFERENCES [dbo].[EventosSet]
        ([NrEvento])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EventosInscricoes'
CREATE INDEX [IX_FK_EventosInscricoes]
ON [dbo].[InscricoesSet]
    ([EventosNrEvento]);
GO

-- Creating foreign key on [EscolasIdEscola] in table 'PessoasSet_Filhos'
ALTER TABLE [dbo].[PessoasSet_Filhos]
ADD CONSTRAINT [FK_EscolasFilhos]
    FOREIGN KEY ([EscolasIdEscola])
    REFERENCES [dbo].[EscolasSet]
        ([IdEscola])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EscolasFilhos'
CREATE INDEX [IX_FK_EscolasFilhos]
ON [dbo].[PessoasSet_Filhos]
    ([EscolasIdEscola]);
GO

-- Creating foreign key on [ClientesIdPessoa] in table 'PessoasSet_Filhos'
ALTER TABLE [dbo].[PessoasSet_Filhos]
ADD CONSTRAINT [FK_ClientesFilhos]
    FOREIGN KEY ([ClientesIdPessoa])
    REFERENCES [dbo].[PessoasSet_Clientes]
        ([IdPessoa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientesFilhos'
CREATE INDEX [IX_FK_ClientesFilhos]
ON [dbo].[PessoasSet_Filhos]
    ([ClientesIdPessoa]);
GO

-- Creating foreign key on [EscolasIdEscola] in table 'ParticipacoesSet'
ALTER TABLE [dbo].[ParticipacoesSet]
ADD CONSTRAINT [FK_ParticipacoesEscolas]
    FOREIGN KEY ([EscolasIdEscola])
    REFERENCES [dbo].[EscolasSet]
        ([IdEscola])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [EventosNrEvento] in table 'ParticipacoesSet'
ALTER TABLE [dbo].[ParticipacoesSet]
ADD CONSTRAINT [FK_EventosParticipacoes]
    FOREIGN KEY ([EventosNrEvento])
    REFERENCES [dbo].[EventosSet]
        ([NrEvento])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EventosParticipacoes'
CREATE INDEX [IX_FK_EventosParticipacoes]
ON [dbo].[ParticipacoesSet]
    ([EventosNrEvento]);
GO

-- Creating foreign key on [AnimadoresIdPessoa] in table 'ColaboracoesSet'
ALTER TABLE [dbo].[ColaboracoesSet]
ADD CONSTRAINT [FK_AnimadoresColaboracoes]
    FOREIGN KEY ([AnimadoresIdPessoa])
    REFERENCES [dbo].[PessoasSet_Animadores]
        ([IdPessoa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [EventosNrEvento] in table 'ColaboracoesSet'
ALTER TABLE [dbo].[ColaboracoesSet]
ADD CONSTRAINT [FK_ColaboracoesEventos]
    FOREIGN KEY ([EventosNrEvento])
    REFERENCES [dbo].[EventosSet]
        ([NrEvento])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ColaboracoesEventos'
CREATE INDEX [IX_FK_ColaboracoesEventos]
ON [dbo].[ColaboracoesSet]
    ([EventosNrEvento]);
GO

-- Creating foreign key on [ClientesIdPessoa] in table 'ComprasSet'
ALTER TABLE [dbo].[ComprasSet]
ADD CONSTRAINT [FK_ComprasClientes]
    FOREIGN KEY ([ClientesIdPessoa])
    REFERENCES [dbo].[PessoasSet_Clientes]
        ([IdPessoa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ComprasClientes'
CREATE INDEX [IX_FK_ComprasClientes]
ON [dbo].[ComprasSet]
    ([ClientesIdPessoa]);
GO

-- Creating foreign key on [ComprasNrCompra] in table 'DetalheComprasSet'
ALTER TABLE [dbo].[DetalheComprasSet]
ADD CONSTRAINT [FK_ComprasDetalheCompras]
    FOREIGN KEY ([ComprasNrCompra])
    REFERENCES [dbo].[ComprasSet]
        ([NrCompra])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ProdutosCodProduto] in table 'DetalheComprasSet'
ALTER TABLE [dbo].[DetalheComprasSet]
ADD CONSTRAINT [FK_DetalheComprasProdutos]
    FOREIGN KEY ([ProdutosCodProduto])
    REFERENCES [dbo].[ProdutosSet]
        ([CodProduto])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DetalheComprasProdutos'
CREATE INDEX [IX_FK_DetalheComprasProdutos]
ON [dbo].[DetalheComprasSet]
    ([ProdutosCodProduto]);
GO

-- Creating foreign key on [TipoProdutoCodTipoProduto] in table 'ProdutosSet'
ALTER TABLE [dbo].[ProdutosSet]
ADD CONSTRAINT [FK_ProdutosTipoProduto]
    FOREIGN KEY ([TipoProdutoCodTipoProduto])
    REFERENCES [dbo].[TipoProdutoSet]
        ([CodTipoProduto])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProdutosTipoProduto'
CREATE INDEX [IX_FK_ProdutosTipoProduto]
ON [dbo].[ProdutosSet]
    ([TipoProdutoCodTipoProduto]);
GO

-- Creating foreign key on [IdPessoa] in table 'PessoasSet_Filhos'
ALTER TABLE [dbo].[PessoasSet_Filhos]
ADD CONSTRAINT [FK_Filhos_inherits_Pessoas]
    FOREIGN KEY ([IdPessoa])
    REFERENCES [dbo].[PessoasSet]
        ([IdPessoa])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdPessoa] in table 'PessoasSet_Clientes'
ALTER TABLE [dbo].[PessoasSet_Clientes]
ADD CONSTRAINT [FK_Clientes_inherits_Pessoas]
    FOREIGN KEY ([IdPessoa])
    REFERENCES [dbo].[PessoasSet]
        ([IdPessoa])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdPessoa] in table 'PessoasSet_Animadores'
ALTER TABLE [dbo].[PessoasSet_Animadores]
ADD CONSTRAINT [FK_Animadores_inherits_Pessoas]
    FOREIGN KEY ([IdPessoa])
    REFERENCES [dbo].[PessoasSet]
        ([IdPessoa])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------