CREATE TABLE [dbo].[Person] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [Firstname] NVARCHAR (50) NOT NULL,
    [Lastname]  NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED ([Id] ASC)
);

