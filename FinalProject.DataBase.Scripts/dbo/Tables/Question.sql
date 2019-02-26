CREATE TABLE [dbo].[Question] (
    [Id]       INT            IDENTITY (1, 1) NOT NULL,
    [TypeId]   INT            NULL,
    [ModuleId] INT            NULL,
    [ThemeId]  INT            NULL,
    [Text]     NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Question] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Question_Module] FOREIGN KEY ([ModuleId]) REFERENCES [dbo].[Module] ([Id]),
    CONSTRAINT [FK_Question_QuestionType] FOREIGN KEY ([TypeId]) REFERENCES [dbo].[QuestionType] ([Id]),
    CONSTRAINT [FK_Question_Theme] FOREIGN KEY ([ThemeId]) REFERENCES [dbo].[Theme] ([Id])
);



