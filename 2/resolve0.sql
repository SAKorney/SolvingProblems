/* Выводит всех покупателей, сделавших более одной покупки,
   и количество их покупой */


SELECT [CustomerId], COUNT([CustomerId]) as num_n
  FROM [Customers].[dbo].[Purchases]
  GROUP BY [CustomerId]
  HAVING COUNT([CustomerId]) > 1