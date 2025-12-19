

use TestDB

--DDL
create table Employee(
id int primary key,
fname varchar(50) Not Null,
sname varchar(50),
hiringDate date default getdate(),
address varchar(50) default 'Cairo'
)

alter table Employee add age int
alter table employee drop column age

drop table employee

-- DML
insert into Employee (id,fname,sname)
values (4,'Ahmed','Ali'),
(2,'Samy','Mahmoud'),
(3,'Asmaa','Ali')

update Employee
set fname = 'Amany'
where id = 4

delete employee
where id =2


--DQL
select * from Employee
select id,fname from employee


select id,fname from employee
order by fname Desc


select * from Employee
where address = 'Alex'


select distinct address from Employee
where address is Not Null

select * from Employee
where age >= 19 and age <= 20


select * from Employee
where age between 19 and 20


select * from Employee
where address = 'Alex' or address ='Menofia'


select * from Employee
where address in ('Alex' ,'Menofia')

select fname ,sname from Employee

select fname +' '+ sname as FullName from Employee