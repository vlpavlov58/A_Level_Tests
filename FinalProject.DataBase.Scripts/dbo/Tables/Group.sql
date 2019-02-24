CREATE TABLE [dbo].[Group] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [CourseId]   INT            NULL,
    [TeacherId]  INT            NULL,
    [Name]       NVARCHAR (MAX) NULL,
    [BegingDate] DATETIME       NULL,
    CONSTRAINT [PK_Group] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Group_Course] FOREIGN KEY ([CourseId]) REFERENCES [dbo].[Course] ([Id]),
    CONSTRAINT [FK_Group_Teacher] FOREIGN KEY ([TeacherId]) REFERENCES [dbo].[Teacher] ([Id])
);



