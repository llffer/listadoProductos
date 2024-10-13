--ADAPROYECTO db
CREATE DATABASE ADAPROYECTO
GO
USE ADAPROYECTO
GO

create table distrito
(iddis int identity primary key,
nombre varchar(100))
go
create table empleados
(idemp int identity primary key,
dni varchar(8),
nombres varchar(100),
apellidos varchar(100),
direccion varchar(100),
telefono varchar(100),
iddis int foreign key references distrito (iddis)
)
go
create table usuarios
(idusu int identity primary key,
nombreusu varchar(100),
claveusu varchar(100),
idemp int  foreign key references empleados(idemp))
go


insert into distrito values('Villa el salvador')

insert into empleados values('45689789','Jose Antonio','Castro Mamani','av. flores 232','987654324',1)

select*from empleados

insert into usuarios values('jose','123456',1)
--crear procedimientos almacenados.

create proc pa_validarUsuario
@nomusu varchar(100),
@claveusu varchar(100)
as
begin 
select*from usuarios where nombreusu=@nomusu and claveusu=@claveusu
end
