IF OBJECT_ID ('dbo.TransferHeader') IS NOT NULL
	DROP TABLE dbo.TransferHeader
GO

CREATE TABLE dbo.TransferHeader
	(
	TransferID     VARCHAR (50) NOT NULL,
	DateOfTransfer DATETIME NOT NULL,
	FromBranch     VARCHAR (50) NOT NULL,
	ToBranch       VARCHAR (50) NOT NULL,
	CONSTRAINT PK_TransferHeader PRIMARY KEY (TransferID)
	)
GO

IF OBJECT_ID ('dbo.TransferDetail') IS NOT NULL
	DROP TABLE dbo.TransferDetail
GO

CREATE TABLE dbo.TransferDetail
	(
	TransferID   VARCHAR (50) NOT NULL,
	ProductID    VARCHAR (50) NOT NULL,
	ProductName  VARCHAR (50) NOT NULL,
	UnitQuantity INT NOT NULL,
	UnitCost     DECIMAL (18,2) NOT NULL,
	FOREIGN KEY (TransferID) REFERENCES dbo.TransferHeader (TransferID)
	)
GO

