CREATE TABLE [dbo].[Broth] (
    [Id]      INT           IDENTITY (1, 1) NOT NULL,
    [Name]    NVARCHAR (25) NOT NULL,
    [IsVegan] BIT           NOT NULL,
    CONSTRAINT [PK_Broth] PRIMARY KEY CLUSTERED ([Id] ASC)
);

