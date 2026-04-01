create table Instructor
(
    id          int identity (1,1),
    salary      decimal(8, 2) default '3000' check (salary between 1000 and 5000),
    Over_Time   decimal(8, 2) unique,
    Nat_salary  as (isnull(salary, 0) + isnull(Over_Time, 0)) PERSISTED,
    hiring_Date date          default getdate(),
    address     varchar(30) check (address in ('cairo', 'alex')),
    FName       varchar(50),
    LName       varchar(50),
    BD          date,
    Age         as year(getdate()) - year(BD),
    constraint Pk_Instructor primary key (id),

)

create table course
(
    cid      int identity (1,1),
    cname    varchar(50),
    Duration decimal(4, 1) unique,
    constraint PK_course primary key (cid)
)


create table Ins_Teach_course
(
    Iid int,
    cid int,
    constraint PK_Isn_Teach_course primary key (Iid,cid),
    constraint FK_Instructor foreign key (Iid)
        references Instructor (id) on delete set null on UPDATE cascade,
    constraint FK_Course foreign key (cid)
        references course (cid) on delete set null on UPDATE cascade
)

create table Lab
(
    Lid      int identity (1,1),
    cid      int,
    location varchar(40),
    capacity int check (capacity < 20),
    constraint PK_lab primary key (Lid, cid),
    constraint FK_course_in_lab foreign key (cid) references course (cid)
        on delete cascade on UPDATE cascade
)
