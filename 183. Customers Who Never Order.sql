/* Write your T-SQL query statement below */
SELECT Name as Customers
FROM Customers c
WHERE NOT EXISTS (SELECT 1 FROM Orders o WHERE o.CustomerId = c.Id)