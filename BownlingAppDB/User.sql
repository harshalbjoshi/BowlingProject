CREATE TABLE [dbo].[User]
(
	[UserId] INT NOT NULL PRIMARY KEY, 
    [FirstName] NCHAR(10) NULL, 
    [LastName] NCHAR(10) NULL, 
    [EmailAddress] NCHAR(50) NULL, 
    [Password] NCHAR(100) NULL
)
