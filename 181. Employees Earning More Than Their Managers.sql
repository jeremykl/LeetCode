/* Write your T-SQL query statement below */
SELECT Name as Employee 
FROM Employee e1
WHERE e1.Salary > (SELECT e2.Salary FROM Employee e2 WHERE e1.ManagerId = e2.Id)