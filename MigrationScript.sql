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

CREATE TABLE [Albums] (
    [AlbumId] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Albums] PRIMARY KEY ([AlbumId])
);
GO

CREATE TABLE [Blogs] (
    [UserId] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    [Password] nvarchar(max) NOT NULL,
    [EmailId] nvarchar(max) NOT NULL,
    [Role] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Blogs] PRIMARY KEY ([UserId])
);
GO

CREATE TABLE [Songs] (
    [SongId] int NOT NULL IDENTITY,
    [Title] nvarchar(max) NOT NULL,
    [AlbumId] int NOT NULL,
    CONSTRAINT [PK_Songs] PRIMARY KEY ([SongId]),
    CONSTRAINT [FK_Songs_Albums_AlbumId] FOREIGN KEY ([AlbumId]) REFERENCES [Albums] ([AlbumId]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_Songs_AlbumId] ON [Songs] ([AlbumId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240518132345_InitialCreate', N'8.0.5');
GO

COMMIT;
GO

