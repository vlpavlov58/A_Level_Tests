CREATE TABLE [dbo].[Teacher] (
    [Id]       INT IDENTITY (1, 1) NOT NULL,
    [CourseId] INT NULL,
    [UserId]   INT NULL,
    CONSTRAINT [PK_Teacher] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Teacher_Course] FOREIGN KEY ([CourseId]) REFERENCES [dbo].[Course] ([Id]),
    CONSTRAINT [FK_Teacher_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([Id])
);



