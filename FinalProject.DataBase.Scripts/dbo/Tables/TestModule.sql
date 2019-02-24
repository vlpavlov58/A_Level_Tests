CREATE TABLE [dbo].[TestModule] (
    [ModuleId] INT NOT NULL,
    [TestId]   INT NOT NULL,
    CONSTRAINT [PK_TestModule] PRIMARY KEY CLUSTERED ([ModuleId] ASC, [TestId] ASC),
    CONSTRAINT [FK_TestModule_Module] FOREIGN KEY ([ModuleId]) REFERENCES [dbo].[Module] ([Id]),
    CONSTRAINT [FK_TestModule_Test] FOREIGN KEY ([TestId]) REFERENCES [dbo].[Test] ([Id])
);



