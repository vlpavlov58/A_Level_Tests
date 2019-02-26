CREATE TABLE [dbo].[Student] (
    [Id]      INT IDENTITY (1, 1) NOT NULL,
    [GroupId] INT NULL,
    [UserId]  INT NULL,
    CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Student_Group] FOREIGN KEY ([GroupId]) REFERENCES [dbo].[Group] ([Id]),
    CONSTRAINT [FK_Student_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([Id])
);



