CREATE TABLE [dbo].[QuestionAnswer] (
    [QuestionId] INT NOT NULL,
    [AnswerId]   INT NOT NULL,
    CONSTRAINT [PK_QuestionAnswer] PRIMARY KEY CLUSTERED ([QuestionId] ASC, [AnswerId] ASC),
    CONSTRAINT [FK_QuestionAnswer_Answer] FOREIGN KEY ([AnswerId]) REFERENCES [dbo].[Answer] ([Id]),
    CONSTRAINT [FK_QuestionAnswer_Question] FOREIGN KEY ([QuestionId]) REFERENCES [dbo].[Question] ([Id])
);



