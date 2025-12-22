use SchoolDB

--Aggregate Functions

select * from Employee
select sal from Employee

select count(id) from Employee
select count(deptId) from Employee

select count(deptId) as 'Employees in department',
count(name) as 'Toatal' from Employee

select Min(sal) from Employee
select Max(sal) from Employee
select Avg(sal) from Employee

select max(sal),deptId from Employee
group by deptId

select max(sal),deptId from Employee
where deptId is not null
group by deptId

select max(sal) as 'MaxSalInDept' ,Dname as 'DeptName'
from Employee inner join Department
on Employee.deptId = Department.Did
where deptId is not null
group by Dname


select max(sal) as 'MaxSalInDept' ,Dname as 'DeptName'
from Employee inner join Department
on Employee.deptId = Department.Did
where deptId is not null
group by Dname
having max(sal) > 5000


select * from Employee
where sal < AVG(sal)  --XXXXXX


--Sub Query
select * from Employee
where sal < (select avg(sal) from Employee)

--Union all
--Union
--Intersect
--Except

select address from Employee
--Except
select address from Student


--Date Types

--char(10) 
--varchar(10)
--nchar(10)
--nvarchar(10) 

--date 3/13/1980
--time h:m:s 1.23

--datetime        3/13/1980 h:m:s 1.23
--datetimeOffset  3/13/1980 h:m:s 1.23 +2:00

--Image
--binary 

--Money 8
--SmallMoney 4
--dec(7,3)  6123.123

--smallint 2
--int 4
--bigint  8


select sname as StudntName from Student
order by StudntName

select sname as StudntName from Student
where StudntName = 'Omnia'

--Execution Order Of Query
--From
--Join
--On
--Where
--Group
--Having
--Select
--OredrBy

----------------------------------------------------------
--variables
--Local Variables
declare @x int 
set @x = 100
select @x as 'Value'

declare @x int 
select @x = 200
select @x as 'Value'

select * from Employee

declare @var int
select @var=sal from Employee
where id = 6
select @var as 'Employee Salary'

declare @na varchar(20),@loc varchar(20)
select @na = name ,@loc= address  from Employee
where id = 6
select @na as 'Employee Name' ,@loc as 'Employee Address'

-- Global Variable
select @@servername
select @@VERSION


--Conditional Statment
declare @x int = 1000
if @x > 100
select 'Level One'
else
begin
select 'Level Two'
end

--Loop Statment
declare @x int = 0
while @x < 2
begin
select 'Test Statment'
set @x += 1
end

Select * from Employee
----------------------------------
--Functions
--Builtin Functions
  -- Max , Min , Count ,Avg ,getdate() 
--UserDefined Functions
   --Scalar Function => Return One Value 
create function GetSalary(@eid int)
returns int
begin
declare @esal int
select @esal = sal from Employee
where id = @eid
return  @esal
end


select dbo.GetSalary(4)
drop function GetSalary


--Inline Function => Return Table (Body - Select Stament)
create Function GetEmployeeByDeptId(@deptId int)
returns table 
as return 
(
select id,name,sal,address from Employee
where deptId = @deptId
)

select * from GetEmployeeByDeptId(101)

--MultiStatment => Return Table (Body - Logic )
create function GetEmpsBy(@loc varchar(50))
returns @t table(id int,info varchar(50))
as
begin
if @loc ='cairo'
insert into @t 
select id,name from employee where address = @loc
else if @loc = 'alex' 
insert into @t
select id,name from employee where address = @loc
return
end


select * from GetEmpsBy('cairo')