CREATE TABLE [dbo].[Student] (
    [Id]      INT IDENTITY (1, 1) NOT NULL,
    [GroupId] INT NULL,
    [UserId]  INT NULL,
    CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED ([Id] ASC)
);

