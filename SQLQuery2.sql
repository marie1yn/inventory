-- Create Users table
CREATE TABLE Users (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(50) NOT NULL,
    Password NVARCHAR(255) NOT NULL,
    Role NVARCHAR(20) NOT NULL
);
GO  -- End of Users table batch

-- Create Products table
CREATE TABLE Products (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Quantity INT NOT NULL,
    Price DECIMAL(10,2) NOT NULL
);
GO  -- End of Products table batch

-- Create Orders table
CREATE TABLE Orders (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    ProductId INT NOT NULL,
    Quantity INT NOT NULL,
    TotalPrice DECIMAL(10,2),  -- Store TotalPrice directly
    Date DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (ProductId) REFERENCES Products(Id)
);
GO  -- End of Orders table batch

-- Create Trigger to Update TotalPrice after Insert or Update on Orders
CREATE TRIGGER trg_UpdateTotalPrice
ON Orders
AFTER INSERT, UPDATE
AS
BEGIN
    UPDATE o
    SET o.TotalPrice = i.Quantity * p.Price
    FROM Orders o
    INNER JOIN inserted i ON o.Id = i.Id
    INNER JOIN Products p ON i.ProductId = p.Id;
END;
GO  -- End of Trigger creation batch
