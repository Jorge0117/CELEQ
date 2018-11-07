use CELEQ
go
create procedure CrearSolicitudMantenimiento (@id varchar(100), @fecha date, @nombre varchar(255), @unidad varchar(255), @telefono varchar(11), @contactoAdicional varchar(255),
											@urgencia varchar(12), @areaTrabajo varchar(50), @lugarTrabajo varchar(255), @descripcion varchar(500))
as
	update SolicitudMantenimiento set ultimoAgregado = 0 where areaTrabajo = @areaTrabajo
	insert into SolicitudMantenimiento values (@id, @fecha, @nombre, @unidad, @telefono, @contactoAdicional, @urgencia, @areaTrabajo, @lugarTrabajo, @descripcion, 'Pendiente', 1)

go

select * from SolicitudMantenimiento

select fecha, nombreSolicitante, unidad, telefono, contactoAdicional, urgencia, areaTrabajo, lugarTrabajo, descripcionTrabajo from SolicitudMantenimiento

select * from SolicitudMantenimientoAprobada
select CONCAT(nombre, ' ', apellido1, ' ', apellido2) from Usuarios