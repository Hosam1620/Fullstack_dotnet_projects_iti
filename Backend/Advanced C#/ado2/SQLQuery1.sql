create table Departments(
deptId int identity,
name varchar(50),
constraint PK_Departments primary key (deptId));

create table students(
Id int identity,
Name varchar(50),
Age int,
Address varchar(100),
deptId int,
constraint PK_students primary key (Id),
constraint FK_students_Departments foreign key (deptId) references Departments(deptId)
);

-- Insert into Departments first (because Students depends on it)
INSERT INTO Departments (name) VALUES
('Computer Science'),
('Mathematics'),
('Physics'),
('Engineering'),
('Business Administration');

-- Insert into Students
INSERT INTO students (Name, Age, Address, deptId) VALUES
('Ahmed Ali',        20, 'Cairo, Egypt',         1),
('Sara Mohamed',     22, 'Alexandria, Egypt',     2),
('Omar Hassan',      21, 'Giza, Egypt',           1),
('Nour Ibrahim',     23, 'Mansoura, Egypt',       3),
('Khaled Youssef',   20, 'Tanta, Egypt',          4),
('Mona Ahmed',       24, 'Aswan, Egypt',          5),
('Youssef Kamal',    22, 'Luxor, Egypt',          2),
('Layla Mahmoud',    21, 'Suez, Egypt',           3),
('Hassan Tarek',     23, 'Hurghada, Egypt',       4),
('Dina Walid',       20, 'Port Said, Egypt',      1);