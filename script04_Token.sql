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
    [Nome_Habilidade] nvarchar(40) NOT NULL,
    [Descricao] nvarchar(max) NOT NULL,
    [Elemento] int NOT NULL,
    [Power] int NOT NULL,
    [Pontos_Precisao] int NOT NULL,
    [Pontos_Power] int NOT NULL,
    CONSTRAINT [PK_Habilidade] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Item] (
    [Id] int NOT NULL IDENTITY,
    [Nome] nvarchar(20) NOT NULL,
    [Pontos_Vida] int NOT NULL,
    [Pontos_Defesa] int NOT NULL,
    [Pontos_Ataque] int NOT NULL,
    [Descricao] nvarchar(max) NOT NULL,
    [Elemento] int NULL,
    CONSTRAINT [PK_Item] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Pokemon] (
    [Id] int NOT NULL IDENTITY,
    [Nome_Pokemon] nvarchar(20) NOT NULL,
    [Peso_Pokemon] real NOT NULL,
    [Altura_Pokemon] real NOT NULL,
    [Codigo] int NOT NULL,
    [Min_Vida] int NOT NULL,
    [Max_Vida] int NOT NULL,
    [Min_Ataque] int NOT NULL,
    [Max_Ataque] int NOT NULL,
    [Min_Defesa] int NOT NULL,
    [Max_Defesa] int NOT NULL,
    [Min_Velocidade] int NOT NULL,
    [Max_Velocidade] int NOT NULL,
    [Elemento] int NOT NULL,
    [SegundoElemento] int NOT NULL,
    [Apanhado] bit NOT NULL,
    [Descricao] nvarchar(max) NOT NULL,
    [Imagem] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Pokemon] PRIMARY KEY ([Id])
);
DECLARE @defaultSchema AS sysname;
SET @defaultSchema = SCHEMA_NAME();
DECLARE @description AS sql_variant;
SET @description = N'Status base da vida';
EXEC sp_addextendedproperty 'MS_Description', @description, 'SCHEMA', @defaultSchema, 'TABLE', N'Pokemon', 'COLUMN', N'Min_Vida';
SET @description = N'Status maximo da vida';
EXEC sp_addextendedproperty 'MS_Description', @description, 'SCHEMA', @defaultSchema, 'TABLE', N'Pokemon', 'COLUMN', N'Max_Vida';
SET @description = N'Status base do ataque';
EXEC sp_addextendedproperty 'MS_Description', @description, 'SCHEMA', @defaultSchema, 'TABLE', N'Pokemon', 'COLUMN', N'Min_Ataque';
SET @description = N'Status maximo do ataque';
EXEC sp_addextendedproperty 'MS_Description', @description, 'SCHEMA', @defaultSchema, 'TABLE', N'Pokemon', 'COLUMN', N'Max_Ataque';
SET @description = N'Status base da defesa';
EXEC sp_addextendedproperty 'MS_Description', @description, 'SCHEMA', @defaultSchema, 'TABLE', N'Pokemon', 'COLUMN', N'Min_Defesa';
SET @description = N'Status maximo da defesa';
EXEC sp_addextendedproperty 'MS_Description', @description, 'SCHEMA', @defaultSchema, 'TABLE', N'Pokemon', 'COLUMN', N'Max_Defesa';
SET @description = N'status base da velocidade';
EXEC sp_addextendedproperty 'MS_Description', @description, 'SCHEMA', @defaultSchema, 'TABLE', N'Pokemon', 'COLUMN', N'Min_Velocidade';
SET @description = N'status maximo da velocidade';
EXEC sp_addextendedproperty 'MS_Description', @description, 'SCHEMA', @defaultSchema, 'TABLE', N'Pokemon', 'COLUMN', N'Max_Velocidade';
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

CREATE TABLE [Evolucao] (
    [Id] int NOT NULL IDENTITY,
    [IdPokemon] int NOT NULL,
    [Nome_Evolcucao] nvarchar(20) NOT NULL,
    [Peso_Evolucao] real NOT NULL,
    [Altura_Evolucao] real NOT NULL,
    [Codigo] int NOT NULL,
    [Min_Vida] int NOT NULL,
    [Max_Vida] int NOT NULL,
    [Min_Ataque] int NOT NULL,
    [Max_Ataque] int NOT NULL,
    [Min_Defesa] int NOT NULL,
    [Max_Defesa] int NOT NULL,
    [Min_Velocidade] int NOT NULL,
    [Max_Velocidade] int NOT NULL,
    [Elemento] int NOT NULL,
    [SegundoElemento] int NOT NULL,
    [Apanhado] bit NOT NULL,
    [Descricao] nvarchar(max) NOT NULL,
    [Imagem] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Evolucao] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Evolucao_Pokemon_IdPokemon] FOREIGN KEY ([IdPokemon]) REFERENCES [Pokemon] ([Id]) ON DELETE CASCADE
);
DECLARE @defaultSchema AS sysname;
SET @defaultSchema = SCHEMA_NAME();
DECLARE @description AS sql_variant;
SET @description = N'Status base da vida';
EXEC sp_addextendedproperty 'MS_Description', @description, 'SCHEMA', @defaultSchema, 'TABLE', N'Evolucao', 'COLUMN', N'Min_Vida';
SET @description = N'Status maximo da vida';
EXEC sp_addextendedproperty 'MS_Description', @description, 'SCHEMA', @defaultSchema, 'TABLE', N'Evolucao', 'COLUMN', N'Max_Vida';
SET @description = N'Status base do ataque';
EXEC sp_addextendedproperty 'MS_Description', @description, 'SCHEMA', @defaultSchema, 'TABLE', N'Evolucao', 'COLUMN', N'Min_Ataque';
SET @description = N'Status maximo do ataque';
EXEC sp_addextendedproperty 'MS_Description', @description, 'SCHEMA', @defaultSchema, 'TABLE', N'Evolucao', 'COLUMN', N'Max_Ataque';
SET @description = N'Status base da defesa';
EXEC sp_addextendedproperty 'MS_Description', @description, 'SCHEMA', @defaultSchema, 'TABLE', N'Evolucao', 'COLUMN', N'Min_Defesa';
SET @description = N'Status maximo da defesa';
EXEC sp_addextendedproperty 'MS_Description', @description, 'SCHEMA', @defaultSchema, 'TABLE', N'Evolucao', 'COLUMN', N'Max_Defesa';
SET @description = N'status base da velocidade';
EXEC sp_addextendedproperty 'MS_Description', @description, 'SCHEMA', @defaultSchema, 'TABLE', N'Evolucao', 'COLUMN', N'Min_Velocidade';
SET @description = N'status maximo da velocidade';
EXEC sp_addextendedproperty 'MS_Description', @description, 'SCHEMA', @defaultSchema, 'TABLE', N'Evolucao', 'COLUMN', N'Max_Velocidade';
GO

CREATE TABLE [PokemonHabilidade] (
    [IdHabilidade] int NOT NULL,
    [IdPokemon] int NOT NULL,
    CONSTRAINT [PK_PokemonHabilidade] PRIMARY KEY ([IdHabilidade], [IdPokemon]),
    CONSTRAINT [FK_PokemonHabilidade_Habilidade_IdHabilidade] FOREIGN KEY ([IdHabilidade]) REFERENCES [Habilidade] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_PokemonHabilidade_Pokemon_IdPokemon] FOREIGN KEY ([IdPokemon]) REFERENCES [Pokemon] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [ItemTreinador] (
    [IdItem] int NOT NULL,
    [IdTreinador] int NOT NULL,
    CONSTRAINT [PK_ItemTreinador] PRIMARY KEY ([IdItem], [IdTreinador]),
    CONSTRAINT [FK_ItemTreinador_Item_IdItem] FOREIGN KEY ([IdItem]) REFERENCES [Item] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_ItemTreinador_Treinador_IdTreinador] FOREIGN KEY ([IdTreinador]) REFERENCES [Treinador] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [PokemonTreinador] (
    [IdPokemon] int NOT NULL,
    [IdTreinador] int NOT NULL,
    CONSTRAINT [PK_PokemonTreinador] PRIMARY KEY ([IdTreinador], [IdPokemon]),
    CONSTRAINT [FK_PokemonTreinador_Pokemon_IdPokemon] FOREIGN KEY ([IdPokemon]) REFERENCES [Pokemon] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_PokemonTreinador_Treinador_IdTreinador] FOREIGN KEY ([IdTreinador]) REFERENCES [Treinador] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [EvolucaoHabilidade] (
    [IdHabilidade] int NOT NULL,
    [IdEvolucao] int NOT NULL,
    CONSTRAINT [PK_EvolucaoHabilidade] PRIMARY KEY ([IdHabilidade], [IdEvolucao]),
    CONSTRAINT [FK_EvolucaoHabilidade_Evolucao_IdEvolucao] FOREIGN KEY ([IdEvolucao]) REFERENCES [Evolucao] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_EvolucaoHabilidade_Habilidade_IdHabilidade] FOREIGN KEY ([IdHabilidade]) REFERENCES [Habilidade] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [EvolucaoTreinador] (
    [IdEvolucao] int NOT NULL,
    [IdTreinador] int NOT NULL,
    CONSTRAINT [PK_EvolucaoTreinador] PRIMARY KEY ([IdEvolucao], [IdTreinador]),
    CONSTRAINT [FK_EvolucaoTreinador_Evolucao_IdEvolucao] FOREIGN KEY ([IdEvolucao]) REFERENCES [Evolucao] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_EvolucaoTreinador_Treinador_IdTreinador] FOREIGN KEY ([IdTreinador]) REFERENCES [Treinador] ([Id]) ON DELETE CASCADE
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Descricao', N'Elemento', N'Nome_Habilidade', N'Power', N'Pontos_Power', N'Pontos_Precisao') AND [object_id] = OBJECT_ID(N'[Habilidade]'))
    SET IDENTITY_INSERT [Habilidade] ON;
INSERT INTO [Habilidade] ([Id], [Descricao], [Elemento], [Nome_Habilidade], [Power], [Pontos_Power], [Pontos_Precisao])
VALUES (1, N'A physical attack in which the user charges and slams into the foe with its whole body.', 1, N'Tackle', 40, 35, 100),
(2, N'The foe is struck with slender, whiplike vines to inflict damage.', 4, N'Vine Whip', 45, 25, 100),
(3, N'A sharp-edged leaf is launched to slash at the foe. It has a high critical-hit ratio.', 4, N'Razor Leaf', 55, 25, 95),
(4, N'Hard, pointed, and sharp claws rake the foe to inflict damage.', 1, N'Scratch', 40, 35, 100),
(5, N'The target is attacked with small flames. It may also leave the target with a burn.', 2, N'Ember', 40, 25, 100),
(6, N'The user bites with flame-cloaked fangs. This may also make the target flinch or leave it with a burn.', 2, N'Fire Fang', 65, 15, 95),
(7, N'Sharp, huge claws hook and slash the foe quickly and with great power.', 16, N'Dragon Claw', 80, 15, 100),
(8, N'The foe is struck with a lot of water expelled forcibly from the mouth.', 3, N'Water Gun', 40, 25, 100),
(9, N'The user attacks the foe with a pulsing blast of water. It may also confuse the foe.', 3, N'Water Pulse', 60, 20, 100);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Descricao', N'Elemento', N'Nome_Habilidade', N'Power', N'Pontos_Power', N'Pontos_Precisao') AND [object_id] = OBJECT_ID(N'[Habilidade]'))
    SET IDENTITY_INSERT [Habilidade] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Descricao', N'Elemento', N'Nome', N'Pontos_Ataque', N'Pontos_Defesa', N'Pontos_Vida') AND [object_id] = OBJECT_ID(N'[Item]'))
    SET IDENTITY_INSERT [Item] ON;
INSERT INTO [Item] ([Id], [Descricao], [Elemento], [Nome], [Pontos_Ataque], [Pontos_Defesa], [Pontos_Vida])
VALUES (1, N'Restaura 20 pontos de vida', NULL, N'Potion', 0, 0, 20);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Descricao', N'Elemento', N'Nome', N'Pontos_Ataque', N'Pontos_Defesa', N'Pontos_Vida') AND [object_id] = OBJECT_ID(N'[Item]'))
    SET IDENTITY_INSERT [Item] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Altura_Pokemon', N'Apanhado', N'Codigo', N'Descricao', N'Elemento', N'Imagem', N'Max_Ataque', N'Max_Defesa', N'Max_Velocidade', N'Max_Vida', N'Min_Ataque', N'Min_Defesa', N'Min_Velocidade', N'Min_Vida', N'Nome_Pokemon', N'Peso_Pokemon', N'SegundoElemento') AND [object_id] = OBJECT_ID(N'[Pokemon]'))
    SET IDENTITY_INSERT [Pokemon] ON;
INSERT INTO [Pokemon] ([Id], [Altura_Pokemon], [Apanhado], [Codigo], [Descricao], [Elemento], [Imagem], [Max_Ataque], [Max_Defesa], [Max_Velocidade], [Max_Vida], [Min_Ataque], [Min_Defesa], [Min_Velocidade], [Min_Vida], [Nome_Pokemon], [Peso_Pokemon], [SegundoElemento])
VALUES (1, CAST(0.7 AS real), CAST(0 AS bit), 1, N'Bulbasaur is a small, mainly turquoise amphibian Pokémon with red eyes and a green bulb on its back. It is based on a frog/toad, with the bulb resembling a plant bulb that grows into a flower as it evolves.', 4, N'https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/001.png', 216, 216, 207, 290, 49, 49, 45, 45, N'Bulbasaur', CAST(6.9 AS real), 7),
(2, CAST(0.6 AS real), CAST(0 AS bit), 4, N'Charmander is a bipedal, reptilian Pokémon. Most of its body is colored orange, while its underbelly is light yellow and it has blue eyes. It has a flame at the end of its tail, which is said to signify its health.', 2, N'https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/004.png', 223, 203, 251, 282, 52, 43, 65, 39, N'Charmander', CAST(8.5 AS real), 0),
(3, CAST(0.5 AS real), CAST(0 AS bit), 7, N'Charmander is a bipedal, reptilian Pokémon. Most of its body is colored orange, while its underbelly is light yellow and it has blue eyes. It has a flame at the end of its tail, which is said to signify its health.', 3, N'https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/007.png', 214, 251, 203, 292, 48, 65, 43, 44, N'Squirtle', CAST(9 AS real), 0);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Altura_Pokemon', N'Apanhado', N'Codigo', N'Descricao', N'Elemento', N'Imagem', N'Max_Ataque', N'Max_Defesa', N'Max_Velocidade', N'Max_Vida', N'Min_Ataque', N'Min_Defesa', N'Min_Velocidade', N'Min_Vida', N'Nome_Pokemon', N'Peso_Pokemon', N'SegundoElemento') AND [object_id] = OBJECT_ID(N'[Pokemon]'))
    SET IDENTITY_INSERT [Pokemon] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Data_Nascimento', N'Login', N'Primeiro_Nome', N'Segundo_Nome', N'Senha') AND [object_id] = OBJECT_ID(N'[Treinador]'))
    SET IDENTITY_INSERT [Treinador] ON;
INSERT INTO [Treinador] ([Id], [Data_Nascimento], [Login], [Primeiro_Nome], [Segundo_Nome], [Senha])
VALUES (1, '2006-01-27T00:00:00.0000000', N'Rafael', N'Rafael', N'Tomaz', N'senha'),
(2, '1977-06-08T00:00:00.0000000', N'Ye', N'Kayne', N'West', N'senha'),
(3, '2014-09-12T00:00:00.0000000', N'SharkBoy', N'Shark', N'Boy', N'senha'),
(4, '2014-04-02T00:00:00.0000000', N'LavaGirl', N'Lava', N'Girl', N'senha');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Data_Nascimento', N'Login', N'Primeiro_Nome', N'Segundo_Nome', N'Senha') AND [object_id] = OBJECT_ID(N'[Treinador]'))
    SET IDENTITY_INSERT [Treinador] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Altura_Evolucao', N'Apanhado', N'Codigo', N'Descricao', N'Elemento', N'IdPokemon', N'Imagem', N'Max_Ataque', N'Max_Defesa', N'Max_Velocidade', N'Max_Vida', N'Min_Ataque', N'Min_Defesa', N'Min_Velocidade', N'Min_Vida', N'Nome_Evolcucao', N'Peso_Evolucao', N'SegundoElemento') AND [object_id] = OBJECT_ID(N'[Evolucao]'))
    SET IDENTITY_INSERT [Evolucao] ON;
INSERT INTO [Evolucao] ([Id], [Altura_Evolucao], [Apanhado], [Codigo], [Descricao], [Elemento], [IdPokemon], [Imagem], [Max_Ataque], [Max_Defesa], [Max_Velocidade], [Max_Vida], [Min_Ataque], [Min_Defesa], [Min_Velocidade], [Min_Vida], [Nome_Evolcucao], [Peso_Evolucao], [SegundoElemento])
VALUES (1, CAST(1 AS real), CAST(0 AS bit), 2, N'Ivysaur''s appearance is very similar to that of its pre-evolved form, Bulbasaur. It still retains the turquoise skin and spots, along with its red eyes.', 4, 1, N'https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/002.png', 245, 247, 240, 324, 62, 63, 60, 60, N'Ivysaur', CAST(13 AS real), 7),
(2, CAST(2 AS real), CAST(0 AS bit), 3, N'Venusaur is a large, quadrupedal Pokémon with a turquoise body. It has small red eyes and several large ferns on its back and head. The plant bulb that was on the back of its previous evolutions, Bulbasaur and Ivysaur, has now bloomed into a large flower with large pink petals and a yellow center. The female has a seed in the center.', 4, 1, N'https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/003.png', 289, 291, 284, 364, 82, 83, 80, 80, N'Venusaur', CAST(100 AS real), 7),
(3, CAST(1.1 AS real), CAST(0 AS bit), 5, N'When it swings its burning tail, the temperature around it rises higher and higher, tormenting its opponents.', 2, 2, N'https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/005.png', 249, 236, 284, 320, 64, 58, 80, 58, N'Charmeleon', CAST(19 AS real), 0),
(4, CAST(1.7 AS real), CAST(0 AS bit), 6, N'Charizard is a large dragon-like Pokémon, mainly orange in color. It has two large wings, the underside of which are turquoise. Like Charmander and Charmeleon, it has a flame at the end of its tail.', 2, 2, N'https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/006.png', 293, 280, 328, 360, 84, 78, 100, 78, N'Charizard', CAST(90.5 AS real), 5),
(5, CAST(1 AS real), CAST(0 AS bit), 8, N'Wartortle is a small, bipedal, turtle-like Pokémon with a similar appearance to that of its pre-evolved form, Squirtle. Some differences are that Wartortle have developed sharper and larger claws and teeth, and that their tails are larger and fluffier than those of Squirtle''s.', 3, 3, N'https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/008.png', 247, 284, 236, 322, 63, 80, 58, 59, N'Wartortle', CAST(22.5 AS real), 0),
(6, CAST(1.6 AS real), CAST(0 AS bit), 9, N'Blastoise is a large, bipedal, reptilian Pokémon. It has a blue body with small purple eyes, a light brown belly, and a stubby tail. It has a large brown shell with two powerful water cannons on either side, which can be withdrawn.', 3, 3, N'https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/009.png', 291, 328, 280, 362, 83, 100, 78, 79, N'Blastoise', CAST(85.5 AS real), 0);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Altura_Evolucao', N'Apanhado', N'Codigo', N'Descricao', N'Elemento', N'IdPokemon', N'Imagem', N'Max_Ataque', N'Max_Defesa', N'Max_Velocidade', N'Max_Vida', N'Min_Ataque', N'Min_Defesa', N'Min_Velocidade', N'Min_Vida', N'Nome_Evolcucao', N'Peso_Evolucao', N'SegundoElemento') AND [object_id] = OBJECT_ID(N'[Evolucao]'))
    SET IDENTITY_INSERT [Evolucao] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'IdItem', N'IdTreinador') AND [object_id] = OBJECT_ID(N'[ItemTreinador]'))
    SET IDENTITY_INSERT [ItemTreinador] ON;
INSERT INTO [ItemTreinador] ([IdItem], [IdTreinador])
VALUES (1, 1),
(1, 2),
(1, 3),
(1, 4);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'IdItem', N'IdTreinador') AND [object_id] = OBJECT_ID(N'[ItemTreinador]'))
    SET IDENTITY_INSERT [ItemTreinador] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'IdHabilidade', N'IdPokemon') AND [object_id] = OBJECT_ID(N'[PokemonHabilidade]'))
    SET IDENTITY_INSERT [PokemonHabilidade] ON;
INSERT INTO [PokemonHabilidade] ([IdHabilidade], [IdPokemon])
VALUES (1, 1),
(1, 3),
(2, 1),
(4, 2),
(5, 2),
(8, 3);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'IdHabilidade', N'IdPokemon') AND [object_id] = OBJECT_ID(N'[PokemonHabilidade]'))
    SET IDENTITY_INSERT [PokemonHabilidade] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'IdPokemon', N'IdTreinador') AND [object_id] = OBJECT_ID(N'[PokemonTreinador]'))
    SET IDENTITY_INSERT [PokemonTreinador] ON;
INSERT INTO [PokemonTreinador] ([IdPokemon], [IdTreinador])
VALUES (2, 1),
(1, 2),
(3, 3),
(2, 4);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'IdPokemon', N'IdTreinador') AND [object_id] = OBJECT_ID(N'[PokemonTreinador]'))
    SET IDENTITY_INSERT [PokemonTreinador] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'IdEvolucao', N'IdHabilidade') AND [object_id] = OBJECT_ID(N'[EvolucaoHabilidade]'))
    SET IDENTITY_INSERT [EvolucaoHabilidade] ON;
INSERT INTO [EvolucaoHabilidade] ([IdEvolucao], [IdHabilidade])
VALUES (1, 1),
(5, 1),
(1, 2),
(2, 2),
(2, 3),
(3, 4),
(3, 6),
(4, 6),
(4, 7),
(6, 8),
(5, 9),
(6, 9);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'IdEvolucao', N'IdHabilidade') AND [object_id] = OBJECT_ID(N'[EvolucaoHabilidade]'))
    SET IDENTITY_INSERT [EvolucaoHabilidade] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'IdEvolucao', N'IdTreinador') AND [object_id] = OBJECT_ID(N'[EvolucaoTreinador]'))
    SET IDENTITY_INSERT [EvolucaoTreinador] ON;
INSERT INTO [EvolucaoTreinador] ([IdEvolucao], [IdTreinador])
VALUES (1, 2),
(3, 1),
(3, 4),
(4, 1),
(5, 3);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'IdEvolucao', N'IdTreinador') AND [object_id] = OBJECT_ID(N'[EvolucaoTreinador]'))
    SET IDENTITY_INSERT [EvolucaoTreinador] OFF;
GO

CREATE INDEX [IX_Evolucao_IdPokemon] ON [Evolucao] ([IdPokemon]);
GO

CREATE INDEX [IX_EvolucaoHabilidade_IdEvolucao] ON [EvolucaoHabilidade] ([IdEvolucao]);
GO

CREATE INDEX [IX_EvolucaoTreinador_IdTreinador] ON [EvolucaoTreinador] ([IdTreinador]);
GO

CREATE INDEX [IX_ItemTreinador_IdTreinador] ON [ItemTreinador] ([IdTreinador]);
GO

CREATE INDEX [IX_PokemonHabilidade_IdPokemon] ON [PokemonHabilidade] ([IdPokemon]);
GO

CREATE INDEX [IX_PokemonTreinador_IdPokemon] ON [PokemonTreinador] ([IdPokemon]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240802181808_AdionandoAtenticacaoPorToken', N'7.0.10');
GO

COMMIT;
GO

