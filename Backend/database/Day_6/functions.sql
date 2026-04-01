------1--------
create function dbo.monthName(@x date)
    returns varchar(25)
as
begin
    return datename(month, @x)
end
go

select dbo.monthName('01-06-2002')
go
----------2--------
create function multiStatementFun(@a int, @b int)
    returns @t table
               (
                   number int
               )
as
begin
    while @a < @b
        begin
            insert into @t values (@a)
            set @a +=1
        end
    return
end
go
select *
from multiStatementFun(10, 20)
go
--------3-------
create function getNameAndDept(@id int)
    returns table
        as
        return(select concat(s.St_Fname, concat(' ', s.St_Lname)) as [full Name], Dept_Name
               from dbo.Student s
                        left join dbo.Department D
                                  on @id = D.Dept_Id)
go
select *
from getNameAndDept(5)
go

--------4---------
create function dbo.printMessage(@id int)
    returns varchar(100)
as
begin
    declare @FirstName varchar(50)
    declare @LastName varchar(50)
    declare @ms varchar(100)

    select @FirstName = St_Fname, @LastName = St_Lname
    from Student
    where @id = St_Id

    if @FirstName is null
        set @ms = 'first name is null'
    else
        if @LastName is null
            set @ms = 'last name is null'
        else
            if @FirstName is null
                set @ms = 'first name is null'
    return @ms
end
select dbo.printMessage(1)
-----------5---------
create function DisplayDepart(@mgId int)
    returns table
        as
        return(select Dept_Name, Ins_Name, Manager_hiredate
               from Department d
                        join Instructor i
                             on d.Dept_Manager = Ins_Id
               where Dept_Manager = @mgId)

------------6--------------------
CREATE FUNCTION dbo.GetStudentNames(@Type VARCHAR(50))
    RETURNS @Result TABLE
                    (
                        Names VARCHAR(100)
                    )
AS
BEGIN

    IF @Type = 'first name'
        INSERT INTO @Result
        SELECT ISNULL(St_Fname, 'No First Name')
        FROM Student

    ELSE
        IF @Type = 'last name'
            INSERT INTO @Result
            SELECT ISNULL(St_Lname, 'No Last Name')
            FROM Student

        ELSE
            IF @Type = 'full name'
                INSERT INTO @Result
                SELECT ISNULL(St_Fname, '') + ' ' + ISNULL(St_Lname, '')
                FROM Student

    RETURN
END
---------7-------------------------
SELECT St_Id,
       LEFT(St_Fname, LEN(St_Fname) - 1) AS FirstNameWithoutLastChar
FROM Student
go
------------8-------------------
DELETE
FROM Stud_Course
WHERE St_Id IN
      (SELECT St_Id
       FROM Student
       WHERE Dept_Id =
             (SELECT Dept_Id
              FROM Department
              WHERE Dept_Name = 'SD'))