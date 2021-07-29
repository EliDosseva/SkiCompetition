CREATE TABLE [dbo].[StartList] (
    [ID]        INT          NOT NULL IDENTITY,
    [FirstName] VARCHAR (50) NOT NULL,
    [LastName]  VARCHAR (50) NOT NULL,
    [Sex]       VARCHAR (20) NOT NULL,
    [Team]      VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_StartList] PRIMARY KEY CLUSTERED ([ID] ASC)
);

