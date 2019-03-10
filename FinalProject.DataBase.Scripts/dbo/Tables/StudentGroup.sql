CREATE TABLE [dbo].[StudentGroup] (
    [StudnetId] INT NOT NULL,
    [GroupId]   INT NOT NULL,
    CONSTRAINT [PK_StudentGroup] PRIMARY KEY CLUSTERED ([StudnetId] ASC, [GroupId] ASC),
    CONSTRAINT [FK_StudentGroup_Group] FOREIGN KEY ([GroupId]) REFERENCES [dbo].[Group] ([Id]),
    CONSTRAINT [FK_StudentGroup_Student] FOREIGN KEY ([StudnetId]) REFERENCES [dbo].[Student] ([Id])
);





