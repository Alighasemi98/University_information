CREATE TABLE [dbo].[Class] (
    [Id]                INT IDENTITY (1, 1) NOT NULL,
    [Class_Number]      INT NOT NULL,
    [Number_of_Borards] INT NOT NULL,
    [Number_of_Seats]   INT NOT NULL,
    [Number_of_Tables]  INT NOT NULL,
    [Number_of_Windows] INT NOT NULL,
    [The_Number_of_TVs] INT NOT NULL,
    [Floor]             INT NOT NULL,
    [Air_Conditioner]   INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
