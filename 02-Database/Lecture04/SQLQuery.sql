select * from Student
select * from Department

-- Cross Join
select Sname ,Dname
from Student , Department

select Sname ,Dname
from Student cross join Department

-- Inner Join
select s.Sname,d.Dname
from Student s, Department d
where s.DeptId = d.Did

select s.Sname,d.Dname
from Student s inner join Department d
on s.DeptId = d.Did
where Dname = 'A'


-- Outer Join
select s.Sname,d.Dname
from Student s left outer join Department d
on s.DeptId = d.Did


select s.Sname,d.Dname
from Student s right outer join Department d
on s.DeptId = d.Did

select Sname,Dname
from student full outer  join department 
on DeptId = Did

-- Self Join
Select x.Ename as 'Employee Name',y.Ename as 'Manager Name'
from Employee X , Employee y
where X.Mid = Y.Eid

Select distinct y.Ename as 'Manager Name'
from Employee X , Employee y
where X.Mid = Y.Eid


---Database Integrity 
-- Primary Key 
-- FK 
-- Default
-- NULL or Not NULL
-- Check
-- Unique
-- Data Type

create table Employee(
id int,
name varchar(50),
sal int,
workingHours int,
netSal as (sal*workingHours),
address varchar(50) default 'Egypt',
gender varchar(1),
deptId int,

constraint C1 primary key(id,name),
constraint C2 check (gender = 'M' or gender ='F'),
constraint C3 check (sal > 1000),
constraint C4 check (address in('Cairo','Giza')),
constraint C5 foreign key (deptId) references Department(Did)
on delete set Null on update cascade
)

alter table Employee drop constraint C3
alter table Employee add constraint C3 check (sal > 5000)


--Rule
create rule r1 as @x > 5000

sp_bindrule r1,'Employee.sal'
sp_bindrule r1,'Student.sal'

sp_unbindrule 'Employee.sal'
drop rule r1
