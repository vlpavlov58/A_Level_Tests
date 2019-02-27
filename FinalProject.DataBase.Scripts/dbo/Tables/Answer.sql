CREATE TABLE [dbo].[Answer] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [QuestionId] INT            NOT NULL,
    [Name]       NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Answer] PRIMARY KEY CLUSTERED ([Id] ASC)
);



