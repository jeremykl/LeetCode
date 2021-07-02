/* Write your T-SQL query statement below */
SELECT ROW_NUMBER() OVER (Order by id) AS id, student FROM(
SELECT id + 1 as id, student FROM seat WHERE id % 2 = 1

UNION ALL

SELECT id - 1 as id, student FROM seat WHERE id % 2 = 0
    ) z