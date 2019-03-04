CREATE TABLE [dbo].[TeacherGroup] (
    [TeacherId] INT NOT NULL,
    [GroupId]   INT NOT NULL,
    CONSTRAINT [PK_TeacherGroup] PRIMARY KEY CLUSTERED ([TeacherId] ASC, [GroupId] ASC)
);



