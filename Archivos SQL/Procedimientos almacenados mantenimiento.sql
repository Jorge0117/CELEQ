use CELEQ
go
create procedure CrearSolicitudMantenimiento (@id varchar(100), @fecha date, @nombre varchar(255), @telefono varchar(11), @contactoAdicional varchar(255),
											@urgencia varchar(12), @areaTrabajo varchar(50), @lugarTrabajo varchar(255), @descripcion varchar(500), @usuario varchar(50))
as
	update SolicitudMantenimiento set ultimoAgregado = 0 where areaTrabajo = @areaTrabajo
	insert into SolicitudMantenimiento values (@id, @fecha, @nombre, @telefono, @contactoAdicional, @urgencia, @areaTrabajo, @lugarTrabajo, @descripcion, 'Pendiente', 1, @usuario)

go

create procedure AprobarSolicitudMantenimiento(@id varchar(100), @usuario varchar(50), @observaciones varchar(500))
as
	update SolicitudMantenimiento set estado = 'Aprobado' where id = @id
	insert into SolicitudMantenimientoAprobada(idSolicitud, personaAsignada, observacionesAprob) values (@id, @usuario, @observaciones)
go

create procedure RechazarSolicitudMantenimiento(@id varchar(100), @motivo varchar(500))
as
	update SolicitudMantenimiento set estado = 'Rechazado' where id = @id
	insert into SolicitudMantenimientoRechazada values(@id, @motivo)
go

drop procedure AprobarSolicitudMantenimiento
drop procedure CrearSolicitudMantenimiento
select * from SolicitudMantenimientoRechazada

select fecha, nombreSolicitante, unidad, telefono, contactoAdicional, urgencia, areaTrabajo, lugarTrabajo, descripcionTrabajo from SolicitudMantenimiento

select * from SolicitudMantenimientoAprobada
delete from SolicitudMantenimientoAprobada
select CONCAT(nombre, ' ', apellido1, ' ', apellido2) from Usuarios
select * from Usuarios

update SolicitudMantenimiento set Estado = 'Pendiente'