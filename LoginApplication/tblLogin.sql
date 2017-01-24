IF OBJECT_ID ('dbo.tblLoginInfo') IS NOT NULL
	DROP TABLE dbo.tblLoginInfo
GO

CREATE TABLE dbo.tblLoginInfo
	(
	Id       INT NOT NULL,
	Name     VARCHAR (50) NOT NULL,
	Password VARCHAR (50) NOT NULL
	)
GO


