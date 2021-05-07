USE QuickCopy
GO

DROP TABLE QuickCopy.Users
GO

DROP SCHEMA QuickCopy
GO

CREATE SCHEMA QuickCopy
GO

CREATE TABLE QuickCopy.Users (
	ID INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	UserName NVARCHAR(32) UNIQUE NOT NULL,
	PasswordHash VARBINARY(32) NOT NULL,
	LoginEnabled BIT NOT NULL DEFAULT(1),
	LastUpdateTime DATETIME,
	LastLoginTime DATETIME,
	[Data] VARBINARY(MAX)
)

/*CREATE TABLE QuickCopy.Categories (
	ID INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	OwnerID INT FOREIGN KEY REFERENCES QuickCopy.Users(ID),
	[Name] VARBINARY(MAX) NOT NULL -- this data will be encrypted

	--CONSTRAINT QuickCopy_Categories_constraint1 UNIQUE(OwnerID, [Name])
)

CREATE TABLE QuickCopy.Items (
	ID INT IDENTITY(1, 1) PRIMARY KEY,
	CategoryID INT FOREIGN KEY REFERENCES QuickCopy.Categories(ID),
	[Name] VARBINARY(MAX) NOT NULL, -- this data will be encrypted
	Content VARBINARY(MAX) NOT NULL -- this data will be encrypted

	--CONSTRAINT QuickCopy_Items_constraint1 UNIQUE(CategoryID, [Name])
)*/
