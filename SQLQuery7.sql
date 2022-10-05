use ejemplo;
GO
create table personasDos(
id int identity primary key,
nombre varchar(20) not null,
apellido varchar(20) not null,
fechaNacimiento date not null,
idDireccion int not null,
)
--insertar datos--
insert into personasDos(nombre,apellido,FechaNacimiento,idDireccion)
values('Adrian','Villagomez','1992/05/09',1),
('Pepe','Forlan','1990/05/05',2);
--obtener datos
select * from personasDos
--obtener nombre datos
select nombre,apellido from personasDos
--Filtrando datos--
select * from personasDos where id = 3;
select * from personasDos where id = 1 or id =2;
-- ordenar por nombre
select * from personasDos order by nombre
-- borrar todo
delete from personas
--borrar solo algo especifico
delete from personasDos WHERE id =1

