/* Write your T-SQL query statement below */
SELECT s.Score, zz.Rank FROM Scores s JOIN (
SELECT Score, ROW_NUMBER() OVER (ORDER BY Score DESC) AS Rank FROM (
SELECT DISTINCT Score FROM Scores ) z ) zz ON zz.Score = s.Score
ORDER BY Score Desc