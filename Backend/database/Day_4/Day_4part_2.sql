-- 1
-- -a
select concat(Fname, Lname) as full_Name, e.Sex
from Employee e
where sex = 'F'
union
select d.Dependent_name, d.Sex
from Dependent d
where d.Sex = 'F';
-- -b
select concat(Fname, Lname) as full_Name, e.Sex
from Employee e
where sex = 'F'
union
select d.Dependent_name, d.Sex
from Dependent d
where d.Sex = 'F';
-- 2
select p.Pname, w.Hours
from Project p,
     Works_for as w
where w.Pno = p.Pnumber
group by p.Pname, w.Hours;
-- 3
select d.*
from Departments d
         join Employee e
              on D.Dnum = e.Dno
where e.SSN = (select min(SSN) from Employee)
--4
select d.Dname, max(Salary) as maximum, min(Salary) as minimum, avg(isnull(Salary, 0)) as average
from Departments d
         join Employee e
              on D.Dnum = e.Dno
group by Dname;
--5
select concat(Fname, Lname) as full_name, Dependent_name
from Dependent d
         full outer join Employee e
                         on d.ESSN = e.SSN
where d.ESSN is null;
--6
select d.Dnum, d.Dname, count(d.Dnum) as number_of_emp, avg(isnull(salary, 0)) as avarage
from Departments d
         join employee e
              on d.Dnum = e.Dno
group by d.Dnum, d.Dname
having avg(isnull(salary, 0)) < (select avg(isnull(Salary, 0))
                                 from Employee)
--7
select Fname, Lname, Pname, D.Dnum
from Employee e
         join Works_for w on e.SSN = w.ESSn
         join dbo.Project P on w.Pno = P.Pnumber
         join dbo.Departments D on D.Dnum = e.Dno
order by d.Dnum, e.Lname, e.Fname
--8
select distinct Salary
from Employee e1
where 2> (select count(distinct Salary)
                 from Employee e2
                 where e2.Salary>e1.Salary)
order by Salary desc;
--9
select concat(Fname, Lname) as full_name
from Employee
         join Dependent
              on dbo.Employee.SSN = Dependent.ESSN
where concat(Fname, concat(' ', Lname)) = Dependent_name
--9
select Fname + ' ' + Lname as fullName
from Employee
where Fname + ' ' + Lname in (select Dependent_name
                              from dbo.Dependent)
--10 we use correlated subquery when we have a subquery that depends on outer query values,
--and we use exists keyword with it.
select ssn, concat(Fname, concat(' ', Lname)) as full_name
from Employee
where exists(select 1
             from Dependent
             where ESSN = SSN)
--11
insert into Departments
values ('DEPT IT', 100, 112233, 1 - 11 - 2006)

--12
--a
update Departments
set MGRSSN=968574
where Dnum = 100;
--b
update Departments
set MGRSSN=102672
where Dnum = 20;
--c
update Employee
set Dno=20,
    Superssn=102672
where SSN = 102660;


--13

DELETE
FROM Dependent
WHERE ESSN = 223344;

DELETE
FROM Works_for
WHERE ESSn = 223344;

UPDATE Departments
SET MGRSSN = 102672
WHERE MGRSSN = 223344;

UPDATE Employee
SET SuperSSN = NULL
WHERE SuperSSN = 223344;

DELETE
FROM Employee
WHERE SSN = 223344;

--14
UPDATE Employee
SET Salary = Salary * 1.3
WHERE SSN IN (SELECT W.ESSn
              FROM Works_for W
                       JOIN Project P
                            ON W.Pno = P.Pnumber
              WHERE P.Pname = 'Al Rabwah');
