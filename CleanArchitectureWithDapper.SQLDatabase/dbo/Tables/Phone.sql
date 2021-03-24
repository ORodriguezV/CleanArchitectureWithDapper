CREATE TABLE [dbo].[Phone] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [IdPerson] INT           NOT NULL,
    [Number]   NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Phone] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Phone_Person] FOREIGN KEY ([IdPerson]) REFERENCES [dbo].[Person] ([Id])
);

