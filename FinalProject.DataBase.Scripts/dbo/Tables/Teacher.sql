CREATE TABLE [dbo].[Teacher] (
    [Id]       INT IDENTITY (1, 1) NOT NULL,
    [CourseId] INT NULL,
    [UserId]   INT NULL,
    CONSTRAINT [PK_Teacher] PRIMARY KEY CLUSTERED ([Id] ASC)
);

