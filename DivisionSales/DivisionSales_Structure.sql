IF OBJECT_ID ('dbo.DivisionSales') IS NOT NULL
	DROP TABLE dbo.DivisionSales
GO

CREATE TABLE dbo.DivisionSales
	(
	DivisionID      VARCHAR (50) NOT NULL,
	YearOfOperation VARCHAR (50) NOT NULL,
	NetSalesAmount  DECIMAL (18,2) NOT NULL
	)
GO

