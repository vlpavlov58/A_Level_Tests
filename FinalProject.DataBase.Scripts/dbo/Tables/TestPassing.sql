CREATE TABLE [dbo].[TestPassing] (
    [Id]        INT      IDENTITY (1, 1) NOT NULL,
    [StudentId] INT      NULL,
    [TestId]    INT      NOT NULL,
    [TeacherId] INT      NULL,
    [Date]      DATETIME NULL,
    CONSTRAINT [PK_TestPassing] PRIMARY KEY CLUSTERED ([Id] ASC)
);

