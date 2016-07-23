/* Выводит всех покупателей, купивших более одной сметаны,
   и количество купленой сметаны */


SELECT [CustomerId], COUNT([CustomerId]) as num_n
  FROM [Customers].[dbo].[Purchases]
  WHERE [ProductName] = 'Сметана'
  GROUP BY [CustomerId]
  HAVING COUNT([CustomerId]) > 1