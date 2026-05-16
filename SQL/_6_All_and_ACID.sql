/*


You are given two tables:

Employees
+--------+--------+---------+
| emp_id | name   | dept_id |
+--------+--------+---------+
| 1      | Alice  | 10      |
| 2      | Bob    | 20      |
| 3      | CPS    | 30      |
| 4      | Abc    | 10      |
+--------+--------+---------+

Departments
+---------+-------------+
| dept_id | dept_name   |
+---------+-------------+
| 10      | HR          |
| 20      | IT          |
| 40      | Marketing   |
+---------+-------------+

--1 left join
Question:
get all employees and their department names.

Expected Output:
+--------+--------+------------+
| emp_id | name   | dept_name  |
+--------+--------+------------+
| 1      | Alice  | HR         |
| 2      | Bob    | IT         |
| 3      | CPS    | NULL       |
| 4      | Abc    | HR         |
+--------+--------+------------+
*/
-- Select employee id, employee name, and department name
SELECT e.emp_id, e.name, d.dept_name

-- Get data from Employees table and give alias 'e'
FROM Employees e

-- Use LEFT JOIN to keep all employees
LEFT JOIN Departments d

-- Match department ids from both tables
ON e.dept_id = d.dept_id;


/*2 right join
Question: Get all departments and the employees assigned

Output
+--------+--------+-------------+
| emp_id | name   | dept_name   |
+--------+--------+-------------+
| 1      | Alice  | HR          |
| 4      | Abc    | HR          |
| 2      | Bob    | IT          |
| NULL   | NULL   | Marketing   |
+--------+--------+-------------+
*/

SELECT e.emp_id, e.name, d.dept_name
FROM Employees e
RIGHT JOIN Departments d
ON e.dept_id = d.dept_id;

/*3 full join/full outer join
Question: Need a final view of Employees and Departments including all employees and all departments

Output
+--------+--------+-------------+
| emp_id | name   | dept_name   |
+--------+--------+-------------+
| 1      | Alice  | HR          |
| 4      | Abc    | HR          |
| 2      | Bob    | IT          |
| 3      | CPS    | NULL        |
| NULL   | NULL   | Marketing   |
+--------+--------+-------------+
*/

SELECT e.emp_id, e.name, d.dept_name
FROM Employees e
FULL OUTER JOIN Departments d --othoba FULL JOIN Departments d
ON e.dept_id = d.dept_id;

/* 5
Question 1:
Find employees who are NOT assigned to any department.

Output
+--------+
| name   |
+--------+
| CPS    |
+--------+
*/

SELECT e.name
FROM Employees e
LEFT JOIN Departments d
ON e.dept_id = d.dept_id
WHERE d.dept_id IS NULL;

/* 6
Question 2:
Find departments that have no employees assigned.

Output
+-------------+
| dept_name   |
+-------------+
| Marketing   |
+-------------+
*/

SELECT d.dept_name
FROM Employees e
RIGHT JOIN Departments d
ON e.dept_id = d.dept_id
WHERE e.emp_id IS NULL;

--ACID

/*
Main Table: accounts

+----+-------+---------+
| id | name  | balance |
+----+-------+---------+
| 1  | Alice | 1000    |
| 2  | Bob   | 1000    |
+----+-------+---------+
*/

--A

/*1. Transaction WITH COMMIT
Question:
Transfer 200 from Alice to Bob and COMMIT the transaction.
*/

START TRANSACTION;

UPDATE accounts 
SET balance = balance - 200 
WHERE name = 'Alice';

UPDATE accounts 
SET balance = balance + 200 
WHERE name = 'Bob';

COMMIT;

SELECT * FROM accounts;

-- --output
-- +----+-------+---------+
-- | id | name  | balance |
-- +----+-------+---------+
-- | 1  | Alice | 800     |
-- | 2  | Bob   | 1200    |
-- +----+-------+---------+


/*2. Transaction WITH ROLLBACK (same original table)
Question:
Try to transfer 2000 from Alice to Bob but ROLLBACK the transaction.
*/

START TRANSACTION;

UPDATE accounts 
SET balance = balance - 2000 
WHERE name = 'Alice';

UPDATE accounts 
SET balance = balance + 2000 
WHERE name = 'Bob';

ROLLBACK;

SELECT * FROM accounts;

-- --output
-- +----+-------+---------+
-- | id | name  | balance |
-- +----+-------+---------+
-- | 1  | Alice | 800     |
-- | 2  | Bob   | 1200    |
-- +----+-------+---------+


--C
START TRANSACTION;

UPDATE accounts 
SET balance = balance - 200 
WHERE name = 'Alice';

UPDATE accounts 
SET balance = balance + 200 
WHERE name = 'Bob';

COMMIT;

--I
-- Transaction 1
START TRANSACTION;

UPDATE accounts 
SET balance = balance - 200 
WHERE name = 'Alice';

-- Transaction 2 runs separately
START TRANSACTION;

UPDATE accounts 
SET balance = balance + 200 
WHERE name = 'Bob';

COMMIT;

--D
START TRANSACTION;

UPDATE accounts 
SET balance = balance - 200 
WHERE name = 'Alice';

UPDATE accounts 
SET balance = balance + 200 
WHERE name = 'Bob';

COMMIT;

-- Transaction already committed earlier

SELECT * FROM accounts; --will print save data