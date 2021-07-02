/* Write your T-SQL query statement below */
SELECT w1.Id 
FROM Weather w1, Weather w2
WHERE w2.RecordDate = DATEADD(day,-1,w1.RecordDate)
AND w1.Temperature > w2.Temperature