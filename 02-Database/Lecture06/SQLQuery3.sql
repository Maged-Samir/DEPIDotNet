--Functions
---Built-In Functions (return single value)
---User Defined Function
----Scalar Function (function return one value)
----Inline Function (function return Table)
create function GetEmpsByDid(@deptId int)
returns table 
as return 
(
   select * from Employee
   where deptId = @deptId
)

select * from GetEmpsByDid(102)


----MultiStatment Function (function return Table)

create function GetMembersByLoc(@loc varchar(50))
returns @t table (id int,info varchar(50))
as
begin

if @loc = 'cairo'
insert into @t
select id,name from Employee where address = @loc

else if @loc = 'alex'
insert into @t
select id,name from Employee where address = @loc

return
end

select * from GetMembersByLoc('alex')
------------------------------------------------------
--Views 
-- is a select statment
-- is a versual table 


alter view vemp
as
select id,name,gender,address from Employee

select * from vemp


create view EmpCairo
as
select * from Employee
where address = 'cairo'

create view EmpAlex
as
select * from Employee
where address = 'alex'

create view AllEmp
as
select * from EmpCairo
union all
select * from EmpAlex

create proc TestEmps
as
select * from AllEmp

TestEmps



alter view NewEmploye
as
select id as 'eid',name as 'ename' from Employee

select * from NewEmploye
select ename from NewEmploye

---------------------------------------

-- Stored Procedure

--Parsing 
--Optimaizing
--Query Tree 
  --From
  --Join
  --On
  --where
  --Group
  --Having
  --Select
  --Order
--Execution

alter proc GetEmploy
as
select id,name,address from Employee

GetEmploy

alter proc GetEmployee(@eid int)
as
select * from Employee
where id = @eid

GetEmployee 5

create proc InsertNewEmp (@eid int,@ename varchar(50),@mid int)
as
insert into Emp(Eid,Ename,Mid)
values(@eid,@ename,@mid)

InsertNewEmp 60,'Test',1
-------------------------------------------------------------

--Database Schema 
---Create two DB object  With the same name 
---Fast access Tables
---Different Permissions

create schema std

alter schema std transfer Student

select * from std.Student


create table std.Department 
(
Did int primary key,
Dname varchar(50)
)

select * from std.Department


----------------------------------
--Security 
--Server
--Authentication (UserName & Pass)
--Authorization (roles)

----------------------------------------
select *  from Employee

select * into NewEmployee
from Employee

select * into SkillsDB.dbo.Employee
from Employee

drop table NewEmployee

select * into NewEmployee
from Employee
where address = 'alex'

select * into NewEmployee
from Employee
where 1 = 2


select top(4)* from Employee


select top(2)* from Employee
where address = 'alex'

select newid()

select top(2)* from Employee
order by newid()

