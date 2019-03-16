CREATE TABLE [dbo].[User] (
    [Id]         INT        NOT NULL,
    [FirstName]  NCHAR (10) NULL,
    [LastName]   NCHAR (10) NULL,
    [Login]      NCHAR (10) NULL,
    [Password]   NCHAR (10) NULL,
    [UserTypeId] INT        NOT NULL,
    CONSTRAINT [PK_User1] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_User_UserType] FOREIGN KEY ([UserTypeId]) REFERENCES [dbo].[UserType] ([Id])
);

