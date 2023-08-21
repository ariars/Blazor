CREATE TABLE [dbo].[Noodle] (
    [Id]      INT           IDENTITY (1, 1) NOT NULL,
    [Name]    NVARCHAR (25) NOT NULL,
    [BrothId] INT           NOT NULL,
    CONSTRAINT [PK_Noodle] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Noodle_Broth_BrothId] FOREIGN KEY ([BrothId]) REFERENCES [dbo].[Broth] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_Noodle_BrothId]
    ON [dbo].[Noodle]([BrothId] ASC);

