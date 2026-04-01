--to know my path
SELECT SERVERPROPERTY('InstanceDefaultDataPath') AS DataPath,
       SERVERPROPERTY('InstanceDefaultLogPath') AS LogPath;

--C:\Program Files\Microsoft SQL Server\MSSQL17.MSSQLSERVER\MSSQL\DATA\
--C:\Program Files\Microsoft SQL Server\MSSQL17.MSSQLSERVER\MSSQL\DATA\

--first question
CREATE DATABASE Company
ON PRIMARY
(
    NAME = 'Company-Data',
    FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL17.MSSQLSERVER\MSSQL\DATA\Company-Data.mdf',
    SIZE = 10MB,
    MAXSIZE = 50MB,
    FILEGROWTH = 10%
)
LOG ON
(
    NAME = 'SD3x-Company-Log',
    FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL17.MSSQLSERVER\MSSQL\DATA\SD3x-Company-Log.ldf',
    SIZE = 5MB,
    MAXSIZE = 40MB,
    FILEGROWTH = 10%
);

--second question
--1
select Dnum,Dname,ssn,Fname+' '+Lname as full_Name
from Employee,Departments
where MGRSSN=SSN;
--2
select Dname,Pname
from Departments
join Project
on Project.Dnum=Departments.Dnum;

--3
select Fname,Dependent.*
from Employee join Dependent
on Employee.SSN = Dependent.ESSN;

--4
select *
from Project
where City in ('cairo','alex');

--5
select *
from Project
where Pname like 'a%';

--6
select *
from Employee
where Dno=30 and Salary between 1000 and 2000;

--7
select Fname
from Employee,Project,Works_for
where ESSn=ssn
  and Pno=Pnumber
  and Employee.Dno=10
  and Hours>=10
  and Pname='Al Rawdah';

--8
select emp.Fname,emp.Lname
from Employee emp,Employee super
where emp.Superssn=super.SSN
  and super.Fname='Kamel'
  and super.Lname='Mohamed';

--9
select concat(Fname,Lname)as full_Name,Pname as project_name
from Employee join Works_for
    ON Works_for.ESSn=Employee.SSN
    join Project
    on Works_for.Pno=Pnumber
order by Pname;

--10
select Pnumber,Departments.Dname,Employee.Lname,Employee.Address,Employee.Bdate
    from Project join Departments
        ON Project.Dnum = Departments.Dnum
    join Employee
        on Departments.MGRSSN = Employee.SSN
where Project.City='cairo';

--11
select Departments.Dname,Employee.*
from Employee join Departments
on Departments.MGRSSN =SSN;

--12
select *
from Employee left join Dependent
    on Dependent.ESSN =Employee.SSN;

--13
insert into Employee
values ('Hossam','Mohamed',102672,01/06/2002,'al sheikh fadl','M',300,112233,30);

--14
insert into Employee
values ('Abdalla','Mahmoud',102660,12/09/2002,'al sheikh fadl','M',null,null,30);

--15
update Employee
set Salary=3000
where ssn=102672;
--16
update Employee
set Salary=Salary*1.2
where ssn=102672;