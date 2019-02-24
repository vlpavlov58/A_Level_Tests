CREATE TABLE [dbo].[TestModule] (
    [ModuleId] INT NOT NULL,
    [TestId]   INT NOT NULL,
    CONSTRAINT [PK_TestModule] PRIMARY KEY CLUSTERED ([ModuleId] ASC, [TestId] ASC)
);

