CREATE DATABASE Data_QL
GO

USE [Data_QL]
GO

CREATE TABLE [Warehouse](
    [Type_Code] NVARCHAR (50) NOT NULL PRIMARY KEY,
    [Name_Car] NVARCHAR (50) NULL,
	[Price] BIGINT NULL,
    [Remaining] INT NULL    
)
GO


	

CREATE TABLE [Import](
    [ID] NVARCHAR(50) NOT NULL PRIMARY KEY,
    [Name_Car] NVARCHAR(50) NOT NULL,
    [Type_Code] NVARCHAR (50) NOT NULL,
    [Amount] INT NOT NULL,
    [Price] BIGINT NOT NULL,
    [Import_date] DATE
)
GO

CREATE TABLE [Customer](
    [Phone] NVARCHAR (50) NOT NULL PRIMARY KEY,
    [Cus_Name] NVARCHAR (50) NOT NULL,
    [Address] NVARCHAR (100) NOT NULL
)
GO

CREATE TABLE [Export](
    [ID] NVARCHAR (50) NOT NULL PRIMARY KEY,
    [Phone] NVARCHAR (50) NOT NULL,
    [Buy_date] DATE,
    [Total] BIGINT NOT NULL,
    CONSTRAINT fk_PhoneEx FOREIGN KEY(Phone) REFERENCES Customer(Phone)
)
GO

CREATE TABLE [Information](
    [Type_Code] NVARCHAR (50) NOT NULL PRIMARY KEY,
    [Phone] NVARCHAR (50) NOT NULL,
    [Amount] INT NOT NULL,
    CONSTRAINT fk_TypeInfor FOREIGN KEY(Type_Code) REFERENCES Warehouse(Type_Code),
    CONSTRAINT fk_PhoneInfor FOREIGN KEY(Phone) REFERENCES Customer(Phone)
)
GO

CREATE TABLE [Temp_Imp](
	[Name_Car] NVARCHAR (50) NOT NULL PRIMARY KEY,
	[Price] BIGINT NULL
)
GO

CREATE TABLE [Remaining](
	[Type_Code] NVARCHAR (50) NOT NULL PRIMARY KEY,
    [Remaining] INT NULL
)
GO

--INSERT INTO [Warehouse] ([Type_Code], [Model], [Remaining], [Price])
--VALUES ('M3', 'BMW M3', '4', '171400' )
--INSERT INTO [Import] ([ID], [Name_Car], [Type_Code], [Amount], [Price], [Import_date])
--VALUES ('B01', 'BMW M3', 'M3', '2', '171400', '2022-01-01')
--INSERT INTO [Import] ([ID], [Name_Car], [Type_Code], [Amount], [Price], [Import_date])
--VALUES ('B02', 'BMW M3', 'M3', '2', '171400', '2022-01-02')
--INSERT INTO [Import] ([ID], [Name_Car], [Type_Code], [Amount], [Price], [Import_date])
--VALUES ('A01', 'AUDI A8', 'A8', '3', '200000', '2020-01-02')
--INSERT INTO [Import] ([ID], [Name_Car], [Type_Code], [Amount], [Price], [Import_date])
--VALUES ('A02', 'AUDI A8', 'A8', '2', '200000', '2020-04-02')
--GO

--INSERT INTO [Temp_Imp] SELECT Name_Car, Price FROM Import
--GO

--INSERT INTO [Remaining] SELECT Type_Code, SUM (Amount) AS Remaining FROM Import GROUP BY Type_Code
--GO