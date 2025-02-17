# Write your MySQL query statement below
SELECT 
    u.name AS NAME,
    SUM(t.amount) AS BALANCE 
FROM transactions t
    LEFT JOIN users u ON u.account = t.account
GROUP BY u.name
HAVING SUM(t.amount) > 10000;