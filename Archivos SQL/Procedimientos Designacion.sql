use CELEQ

create procedure agregarEstudiante (@id varchar(30), @tipoId varchar(100), @nombre varchar(255), @apellido1 varchar(255), @apellido2 varchar(255),
									@correo varchar(255), @celular varchar(255), @telefonoFijo varchar(255), @carrera varchar(255))
as
	insert into estudiante values(@id, @tipoId, @nombre, @apellido1, @apellido2, @correo, @celular, @telefonoFijo, @carrera)
go

create procedure modificarEstudiante (@id varchar(30), @tipoId varchar(100), @nombre varchar(255), @apellido1 varchar(255), @apellido2 varchar(255),
									@correo varchar(255), @celular varchar(255), @telefonoFijo varchar(255), @carrera varchar(255))
as
	update estudiante set tipoId = @tipoId, nombre = @nombre, apellido1 = @apellido1, apellido2 = @apellido2, correo = @correo, celular = @celular, telefonofijo = @telefonoFijo, carrera = @carrera
	where id = @id
go

create procedure agregarDesignacion(@ano varchar(4), @ciclo varchar(10), @fechaIni date, @fechaFin date, @convocatoria varchar(10), @horas int, @modalidad varchar(10), 
									@monto int,  @inopia bit, @motivoInopia varchar(500), @tramitado bit, @observaciones varchar(500), @idEstudiante varchar(30),
									@presupuesto varchar(12), @encargado varchar(255), @unidad varchar(100), @adHonorem bit ,@id int output)
as
	insert into designacionAsistencia(ano, ciclo, fechaInicio, fechaFinal, convocatoria, horas, modalidad, monto, inopia, motivoInopia, tramitado, observaciones, idEstudiante, presupuesto, encargado, unidad, adHonorem)
	values(@ano, @ciclo, @fechaIni, @fechaFin, @convocatoria, @horas, @modalidad, @monto, @inopia, @motivoInopia, @tramitado, @observaciones, @idEstudiante, @presupuesto, @encargado, @unidad, @adHonorem)

	select top 1 @id = id FROM designacionAsistencia ORDER BY id DESC 
go
select * from designacionAsistencia


create procedure editarDesignacion(@id int, @responsable varchar(255), @unidad varchar(100), @horas int, @fechaFinal date, @Observaciones varchar(500), @tramitado bit)
as
	update designacionAsistencia set encargado = @responsable, unidad = @unidad, horas = @horas, fechafinal = @fechaFinal, observaciones = @Observaciones, tramitado = @tramitado where id = @id
go

create procedure agregarP9(@documento varbinary(max), @nombre varchar(255), @numero varchar(20), @idDesignacion int)
as
	update p9 set ultimoAgregado = 0 where idDesignacion = @idDesignacion 
	declare @id uniqueidentifier = newid()
	insert into p9 values(@id, @documento, @nombre, @numero, @idDesignacion, 1)
go
drop procedure agregarP9

SELECT TOP 1 id FROM designacionAsistencia ORDER BY id DESC 


select * from p9
delete from p9 where idDesignacion = 1
select * from designacionAsistencia
delete from designacionAsistencia where id = 1
select numero, nombre from p9 where idDesignacion  = 1 order by numero desc
select *
select D.idEstudiante as Identificación, CONCAT(E.nombre, ' ', E.apellido1, ' ', E.apellido2) as Nombre, D.ano as Año, D.ciclo as Ciclo, D.modalidad as Modalidad, E.carrera as Carrera, D.encargado as Encargado, D.id from designacionAsistencia D join estudiante E on D.idEstudiante = E.id


select * from designacionAsistencia
select nombre, apellido1, apellido2, correo, celular, telefonofijo, carrera from estudiante

insert into designacionAsistencia(ano) values (2022)
delete from designacionAsistencia

select * from montoHoras

select monto from montoHoras where tipo = 'HE'
/*M�todo para agregar un nuevo presupuesto a la base de datos*/
CREATE PROCEDURE agregarPresupuesto(@codigo varchar(12), @nombre varchar(560),@estado bit OUTPUT) as
	BEGIN
	BEGIN TRY
		INSERT INTO presupuesto VALUES(@codigo, @nombre)
		SET @estado=1 
	END TRY
	BEGIN CATCH
		/*En cualquier otro caso se devuelve el mensaje de error*/
		SET @estado=ERROR_MESSAGE()
	END CATCH
	END
GO

drop procedure agregarPresupuesto
drop procedure modificarPresupuesto

create procedure modificarPresupuesto(@codigoViejo varchar(12), @codigo varchar(12), @nombre varchar(560)) as
	begin
		update presupuesto
		set presupuesto.codigo = @codigo, presupuesto.nombre = @nombre
		where presupuesto.codigo = @codigoViejo;
	end
go

CREATE PROCEDURE agregarResponsable(@nombre VARCHAR(100)) AS
	BEGIN
		INSERT INTO responsable VALUES(@nombre)
	END
GO


select getDate()
select * from p9
select * from designacionasistencia

select ano, ciclo, fechainicio, fechafinal, convocatoria, horas, modalidad, inopia, motivoInopia, tramitado, observaciones, idestudiante, encargado, unidad from designacionasistencia