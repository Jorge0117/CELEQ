CREATE PROCEDURE agregarLocalizacion(@provincia VARCHAR(100), @canton VARCHAR(100), @localidad VARCHAR(100), @distancia FLOAT, @hospedaje FLOAT) AS
BEGIN
	INSERT INTO Localizaciones VALUES(@provincia,@canton,@localidad,@distancia,@hospedaje)
END
GO

CREATE PROCEDURE modificarLocalizacion(@vProvincia VARCHAR(100), @vCanton VARCHAR(100), @vLocalidad VARCHAR(100), @provincia VARCHAR(100), @canton VARCHAR(100), @localidad VARCHAR(100), @distancia FLOAT, @hospedaje FLOAT) AS
BEGIN
	UPDATE Localizaciones
	SET provincia = @provincia, canton = @canton, localidad = @localidad, distancia = @distancia, hospedaje = @hospedaje
	WHERE provincia = @vProvincia AND canton = @vCanton AND localidad = @vLocalidad
END
GO

CREATE PROCEDURE eliminarLocalizacion(@provincia VARCHAR(100), @canton VARCHAR(100), @localidad VARCHAR(100)) AS
BEGIN
	DELETE FROM Localizaciones
	WHERE provincia = @provincia AND canton = @canton AND localidad = @localidad
END
GO

create procedure agregarClienteCotizacion(@nombre varchar(255), @telefono1 varchar(20), @telefono2 varchar(20), @correo varchar(255), @fax varchar(20), @direccion varchar(255), @contacto varchar(255))
as
	insert into ClienteCotizacion values(@nombre, @telefono1, @telefono2, @correo, @fax, @direccion)
	insert into ContactoCotizacion values(@nombre, @contacto, 1)
go

create procedure agregarcontactoCotizacion(@nombre varchar(255), @contacto varchar(255))
as
	update ContactoCotizacion set ultimoAgregado = 0 where nombreCliente = @nombre
	insert into ContactoCotizacion values(@nombre, @contacto, 1)
go

create procedure modificarClienteCotizacion(@nombreAnterior varchar(255), @nombreNuevo varchar(255), @telefono1 varchar(20), @telefono2 varchar(20), @correo varchar(255), @fax varchar(20), @direccion varchar(255), @contacto varchar(255))
 as

	update ClienteCotizacion set nombre = @nombreNuevo, telefono = @telefono1, telefono2 = @telefono2, correo = @correo, fax = @fax, direccion = @direccion where nombre = @nombreAnterior
	update ContactoCotizacion set ultimoAgregado = 0 where nombreCliente = @nombreNuevo
	update ContactoCotizacion set ultimoAgregado = 1 where nombreCliente = @nombreAnterior and atencionDe = @contacto
go


drop procedure modificarClienteCotizacion
select * from ClienteCotizacion
select * from ContactoCotizacion

update ContactoCotizacion set ultimoAgregado = 1 where atencionDe = 'Jorge'

update ContactoCotizacion set ultimoAgregado = 1 where nombreCliente = 'dsadsa' and atencionDe = 'Daniel'

delete from ContactoCotizacion
delete from ClienteCotizacion
