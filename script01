IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Habilidade] (
    [Id] int NOT NULL IDENTITY,
    [Descricao] nvarchar(40) NOT NULL,
    [Pontos_Vida] int NOT NULL,
    [Pontos_Defesa] int NOT NULL,
    [Pontos_Ataque] int NOT NULL,
    CONSTRAINT [PK_Habilidade] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Treinador] (
    [Id] int NOT NULL IDENTITY,
    [Primeiro_Nome] nvarchar(20) NOT NULL,
    [Segundo_Nome] nvarchar(20) NOT NULL,
    [Data_Nascimento] datetime2 NOT NULL,
    [Login] nvarchar(15) NOT NULL,
    [Senha] nvarchar(15) NOT NULL,
    CONSTRAINT [PK_Treinador] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Item] (
    [Id] int NOT NULL IDENTITY,
    [IdTreinador] int NOT NULL,
    [Pontos_Vida] int NOT NULL,
    [Pontos_Defesa] int NOT NULL,
    [Pontos_Ataque] int NOT NULL,
    [Descricao] nvarchar(30) NOT NULL,
    [Elemento] int NOT NULL,
    CONSTRAINT [PK_Item] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Item_Treinador_IdTreinador] FOREIGN KEY ([IdTreinador]) REFERENCES [Treinador] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [Pokemon] (
    [Id] int NOT NULL IDENTITY,
    [Nome_Pokemon] nvarchar(20) NOT NULL,
    [Peso_Pokemon] nvarchar(3) NOT NULL,
    [IdTreinador] int NOT NULL,
    [Pontos_Vida] int NOT NULL,
    [Pontos_Ataque] int NOT NULL,
    [Pontos_Defesa] int NOT NULL,
    [Elemento] int NOT NULL,
    CONSTRAINT [PK_Pokemon] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Pokemon_Treinador_IdTreinador] FOREIGN KEY ([IdTreinador]) REFERENCES [Treinador] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [Evolucao] (
    [Id] int NOT NULL IDENTITY,
    [IdPokemon] int NOT NULL,
    [Nome_Pokemon] nvarchar(20) NOT NULL,
    [Peso_Pokemon] nvarchar(3) NOT NULL,
    [IdTreinador] int NOT NULL,
    [Pontos_Vida] int NOT NULL,
    [Pontos_Ataque] int NOT NULL,
    [Pontos_Defesa] int NOT NULL,
    [Elemento] int NOT NULL,
    CONSTRAINT [PK_Evolucao] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Evolucao_Pokemon_IdPokemon] FOREIGN KEY ([IdPokemon]) REFERENCES [Pokemon] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [PokemonHabilidade] (
    [IdPokemon] int NOT NULL,
    [IdHabilidade] int NOT NULL,
    CONSTRAINT [PK_PokemonHabilidade] PRIMARY KEY ([IdPokemon]),
    CONSTRAINT [FK_PokemonHabilidade_Habilidade_IdHabilidade] FOREIGN KEY ([IdHabilidade]) REFERENCES [Habilidade] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_PokemonHabilidade_Pokemon_IdPokemon] FOREIGN KEY ([IdPokemon]) REFERENCES [Pokemon] ([Id]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_Evolucao_IdPokemon] ON [Evolucao] ([IdPokemon]);
GO

CREATE INDEX [IX_Item_IdTreinador] ON [Item] ([IdTreinador]);
GO

CREATE INDEX [IX_Pokemon_IdTreinador] ON [Pokemon] ([IdTreinador]);
GO

CREATE INDEX [IX_PokemonHabilidade_IdHabilidade] ON [PokemonHabilidade] ([IdHabilidade]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231215005415_InitialMigration', N'7.0.10');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Evolucao]') AND [c].[name] = N'IdTreinador');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Evolucao] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [Evolucao] DROP COLUMN [IdTreinador];
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231215010017_CorrecaoModelEvolucao', N'7.0.10');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Item]') AND [c].[name] = N'Elemento');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [Item] DROP CONSTRAINT [' + @var1 + '];');
ALTER TABLE [Item] ALTER COLUMN [Elemento] int NULL;
GO

ALTER TABLE [Item] ADD [Nome] nvarchar(20) NOT NULL DEFAULT N'';
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231215164538_CorrecaoModelItem', N'7.0.10');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DECLARE @var2 sysname;
SELECT @var2 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Pokemon]') AND [c].[name] = N'Peso_Pokemon');
IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [Pokemon] DROP CONSTRAINT [' + @var2 + '];');
ALTER TABLE [Pokemon] ALTER COLUMN [Peso_Pokemon] real NOT NULL;
GO

ALTER TABLE [Pokemon] ADD [Altura_Pokemon] real NOT NULL DEFAULT CAST(0 AS real);
GO

ALTER TABLE [Pokemon] ADD [Pontos_Velocidade] int NOT NULL DEFAULT 0;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231215165754_CorrecaoModelPokemon', N'7.0.10');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [Habilidade] ADD [Nome_Habilidade] nvarchar(40) NOT NULL DEFAULT N'';
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231215173301_CorrecaoModelHabilidade', N'7.0.10');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

EXEC sp_rename N'[Habilidade].[Pontos_Vida]', N'Power', N'COLUMN';
GO

EXEC sp_rename N'[Habilidade].[Pontos_Defesa]', N'Pontos_Precisao', N'COLUMN';
GO

EXEC sp_rename N'[Habilidade].[Pontos_Ataque]', N'Pontos_Power', N'COLUMN';
GO

ALTER TABLE [Habilidade] ADD [Elemento] int NOT NULL DEFAULT 0;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231216125636_AlteracaoHabilidade', N'7.0.10');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [EvolucaoHabilidade] (
    [IdHabilidade] int NOT NULL,
    [IdEvolucao] int NOT NULL,
    [HabilidadeId] int NULL,
    CONSTRAINT [PK_EvolucaoHabilidade] PRIMARY KEY ([IdHabilidade]),
    CONSTRAINT [FK_EvolucaoHabilidade_Evolucao_IdHabilidade] FOREIGN KEY ([IdHabilidade]) REFERENCES [Evolucao] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_EvolucaoHabilidade_Habilidade_HabilidadeId] FOREIGN KEY ([HabilidadeId]) REFERENCES [Habilidade] ([Id])
);
GO

CREATE INDEX [IX_EvolucaoHabilidade_HabilidadeId] ON [EvolucaoHabilidade] ([HabilidadeId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231216133146_AdicionandoEvolucaoHabilidade', N'7.0.10');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231216133437_CorrecaoEvolucaoHabilidade', N'7.0.10');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

EXEC sp_rename N'[Evolucao].[Peso_Pokemon]', N'Peso_Evolucao', N'COLUMN';
GO

DECLARE @var3 sysname;
SELECT @var3 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Evolucao]') AND [c].[name] = N'Peso_Evolucao');
IF @var3 IS NOT NULL EXEC(N'ALTER TABLE [Evolucao] DROP CONSTRAINT [' + @var3 + '];');
ALTER TABLE [Evolucao] ALTER COLUMN [Peso_Evolucao] real NOT NULL;
GO

ALTER TABLE [Evolucao] ADD [Altura_Evolucao] real NOT NULL DEFAULT CAST(0 AS real);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231216150352_CorrecaoModelEvolucao2', N'7.0.10');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

EXEC sp_rename N'[Evolucao].[Nome_Pokemon]', N'Nome_Evolcucao', N'COLUMN';
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231216150801_CorrecaoModelEvolucao3', N'7.0.10');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [Evolucao] ADD [Pontos_Velocidade] int NOT NULL DEFAULT 0;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240111233227_AlteracaoNaModelEvolucao', N'7.0.10');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DECLARE @var4 sysname;
SELECT @var4 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Pokemon]') AND [c].[name] = N'Pontos_Ataque');
IF @var4 IS NOT NULL EXEC(N'ALTER TABLE [Pokemon] DROP CONSTRAINT [' + @var4 + '];');
ALTER TABLE [Pokemon] DROP COLUMN [Pontos_Ataque];
GO

DECLARE @var5 sysname;
SELECT @var5 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Pokemon]') AND [c].[name] = N'Pontos_Defesa');
IF @var5 IS NOT NULL EXEC(N'ALTER TABLE [Pokemon] DROP CONSTRAINT [' + @var5 + '];');
ALTER TABLE [Pokemon] DROP COLUMN [Pontos_Defesa];
GO

DECLARE @var6 sysname;
SELECT @var6 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Pokemon]') AND [c].[name] = N'Pontos_Velocidade');
IF @var6 IS NOT NULL EXEC(N'ALTER TABLE [Pokemon] DROP CONSTRAINT [' + @var6 + '];');
ALTER TABLE [Pokemon] DROP COLUMN [Pontos_Velocidade];
GO

EXEC sp_rename N'[Pokemon].[Pontos_Vida]', N'SegundoElemento', N'COLUMN';
GO

ALTER TABLE [Pokemon] ADD [Apanhado] bit NOT NULL DEFAULT CAST(0 AS bit);
GO

ALTER TABLE [Pokemon] ADD [Codigo] nvarchar(max) NOT NULL DEFAULT N'';
GO

ALTER TABLE [Pokemon] ADD [Descricao] nvarchar(70) NOT NULL DEFAULT N'';
GO

ALTER TABLE [Pokemon] ADD [Max_Ataque] int NOT NULL DEFAULT 0;
DECLARE @defaultSchema AS sysname;
SET @defaultSchema = SCHEMA_NAME();
DECLARE @description AS sql_variant;
SET @description = N'Status maximo do ataque';
EXEC sp_addextendedproperty 'MS_Description', @description, 'SCHEMA', @defaultSchema, 'TABLE', N'Pokemon', 'COLUMN', N'Max_Ataque';
GO

ALTER TABLE [Pokemon] ADD [Max_Defesa] int NOT NULL DEFAULT 0;
DECLARE @defaultSchema AS sysname;
SET @defaultSchema = SCHEMA_NAME();
DECLARE @description AS sql_variant;
SET @description = N'Status maximo da defesa';
EXEC sp_addextendedproperty 'MS_Description', @description, 'SCHEMA', @defaultSchema, 'TABLE', N'Pokemon', 'COLUMN', N'Max_Defesa';
GO

ALTER TABLE [Pokemon] ADD [Max_Velocidade] int NOT NULL DEFAULT 0;
DECLARE @defaultSchema AS sysname;
SET @defaultSchema = SCHEMA_NAME();
DECLARE @description AS sql_variant;
SET @description = N'status maximo da velocidade';
EXEC sp_addextendedproperty 'MS_Description', @description, 'SCHEMA', @defaultSchema, 'TABLE', N'Pokemon', 'COLUMN', N'Max_Velocidade';
GO

ALTER TABLE [Pokemon] ADD [Max_Vida] int NOT NULL DEFAULT 0;
DECLARE @defaultSchema AS sysname;
SET @defaultSchema = SCHEMA_NAME();
DECLARE @description AS sql_variant;
SET @description = N'Status maximo da vida';
EXEC sp_addextendedproperty 'MS_Description', @description, 'SCHEMA', @defaultSchema, 'TABLE', N'Pokemon', 'COLUMN', N'Max_Vida';
GO

ALTER TABLE [Pokemon] ADD [Min_Ataque] int NOT NULL DEFAULT 0;
DECLARE @defaultSchema AS sysname;
SET @defaultSchema = SCHEMA_NAME();
DECLARE @description AS sql_variant;
SET @description = N'Status base do ataque';
EXEC sp_addextendedproperty 'MS_Description', @description, 'SCHEMA', @defaultSchema, 'TABLE', N'Pokemon', 'COLUMN', N'Min_Ataque';
GO

ALTER TABLE [Pokemon] ADD [Min_Defesa] int NOT NULL DEFAULT 0;
DECLARE @defaultSchema AS sysname;
SET @defaultSchema = SCHEMA_NAME();
DECLARE @description AS sql_variant;
SET @description = N'Status base da defesa';
EXEC sp_addextendedproperty 'MS_Description', @description, 'SCHEMA', @defaultSchema, 'TABLE', N'Pokemon', 'COLUMN', N'Min_Defesa';
GO

ALTER TABLE [Pokemon] ADD [Min_Velocidade] int NOT NULL DEFAULT 0;
DECLARE @defaultSchema AS sysname;
SET @defaultSchema = SCHEMA_NAME();
DECLARE @description AS sql_variant;
SET @description = N'status base da velocidade';
EXEC sp_addextendedproperty 'MS_Description', @description, 'SCHEMA', @defaultSchema, 'TABLE', N'Pokemon', 'COLUMN', N'Min_Velocidade';
GO

ALTER TABLE [Pokemon] ADD [Min_Vida] int NOT NULL DEFAULT 0;
DECLARE @defaultSchema AS sysname;
SET @defaultSchema = SCHEMA_NAME();
DECLARE @description AS sql_variant;
SET @description = N'Status base da vida';
EXEC sp_addextendedproperty 'MS_Description', @description, 'SCHEMA', @defaultSchema, 'TABLE', N'Pokemon', 'COLUMN', N'Min_Vida';
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240119054311_AlteracaoNaModelDePokemon', N'7.0.10');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240119061329_ErroNaModelPokemon', N'7.0.10');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DECLARE @var7 sysname;
SELECT @var7 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Pokemon]') AND [c].[name] = N'Descricao');
IF @var7 IS NOT NULL EXEC(N'ALTER TABLE [Pokemon] DROP CONSTRAINT [' + @var7 + '];');
ALTER TABLE [Pokemon] ALTER COLUMN [Descricao] nvarchar(250) NOT NULL;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240119061708_ConsertandoErroNaTabelaDePokemon', N'7.0.10');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DECLARE @var8 sysname;
SELECT @var8 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Evolucao]') AND [c].[name] = N'Pontos_Ataque');
IF @var8 IS NOT NULL EXEC(N'ALTER TABLE [Evolucao] DROP CONSTRAINT [' + @var8 + '];');
ALTER TABLE [Evolucao] DROP COLUMN [Pontos_Ataque];
GO

DECLARE @var9 sysname;
SELECT @var9 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Evolucao]') AND [c].[name] = N'Pontos_Defesa');
IF @var9 IS NOT NULL EXEC(N'ALTER TABLE [Evolucao] DROP CONSTRAINT [' + @var9 + '];');
ALTER TABLE [Evolucao] DROP COLUMN [Pontos_Defesa];
GO

DECLARE @var10 sysname;
SELECT @var10 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Evolucao]') AND [c].[name] = N'Pontos_Velocidade');
IF @var10 IS NOT NULL EXEC(N'ALTER TABLE [Evolucao] DROP CONSTRAINT [' + @var10 + '];');
ALTER TABLE [Evolucao] DROP COLUMN [Pontos_Velocidade];
GO

EXEC sp_rename N'[Evolucao].[Pontos_Vida]', N'SegundoElemento', N'COLUMN';
GO

ALTER TABLE [Evolucao] ADD [Apanhado] bit NOT NULL DEFAULT CAST(0 AS bit);
GO

ALTER TABLE [Evolucao] ADD [Codigo] nvarchar(max) NOT NULL DEFAULT N'';
GO

ALTER TABLE [Evolucao] ADD [Descricao] nvarchar(250) NOT NULL DEFAULT N'';
GO

ALTER TABLE [Evolucao] ADD [Max_Ataque] int NOT NULL DEFAULT 0;
DECLARE @defaultSchema AS sysname;
SET @defaultSchema = SCHEMA_NAME();
DECLARE @description AS sql_variant;
SET @description = N'Status maximo do ataque';
EXEC sp_addextendedproperty 'MS_Description', @description, 'SCHEMA', @defaultSchema, 'TABLE', N'Evolucao', 'COLUMN', N'Max_Ataque';
GO

ALTER TABLE [Evolucao] ADD [Max_Defesa] int NOT NULL DEFAULT 0;
DECLARE @defaultSchema AS sysname;
SET @defaultSchema = SCHEMA_NAME();
DECLARE @description AS sql_variant;
SET @description = N'Status maximo da defesa';
EXEC sp_addextendedproperty 'MS_Description', @description, 'SCHEMA', @defaultSchema, 'TABLE', N'Evolucao', 'COLUMN', N'Max_Defesa';
GO

ALTER TABLE [Evolucao] ADD [Max_Velocidade] int NOT NULL DEFAULT 0;
DECLARE @defaultSchema AS sysname;
SET @defaultSchema = SCHEMA_NAME();
DECLARE @description AS sql_variant;
SET @description = N'status maximo da velocidade';
EXEC sp_addextendedproperty 'MS_Description', @description, 'SCHEMA', @defaultSchema, 'TABLE', N'Evolucao', 'COLUMN', N'Max_Velocidade';
GO

ALTER TABLE [Evolucao] ADD [Max_Vida] int NOT NULL DEFAULT 0;
DECLARE @defaultSchema AS sysname;
SET @defaultSchema = SCHEMA_NAME();
DECLARE @description AS sql_variant;
SET @description = N'Status maximo da vida';
EXEC sp_addextendedproperty 'MS_Description', @description, 'SCHEMA', @defaultSchema, 'TABLE', N'Evolucao', 'COLUMN', N'Max_Vida';
GO

ALTER TABLE [Evolucao] ADD [Min_Ataque] int NOT NULL DEFAULT 0;
DECLARE @defaultSchema AS sysname;
SET @defaultSchema = SCHEMA_NAME();
DECLARE @description AS sql_variant;
SET @description = N'Status base do ataque';
EXEC sp_addextendedproperty 'MS_Description', @description, 'SCHEMA', @defaultSchema, 'TABLE', N'Evolucao', 'COLUMN', N'Min_Ataque';
GO

ALTER TABLE [Evolucao] ADD [Min_Defesa] int NOT NULL DEFAULT 0;
DECLARE @defaultSchema AS sysname;
SET @defaultSchema = SCHEMA_NAME();
DECLARE @description AS sql_variant;
SET @description = N'Status base da defesa';
EXEC sp_addextendedproperty 'MS_Description', @description, 'SCHEMA', @defaultSchema, 'TABLE', N'Evolucao', 'COLUMN', N'Min_Defesa';
GO

ALTER TABLE [Evolucao] ADD [Min_Velocidade] int NOT NULL DEFAULT 0;
DECLARE @defaultSchema AS sysname;
SET @defaultSchema = SCHEMA_NAME();
DECLARE @description AS sql_variant;
SET @description = N'status base da velocidade';
EXEC sp_addextendedproperty 'MS_Description', @description, 'SCHEMA', @defaultSchema, 'TABLE', N'Evolucao', 'COLUMN', N'Min_Velocidade';
GO

ALTER TABLE [Evolucao] ADD [Min_Vida] int NOT NULL DEFAULT 0;
DECLARE @defaultSchema AS sysname;
SET @defaultSchema = SCHEMA_NAME();
DECLARE @description AS sql_variant;
SET @description = N'Status base da vida';
EXEC sp_addextendedproperty 'MS_Description', @description, 'SCHEMA', @defaultSchema, 'TABLE', N'Evolucao', 'COLUMN', N'Min_Vida';
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240119223502_AlteracaoNaModelDeEvolucao', N'7.0.10');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [Pokemon] ADD [Imagem] nvarchar(max) NOT NULL DEFAULT N'';
GO

ALTER TABLE [Evolucao] ADD [Imagem] nvarchar(max) NOT NULL DEFAULT N'';
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240121000116_AdicionandoImagemPokemon', N'7.0.10');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DECLARE @var11 sysname;
SELECT @var11 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Pokemon]') AND [c].[name] = N'Codigo');
IF @var11 IS NOT NULL EXEC(N'ALTER TABLE [Pokemon] DROP CONSTRAINT [' + @var11 + '];');
ALTER TABLE [Pokemon] ALTER COLUMN [Codigo] int NOT NULL;
GO

DECLARE @var12 sysname;
SELECT @var12 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Evolucao]') AND [c].[name] = N'Codigo');
IF @var12 IS NOT NULL EXEC(N'ALTER TABLE [Evolucao] DROP CONSTRAINT [' + @var12 + '];');
ALTER TABLE [Evolucao] ALTER COLUMN [Codigo] int NOT NULL;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240121061102_AlteracaoCodigoParaInt', N'7.0.10');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240410190408_IntialMigration', N'7.0.10');
GO

COMMIT;
GO

