IF OBJECT_ID ('dbo.AgedARCustomer') IS NOT NULL
	DROP TABLE dbo.AgedARCustomer
GO

CREATE TABLE dbo.AgedARCustomer
	(
	CustomerID   INT NOT NULL,
	CustomerName VARCHAR (50) NOT NULL,
	CONSTRAINT PK_AgedARCustomer PRIMARY KEY (CustomerID)
	)
GO

IF OBJECT_ID ('dbo.AgedAR') IS NOT NULL
	DROP TABLE dbo.AgedAR
GO

CREATE TABLE dbo.AgedAR
	(
	CustomerID INT NOT NULL,
	InvoiceNo  VARCHAR (50) NOT NULL,
	Amount     INT NOT NULL,
	InvoiceAge INT NOT NULL,
	CONSTRAINT FK_AgedAR_AgedARCustomer FOREIGN KEY (CustomerID) REFERENCES dbo.AgedARCustomer (CustomerID)
	)
GO



-- Table:  AgedARCustomer
-- Date:   2/9/2017 12:24 PM

INSERT INTO AgedARCustomer (CustomerID, CustomerName) VALUES (1, 'ABC Water Filter INC.')
GO
INSERT INTO AgedARCustomer (CustomerID, CustomerName) VALUES (2, 'Clear Glass Industries')
GO
INSERT INTO AgedARCustomer (CustomerID, CustomerName) VALUES (3, 'Home Design and More INC.')
GO
INSERT INTO AgedARCustomer (CustomerID, CustomerName) VALUES (4, 'Toronto Auto Parts INC.')
GO


-- Table:  AgedAR
-- Date:   2/9/2017 12:25 PM

INSERT INTO AgedAR (CustomerID, InvoiceNo, Amount, InvoiceAge) VALUES (1, 'A-123', 54654, 10)
GO
INSERT INTO AgedAR (CustomerID, InvoiceNo, Amount, InvoiceAge) VALUES (1, 'B-123', 68547, 20)
GO
INSERT INTO AgedAR (CustomerID, InvoiceNo, Amount, InvoiceAge) VALUES (1, 'C-123', 35435, 30)
GO
INSERT INTO AgedAR (CustomerID, InvoiceNo, Amount, InvoiceAge) VALUES (2, 'A-456', 54354, 10)
GO
INSERT INTO AgedAR (CustomerID, InvoiceNo, Amount, InvoiceAge) VALUES (2, 'B-456', 54335, 20)
GO
INSERT INTO AgedAR (CustomerID, InvoiceNo, Amount, InvoiceAge) VALUES (2, 'C-456', 69333, 30)
GO
INSERT INTO AgedAR (CustomerID, InvoiceNo, Amount, InvoiceAge) VALUES (3, 'A-789', 43685, 10)
GO
INSERT INTO AgedAR (CustomerID, InvoiceNo, Amount, InvoiceAge) VALUES (3, 'B-789', 46335, 20)
GO
INSERT INTO AgedAR (CustomerID, InvoiceNo, Amount, InvoiceAge) VALUES (3, 'C-789', 84535, 30)
GO
INSERT INTO AgedAR (CustomerID, InvoiceNo, Amount, InvoiceAge) VALUES (4, 'A-159', 46543, 10)
GO
INSERT INTO AgedAR (CustomerID, InvoiceNo, Amount, InvoiceAge) VALUES (4, 'B-159', 83843, 20)
GO
INSERT INTO AgedAR (CustomerID, InvoiceNo, Amount, InvoiceAge) VALUES (4, 'C-159', 74534, 30)
GO

