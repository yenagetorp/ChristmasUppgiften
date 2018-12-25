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
	(1, 'Denna saken som du f�r Den bara g�r och g�r.'),
	(2, 'Ta nu dessa s� att du inte fryser i vinter, n�r du ute �r och m�nen lyser.'),
	(3, 'Vacker som en dag Sm�rj med behag')
delete from Present
where Rhyme='some'