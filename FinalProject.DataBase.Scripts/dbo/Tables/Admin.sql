CREATE TABLE [dbo].[Admin] (
    [Id]     INT NOT NULL,
    [UserId] INT NULL,
    CONSTRAINT [PK_Admin] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Admin_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([Id])
);

