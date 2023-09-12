create database ProductDb
use ProductDb

create table Product(
Id int primary key identity,
Name nvarchar(50)not null,
Price float not null)
insert into Product values('e-notebook',55000)
insert into Product values('mobile-1',35000)
insert into Product values('earpods',3000)

select * from Product