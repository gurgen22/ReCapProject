DROP TABLE CUSTOMERS;
DROP TABLE USERS;
CREATE TABLE [dbo].[Users] (
    [Id]        INT        IDENTITY (1, 1) NOT NULL,
    [FirstName] NVARCHAR(50) NOT NULL,
    [LastName]  NVARCHAR(50) NOT NULL,
    [Email]     NVARCHAR(75) NOT NULL,
    [PasswordHash] VARBINARY(250) NOT NULL, 
    [PasswordSalt] VARBINARY(250) NOT NULL, 
    [Status] BIT NOT NULL, 
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([Id] ASC)
);
CREATE TABLE [dbo].[Customers] (
    [Id]          INT        NOT NULL,
    [UserId]      INT        NOT NULL,
    [CompanyName] NCHAR (50) NOT NULL,
    CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED ([Id] ASC),
   
);


