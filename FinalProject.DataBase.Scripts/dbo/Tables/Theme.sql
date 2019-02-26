CREATE TABLE [dbo].[Theme] (
    [Id]   INT            IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Theme] PRIMARY KEY CLUSTERED ([Id] ASC)
);

