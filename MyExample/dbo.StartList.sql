CREATE TABLE [dbo].[StartList] (
    [ID]        INT          CONSTRAINT [DF_StartList_ID] DEFAULT ((1)) NOT NULL,
    [FirstName] VARCHAR (50) NOT NULL,
    [Sex]       VARCHAR (20) NOT NULL,
    [Team]      VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_StartList] PRIMARY KEY CLUSTERED ([ID] ASC)
);

