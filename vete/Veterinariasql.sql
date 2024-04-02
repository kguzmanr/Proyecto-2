create database VETERINARIA;

create table USUARIOS
(
login_usuario varchar(30) primary key,
clave_usuario varchar(20) not null,
nombre varchar(50) not null,
apellidos varchar(60) not null,
)
go
create table MASCOTAS
(
id_mascota int identity(1,1) primary key,
nombre_mascota varchar(30) not null,
tipo_mascota varchar(30) not null,
comida_favorita varchar(50),
)
go
create table CITAS
(
id_mascota int identity(1,1) primary key,
proxima_fecha date not null,
medico_asignado varchar(50) not null,
)

CREATE TABLE Ingresa
(
  id int identity primary key,
  usuario varchar (50) not null,
  clave varchar (50) not null,
  )
 

  insert into USUARIOS values ('Kev','123', 'Kevin', 'Guzman'),('Narv','456','Narbix','Salazar')

select usuario, clave from	Ingresa where usuario = 'Kev' and clave = '123' 

select * from USUARIOS
