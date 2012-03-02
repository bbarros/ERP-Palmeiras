
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 03/02/2012 09:16:55
-- Generated from EDMX file: C:\Users\Mauricio\Documents\Poli\Cooperativo\4o Quadrimestre\PCS2044\ERP-Palmeiras\ERP-Palmeiras\ERP-Palmeiras-RH\ERP-Palmeiras-RH\Models\ModelRH.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [sepsystems-rh];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_EntradasCartaoPontoCartoesPonto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TblEntradasCartaoPonto] DROP CONSTRAINT [FK_EntradasCartaoPontoCartoesPonto];
GO
IF OBJECT_ID(N'[dbo].[FK_FuncionariosCredenciais]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TblFuncionarios] DROP CONSTRAINT [FK_FuncionariosCredenciais];
GO
IF OBJECT_ID(N'[dbo].[FK_FuncionariosPermissoes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TblFuncionarios] DROP CONSTRAINT [FK_FuncionariosPermissoes];
GO
IF OBJECT_ID(N'[dbo].[FK_FuncionariosCurricula]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TblFuncionarios] DROP CONSTRAINT [FK_FuncionariosCurricula];
GO
IF OBJECT_ID(N'[dbo].[FK_FuncionariosDadosPessoais]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TblFuncionarios] DROP CONSTRAINT [FK_FuncionariosDadosPessoais];
GO
IF OBJECT_ID(N'[dbo].[FK_FuncionariosCartoesPonto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TblFuncionarios] DROP CONSTRAINT [FK_FuncionariosCartoesPonto];
GO
IF OBJECT_ID(N'[dbo].[FK_DadosPessoaisEnderecos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TblEnderecos] DROP CONSTRAINT [FK_DadosPessoaisEnderecos];
GO
IF OBJECT_ID(N'[dbo].[FK_FuncionariosBeneficios]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TblBeneficios] DROP CONSTRAINT [FK_FuncionariosBeneficios];
GO
IF OBJECT_ID(N'[dbo].[FK_FuncionariosCargos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TblFuncionarios] DROP CONSTRAINT [FK_FuncionariosCargos];
GO
IF OBJECT_ID(N'[dbo].[FK_FuncionariosDadosBancarios]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TblFuncionarios] DROP CONSTRAINT [FK_FuncionariosDadosBancarios];
GO
IF OBJECT_ID(N'[dbo].[FK_FuncionariosAdmissoes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TblFuncionarios] DROP CONSTRAINT [FK_FuncionariosAdmissoes];
GO
IF OBJECT_ID(N'[dbo].[FK_PagamentoFuncionarios]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TblPagamentos] DROP CONSTRAINT [FK_PagamentoFuncionarios];
GO
IF OBJECT_ID(N'[dbo].[FK_DadoPessoalTelefone]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TblTelefones] DROP CONSTRAINT [FK_DadoPessoalTelefone];
GO
IF OBJECT_ID(N'[dbo].[FK_AdmissaoCargo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TblCargos] DROP CONSTRAINT [FK_AdmissaoCargo];
GO
IF OBJECT_ID(N'[dbo].[FK_MedicoEspecialidade]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TblFuncionarios_Medico] DROP CONSTRAINT [FK_MedicoEspecialidade];
GO
IF OBJECT_ID(N'[dbo].[FK_Medico_inherits_Funcionario]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TblFuncionarios_Medico] DROP CONSTRAINT [FK_Medico_inherits_Funcionario];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[TblFuncionarios]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TblFuncionarios];
GO
IF OBJECT_ID(N'[dbo].[TblPagamentos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TblPagamentos];
GO
IF OBJECT_ID(N'[dbo].[TblCredenciais]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TblCredenciais];
GO
IF OBJECT_ID(N'[dbo].[TblPermissoes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TblPermissoes];
GO
IF OBJECT_ID(N'[dbo].[TblCurricula]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TblCurricula];
GO
IF OBJECT_ID(N'[dbo].[TblCartoesPonto]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TblCartoesPonto];
GO
IF OBJECT_ID(N'[dbo].[TblEntradasCartaoPonto]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TblEntradasCartaoPonto];
GO
IF OBJECT_ID(N'[dbo].[TblDadosPessoais]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TblDadosPessoais];
GO
IF OBJECT_ID(N'[dbo].[TblEnderecos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TblEnderecos];
GO
IF OBJECT_ID(N'[dbo].[TblTelefones]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TblTelefones];
GO
IF OBJECT_ID(N'[dbo].[TblBeneficios]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TblBeneficios];
GO
IF OBJECT_ID(N'[dbo].[TblCargos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TblCargos];
GO
IF OBJECT_ID(N'[dbo].[TblEspecialidades]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TblEspecialidades];
GO
IF OBJECT_ID(N'[dbo].[TblDadosBancarios]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TblDadosBancarios];
GO
IF OBJECT_ID(N'[dbo].[TblAdmissoes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TblAdmissoes];
GO
IF OBJECT_ID(N'[dbo].[TblFuncionarios_Medico]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TblFuncionarios_Medico];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'TblFuncionarios'
CREATE TABLE [dbo].[TblFuncionarios] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Status] int  NOT NULL,
    [Salario] float  NOT NULL,
    [Ramal] int  NOT NULL,
    [EntityType] nvarchar(max)  NOT NULL,
    [PermissaoId] int  NOT NULL,
    [CargoId] int  NOT NULL,
    [Credencial_Id] int  NOT NULL,
    [Curriculum_Id] int  NOT NULL,
    [DadosPessoais_Id] int  NOT NULL,
    [CartaoPonto_Id] int  NOT NULL,
    [DadosBancarios_Id] int  NOT NULL,
    [Admissao_Id] int  NOT NULL
);
GO

-- Creating table 'TblPagamentos'
CREATE TABLE [dbo].[TblPagamentos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Salario] float  NOT NULL,
    [Adicionais] float  NOT NULL,
    [Descontos] float  NOT NULL,
    [Total] float  NOT NULL,
    [DataPagamento] datetime  NOT NULL,
    [Cargo] nvarchar(max)  NOT NULL,
    [funcionariosId] int  NOT NULL
);
GO

-- Creating table 'TblCredenciais'
CREATE TABLE [dbo].[TblCredenciais] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Usuario] nvarchar(max)  NOT NULL,
    [Senha] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'TblPermissoes'
CREATE TABLE [dbo].[TblPermissoes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'TblCurricula'
CREATE TABLE [dbo].[TblCurricula] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Formacao] nvarchar(max)  NOT NULL,
    [Arquivo] varbinary(max)  NOT NULL
);
GO

-- Creating table 'TblCartoesPonto'
CREATE TABLE [dbo].[TblCartoesPonto] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Mes] int  NOT NULL,
    [Ano] int  NOT NULL
);
GO

-- Creating table 'TblEntradasCartaoPonto'
CREATE TABLE [dbo].[TblEntradasCartaoPonto] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Dia] datetime  NOT NULL,
    [EntradaManha] time  NOT NULL,
    [SaidaManha] time  NOT NULL,
    [EntradaTarde] time  NOT NULL,
    [SaidaTarde] time  NOT NULL,
    [EntradaNoite] time  NOT NULL,
    [SaidaNoite] time  NOT NULL,
    [cartoesPontoId] int  NOT NULL
);
GO

-- Creating table 'TblDadosPessoais'
CREATE TABLE [dbo].[TblDadosPessoais] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Sobrenome] nvarchar(max)  NOT NULL,
    [DataNascimento] nvarchar(max)  NOT NULL,
    [Sexo] nvarchar(max)  NOT NULL,
    [CPF] float  NOT NULL,
    [RG] float  NOT NULL,
    [CLT] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'TblEnderecos'
CREATE TABLE [dbo].[TblEnderecos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Rua] nvarchar(max)  NOT NULL,
    [Numero] int  NOT NULL,
    [Complemento] nvarchar(max)  NOT NULL,
    [Bairro] nvarchar(max)  NOT NULL,
    [CEP] nvarchar(max)  NOT NULL,
    [Cidade] nvarchar(max)  NOT NULL,
    [Estado] nvarchar(max)  NOT NULL,
    [Pais] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'TblTelefones'
CREATE TABLE [dbo].[TblTelefones] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DDD] int  NOT NULL,
    [Numero] int  NOT NULL,
    [DadoPessoalId] int  NOT NULL
);
GO

-- Creating table 'TblBeneficios'
CREATE TABLE [dbo].[TblBeneficios] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Valor] float  NOT NULL,
    [funcionarioId] int  NOT NULL
);
GO

-- Creating table 'TblCargos'
CREATE TABLE [dbo].[TblCargos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [SalarioBase] float  NOT NULL,
    [AdmissaoCargo_Cargo_Id] int  NOT NULL
);
GO

-- Creating table 'TblEspecialidades'
CREATE TABLE [dbo].[TblEspecialidades] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'TblDadosBancarios'
CREATE TABLE [dbo].[TblDadosBancarios] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Banco] int  NOT NULL,
    [ContaCorrente] nvarchar(max)  NOT NULL,
    [Agencia] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'TblAdmissoes'
CREATE TABLE [dbo].[TblAdmissoes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DataAdmissao] datetime  NOT NULL,
    [DataDesligamento] datetime  NOT NULL,
    [MotivoDesligamento] nvarchar(max)  NOT NULL,
    [UltimoSalario] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'TblFuncionarios_Medico'
CREATE TABLE [dbo].[TblFuncionarios_Medico] (
    [CRM] nvarchar(max)  NOT NULL,
    [EspecialidadeId] int  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'TblFuncionarios'
ALTER TABLE [dbo].[TblFuncionarios]
ADD CONSTRAINT [PK_TblFuncionarios]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TblPagamentos'
ALTER TABLE [dbo].[TblPagamentos]
ADD CONSTRAINT [PK_TblPagamentos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TblCredenciais'
ALTER TABLE [dbo].[TblCredenciais]
ADD CONSTRAINT [PK_TblCredenciais]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TblPermissoes'
ALTER TABLE [dbo].[TblPermissoes]
ADD CONSTRAINT [PK_TblPermissoes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TblCurricula'
ALTER TABLE [dbo].[TblCurricula]
ADD CONSTRAINT [PK_TblCurricula]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TblCartoesPonto'
ALTER TABLE [dbo].[TblCartoesPonto]
ADD CONSTRAINT [PK_TblCartoesPonto]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TblEntradasCartaoPonto'
ALTER TABLE [dbo].[TblEntradasCartaoPonto]
ADD CONSTRAINT [PK_TblEntradasCartaoPonto]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TblDadosPessoais'
ALTER TABLE [dbo].[TblDadosPessoais]
ADD CONSTRAINT [PK_TblDadosPessoais]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TblEnderecos'
ALTER TABLE [dbo].[TblEnderecos]
ADD CONSTRAINT [PK_TblEnderecos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TblTelefones'
ALTER TABLE [dbo].[TblTelefones]
ADD CONSTRAINT [PK_TblTelefones]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TblBeneficios'
ALTER TABLE [dbo].[TblBeneficios]
ADD CONSTRAINT [PK_TblBeneficios]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TblCargos'
ALTER TABLE [dbo].[TblCargos]
ADD CONSTRAINT [PK_TblCargos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TblEspecialidades'
ALTER TABLE [dbo].[TblEspecialidades]
ADD CONSTRAINT [PK_TblEspecialidades]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TblDadosBancarios'
ALTER TABLE [dbo].[TblDadosBancarios]
ADD CONSTRAINT [PK_TblDadosBancarios]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TblAdmissoes'
ALTER TABLE [dbo].[TblAdmissoes]
ADD CONSTRAINT [PK_TblAdmissoes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TblFuncionarios_Medico'
ALTER TABLE [dbo].[TblFuncionarios_Medico]
ADD CONSTRAINT [PK_TblFuncionarios_Medico]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [cartoesPontoId] in table 'TblEntradasCartaoPonto'
ALTER TABLE [dbo].[TblEntradasCartaoPonto]
ADD CONSTRAINT [FK_EntradasCartaoPontoCartoesPonto]
    FOREIGN KEY ([cartoesPontoId])
    REFERENCES [dbo].[TblCartoesPonto]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EntradasCartaoPontoCartoesPonto'
CREATE INDEX [IX_FK_EntradasCartaoPontoCartoesPonto]
ON [dbo].[TblEntradasCartaoPonto]
    ([cartoesPontoId]);
GO

-- Creating foreign key on [Credencial_Id] in table 'TblFuncionarios'
ALTER TABLE [dbo].[TblFuncionarios]
ADD CONSTRAINT [FK_FuncionariosCredenciais]
    FOREIGN KEY ([Credencial_Id])
    REFERENCES [dbo].[TblCredenciais]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FuncionariosCredenciais'
CREATE INDEX [IX_FK_FuncionariosCredenciais]
ON [dbo].[TblFuncionarios]
    ([Credencial_Id]);
GO

-- Creating foreign key on [PermissaoId] in table 'TblFuncionarios'
ALTER TABLE [dbo].[TblFuncionarios]
ADD CONSTRAINT [FK_FuncionariosPermissoes]
    FOREIGN KEY ([PermissaoId])
    REFERENCES [dbo].[TblPermissoes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FuncionariosPermissoes'
CREATE INDEX [IX_FK_FuncionariosPermissoes]
ON [dbo].[TblFuncionarios]
    ([PermissaoId]);
GO

-- Creating foreign key on [Curriculum_Id] in table 'TblFuncionarios'
ALTER TABLE [dbo].[TblFuncionarios]
ADD CONSTRAINT [FK_FuncionariosCurricula]
    FOREIGN KEY ([Curriculum_Id])
    REFERENCES [dbo].[TblCurricula]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FuncionariosCurricula'
CREATE INDEX [IX_FK_FuncionariosCurricula]
ON [dbo].[TblFuncionarios]
    ([Curriculum_Id]);
GO

-- Creating foreign key on [DadosPessoais_Id] in table 'TblFuncionarios'
ALTER TABLE [dbo].[TblFuncionarios]
ADD CONSTRAINT [FK_FuncionariosDadosPessoais]
    FOREIGN KEY ([DadosPessoais_Id])
    REFERENCES [dbo].[TblDadosPessoais]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FuncionariosDadosPessoais'
CREATE INDEX [IX_FK_FuncionariosDadosPessoais]
ON [dbo].[TblFuncionarios]
    ([DadosPessoais_Id]);
GO

-- Creating foreign key on [CartaoPonto_Id] in table 'TblFuncionarios'
ALTER TABLE [dbo].[TblFuncionarios]
ADD CONSTRAINT [FK_FuncionariosCartoesPonto]
    FOREIGN KEY ([CartaoPonto_Id])
    REFERENCES [dbo].[TblCartoesPonto]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FuncionariosCartoesPonto'
CREATE INDEX [IX_FK_FuncionariosCartoesPonto]
ON [dbo].[TblFuncionarios]
    ([CartaoPonto_Id]);
GO

-- Creating foreign key on [Id] in table 'TblEnderecos'
ALTER TABLE [dbo].[TblEnderecos]
ADD CONSTRAINT [FK_DadosPessoaisEnderecos]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[TblDadosPessoais]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [funcionarioId] in table 'TblBeneficios'
ALTER TABLE [dbo].[TblBeneficios]
ADD CONSTRAINT [FK_FuncionariosBeneficios]
    FOREIGN KEY ([funcionarioId])
    REFERENCES [dbo].[TblFuncionarios]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FuncionariosBeneficios'
CREATE INDEX [IX_FK_FuncionariosBeneficios]
ON [dbo].[TblBeneficios]
    ([funcionarioId]);
GO

-- Creating foreign key on [CargoId] in table 'TblFuncionarios'
ALTER TABLE [dbo].[TblFuncionarios]
ADD CONSTRAINT [FK_FuncionariosCargos]
    FOREIGN KEY ([CargoId])
    REFERENCES [dbo].[TblCargos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FuncionariosCargos'
CREATE INDEX [IX_FK_FuncionariosCargos]
ON [dbo].[TblFuncionarios]
    ([CargoId]);
GO

-- Creating foreign key on [DadosBancarios_Id] in table 'TblFuncionarios'
ALTER TABLE [dbo].[TblFuncionarios]
ADD CONSTRAINT [FK_FuncionariosDadosBancarios]
    FOREIGN KEY ([DadosBancarios_Id])
    REFERENCES [dbo].[TblDadosBancarios]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FuncionariosDadosBancarios'
CREATE INDEX [IX_FK_FuncionariosDadosBancarios]
ON [dbo].[TblFuncionarios]
    ([DadosBancarios_Id]);
GO

-- Creating foreign key on [Admissao_Id] in table 'TblFuncionarios'
ALTER TABLE [dbo].[TblFuncionarios]
ADD CONSTRAINT [FK_FuncionariosAdmissoes]
    FOREIGN KEY ([Admissao_Id])
    REFERENCES [dbo].[TblAdmissoes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FuncionariosAdmissoes'
CREATE INDEX [IX_FK_FuncionariosAdmissoes]
ON [dbo].[TblFuncionarios]
    ([Admissao_Id]);
GO

-- Creating foreign key on [funcionariosId] in table 'TblPagamentos'
ALTER TABLE [dbo].[TblPagamentos]
ADD CONSTRAINT [FK_PagamentoFuncionarios]
    FOREIGN KEY ([funcionariosId])
    REFERENCES [dbo].[TblFuncionarios]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PagamentoFuncionarios'
CREATE INDEX [IX_FK_PagamentoFuncionarios]
ON [dbo].[TblPagamentos]
    ([funcionariosId]);
GO

-- Creating foreign key on [DadoPessoalId] in table 'TblTelefones'
ALTER TABLE [dbo].[TblTelefones]
ADD CONSTRAINT [FK_DadoPessoalTelefone]
    FOREIGN KEY ([DadoPessoalId])
    REFERENCES [dbo].[TblDadosPessoais]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_DadoPessoalTelefone'
CREATE INDEX [IX_FK_DadoPessoalTelefone]
ON [dbo].[TblTelefones]
    ([DadoPessoalId]);
GO

-- Creating foreign key on [AdmissaoCargo_Cargo_Id] in table 'TblCargos'
ALTER TABLE [dbo].[TblCargos]
ADD CONSTRAINT [FK_AdmissaoCargo]
    FOREIGN KEY ([AdmissaoCargo_Cargo_Id])
    REFERENCES [dbo].[TblAdmissoes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_AdmissaoCargo'
CREATE INDEX [IX_FK_AdmissaoCargo]
ON [dbo].[TblCargos]
    ([AdmissaoCargo_Cargo_Id]);
GO

-- Creating foreign key on [EspecialidadeId] in table 'TblFuncionarios_Medico'
ALTER TABLE [dbo].[TblFuncionarios_Medico]
ADD CONSTRAINT [FK_MedicoEspecialidade]
    FOREIGN KEY ([EspecialidadeId])
    REFERENCES [dbo].[TblEspecialidades]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_MedicoEspecialidade'
CREATE INDEX [IX_FK_MedicoEspecialidade]
ON [dbo].[TblFuncionarios_Medico]
    ([EspecialidadeId]);
GO

-- Creating foreign key on [Id] in table 'TblFuncionarios_Medico'
ALTER TABLE [dbo].[TblFuncionarios_Medico]
ADD CONSTRAINT [FK_Medico_inherits_Funcionario]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[TblFuncionarios]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------