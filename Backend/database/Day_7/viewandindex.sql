create view DisplayAllStudents
as
select concat(St_Fname, '', St_Lname) as fullName, c.Crs_Name
from Student s
         join Stud_Course sc
              on s.St_Id = sc.St_Id
         join dbo.Course C
              on sc.Crs_Id = C.Crs_Id
where sc.Grade > 50;
---------------2--------------
create view encryptManger
    with encryption
as
select Ins_Name
from Department d
         join Instructor i on d.Dept_Manager = Ins_Id
         join Ins_Course ic on i.Ins_Id = ic.Ins_Id
         join course c on ic.Crs_Id = c.Crs_Id
go
-------------------------------3------------------------
create view showDeptIns
as
select Ins_Name, Dept_Name
from Department d,
     Instructor i
where d.Dept_Id = i.Dept_Id
  and d.Dept_Name in ('SD', 'java')
go
select *
from showDeptIns
go
-------------------4------------------------------
create view V1
as
select *
from Student
where St_Address in ('alex', 'cairo')
with check option
go
-----------------------5-------------------------

create view V2
as
    select p.Pname,p.Pnumber
        from dbo.Project p
go

------------6-------------
create schema company
go
alter schema company transfer Departments;
go

create schema Human_Resource
go
alter schema Human_Resource transfer Employee
go
-------------------------------7---------------
create  clustered index IX_Manager_HireDate
    on dbo.Department(Manager_hiredate)
--error
--------------------------8---------------------
create unique index IX_Age
on Student(St_Age)
--error also
