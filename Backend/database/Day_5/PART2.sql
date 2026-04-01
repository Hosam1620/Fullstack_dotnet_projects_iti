USE AdventureWorks2012

------------------Q1---------------------
SELECT SalesOrderID, ShipDate
FROM SALES.SalesOrderHeader
WHERE ShipDate BETWEEN '2002-07-28' AND '2014-07-29';

------------------Q2---------------------

select p.ProductID, p.Name
from Production.Product p
where p.StandardCost < 110

------------------Q3---------------------
select p.ProductID, p.Name
from Production.Product p
where p.Weight is null

------------------Q4---------------------
select p.ProductID, p.Name
from Production.Product p
where p.Color in ('silver', 'black', 'red')
------------------Q5---------------------
select p.ProductID, p.Name
from Production.Product p
where p.Name like 'B%'

------------------Q6---------------------


select *
from Production.ProductDescription
where Description like '%\_%' escape '\'

------------------Q7---------------------
SELECT OrderDate,
       SUM(TotalDue) AS TotalSales
FROM Sales.SalesOrderHeader
WHERE OrderDate BETWEEN '2001-07-01' AND '2014-07-31'
GROUP BY OrderDate
ORDER BY OrderDate
------------------Q8---------------------
select distinct HireDate
from HumanResources.Employee
------------------Q9---------------------
select avg(DISTINCT p.ListPrice)
from Production.Product p
------------------Q10---------------------
SELECT 'The ' + Name + ' is only! ' + CAST(ListPrice AS VARCHAR(20)) AS ProductInfo
FROM Production.Product
WHERE ListPrice BETWEEN 100 AND 120
ORDER BY ListPrice
------------------Q11---------------------
--a
select s.rowguid, s.Name, s.SalesPersonID, s.Demographics
into [store_Archive]
from Sales.Store s
go
--b
select s.rowguid, s.Name, s.SalesPersonID, s.Demographics
into sales.[store_Archive]
from Sales.Store s
where 1 = 2
go


------------------Q12---------------------]

SELECT FORMAT(GETDATE(), 'dd/MM/yyyy')
UNION
SELECT FORMAT(GETDATE(), 'MM-dd-yyyy')
UNION
SELECT FORMAT(GETDATE(), 'yyyy/MM/dd')
UNION
SELECT FORMAT(GETDATE(), 'dddd, MMMM dd yyyy')