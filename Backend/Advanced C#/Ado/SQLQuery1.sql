create table Products(
Id int identity ,
Name varchar(50) null,
Price decimal(10,2) null,
constraint PK_Product primary key (Id),
);
go
Create table Orders
(
OrderId int identity,
CustomerName varchar(50) null,
OrderDate date,
constraint PK_Orders primary key (OrderId)
);
go
create table OrderProducts
( 
OrderId int,
ProductId int,
constraint PK_OrderProducts primary key (OrderId, ProductId),
constraint FK_OrderProducts_Orders foreign key (OrderId) references Orders(OrderId),
constraint FK_OrderProducts_Product foreign key (ProductId) references Products(Id)
)

-- insert data into the tables
INSERT INTO Products (Name, Price) VALUES
('Laptop', 15000.00),
('Mouse', 150.50),
('Keyboard', 350.75),
('Monitor', 4200.00),
('Headphones', 800.00),
('USB Flash', 120.00),
('Printer', 2500.00),
('Webcam', 600.00),
('External HDD', 3200.00),
('Microphone', 950.00);


INSERT INTO Orders (CustomerName, OrderDate) VALUES
('Ahmed Ali', '2026-03-01'),
('Mohamed Hassan', '2026-03-02'),
('Sara Mahmoud', '2026-03-03'),
('Omar Khaled', '2026-03-04'),
('Mona Adel', '2026-03-05'),
('Hany Ibrahim', '2026-03-06'),
('Nour Samy', '2026-03-07'),
('Youssef Tarek', '2026-03-08'),
('Salma Fathy', '2026-03-09'),
('Karim Nabil', '2026-03-10');

INSERT INTO OrderProducts (OrderId, ProductId) VALUES
(1,1),
(1,2),
(2,3),
(2,4),
(3,5),
(3,6),
(4,7),
(5,8),
(6,9),
(7,10),
(8,1),
(9,2),
(10,3);

