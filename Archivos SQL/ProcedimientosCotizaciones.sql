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

create procedure agregarAnalisisCotizacion(@descripcion varchar(255), @metodo varchar(255), @precio int, @acreditacion tinyint, @tipoanalisis varchar(100))
as
	insert into Analisis values(@descripcion, @tipoanalisis, @metodo, @precio, @acreditacion)
go

create procedure modificarAnalisisCotizacion(@descripcionNueva varchar(255), @descripcionVieja varchar(255), @metodo varchar(255), @precio int, @acreditacion tinyint, @tipoanalisis varchar(100))
as
	update Analisis set descripcion = @descripcionNueva, metodo = @metodo, precio = @precio, acreditacion = @acreditacion where descripcion = @descripcionVieja and tipoAnalisis = @tipoanalisis
go

create procedure eliminarAnalisisCotizacion(@descripcion varchar(255), @tipoAnalisis varchar(100))
as
	delete from Analisis where descripcion = @descripcion and tipoAnalisis = @tipoAnalisis
go

create procedure agregarCotizacion(@anno int, @licitacion bit, @observaciones varchar(600), @precioMuestreo float ,@descuento float, 
									@gastosAdm float, @fechaLimite date, @fechaSolicitud date, @fechaRespuesta date, @saldoAfavor float ,@granTotal float, @moneda char(1),
									@cotizador nvarchar(50), @cliente varchar(255), @precioMuestra float, @diasEntregaRes int, @subTotal float, @idgenerado int output)
as 
	insert into Cotizacion(id, anno, licitacion, observaciones, precioMuestreo, descuento, gastosAdm, fechaCotizacion, fechaSolicitud, fechaRespuesta, saldoAfavor, granTotal, moneda, cotizador, cliente, precioMuestra, diasEntregaRes, subTotal)
	values(0, @anno, @licitacion, @observaciones, @precioMuestreo, @descuento, @gastosAdm, @fechaLimite, @fechaSolicitud, 
			@fechaRespuesta, @saldoAfavor, @granTotal, @moneda, @cotizador, @cliente, @precioMuestra, @diasEntregaRes, @subTotal)

	select @idgenerado = @@IDENTITY
go
drop procedure agregarCotizacion

select tipo from tipoAnalisis
select * from Analisis

select descripcion as 'Análisis', metodo as 'Método', concat('$', precio) as 'Precio' from Analisis where tipoAnalisis = 'Aceites y grasas'

select * from Cotizacion
go

SET IDENTITY_INSERT CELEQ.dbo.Cotizacion ON
go

create trigger consecutivoCotizacion
on Cotizacion
instead of Insert
AS

declare @id int
declare @anno int
declare @licitacion bit
declare @observaciones varchar(600)
declare @precioMuestreo float
declare @descuento float
declare @gastosAdm float
declare @fechaLimite date
declare @fechaSolicitud date
declare @fechaRespuesta date
declare @saldoAfavor float
declare @granTotal float
declare @moneda char(1)
declare @cotizador nvarchar(50)
declare @cliente varchar(255)
declare @precioMuestra float
declare @diasEntregaRes int
declare @subTotal float

select @anno = anno from inserted

select @licitacion = licitacion from inserted
select @observaciones = observaciones from inserted
select @precioMuestreo = precioMuestreo from inserted
select @descuento = descuento from inserted
select @gastosAdm = gastosAdm from inserted
select @fechaLimite = fechaCotizacion from inserted
select @fechaSolicitud = fechaSolicitud from inserted
select @fechaRespuesta = fechaRespuesta from inserted
select @saldoAfavor = saldoAfavor from inserted
select @granTotal  = granTotal  from inserted
select @moneda = moneda from inserted
select @cotizador  = cotizador  from inserted
select @cliente  = cliente  from inserted
select @precioMuestra  = precioMuestra  from inserted
select @diasEntregaRes = diasEntregaRes from inserted
select @subTotal = subTotal from inserted

if not exists (select id, anno from Cotizacion where anno = @anno)
	set @id = 1
else
	select @id =  max(id)+1 from Cotizacion where anno = @anno

insert into Cotizacion (id, anno, licitacion, observaciones, precioMuestreo, descuento, gastosAdm, fechaCotizacion, fechaSolicitud, fechaRespuesta, saldoAfavor, granTotal, moneda, cotizador, cliente, precioMuestra, diasEntregaRes, subTotal)
values(@id, @anno, @licitacion, @observaciones, @precioMuestreo, @descuento, @gastosAdm, @fechaLimite, @fechaSolicitud, 
@fechaRespuesta, @saldoAfavor, @granTotal, @moneda, @cotizador, @cliente, @precioMuestra, @diasEntregaRes, @subTotal)

go

delete from CotizacionAnalisis
delete from Cotizacion
select * from Cotizacion order by anno, id


insert into Cotizacion(id, anno, licitacion, observaciones, precioMuestreo, descuento, gastosAdm, fechaCotizacion, fechaSolicitud, fechaRespuesta, saldoAfavor, granTotal, moneda, cotizador, cliente, precioMuestra, diasEntregaRes, subTotal)
values(0, 2021, 0, 'hola', 50, 7, 15, '2019-01-05', '2019-01-01', '2019-01-05', 0, 500, 'd', 'jorge', '5utrsutrs', 43, 4, 6)
select @@IDENTITY

select * from ClienteCotizacion
insert into ContactoCotizacion values('5utrsutrs', 'Jorge', 1)
insert into ContactoCotizacion values('ewdew', 'Jorge', 1) 
insert into ContactoCotizacion values('jajajajaja', 'Jorge', 1) 
insert into ContactoCotizacion values('lol', 'Jorge', 1) 
insert into ContactoCotizacion values('thicc', 'Jorge', 1) 
insert into ContactoCotizacion values('xipaom', 'Jorge', 1) 
select * from ContactoCotizacion
delete from ClienteCotizacion

select * from puestos

insert into puestos values('Técnico')
