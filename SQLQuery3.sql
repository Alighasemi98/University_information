CREATE TABLE [dbo].[user_password] (
    [Id]            INT          IDENTITY (1, 1) NOT NULL,
    [Name]          VARCHAR (50) NOT NULL,
    [Password]      VARCHAR (20) NOT NULL,
    [National_Code] VARCHAR (20) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
