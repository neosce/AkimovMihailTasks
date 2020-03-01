CREATE TABLE [dbo].[UserAndAward] (
    [IdUser]  INT NOT NULL,
    [IdAward] INT NOT NULL,
    CONSTRAINT [FK_UserAndAward_User] FOREIGN KEY ([IdUser]) REFERENCES [dbo].[User] ([Id]),
    CONSTRAINT [FK_UserAndAward_Award] FOREIGN KEY ([IdAward]) REFERENCES [dbo].[Award] ([IdAward])
);