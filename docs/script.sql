-- Este script foi gerado através do mapeamento das Migrations do Entity Framework Core. A aplicação por padrão já sobe todas as alterações necessárias, logo esse script não é necessário

IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

CREATE TABLE [ChartOfAccounts] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    [Type] nvarchar(1) NOT NULL,
    CONSTRAINT [PK_ChartOfAccounts] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Transactions] (
    [Id] int NOT NULL IDENTITY,
    [History] nvarchar(max) NULL,
    [Date] datetime2 NULL,
    [Amount] float NULL,
    [ChartOfAccountId] int NOT NULL,
    CONSTRAINT [PK_Transactions] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Transactions_ChartOfAccounts_ChartOfAccountId] FOREIGN KEY ([ChartOfAccountId]) REFERENCES [ChartOfAccounts] ([Id]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_Transactions_ChartOfAccountId] ON [Transactions] ([ChartOfAccountId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20250707214202_AddSqlServerSupport', N'9.0.6');
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Name', N'Type') AND [object_id] = OBJECT_ID(N'[ChartOfAccounts]'))
    SET IDENTITY_INSERT [ChartOfAccounts] ON;
INSERT INTO [ChartOfAccounts] ([Name], [Type])
VALUES (N'Combustível', N'D');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Name', N'Type') AND [object_id] = OBJECT_ID(N'[ChartOfAccounts]'))
    SET IDENTITY_INSERT [ChartOfAccounts] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Name', N'Type') AND [object_id] = OBJECT_ID(N'[ChartOfAccounts]'))
    SET IDENTITY_INSERT [ChartOfAccounts] ON;
INSERT INTO [ChartOfAccounts] ([Name], [Type])
VALUES (N'Alimentação', N'D');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Name', N'Type') AND [object_id] = OBJECT_ID(N'[ChartOfAccounts]'))
    SET IDENTITY_INSERT [ChartOfAccounts] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Name', N'Type') AND [object_id] = OBJECT_ID(N'[ChartOfAccounts]'))
    SET IDENTITY_INSERT [ChartOfAccounts] ON;
INSERT INTO [ChartOfAccounts] ([Name], [Type])
VALUES (N'Saúde', N'D');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Name', N'Type') AND [object_id] = OBJECT_ID(N'[ChartOfAccounts]'))
    SET IDENTITY_INSERT [ChartOfAccounts] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Name', N'Type') AND [object_id] = OBJECT_ID(N'[ChartOfAccounts]'))
    SET IDENTITY_INSERT [ChartOfAccounts] ON;
INSERT INTO [ChartOfAccounts] ([Name], [Type])
VALUES (N'Manutenção Carro', N'D');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Name', N'Type') AND [object_id] = OBJECT_ID(N'[ChartOfAccounts]'))
    SET IDENTITY_INSERT [ChartOfAccounts] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Name', N'Type') AND [object_id] = OBJECT_ID(N'[ChartOfAccounts]'))
    SET IDENTITY_INSERT [ChartOfAccounts] ON;
INSERT INTO [ChartOfAccounts] ([Name], [Type])
VALUES (N'Viagens', N'D');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Name', N'Type') AND [object_id] = OBJECT_ID(N'[ChartOfAccounts]'))
    SET IDENTITY_INSERT [ChartOfAccounts] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Name', N'Type') AND [object_id] = OBJECT_ID(N'[ChartOfAccounts]'))
    SET IDENTITY_INSERT [ChartOfAccounts] ON;
INSERT INTO [ChartOfAccounts] ([Name], [Type])
VALUES (N'Salário', N'R');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Name', N'Type') AND [object_id] = OBJECT_ID(N'[ChartOfAccounts]'))
    SET IDENTITY_INSERT [ChartOfAccounts] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Name', N'Type') AND [object_id] = OBJECT_ID(N'[ChartOfAccounts]'))
    SET IDENTITY_INSERT [ChartOfAccounts] ON;
INSERT INTO [ChartOfAccounts] ([Name], [Type])
VALUES (N'Juros Recebidos', N'R');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Name', N'Type') AND [object_id] = OBJECT_ID(N'[ChartOfAccounts]'))
    SET IDENTITY_INSERT [ChartOfAccounts] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Name', N'Type') AND [object_id] = OBJECT_ID(N'[ChartOfAccounts]'))
    SET IDENTITY_INSERT [ChartOfAccounts] ON;
INSERT INTO [ChartOfAccounts] ([Name], [Type])
VALUES (N'Créditos de Dividendos', N'R');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Name', N'Type') AND [object_id] = OBJECT_ID(N'[ChartOfAccounts]'))
    SET IDENTITY_INSERT [ChartOfAccounts] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Name', N'Type') AND [object_id] = OBJECT_ID(N'[ChartOfAccounts]'))
    SET IDENTITY_INSERT [ChartOfAccounts] ON;
INSERT INTO [ChartOfAccounts] ([Name], [Type])
VALUES (N'Restituição de IR', N'R');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Name', N'Type') AND [object_id] = OBJECT_ID(N'[ChartOfAccounts]'))
    SET IDENTITY_INSERT [ChartOfAccounts] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'History', N'Date', N'Amount', N'ChartOfAccountId') AND [object_id] = OBJECT_ID(N'[Transactions]'))
    SET IDENTITY_INSERT [Transactions] ON;
INSERT INTO [Transactions] ([History], [Date], [Amount], [ChartOfAccountId])
VALUES (N'Combustível Blazer', '2025-07-07T22:20:16.0784871-03:00', 489.0E0, 1);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'History', N'Date', N'Amount', N'ChartOfAccountId') AND [object_id] = OBJECT_ID(N'[Transactions]'))
    SET IDENTITY_INSERT [Transactions] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'History', N'Date', N'Amount', N'ChartOfAccountId') AND [object_id] = OBJECT_ID(N'[Transactions]'))
    SET IDENTITY_INSERT [Transactions] ON;
INSERT INTO [Transactions] ([History], [Date], [Amount], [ChartOfAccountId])
VALUES (N'Almoço de Domingo', '2025-05-18 12:00', 150.0E0, 2);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'History', N'Date', N'Amount', N'ChartOfAccountId') AND [object_id] = OBJECT_ID(N'[Transactions]'))
    SET IDENTITY_INSERT [Transactions] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'History', N'Date', N'Amount', N'ChartOfAccountId') AND [object_id] = OBJECT_ID(N'[Transactions]'))
    SET IDENTITY_INSERT [Transactions] ON;
INSERT INTO [Transactions] ([History], [Date], [Amount], [ChartOfAccountId])
VALUES (N'Peças da Blazer', '2025-05-10 03:00', 18000.0E0, 4);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'History', N'Date', N'Amount', N'ChartOfAccountId') AND [object_id] = OBJECT_ID(N'[Transactions]'))
    SET IDENTITY_INSERT [Transactions] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'History', N'Date', N'Amount', N'ChartOfAccountId') AND [object_id] = OBJECT_ID(N'[Transactions]'))
    SET IDENTITY_INSERT [Transactions] ON;
INSERT INTO [Transactions] ([History], [Date], [Amount], [ChartOfAccountId])
VALUES (N'Salário', '2025-05-12 10:00', 10000.0E0, 6);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'History', N'Date', N'Amount', N'ChartOfAccountId') AND [object_id] = OBJECT_ID(N'[Transactions]'))
    SET IDENTITY_INSERT [Transactions] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'History', N'Date', N'Amount', N'ChartOfAccountId') AND [object_id] = OBJECT_ID(N'[Transactions]'))
    SET IDENTITY_INSERT [Transactions] ON;
INSERT INTO [Transactions] ([History], [Date], [Amount], [ChartOfAccountId])
VALUES (N'ITAUSA', '2025-05-14 10:00', 678.0E0, 8);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'History', N'Date', N'Amount', N'ChartOfAccountId') AND [object_id] = OBJECT_ID(N'[Transactions]'))
    SET IDENTITY_INSERT [Transactions] OFF;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20250707214216_PopulateSqlServerDatabase', N'9.0.6');
GO

