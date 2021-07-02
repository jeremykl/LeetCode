/* Write your T-SQL query statement below */
SELECT d2.Name Department, e2.Name Employee, e2.Salary
FROM Employee e2, Department d2,
(
SELECT e.DepartmentId, MAX(e.Salary) MaxSalary
FROM Employee e JOIN Department d ON e.DepartmentId = d.Id
GROUP BY e.DepartmentId
    ) z
WHERE z.DepartmentId = e2.DepartmentID
AND e2.DepartmentId = d2.Id
AND e2.Salary = z.MaxSalary