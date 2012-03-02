
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 03/01/2012 22:42:56
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
    ALTER TABLE [dbo].[EntradasCartaoPontoSet] DROP CONSTRAINT [FK_EntradasCartaoPontoCartoesPonto];
GO
IF OBJECT_ID(N'[dbo].[FK_FuncionariosCredenciais]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FuncionariosSet] DROP CONSTRAINT [FK_FuncionariosCredenciais];
GO
IF OBJECT_ID(N'[dbo].[FK_FuncionariosPermissoes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FuncionariosSet] DROP CONSTRAINT [FK_FuncionariosPermissoes];
GO
IF OBJECT_ID(N'[dbo].[FK_FuncionariosCurricula]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FuncionariosSet] DROP CONSTRAINT [FK_FuncionariosCurricula];
GO
IF OBJECT_ID(N'[dbo].[FK_FuncionariosDadosPessoais]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FuncionariosSet] DROP CONSTRAINT [FK_FuncionariosDadosPessoais];
GO
IF OBJECT_ID(N'[dbo].[FK_FuncionariosCartoesPonto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FuncionariosSet] DROP CONSTRAINT [FK_FuncionariosCartoesPonto];
GO
IF OBJECT_ID(N'[dbo].[FK_DadosPessoaisEnderecos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DadosPessoaisSet] DROP CONSTRAINT [FK_DadosPessoaisEnderecos];
GO
IF OBJECT_ID(N'[dbo].[FK_DadosPessoaisTelefones]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TelefonesSet] DROP CONSTRAINT [FK_DadosPessoaisTelefones];
GO
IF OBJECT_ID(N'[dbo].[FK_FuncionariosBeneficios]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BeneficiosSet] DROP CONSTRAINT [FK_FuncionariosBeneficios];
GO
IF OBJECT_ID(N'[dbo].[FK_FuncionariosCargos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FuncionariosSet] DROP CONSTRAINT [FK_FuncionariosCargos];
GO
IF OBJECT_ID(N'[dbo].[FK_FuncionariosEspecialidades]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FuncionariosSet] DROP CONSTRAINT [FK_FuncionariosEspecialidades];
GO
IF OBJECT_ID(N'[dbo].[FK_FuncionariosDadosBancarios]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FuncionariosSet] DROP CONSTRAINT [FK_FuncionariosDadosBancarios];
GO
IF OBJECT_ID(N'[dbo].[FK_FuncionariosAdmissoes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FuncionariosSet] DROP CONSTRAINT [FK_FuncionariosAdmissoes];
GO
IF OBJECT_ID(N'[dbo].[FK_PagamentoFuncionarios]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PagamentoSet] DROP CONSTRAINT [FK_PagamentoFuncionarios];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FuncionariosSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FuncionariosSet];
GO
IF OBJECT_ID(N'[dbo].[PagamentoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PagamentoSet];
GO
IF OBJECT_ID(N'[dbo].[CredenciaisSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CredenciaisSet];
GO
IF OBJECT_ID(N'[dbo].[PermissoesSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PermissoesSet];
GO
IF OBJECT_ID(N'[dbo].[CurriculaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CurriculaSet];
GO
IF OBJECT_ID(N'[dbo].[CartoesPontoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CartoesPontoSet];
GO
IF OBJECT_ID(N'[dbo].[EntradasCartaoPontoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EntradasCartaoPontoSet];
GO
IF OBJECT_ID(N'[dbo].[DadosPessoaisSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DadosPessoaisSet];
GO
IF OBJECT_ID(N'[dbo].[EnderecosSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EnderecosSet];
GO
IF OBJECT_ID(N'[dbo].[TelefonesSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TelefonesSet];
GO
IF OBJECT_ID(N'[dbo].[BeneficiosSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BeneficiosSet];
GO
IF OBJECT_ID(N'[dbo].[CargosSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CargosSet];
GO
IF OBJECT_ID(N'[dbo].[EspecialidadesSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EspecialidadesSet];
GO
IF OBJECT_ID(N'[dbo].[DadosBancariosSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DadosBancariosSet];
GO
IF OBJECT_ID(N'[dbo].[AdmissoesSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AdmissoesSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'tblFuncionarios'
CREATE TABLE [dbo].[tblFuncionarios] (
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

-- Creating table 'tblPagamentos'
CREATE TABLE [dbo].[tblPagamentos] (
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

-- Creating table 'tblCredenciais'
CREATE TABLE [dbo].[tblCredenciais] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Usuario] nvarchar(max)  NOT NULL,
    [Senha] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'tblPermissoes'
CREATE TABLE [dbo].[tblPermissoes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'tblCurricula'
CREATE TABLE [dbo].[tblCurricula] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Formacao] nvarchar(max)  NOT NULL,
    [Arquivo] varbinary(max)  NOT NULL
);
GO

-- Creating table 'tblCartoesPonto'
CREATE TABLE [dbo].[tblCartoesPonto] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Mes] int  NOT NULL,
    [Ano] int  NOT NULL
);
GO

-- Creating table 'tblEntradasCartaoPonto'
CREATE TABLE [dbo].[tblEntradasCartaoPonto] (
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

-- Creating table 'tblDadosPessoais'
CREATE TABLE [dbo].[tblDadosPessoais] (
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

-- Creating table 'tblEnderecos'
CREATE TABLE [dbo].[tblEnderecos] (
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

-- Creating table 'tblTelefones'
CREATE TABLE [dbo].[tblTelefones] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DDD] int  NOT NULL,
    [Numero] int  NOT NULL,
    [DadoPessoalId] int  NOT NULL
);
GO

-- Creating table 'tblBeneficios'
CREATE TABLE [dbo].[tblBeneficios] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Valor] float  NOT NULL,
    [funcionarioId] int  NOT NULL
);
GO

-- Creating table 'tblCargos'
CREATE TABLE [dbo].[tblCargos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [SalarioBase] float  NOT NULL,
    [AdmissaoCargo_Cargo_Id] int  NOT NULL
);
GO

-- Creating table 'tblEspecialidades'
CREATE TABLE [dbo].[tblEspecialidades] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'tblDadosBancarios'
CREATE TABLE [dbo].[tblDadosBancarios] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Banco] int  NOT NULL,
    [ContaCorrente] float  NOT NULL,
    [Agencia] float  NOT NULL
);
GO

-- Creating table 'tblAdmissoes'
CREATE TABLE [dbo].[tblAdmissoes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DataAdmissao] datetime  NOT NULL,
    [DataDesligamento] datetime  NOT NULL,
    [MotivoDesligamento] nvarchar(max)  NOT NULL,
    [UltimoSalario] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'tblFuncionarios_Medico'
CREATE TABLE [dbo].[tblFuncionarios_Medico] (
    [CRM] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL,
    [Especialidade_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'tblFuncionarios'
ALTER TABLE [dbo].[tblFuncionarios]
ADD CONSTRAINT [PK_tblFuncionarios]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'tblPagamentos'
ALTER TABLE [dbo].[tblPagamentos]
ADD CONSTRAINT [PK_tblPagamentos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'tblCredenciais'
ALTER TABLE [dbo].[tblCredenciais]
ADD CONSTRAINT [PK_tblCredenciais]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'tblPermissoes'
ALTER TABLE [dbo].[tblPermissoes]
ADD CONSTRAINT [PK_tblPermissoes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'tblCurricula'
ALTER TABLE [dbo].[tblCurricula]
ADD CONSTRAINT [PK_tblCurricula]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'tblCartoesPonto'
ALTER TABLE [dbo].[tblCartoesPonto]
ADD CONSTRAINT [PK_tblCartoesPonto]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'tblEntradasCartaoPonto'
ALTER TABLE [dbo].[tblEntradasCartaoPonto]
ADD CONSTRAINT [PK_tblEntradasCartaoPonto]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'tblDadosPessoais'
ALTER TABLE [dbo].[tblDadosPessoais]
ADD CONSTRAINT [PK_tblDadosPessoais]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'tblEnderecos'
ALTER TABLE [dbo].[tblEnderecos]
ADD CONSTRAINT [PK_tblEnderecos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'tblTelefones'
ALTER TABLE [dbo].[tblTelefones]
ADD CONSTRAINT [PK_tblTelefones]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'tblBeneficios'
ALTER TABLE [dbo].[tblBeneficios]
ADD CONSTRAINT [PK_tblBeneficios]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'tblCargos'
ALTER TABLE [dbo].[tblCargos]
ADD CONSTRAINT [PK_tblCargos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'tblEspecialidades'
ALTER TABLE [dbo].[tblEspecialidades]
ADD CONSTRAINT [PK_tblEspecialidades]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'tblDadosBancarios'
ALTER TABLE [dbo].[tblDadosBancarios]
ADD CONSTRAINT [PK_tblDadosBancarios]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'tblAdmissoes'
ALTER TABLE [dbo].[tblAdmissoes]
ADD CONSTRAINT [PK_tblAdmissoes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'tblFuncionarios_Medico'
ALTER TABLE [dbo].[tblFuncionarios_Medico]
ADD CONSTRAINT [PK_tblFuncionarios_Medico]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [cartoesPontoId] in table 'tblEntradasCartaoPonto'
ALTER TABLE [dbo].[tblEntradasCartaoPonto]
ADD CONSTRAINT [FK_EntradasCartaoPontoCartoesPonto]
    FOREIGN KEY ([cartoesPontoId])
    REFERENCES [dbo].[tblCartoesPonto]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EntradasCartaoPontoCartoesPonto'
CREATE INDEX [IX_FK_EntradasCartaoPontoCartoesPonto]
ON [dbo].[tblEntradasCartaoPonto]
    ([cartoesPontoId]);
GO

-- Creating foreign key on [Credencial_Id] in table 'tblFuncionarios'
ALTER TABLE [dbo].[tblFuncionarios]
ADD CONSTRAINT [FK_FuncionariosCredenciais]
    FOREIGN KEY ([Credencial_Id])
    REFERENCES [dbo].[tblCredenciais]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FuncionariosCredenciais'
CREATE INDEX [IX_FK_FuncionariosCredenciais]
ON [dbo].[tblFuncionarios]
    ([Credencial_Id]);
GO

-- Creating foreign key on [PermissaoId] in table 'tblFuncionarios'
ALTER TABLE [dbo].[tblFuncionarios]
ADD CONSTRAINT [FK_FuncionariosPermissoes]
    FOREIGN KEY ([PermissaoId])
    REFERENCES [dbo].[tblPermissoes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FuncionariosPermissoes'
CREATE INDEX [IX_FK_FuncionariosPermissoes]
ON [dbo].[tblFuncionarios]
    ([PermissaoId]);
GO

-- Creating foreign key on [Curriculum_Id] in table 'tblFuncionarios'
ALTER TABLE [dbo].[tblFuncionarios]
ADD CONSTRAINT [FK_FuncionariosCurricula]
    FOREIGN KEY ([Curriculum_Id])
    REFERENCES [dbo].[tblCurricula]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FuncionariosCurricula'
CREATE INDEX [IX_FK_FuncionariosCurricula]
ON [dbo].[tblFuncionarios]
    ([Curriculum_Id]);
GO

-- Creating foreign key on [DadosPessoais_Id] in table 'tblFuncionarios'
ALTER TABLE [dbo].[tblFuncionarios]
ADD CONSTRAINT [FK_FuncionariosDadosPessoais]
    FOREIGN KEY ([DadosPessoais_Id])
    REFERENCES [dbo].[tblDadosPessoais]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FuncionariosDadosPessoais'
CREATE INDEX [IX_FK_FuncionariosDadosPessoais]
ON [dbo].[tblFuncionarios]
    ([DadosPessoais_Id]);
GO

-- Creating foreign key on [CartaoPonto_Id] in table 'tblFuncionarios'
ALTER TABLE [dbo].[tblFuncionarios]
ADD CONSTRAINT [FK_FuncionariosCartoesPonto]
    FOREIGN KEY ([CartaoPonto_Id])
    REFERENCES [dbo].[tblCartoesPonto]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FuncionariosCartoesPonto'
CREATE INDEX [IX_FK_FuncionariosCartoesPonto]
ON [dbo].[tblFuncionarios]
    ([CartaoPonto_Id]);
GO

-- Creating foreign key on [Id] in table 'tblEnderecos'
ALTER TABLE [dbo].[tblEnderecos]
ADD CONSTRAINT [FK_DadosPessoaisEnderecos]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[tblDadosPessoais]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [funcionarioId] in table 'tblBeneficios'
ALTER TABLE [dbo].[tblBeneficios]
ADD CONSTRAINT [FK_FuncionariosBeneficios]
    FOREIGN KEY ([funcionarioId])
    REFERENCES [dbo].[tblFuncionarios]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FuncionariosBeneficios'
CREATE INDEX [IX_FK_FuncionariosBeneficios]
ON [dbo].[tblBeneficios]
    ([funcionarioId]);
GO

-- Creating foreign key on [CargoId] in table 'tblFuncionarios'
ALTER TABLE [dbo].[tblFuncionarios]
ADD CONSTRAINT [FK_FuncionariosCargos]
    FOREIGN KEY ([CargoId])
    REFERENCES [dbo].[tblCargos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FuncionariosCargos'
CREATE INDEX [IX_FK_FuncionariosCargos]
ON [dbo].[tblFuncionarios]
    ([CargoId]);
GO

-- Creating foreign key on [DadosBancarios_Id] in table 'tblFuncionarios'
ALTER TABLE [dbo].[tblFuncionarios]
ADD CONSTRAINT [FK_FuncionariosDadosBancarios]
    FOREIGN KEY ([DadosBancarios_Id])
    REFERENCES [dbo].[tblDadosBancarios]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FuncionariosDadosBancarios'
CREATE INDEX [IX_FK_FuncionariosDadosBancarios]
ON [dbo].[tblFuncionarios]
    ([DadosBancarios_Id]);
GO

-- Creating foreign key on [Admissao_Id] in table 'tblFuncionarios'
ALTER TABLE [dbo].[tblFuncionarios]
ADD CONSTRAINT [FK_FuncionariosAdmissoes]
    FOREIGN KEY ([Admissao_Id])
    REFERENCES [dbo].[tblAdmissoes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FuncionariosAdmissoes'
CREATE INDEX [IX_FK_FuncionariosAdmissoes]
ON [dbo].[tblFuncionarios]
    ([Admissao_Id]);
GO

-- Creating foreign key on [funcionariosId] in table 'tblPagamentos'
ALTER TABLE [dbo].[tblPagamentos]
ADD CONSTRAINT [FK_PagamentoFuncionarios]
    FOREIGN KEY ([funcionariosId])
    REFERENCES [dbo].[tblFuncionarios]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PagamentoFuncionarios'
CREATE INDEX [IX_FK_PagamentoFuncionarios]
ON [dbo].[tblPagamentos]
    ([funcionariosId]);
GO

-- Creating foreign key on [Especialidade_Id] in table 'tblFuncionarios_Medico'
ALTER TABLE [dbo].[tblFuncionarios_Medico]
ADD CONSTRAINT [FK_MedicoEspecialidade]
    FOREIGN KEY ([Especialidade_Id])
    REFERENCES [dbo].[tblEspecialidades]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_MedicoEspecialidade'
CREATE INDEX [IX_FK_MedicoEspecialidade]
ON [dbo].[tblFuncionarios_Medico]
    ([Especialidade_Id]);
GO

-- Creating foreign key on [DadoPessoalId] in table 'tblTelefones'
ALTER TABLE [dbo].[tblTelefones]
ADD CONSTRAINT [FK_DadoPessoalTelefone]
    FOREIGN KEY ([DadoPessoalId])
    REFERENCES [dbo].[tblDadosPessoais]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_DadoPessoalTelefone'
CREATE INDEX [IX_FK_DadoPessoalTelefone]
ON [dbo].[tblTelefones]
    ([DadoPessoalId]);
GO

-- Creating foreign key on [AdmissaoCargo_Cargo_Id] in table 'tblCargos'
ALTER TABLE [dbo].[tblCargos]
ADD CONSTRAINT [FK_AdmissaoCargo]
    FOREIGN KEY ([AdmissaoCargo_Cargo_Id])
    REFERENCES [dbo].[tblAdmissoes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_AdmissaoCargo'
CREATE INDEX [IX_FK_AdmissaoCargo]
ON [dbo].[tblCargos]
    ([AdmissaoCargo_Cargo_Id]);
GO

-- Creating foreign key on [Id] in table 'tblFuncionarios_Medico'
ALTER TABLE [dbo].[tblFuncionarios_Medico]
ADD CONSTRAINT [FK_Medico_inherits_Funcionario]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[tblFuncionarios]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------