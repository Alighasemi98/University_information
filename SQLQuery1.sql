CREATE TABLE [dbo].[Field] (
    [Id]                      INT           IDENTITY (1, 1) NOT NULL,
    [field_name]              NVARCHAR (50) NOT NULL,
    [String_code]             VARCHAR (15)  NOT NULL,
    [Total_number_of_lessons] INT           NOT NULL,
    [General_number]          INT           NOT NULL,
    [Specialized_number]      INT           NOT NULL,
    [Number_of_students]      INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
