CREATE TABLE [dbo].[Question] (
    [Id]       INT            IDENTITY (1, 1) NOT NULL,
    [TypeId]   INT            NULL,
    [ModuleId] INT            NULL,
    [ThemeId]  INT            NULL,
    [Text]     NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Question] PRIMARY KEY CLUSTERED ([Id] ASC)
);

