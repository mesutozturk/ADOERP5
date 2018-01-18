--- 1996 yılında hangi kategoriden ne kadarlık satış yapmışım $

ALTER VIEW "Sales by Categories in 1996"
AS
SELECT TOP 100 c.CategoryName [Kategori Adı],SUM(od.Quantity*od.UnitPrice*(1-od.Discount)) Toplam
FROM dbo.Products p
JOIN dbo.Categories c ON c.CategoryID = p.CategoryID
JOIN dbo.[Order Details] od ON od.ProductID = p.ProductID
JOIN dbo.Orders o ON o.OrderID = od.OrderID
WHERE YEAR(o.OrderDate)=1996
GROUP BY c.CategoryName
ORDER BY Toplam DESC
go

SELECT*
FROM "Sales by Categories in 1996"
WHERE Toplam>20000

CREATE VIEW SatistakiUrunler
AS
SELECT productid,productname,unitprice
FROM products
WHERE discontinued=0
GO

INSERT INTO SatistakiUrunler(productname,unitprice)
VALUES('viewci',9999)

SELECT * FROM products

DROP VIEW SatistakiUrunler

--Speedy Express ile tasinmis,Nancy'nin almis oldugu,DUMON ya da ALFKI adlı musteriler tarindan verilmis olan siparisleri saklayan view olusuturunuz.

-- en çok satan ürünün (adet olarak) adını kategori adını ve toplam satış adedini gösteren bir view yazınız

--Speedy Express ile tasinmis,Nancy'nin almis oldugu,DUMON ya da ALFKI adlı musteriler tarindan verilmis olan siparisleri saklayan view olusuturunuz.

create view SpeedyNacy
AS
select o.OrderID,o.OrderDate,c.CompanyName as MusteriSirket,s.CompanyName as KargoSirket,e.FirstName + ' ' + e.LastName as 'FullName'
from Orders o 
join Shippers s on s.ShipperID=o.ShipVia
join Employees e on e.EmployeeID = o.EmployeeID
join Customers c on c.CustomerID=o.CustomerID
where e.FirstName='nancy' and s.CompanyName='Speedy Express' 
and c.CustomerID in ('DUMON','ALFKI')
go
-- en çok satan ürünün (adet olarak) adını kategori adını ve toplam satış adedini gösteren bir view 
CREATE VIEW [Top10Products ]
as
SELECT TOP 10 p.ProductName,SUM(od.Quantity) adet,c.CategoryName 
FROM dbo.Products p 
JOIN dbo.[Order Details] od ON od.ProductID = p.ProductID
JOIN dbo.Orders o ON o.OrderID = od.OrderID
JOIN dbo.Categories c ON c.CategoryID = p.CategoryID
GROUP BY p.ProductName,c.CategoryName
ORDER BY adet DESC
GO

-- ortalama satış miktarının üzerine çıkan (para bazlı) satışları gösteren (orderId ve sipariş fiyatı) bir view hazırlayınız
CREATE VIEW OverSalesAvarage
AS
SELECT  od.OrderID, SUM(od.Quantity*od.UnitPrice*(1-od.Discount)) Total
FROM dbo.[Order Details] od
GROUP BY od.OrderID
HAVING SUM(od.Quantity*od.UnitPrice*(1-od.Discount))>(
		SELECT  AVG(od2.Quantity*od2.UnitPrice*(1-od2.Discount)) 
		FROM dbo.[Order Details] od2
	)
go