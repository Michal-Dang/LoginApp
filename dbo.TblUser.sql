CREATE TABLE [dbo].[TblUser] (
    [loginid] INT           NOT NULL IDENTITY,
    [Imię]   NVARCHAR (50) NULL,
    [Nazwisko]   NVARCHAR (50) NULL,
    [Login]   NVARCHAR (50) NULL,
    [Hasło] NVARCHAR(50) NULL, 
    [Email] NVARCHAR(50) NULL, 
    PRIMARY KEY CLUSTERED ([loginid] ASC)
);

