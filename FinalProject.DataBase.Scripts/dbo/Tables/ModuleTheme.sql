CREATE TABLE [dbo].[ModuleTheme] (
    [ModuleId] INT NOT NULL,
    [ThemeId]  INT NOT NULL,
    CONSTRAINT [PK_ModuleTheme] PRIMARY KEY CLUSTERED ([ModuleId] ASC, [ThemeId] ASC),
    CONSTRAINT [FK_ModuleTheme_Module] FOREIGN KEY ([ModuleId]) REFERENCES [dbo].[Module] ([Id]),
    CONSTRAINT [FK_ModuleTheme_Theme] FOREIGN KEY ([ThemeId]) REFERENCES [dbo].[Theme] ([Id])
);



