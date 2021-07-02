/* Write your T-SQL query statement below */
SELECT d1.Name as Department, e1.Name as Employee, e1.Salary
FROM Employee e1, Department d1
WHERE e1.DepartmentID = d1.Id
AND e1.Salary IN (SELECT DISTINCT e2.Salary FROM Employee e2, Department d2
WHERE e2.DepartmentID = d2.Id AND d1.Id = d2.Id ORDER BY Salary DESC OFFSET (0) ROWS FETCH NEXT (3) ROWS ONLY )