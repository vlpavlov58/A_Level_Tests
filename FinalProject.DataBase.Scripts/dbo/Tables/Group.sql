CREATE TABLE [dbo].[Group] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [CourseId]   INT            NULL,
    [TeacherId]  INT            NULL,
    [Name]       NVARCHAR (MAX) NULL,
    [BegingDate] DATETIME       NULL,
    CONSTRAINT [PK_Group] PRIMARY KEY CLUSTERED ([Id] ASC)
);

