CREATE TABLE [dbo].[Garnish] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [Name]     NVARCHAR (25) NOT NULL,
    [NoodleId] INT           NULL,
    CONSTRAINT [PK_Garnish] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Garnish_Noodle_NoodleId] FOREIGN KEY ([NoodleId]) REFERENCES [dbo].[Noodle] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Garnish_NoodleId]
    ON [dbo].[Garnish]([NoodleId] ASC);

