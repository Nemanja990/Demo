USE master
IF EXISTS(select * from sys.databases where name='Demo')
DROP DATABASE Demo

CREATE DATABASE Demo
GO

USE Demo

CREATE TABLE [DemoTable] (
    [Id]          INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    [Name]        NVARCHAR (50)  NOT NULL,
    [Description] NVARCHAR (100) NOT NULL,
    [Category]    NVARCHAR (50)  NOT NULL,
    [Producer]    NVARCHAR (50)  NOT NULL,
    [Supplier]    NVARCHAR (50)  NOT NULL,
    [Price]       SMALLMONEY     NOT NULL
);
GO

INSERT INTO DemoTable ([Name], [Description], [Category], [Producer], [Supplier], [Price])
VALUES
('Top Gun', 'Cone ice cream', 'Sweets', 'Frikom','Frikom', 200),
('Nirvana', 'Ice cream in cup', 'Sweets', 'Delta','Delta', 300),
('Sweet', 'Tasty candy', 'Sweets', 'Soko stark','Soko stark', 30),
('Najlepse zelje', 'Chocolate', 'Sweets', 'Soko stark','Soko stark', 200),
('Bread', 'Basic ingredient', 'Food', 'Homemade','Homemade', 30)