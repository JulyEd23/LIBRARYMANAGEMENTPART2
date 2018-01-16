﻿CREATE TABLE [dbo].[AUTHOR] (
    [FirstName] VARCHAR (50) NOT NULL,
    [ID]   INT          IDENTITY (1, 1) NOT NULL,
    [LastName] VARCHAR(50) NOT NULL, 
    CONSTRAINT [PK_AUTHOR] PRIMARY KEY CLUSTERED ([ID] ASC)
);
