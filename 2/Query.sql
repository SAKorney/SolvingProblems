SELECT Customers.CustomerId 
  FROM Customers INNER JOIN Purchases
  ON Customers.CustomerId = Purchases.CustomerId
  WHERE Purchases.ProductName = 'Молоко' AND
        Customers.CustomerId NOT IN ( SELECT DISTINCT CustomerId
                                      FROM Purchases
                                      WHERE Purchases.ProductName = 'Сметана' )


