use Regencia
create procedure AgregarReactivo(@Nombre varchar(255), @Pureza varchar(100), @Cantidad float,
									@Estado varchar(10), @Estante varchar(10))
as
		Insert into Reactivo(Nombre, Pureza, Cantidad, Estado, Estante)
		Values (@Nombre, @Pureza, @Cantidad, @Estado, @Estante)
go


create procedure AgregarCristaleria(@Nombre varchar(255), @Material varchar(255), @Cantidad int,
									@Capacidad varchar(255))
as
		Insert into Cristaleria(Nombre, Material, Capacidad, Cantidad)
		Values(@Nombre, @Material, @Capacidad, @Cantidad)
go

create procedure ModificarReactivo(@NombreNuevo varchar(255), @PurezaNueva varchar(100), @Cantidad float,
									@Estado varchar(10), @Estante varchar(10), @Nombre varchar(255), @Pureza varchar(100))
as
		update Reactivo
		set Nombre = @NombreNuevo, Pureza = @PurezaNueva, Cantidad = @Cantidad, Estado = @Estado, Estante = @Estante
		where Nombre = @Nombre and Pureza = @Pureza
go

create procedure ModificarCristaleria(@NombreNuevo varchar(255), @MaterialNuevo varchar(255), @Cantidad int,
									@CapacidadNueva varchar(255), @Nombre varchar(255), @Material varchar(255), @Capacidad varchar(255))
as
		update Cristaleria
		set Nombre = @NombreNuevo, Material = @MaterialNuevo, Cantidad = @Cantidad, Capacidad = @CapacidadNueva
		where Nombre = @Nombre and Material = @Material and Capacidad = @Capacidad

select * from Reactivo

go

create procedure ultimoAgregado(@idSolicitud varchar(130) output)
as
	select @idSolicitud = id from Solicitud where ultimoAgregado = 1;
	if(@idSolicitud is null)
	BEGIN
		set @idSolicitud = '-1'
	END

go


create procedure agregarSolicitud(@Id varchar (130), @FechSol date, @nombreSol varchar(255), @nombreEnc varchar(255),
									@correoSol varchar(255), @Unidad varchar(100), @Observacion varchar(255), @usuario nvarchar(50))
as
	update Solicitud
	set ultimoAgregado = 0 where ultimoAgregado = 1

	Insert into Solicitud
	values(@Id, @FechSol, null, 'Solicitado', @nombreSol, @nombreEnc, @correoSol, @Unidad, null, @Observacion ,1, @usuario)

go

create procedure agregarSolicitudReactivo(@IdSolicitud varchar(130), @Reactivo varchar(255), @Pureza varchar(100), @Cantidad float)
as
	Insert into SolicitudReactivo
	values(@IdSolicitud, @Reactivo, @Pureza, @Cantidad)

	update Reactivo
	set Cantidad = Cantidad - @Cantidad
	where Nombre = @Reactivo and Pureza = @Pureza

go

create procedure agregarSolicitudCristaleria(@IdSolicitud varchar(130), @Cristaleria varchar(255), @Material varchar(100), @Capacidad varchar(255), @Cantidad int)
as
	Insert into SolicitudCristaleria
	values(@IdSolicitud, @Cristaleria, @Material, @Capacidad, @Cantidad)

	update Cristaleria
	set Cantidad = Cantidad - @Cantidad
	where Nombre = @Cristaleria and Material = @Material and Capacidad = @Capacidad

go

create procedure denegarReactivo(@IdSolicitud varchar(130), @Reactivo varchar(255), @Pureza varchar(100))
as
	declare @cantidad int
	select @cantidad = Cantidad
	from SolicitudReactivo
	where IdSolicitud = @IdSolicitud and NombreReactivo = @Reactivo and Pureza = @Pureza

	delete from SolicitudReactivo
	where IdSolicitud = @IdSolicitud and NombreReactivo = @Reactivo and Pureza = @Pureza

	update Reactivo
	set Cantidad = Cantidad + @cantidad
	where Nombre = @Reactivo and Pureza = @Pureza
go

create procedure denegarCristaleria(@IdSolicitud varchar(130), @Cristaleria varchar(255), @Material varchar(100), @Capacidad varchar(255))
as
	declare @cantidad int
	select @cantidad = Cantidad
	from SolicitudCristaleria
	where IdSolicitud = @IdSolicitud and NombreCristaleria = @Cristaleria and Material = @Material and Capacidad = @Capacidad

	delete from SolicitudCristaleria
	where IdSolicitud = @IdSolicitud and NombreCristaleria = @Cristaleria and Material = @Material and Capacidad = @Capacidad

	update Cristaleria
	set Cantidad = Cantidad + @cantidad
	where Nombre = @Cristaleria and Material = @Material and Capacidad = @Capacidad
go
