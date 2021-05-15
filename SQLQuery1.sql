select*from orders join [Order Details] on orders.OrderID=[Order Details].OrderID,
sum([order details].UnitPrice*[order details].Quantity)
ORDER BY ProductID 


 
 select Products.ProductName Ürün,
 sum([Order Details].Quantity*[Order Details].UnitPrice)Toplam_Kazanç 
 from products 
 inner join [Order Details] on Products.ProductID=[Order Details].ProductID
 inner join Orders on Orders.OrderID=[Order Details].OrderID
 group by ProductName order by Toplam_Kazanç desc

 select  p.ProductName ÜrünAdi,
 sum((od.UnitPrice*od.Quantity)*(1-od.Discount)) ToplamKazanç
from Products as p 
inner join [Order Details] as od on p.ProductID=od.ProductID 
inner join Orders as o on od.OrderID=o.OrderID
group by p.ProductName order by ToplamKazanç desc

select product.productname 
sum(



 