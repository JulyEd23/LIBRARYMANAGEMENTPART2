CREATE TABLE [dbo].[BOOK] (
    [BookID]       INT          IDENTITY (1, 1) NOT NULL,
    [Title]        VARCHAR (50) NOT NULL,
    [Category]     VARCHAR (50) NOT NULL,
    [Availability] VARCHAR (50) NOT NULL,
    [AuthorID]     INT          NOT NULL,
    CONSTRAINT [FK_BOOK_AUTHOR] FOREIGN KEY ([AuthorID]) REFERENCES [dbo].[AUTHOR] ([AuthorID]), 
    CONSTRAINT [PK_BOOK] PRIMARY KEY ([BookID])
);

