/* Write your T-SQL query statement below */
SELECT Email FROM (
SELECT Email, COUNT(Email) as c
FROM Person
GROUP BY Email) z WHERE z.c > 1