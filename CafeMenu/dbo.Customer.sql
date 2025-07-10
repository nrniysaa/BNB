CREATE TABLE [dbo].[Customer] (
    [UserId]    INT        IDENTITY (1, 1) NOT NULL,
    [Name]      NVARCHAR(50) NOT NULL,
    [Phone]     NVARCHAR(50) NOT NULL,
    [orderType] NVARCHAR(50) NOT NULL,
    PRIMARY KEY CLUSTERED ([UserId] ASC)
);

