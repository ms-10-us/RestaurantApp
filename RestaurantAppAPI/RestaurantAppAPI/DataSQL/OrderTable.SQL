CREATE TABLE Orders (
	OrderID INT IDENTITY(1,1) PRIMARY KEY,
	[Description] VARCHAR(255) NOT NULL,
	Restaurant VARCHAR(255) NOT NULL,
	Rating INT,
	OrderAgain BIT NOT NULL
);

INSERT INTO Orders ([Description], Restaurant, Rating, OrderAgain) Values
('Eggplant Parmesan', 'Antonios', 2, 0) 
