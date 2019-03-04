CREATE TABLE [dbo].[QuestionType] (
    [Id]   INT            IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_QuestionType] PRIMARY KEY CLUSTERED ([Id] ASC)
);



