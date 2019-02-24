CREATE TABLE [dbo].[QuestionAnswer] (
    [QuestionId] INT NOT NULL,
    [AnswerId]   INT NOT NULL,
    CONSTRAINT [PK_QuestionAnswer] PRIMARY KEY CLUSTERED ([QuestionId] ASC, [AnswerId] ASC)
);

