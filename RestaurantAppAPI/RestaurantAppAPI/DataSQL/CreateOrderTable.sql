CREATE TABLE Orders (
	OrderID INT PRIMARY KEY,
	[Description] VARCHAR(255) NOT NULL,
	Restaurant VARCHAR(255) NOT NULL,
	Rating INT,
	OrderAgain BIT NOT NULL
);