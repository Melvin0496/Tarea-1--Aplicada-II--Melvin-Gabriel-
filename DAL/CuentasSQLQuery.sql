create database CuentasFaciles

use CuentasFaciles

create table Cuentas(
CuentaId int identity(1,1) primary key,
Descripcion varchar(100),
Balance float
)

select *from Cuentas