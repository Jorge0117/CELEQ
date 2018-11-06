
create procedure CrearSolicitudMantenimiento (@id varchar(100), @fecha date, @nombre varchar(255), @unidad varchar(255), @telefono varchar(11), @contactoAdicional varchar(255),
											@urgencia varchar(12), @areaTrabajo varchar(50), @lugarTrabajo varchar(255), @descripcion varchar(500))
as
	update SolicitudMantenimiento set ultimoAgregado = 0 where areaTrabajo = @areaTrabajo
	insert into SolicitudMantenimiento values (@id, @fecha, @nombre, @unidad, @telefono, @contactoAdicional, @urgencia, @areaTrabajo, @lugarTrabajo, @descripcion, 'Pendiente', 1)

go

drop procedure CrearSolicitudMantenimiento
