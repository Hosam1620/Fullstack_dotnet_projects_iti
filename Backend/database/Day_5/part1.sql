use ITI

-----------------Q1-----------------
select count(St_Age)
from student

-----------------Q2-----------------

select distinct Ins_Name
from Instructor

-----------------Q3-----------------
select St_Id                                               as [Student ID],
       ISNULL(St_Fname + ' ' + St_Lname, 'name not found') as [Student Full Name],
       ISNULL(d.Dept_Name, 'department name not found')    as [ Department name]
from Student s
         left join Department d on s.Dept_Id = d.Dept_Id;

-----------------Q4-----------------
select ISNULL(i.Ins_Name, 'no name ')       as [instructor name ],
       ISNULL(d.Dept_Name, 'NO department') as [DEPARTMENT NAME ]
from Instructor i
         left join Department d on i.Dept_Id = d.Dept_Id;

-----------------Q5-----------------
SELECT S.St_Fname + ' ' + S.St_Lname AS [STUDEDNT FULL NAME ], C.Crs_Name
FROM Student S,
     Stud_Course SC,
     Course C
WHERE SC.St_Id = S.St_Id
  AND SC.Crs_Id = C.Crs_Id
  AND SC.Grade IS NOT NULL;

-----------------Q6-----------------
SELECT T.Top_Name, COUNT(C.Crs_Id) AS NumberOfCourses
FROM Course C
         JOIN Topic T ON C.Top_Id = T.Top_Id
GROUP BY T.Top_Name
-----------------Q7----------------- 
SELECT MAX(I.Salary) AS [MAX SALARY ], MIN(I.Salary) AS [MIN SALARY ]
FROM Instructor I

-----------------Q8----------------- 
SELECT *
FROM Instructor
WHERE Salary < (SELECT AVG(Salary) FROM Instructor)

-----------------Q9----------------- 

SELECT D.Dept_Name
FROM Instructor I
         JOIN Department D ON I.Dept_ID = D.Dept_Id
WHERE I.Salary = (SELECT MIN(Salary) FROM Instructor)

-----------------Q10----------------- 
SELECT DISTINCT TOP (2) SALARY
FROM Instructor
ORDER BY Salary DESC

-----------------Q11----------------- 
SELECT Ins_Name,
       COALESCE(CAST(Salary AS VARCHAR(50)), 'bonus') AS Salary
FROM Instructor

-----------------Q12----------------- 

SELECT AVG(SALARY)
FROM Instructor
-----------------Q13----------------- 
SELECT S.St_Fname, M.*
FROM Student S
         JOIN Student M
              ON S.St_super = M.St_Id
-----------------Q14----------------- 

SELECT Dept_Id, Ins_Name, Salary
FROM (SELECT Dept_Id,
             Ins_Name,
             Salary,
             DENSE_RANK() OVER (PARTITION BY Dept_Id ORDER BY Salary DESC) AS RankNum
      FROM Instructor
      WHERE Salary IS NOT NULL) AS T
WHERE RankNum <= 2

-----------------Q15----------------- 
SELECT Dept_Id, St_Fname, St_Lname
FROM (SELECT *, ROW_NUMBER() OVER (PARTITION BY Dept_Id ORDER BY NEWID() ) AS RN
      FROM Student
      WHERE Dept_Id IS NOT NULL) AS T
WHERE T.RN = 1