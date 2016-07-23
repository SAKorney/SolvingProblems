/* Вставляет группу записей из первой таблицы во вторую */  

USE [Customers]
GO

INSERT INTO [dbo].[BookReserv]
           ([Name])
	SELECT [Name]
	FROM [Book]
GO


