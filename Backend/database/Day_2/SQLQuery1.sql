select * 
from Employee
go

select Fname, Lname, Salary,Dno
from Employee
go

select *
from Project
go

select fname+' '+Lname as FullName, Salary*12.1 as AnnualSalary
FROM Employee
go

select ssn,fname+' '+Lname as FullName
from Employee
where Salary > 1000
go

select ssn,fname+' '+Lname as FullName,Salary*12 as AnnualSalary
from Employee
where (Salary*12) > 10000
GO

SELECT FNAME+' '+ LNAME AS FULLNAME,SALARY
FROM EMPLOYEE 
WHERE Sex='F'
GO

SELECT DEPARTMENTS.Dnum, DEPARTMENTS.Dname
FROM Departments
WHERE Departments.MGRSSN=968574
GO

SELECT Project.Pnumber, Project.Pname,Project.Plocation
FROM PROJECT
WHERE PROJECT.Dnum=10
GO