/* ===============================
   DATA INSERT SCRIPT
   Product Management System
   =============================== */

-- ===============================
-- 1. Category
-- ===============================
INSERT INTO Category (CategoryID, CategoryName, Description) VALUES
(1, 'Electronics', 'Electronic devices and accessories'),
(2, 'Furniture', 'Home and office furniture'),
(3, 'Clothing', 'Men and women clothing'),
(4, 'Food', 'Food and beverages'),
(5, 'Books', 'Educational and entertainment books');

-- ===============================
-- 2. Product
-- ===============================
INSERT INTO Product (ProductID, ProductName, Description, Price, ManufacturingDate, CategoryID) VALUES
(1, 'Laptop', '15-inch laptop', 1200.00, '2024-01-15', 1),
(2, 'Smartphone', 'Android smartphone', 800.00, '2024-02-10', 1),
(3, 'Desk', 'Wooden office desk', 300.00, '2023-11-05', 2),
(4, 'Chair', 'Ergonomic chair', 150.00, '2023-12-01', 2),
(5, 'T-Shirt', 'Cotton t-shirt', 25.00, '2024-03-01', 3),
(6, 'Jeans', 'Blue denim jeans', 60.00, '2024-03-05', 3),
(7, 'Chocolate', 'Dark chocolate bar', 5.00, '2024-04-01', 4),
(8, 'Coffee', 'Ground coffee pack', 12.00, '2024-04-10', 4),
(9, 'SQL Book', 'Learn SQL from scratch', 40.00, '2023-09-20', 5),
(10, 'C# Book', 'Mastering C# programming', 55.00, '2023-10-15', 5);

-- ===============================
-- 3. Supplier
-- ===============================
INSERT INTO Supplier (SupplierID, SupplierName, Phone, Address) VALUES
(1, 'Tech Supplier Co.', '0101111111', 'Cairo'),
(2, 'Office Supplies Ltd.', '0102222222', 'Giza'),
(3, 'Fashion World', '0103333333', 'Alexandria'),
(4, 'Food Distributors', '0104444444', 'Mansoura'),
(5, 'Book House', '0105555555', 'Cairo');

-- ===============================
-- 4. ProductSupplier
-- ===============================
INSERT INTO ProductSupplier (ProductID, SupplierID) VALUES
(1, 1),
(2, 1),
(3, 2),
(4, 2),
(5, 3),
(6, 3),
(7, 4),
(8, 4),
(9, 5),
(10, 5),
(1, 2),
(2, 2);

-- ===============================
-- 5. Warehouse
-- ===============================
INSERT INTO Warehouse (WarehouseID, Location, Capacity) VALUES
(1, 'Cairo Warehouse', 1000),
(2, 'Giza Warehouse', 800),
(3, 'Alex Warehouse', 600);

-- ===============================
-- 6. ProductWarehouse
-- ===============================
INSERT INTO ProductWarehouse (ProductID, WarehouseID, Quantity) VALUES
(1, 1, 50),
(1, 2, 30),
(2, 1, 70),
(3, 2, 40),
(4, 2, 60),
(5, 3, 100),
(6, 3, 80),
(7, 1, 200),
(8, 1, 150),
(9, 2, 25),
(10, 2, 20);

-- ===============================
-- 7. Orders
-- ===============================
INSERT INTO Orders (OrderID, OrderDate, Status) VALUES
(1, '2024-05-01', 'Pending'),
(2, '2024-05-02', 'Completed'),
(3, '2024-05-03', 'Cancelled'),
(4, '2024-05-04', 'Completed'),
(5, '2024-05-05', 'Pending');

-- ===============================
-- 8. OrderItem
-- ===============================
INSERT INTO OrderItem (OrderID, ProductID, Quantity, UnitPrice) VALUES
(1, 1, 1, 1200.00),
(1, 5, 2, 25.00),
(2, 2, 1, 800.00),
(2, 7, 5, 5.00),
(3, 3, 1, 300.00),
(4, 4, 2, 150.00),
(4, 9, 1, 40.00),
(5, 6, 1, 60.00),
(5, 8, 3, 12.00);

/* ===============================
   END OF SCRIPT
   =============================== */
