create database Gifts
create table Person
(
	Id int primary key identity not null,
	Name nvarchar(50) not null,
)

create table Present
(
	Id int primary key identity not null,
	RecieverId int references Person(Id) not null,
	Rhyme nvarchar(256) not null
)

insert into Person
values
	('Sam'),
	('Elias'),
	('Lineea')
	


insert into Present
values
	(1, 'Denna saken som du får Den bara går och går.'),
	(2, 'Ta nu dessa så att du inte fryser i vinter, när du ute är och månen lyser.'),
	(3, 'Vacker som en dag Smörj med behag')
delete from Person
where name='Joel'

delete from Present
where Id=21

update Person
set Name = 'Lilla Bro' where name='yen'

alter table  Present
Add Sender nvarchar(50)
alter table  Present
alter column Sender nvarchar(50)

update Present
set sender ='Joel' where Id=1
update Present
set sender ='Pappa' where Id=2

update Present
set sender ='Joel' where Id=3
update Present
set sender ='Samuel' where Id=9
update Present
set sender ='Marianna' where Id=11
update Present
set sender ='Linnea' where Id=14
update Present
set sender ='Elias' where Id=15
update Present
set sender ='Mamma' where Id=19
update Present
set sender ='Anders' where Id=20
update Present
set sender ='Sam' where Id=21

select * from Person
select * from Present
delete from Present where id=32
delete from Present where id=33