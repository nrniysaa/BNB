CREATE TABLE [dbo].[menu2] (
    [id]       INT           IDENTITY (1, 1) NOT NULL,
    [menuid]   NVARCHAR (50) NOT NULL,
    [owner]    NVARCHAR (50) NOT NULL,
    [quantity] NVARCHAR (50) NOT NULL,
    [price]    NVARCHAR (50) NOT NULL,
    [orderDate] NVARCHAR (50) NOT NULL, 
    [orderTime] NVARCHAR (50) NOT NULL, 
    PRIMARY KEY CLUSTERED ([id] ASC)
);

