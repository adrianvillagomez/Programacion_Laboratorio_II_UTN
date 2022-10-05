INSERT INTO Puestos(ID_PUESTOS,NOMBRE,NIVEL_AUTORIZACION) VALUES
(1,'Director',3),
(2,'Gerente',3),
(5,'Jefe de Sector',2),
(4,'Administrativo',1),
(3,'Vendedor',0),
(6,'Secretario',2);
select * from Puestos
INSERT INTO EMPLEADOS(NOMBRE,APELLIDO,ID_PUESTO,SALARIO,ESTA_ACTIVO,FECHA_ALTA,FECHA_BAJA,MAIL) VALUES
('Leilani','Kinney',1,383946.80,1,'1996-03-21',NULL,'lkinney@gmail.com'),
('Igor','England',5,283558.85,1,'2013-03-28',NULL,'lkinney@gmail.com'),
('Maya','Brock',3,164546.09,1,'1993-10-24',NULL,NULL),
('Hayden','Moss',4,211695.50,0,'2012-06-07','2015-02-19','hmoss@gmail.com'),
('Amal','Colon',2,388933.60,1,'2019-09-23',NULL,NULL);
select * from EMPLEADOS
select * from Puestos
select NOMBRE from Puestos
select * from EMPLEADOS where ESTA_ACTIVO=1