CREATE TABLE [dbo].[ModuleTheme] (
    [ModuleId] INT NOT NULL,
    [ThemeId]  INT NOT NULL,
    CONSTRAINT [PK_ModuleTheme] PRIMARY KEY CLUSTERED ([ModuleId] ASC, [ThemeId] ASC)
);

