use CELEQ
go
create procedure CrearSolicitudMantenimiento (@id varchar(100), @fecha date, @nombre varchar(255), @telefono varchar(11), @contactoAdicional varchar(255),
											@urgencia varchar(12), @areaTrabajo varchar(50), @lugarTrabajo varchar(255), @descripcion varchar(500), @usuario varchar(50))
as
	update SolicitudMantenimiento set ultimoAgregado = 0 where areaTrabajo = @areaTrabajo
	insert into SolicitudMantenimiento values (@id, @fecha, @nombre, @telefono, @contactoAdicional, @urgencia, @areaTrabajo, @lugarTrabajo, @descripcion, 'Pendiente', 1, @usuario)

go

create procedure AprobarSolicitudMantenimiento(@id varchar(100), @fecha date, @usuario varchar(50), @observaciones varchar(500))
as
	update SolicitudMantenimiento set estado = 'Aprobado' where id = @id
	insert into SolicitudMantenimientoAprobada(idSolicitud, fechaAprobacion, personaAsignada, observacionesAprob) values (@id, @fecha, @usuario, @observaciones)
go
drop procedure AprobarSolicitudMantenimiento

create procedure RechazarSolicitudMantenimiento(@id varchar(100), @motivo varchar(500))
as
	update SolicitudMantenimiento set estado = 'Rechazado' where id = @id
	insert into SolicitudMantenimientoRechazada values(@id, @motivo)
go

create procedure analizarSolicitud(@id varchar(100), @insumos varchar(500), @costo varchar(100), @observaciones varchar(500), @archivo varbinary(max), @nombreArchivo varchar(255))
as
	IF @archivo is not null
	begin
		declare @newid uniqueidentifier = newid()
		insert into DocumentosMantenimiento values(@newid, @archivo, @nombreArchivo)
	end
	update SolicitudMantenimiento set estado = 'En proceso' where id = @id

	update SolicitudMantenimientoAprobada set insumos = @insumos, costoEstimado = @costo, observacionesAnalisis = @observaciones, documento = @newid where idSolicitud = @id

go

create procedure finalizarSolicitud(@id varchar(100), @periodo varchar(100), @observaciones varchar(500))
as
	update SolicitudMantenimiento set estado = 'Finalizado' where id = @id

	update SolicitudMantenimientoAprobada set periodoEjecucion = @periodo, observacionesFinales = @observaciones where idSolicitud = @id

go

select * from DocumentosMantenimiento
select cast('sAS' AS varbinary(max))
drop procedure analizarSolicitud
drop procedure CrearSolicitudMantenimiento
select * from SolicitudMantenimientoRechazada
select * from DocumentosMantenimiento
select fecha, nombreSolicitante, unidad, telefono, contactoAdicional, urgencia, areaTrabajo, lugarTrabajo, descripcionTrabajo from SolicitudMantenimiento

select * from SolicitudMantenimientoAprobada
delete from SolicitudMantenimientoAprobada
select CONCAT(nombre, ' ', apellido1, ' ', apellido2) from Usuarios
select * from Usuarios

update SolicitudMantenimiento set Estado = 'Pendiente'


select sm.NombreSolicitante, sm.lugarTrabajo, sm.descripcionTrabajo, sma.observacionesAprob, sma.observacionesAnalisis, sm.usuario, sma.documento from  SolicitudMantenimiento as sm join SolicitudMantenimientoAprobada as sma on sm.id = sma.idSolicitud where sm.id

select * from DocumentosMantenimiento

select id, nombre from DocumentosMantenimiento where id = '0bf076d5-9f59-431a-8d78-5bc520a8159d'