CREATE TABLE [dbo].[CourseTeacher] (
    [TeacherId] INT NOT NULL,
    [CourseId]  INT NOT NULL,
    CONSTRAINT [PK_CourseTeacher] PRIMARY KEY CLUSTERED ([TeacherId] ASC, [CourseId] ASC)
);



