CREATE TABLE [dbo].[Competitors] (
    [ID]        INT          IDENTITY (1, 1) NOT NULL,
    [FirstName] VARCHAR (50) NOT NULL,
    [LastName]  VARCHAR (50) NOT NULL,
    [Sex]       VARCHAR (20) NOT NULL,
    [TeamID]    INT          NOT NULL,
    CONSTRAINT [PK_StartList] PRIMARY KEY CLUSTERED ([ID] ASC), 
    CONSTRAINT [FK_Competitors_ToTeamTable] FOREIGN KEY ([TeamID]) REFERENCES [TeamTable]([ID])
);

