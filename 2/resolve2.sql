/* ��������� ������ ������� �� ������ ������� �� ������ */  

USE [Customers]
GO

INSERT INTO [dbo].[BookReserv]
           ([Name])
	SELECT [Name]
	FROM [Book]
GO


