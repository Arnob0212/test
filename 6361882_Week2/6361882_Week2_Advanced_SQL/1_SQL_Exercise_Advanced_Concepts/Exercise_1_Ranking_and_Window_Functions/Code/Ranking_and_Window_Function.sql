CREATE TABLE Products (
    ProductID INT PRIMARY KEY IDENTITY(1,1),
    ProductName VARCHAR(100),
    Category VARCHAR(50),
    Price DECIMAL(10, 2)
);

INSERT INTO Products (ProductName, Category, Price) VALUES
('IPhone 15', 'Electronics', 120000),
('Samsung TV', 'Electronics', 55000),
('Dell Laptop', 'Electronics', 75000),
('AirPods', 'Electronics', 18000),
('Sony Camera', 'Electronics', 80000),

('Nike Shoes', 'Sports', 9000),
('Cricket Bat', 'Sports', 4500),
('Yonex Racket', 'Sports', 4000),
('SG Ball', 'Sports', 3500),
('Football', 'Sports', 9500),

('The Revenge of Geography', 'Book', 40),
('Connectography: Mapping the Future of Global Civilization', 'Book', 60),
('The Grand Chessboard: American Primacy and Its Geostrategic Imperatives', 'Book', 450),
('Prisoners of Geography', 'Book', 75),
('Why Nations Go to War', 'Book', 150);

SELECT *
FROM (
    SELECT 
        ProductName,
        Category,
        Price,
        ROW_NUMBER() OVER (PARTITION BY Category ORDER BY Price DESC) AS RowNum
    FROM Products
) AS RankedProducts
WHERE RowNum <= 3;

SELECT *
FROM (
    SELECT 
        ProductName,
        Category,
        Price,
        RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS RankInCategory
    FROM Products
) AS RankedProducts
WHERE RankInCategory <= 3;

SELECT *
FROM (
    SELECT 
        ProductName,
        Category,
        Price,
        DENSE_RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS DenseRankInCategory
    FROM Products
) AS RankedProducts
WHERE DenseRankInCategory <= 3;
