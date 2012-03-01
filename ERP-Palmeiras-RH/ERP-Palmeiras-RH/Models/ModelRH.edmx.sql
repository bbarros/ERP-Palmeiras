
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 03/01/2012 12:37:59
-- Generated from EDMX file: C:\Users\Bruno\Documents\github\ERP-Palmeiras\ERP-Palmeiras-RH\ERP-Palmeiras-RH\Models\ModelRH.edmx
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

-- Creating table 'FuncionariosSet'
CREATE TABLE [dbo].[FuncionariosSet] (
    [id] int IDENTITY(1,1) NOT NULL,
    [status] nvarchar(max)  NOT NULL,
    [salario] float  NOT NULL,
    [ramal] int  NOT NULL,
    [permissaoId] int  NOT NULL,
    [cargoId] int  NOT NULL,
    [crm] nvarchar(max)  NULL,
    [especialidadeId] int  NOT NULL,
    [credencial_id] int  NOT NULL,
    [curriculum_id] int  NOT NULL,
    [dadosPessoais_id] int  NOT NULL,
    [cartaoPonto_id] int  NOT NULL,
    [dadosBancarios_id] int  NOT NULL,
    [admissao_id] int  NOT NULL
);
GO

-- Creating table 'PagamentoSet'
CREATE TABLE [dbo].[PagamentoSet] (
    [id] int IDENTITY(1,1) NOT NULL,
    [salario] float  NOT NULL,
    [adicionais] float  NOT NULL,
    [descontos] float  NOT NULL,
    [total] float  NOT NULL,
    [dataPagamento] datetime  NOT NULL,
    [cargo] nvarchar(max)  NOT NULL,
    [funcionariosId] int  NOT NULL
);
GO

-- Creating table 'CredenciaisSet'
CREATE TABLE [dbo].[CredenciaisSet] (
    [id] int IDENTITY(1,1) NOT NULL,
    [usuario] nvarchar(max)  NOT NULL,
    [senha] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PermissoesSet'
CREATE TABLE [dbo].[PermissoesSet] (
    [id] int IDENTITY(1,1) NOT NULL,
    [nome] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'CurriculaSet'
CREATE TABLE [dbo].[CurriculaSet] (
    [id] int IDENTITY(1,1) NOT NULL,
    [formacao] nvarchar(max)  NOT NULL,
    [arquivo] tinyint  NOT NULL
);
GO

-- Creating table 'CartoesPontoSet'
CREATE TABLE [dbo].[CartoesPontoSet] (
    [id] int IDENTITY(1,1) NOT NULL,
    [mes] int  NOT NULL,
    [ano] int  NOT NULL
);
GO

-- Creating table 'EntradasCartaoPontoSet'
CREATE TABLE [dbo].[EntradasCartaoPontoSet] (
    [id] int IDENTITY(1,1) NOT NULL,
    [dia] datetime  NOT NULL,
    [entradaManha] time  NOT NULL,
    [saidaManha] time  NOT NULL,
    [entradaTarde] time  NOT NULL,
    [saidaTarde] time  NOT NULL,
    [entradaNoite] time  NOT NULL,
    [saidaNoite] time  NOT NULL,
    [cartoesPontoId] int  NOT NULL
);
GO

-- Creating table 'DadosPessoaisSet'
CREATE TABLE [dbo].[DadosPessoaisSet] (
    [id] int IDENTITY(1,1) NOT NULL,
    [nome] nvarchar(max)  NOT NULL,
    [sobrenome] nvarchar(max)  NOT NULL,
    [dataNascimento] nvarchar(max)  NOT NULL,
    [sexo] nvarchar(max)  NOT NULL,
    [cpf] float  NOT NULL,
    [rg] float  NOT NULL,
    [clt] nvarchar(max)  NOT NULL,
    [email] nvarchar(max)  NOT NULL,
    [EnderecosId] int  NOT NULL,
    [endereco_id] int  NOT NULL
);
GO

-- Creating table 'EnderecosSet'
CREATE TABLE [dbo].[EnderecosSet] (
    [id] int IDENTITY(1,1) NOT NULL,
    [rua] nvarchar(max)  NOT NULL,
    [numero] int  NOT NULL,
    [complemento] nvarchar(max)  NOT NULL,
    [bairro] nvarchar(max)  NOT NULL,
    [cep] nvarchar(max)  NOT NULL,
    [cidade] nvarchar(max)  NOT NULL,
    [estado] nvarchar(max)  NOT NULL,
    [pais] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'TelefonesSet'
CREATE TABLE [dbo].[TelefonesSet] (
    [id] int IDENTITY(1,1) NOT NULL,
    [ddd] int  NOT NULL,
    [numero] int  NOT NULL,
    [dadosPessoaisId] int  NOT NULL
);
GO

-- Creating table 'BeneficiosSet'
CREATE TABLE [dbo].[BeneficiosSet] (
    [id] int IDENTITY(1,1) NOT NULL,
    [nome] nvarchar(max)  NOT NULL,
    [valor] float  NOT NULL,
    [funcionarioId] int  NOT NULL
);
GO

-- Creating table 'CargosSet'
CREATE TABLE [dbo].[CargosSet] (
    [id] int IDENTITY(1,1) NOT NULL,
    [nome] nvarchar(max)  NOT NULL,
    [salarioBase] float  NOT NULL
);
GO

-- Creating table 'EspecialidadesSet'
CREATE TABLE [dbo].[EspecialidadesSet] (
    [id] int IDENTITY(1,1) NOT NULL,
    [nome] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'DadosBancariosSet'
CREATE TABLE [dbo].[DadosBancariosSet] (
    [id] int IDENTITY(1,1) NOT NULL,
    [banco] int  NOT NULL,
    [contaCorrente] float  NOT NULL,
    [agencia] float  NOT NULL
);
GO

-- Creating table 'AdmissoesSet'
CREATE TABLE [dbo].[AdmissoesSet] (
    [id] int IDENTITY(1,1) NOT NULL,
    [dataAdmissao] datetime  NOT NULL,
    [dataDesligamento] datetime  NOT NULL,
    [motivoDesligamento] nvarchar(max)  NOT NULL,
    [ultimoCargo] nvarchar(max)  NOT NULL,
    [ultimoSalario] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id] in table 'FuncionariosSet'
ALTER TABLE [dbo].[FuncionariosSet]
ADD CONSTRAINT [PK_FuncionariosSet]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'PagamentoSet'
ALTER TABLE [dbo].[PagamentoSet]
ADD CONSTRAINT [PK_PagamentoSet]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'CredenciaisSet'
ALTER TABLE [dbo].[CredenciaisSet]
ADD CONSTRAINT [PK_CredenciaisSet]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'PermissoesSet'
ALTER TABLE [dbo].[PermissoesSet]
ADD CONSTRAINT [PK_PermissoesSet]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'CurriculaSet'
ALTER TABLE [dbo].[CurriculaSet]
ADD CONSTRAINT [PK_CurriculaSet]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'CartoesPontoSet'
ALTER TABLE [dbo].[CartoesPontoSet]
ADD CONSTRAINT [PK_CartoesPontoSet]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'EntradasCartaoPontoSet'
ALTER TABLE [dbo].[EntradasCartaoPontoSet]
ADD CONSTRAINT [PK_EntradasCartaoPontoSet]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'DadosPessoaisSet'
ALTER TABLE [dbo].[DadosPessoaisSet]
ADD CONSTRAINT [PK_DadosPessoaisSet]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'EnderecosSet'
ALTER TABLE [dbo].[EnderecosSet]
ADD CONSTRAINT [PK_EnderecosSet]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'TelefonesSet'
ALTER TABLE [dbo].[TelefonesSet]
ADD CONSTRAINT [PK_TelefonesSet]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'BeneficiosSet'
ALTER TABLE [dbo].[BeneficiosSet]
ADD CONSTRAINT [PK_BeneficiosSet]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'CargosSet'
ALTER TABLE [dbo].[CargosSet]
ADD CONSTRAINT [PK_CargosSet]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'EspecialidadesSet'
ALTER TABLE [dbo].[EspecialidadesSet]
ADD CONSTRAINT [PK_EspecialidadesSet]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'DadosBancariosSet'
ALTER TABLE [dbo].[DadosBancariosSet]
ADD CONSTRAINT [PK_DadosBancariosSet]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'AdmissoesSet'
ALTER TABLE [dbo].[AdmissoesSet]
ADD CONSTRAINT [PK_AdmissoesSet]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [cartoesPontoId] in table 'EntradasCartaoPontoSet'
ALTER TABLE [dbo].[EntradasCartaoPontoSet]
ADD CONSTRAINT [FK_EntradasCartaoPontoCartoesPonto]
    FOREIGN KEY ([cartoesPontoId])
    REFERENCES [dbo].[CartoesPontoSet]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EntradasCartaoPontoCartoesPonto'
CREATE INDEX [IX_FK_EntradasCartaoPontoCartoesPonto]
ON [dbo].[EntradasCartaoPontoSet]
    ([cartoesPontoId]);
GO

-- Creating foreign key on [credencial_id] in table 'FuncionariosSet'
ALTER TABLE [dbo].[FuncionariosSet]
ADD CONSTRAINT [FK_FuncionariosCredenciais]
    FOREIGN KEY ([credencial_id])
    REFERENCES [dbo].[CredenciaisSet]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FuncionariosCredenciais'
CREATE INDEX [IX_FK_FuncionariosCredenciais]
ON [dbo].[FuncionariosSet]
    ([credencial_id]);
GO

-- Creating foreign key on [permissaoId] in table 'FuncionariosSet'
ALTER TABLE [dbo].[FuncionariosSet]
ADD CONSTRAINT [FK_FuncionariosPermissoes]
    FOREIGN KEY ([permissaoId])
    REFERENCES [dbo].[PermissoesSet]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FuncionariosPermissoes'
CREATE INDEX [IX_FK_FuncionariosPermissoes]
ON [dbo].[FuncionariosSet]
    ([permissaoId]);
GO

-- Creating foreign key on [curriculum_id] in table 'FuncionariosSet'
ALTER TABLE [dbo].[FuncionariosSet]
ADD CONSTRAINT [FK_FuncionariosCurricula]
    FOREIGN KEY ([curriculum_id])
    REFERENCES [dbo].[CurriculaSet]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FuncionariosCurricula'
CREATE INDEX [IX_FK_FuncionariosCurricula]
ON [dbo].[FuncionariosSet]
    ([curriculum_id]);
GO

-- Creating foreign key on [dadosPessoais_id] in table 'FuncionariosSet'
ALTER TABLE [dbo].[FuncionariosSet]
ADD CONSTRAINT [FK_FuncionariosDadosPessoais]
    FOREIGN KEY ([dadosPessoais_id])
    REFERENCES [dbo].[DadosPessoaisSet]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FuncionariosDadosPessoais'
CREATE INDEX [IX_FK_FuncionariosDadosPessoais]
ON [dbo].[FuncionariosSet]
    ([dadosPessoais_id]);
GO

-- Creating foreign key on [cartaoPonto_id] in table 'FuncionariosSet'
ALTER TABLE [dbo].[FuncionariosSet]
ADD CONSTRAINT [FK_FuncionariosCartoesPonto]
    FOREIGN KEY ([cartaoPonto_id])
    REFERENCES [dbo].[CartoesPontoSet]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FuncionariosCartoesPonto'
CREATE INDEX [IX_FK_FuncionariosCartoesPonto]
ON [dbo].[FuncionariosSet]
    ([cartaoPonto_id]);
GO

-- Creating foreign key on [endereco_id] in table 'DadosPessoaisSet'
ALTER TABLE [dbo].[DadosPessoaisSet]
ADD CONSTRAINT [FK_DadosPessoaisEnderecos]
    FOREIGN KEY ([endereco_id])
    REFERENCES [dbo].[EnderecosSet]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_DadosPessoaisEnderecos'
CREATE INDEX [IX_FK_DadosPessoaisEnderecos]
ON [dbo].[DadosPessoaisSet]
    ([endereco_id]);
GO

-- Creating foreign key on [dadosPessoaisId] in table 'TelefonesSet'
ALTER TABLE [dbo].[TelefonesSet]
ADD CONSTRAINT [FK_DadosPessoaisTelefones]
    FOREIGN KEY ([dadosPessoaisId])
    REFERENCES [dbo].[DadosPessoaisSet]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_DadosPessoaisTelefones'
CREATE INDEX [IX_FK_DadosPessoaisTelefones]
ON [dbo].[TelefonesSet]
    ([dadosPessoaisId]);
GO

-- Creating foreign key on [funcionarioId] in table 'BeneficiosSet'
ALTER TABLE [dbo].[BeneficiosSet]
ADD CONSTRAINT [FK_FuncionariosBeneficios]
    FOREIGN KEY ([funcionarioId])
    REFERENCES [dbo].[FuncionariosSet]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FuncionariosBeneficios'
CREATE INDEX [IX_FK_FuncionariosBeneficios]
ON [dbo].[BeneficiosSet]
    ([funcionarioId]);
GO

-- Creating foreign key on [cargoId] in table 'FuncionariosSet'
ALTER TABLE [dbo].[FuncionariosSet]
ADD CONSTRAINT [FK_FuncionariosCargos]
    FOREIGN KEY ([cargoId])
    REFERENCES [dbo].[CargosSet]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FuncionariosCargos'
CREATE INDEX [IX_FK_FuncionariosCargos]
ON [dbo].[FuncionariosSet]
    ([cargoId]);
GO

-- Creating foreign key on [especialidadeId] in table 'FuncionariosSet'
ALTER TABLE [dbo].[FuncionariosSet]
ADD CONSTRAINT [FK_FuncionariosEspecialidades]
    FOREIGN KEY ([especialidadeId])
    REFERENCES [dbo].[EspecialidadesSet]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FuncionariosEspecialidades'
CREATE INDEX [IX_FK_FuncionariosEspecialidades]
ON [dbo].[FuncionariosSet]
    ([especialidadeId]);
GO

-- Creating foreign key on [dadosBancarios_id] in table 'FuncionariosSet'
ALTER TABLE [dbo].[FuncionariosSet]
ADD CONSTRAINT [FK_FuncionariosDadosBancarios]
    FOREIGN KEY ([dadosBancarios_id])
    REFERENCES [dbo].[DadosBancariosSet]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FuncionariosDadosBancarios'
CREATE INDEX [IX_FK_FuncionariosDadosBancarios]
ON [dbo].[FuncionariosSet]
    ([dadosBancarios_id]);
GO

-- Creating foreign key on [admissao_id] in table 'FuncionariosSet'
ALTER TABLE [dbo].[FuncionariosSet]
ADD CONSTRAINT [FK_FuncionariosAdmissoes]
    FOREIGN KEY ([admissao_id])
    REFERENCES [dbo].[AdmissoesSet]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FuncionariosAdmissoes'
CREATE INDEX [IX_FK_FuncionariosAdmissoes]
ON [dbo].[FuncionariosSet]
    ([admissao_id]);
GO

-- Creating foreign key on [funcionariosId] in table 'PagamentoSet'
ALTER TABLE [dbo].[PagamentoSet]
ADD CONSTRAINT [FK_PagamentoFuncionarios]
    FOREIGN KEY ([funcionariosId])
    REFERENCES [dbo].[FuncionariosSet]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PagamentoFuncionarios'
CREATE INDEX [IX_FK_PagamentoFuncionarios]
ON [dbo].[PagamentoSet]
    ([funcionariosId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------