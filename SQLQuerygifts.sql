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
	
select * from Person

select * from Present

insert into Present
values
	(1, 'Denna saken som du får Den bara går och går.'),
	(2, 'Ta nu dessa så att du inte fryser i vinter, när du ute är och månen lyser.'),
	(3, 'Vacker som en dag Smörj med behag')
delete from Present
where Rhyme='some'