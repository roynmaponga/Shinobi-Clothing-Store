SELECT OrderID
FROM tblOrders
WHERE OrderID NOT IN (SELECT OrderID FROM tblSales);