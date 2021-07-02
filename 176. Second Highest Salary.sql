/* Write your T-SQL query statement below */
SELECT Max(Salary) as SecondHighestSalary FROM Employee 
WHERE Salary <> (SELECT MAX(Salary) FROM Employee)