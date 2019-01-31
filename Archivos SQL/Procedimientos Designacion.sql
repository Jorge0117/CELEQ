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
									@presupuesto varchar(12), @encargado nvarchar(50), @unidad varchar(100) ,@id int output)
as
	insert into designacionAsistencia(ano, ciclo, fechaInicio, fechaFinal, convocatoria, horas, modalidad, monto, inopia, motivoInopia, tramitado, observaciones, idEstudiante, presupuesto, encargado, unidad)
	values(@ano, @ciclo, @fechaIni, @fechaFin, @convocatoria, @horas, @modalidad, @monto, @inopia, @motivoInopia, @tramitado, @observaciones, @idEstudiante, @presupuesto, @encargado, @unidad)

	select top 1 @id = id FROM designacionAsistencia ORDER BY id DESC 
go

create procedure agregarP9(@documento varbinary(max), @nombre varchar(255), @numero int, @idDesignacion int)
as
	declare @id uniqueidentifier = newid()
	insert into p9 values(@id, @documento, @nombre, @numero, @idDesignacion)
go

SELECT TOP 1 id FROM designacionAsistencia ORDER BY id DESC 

select * from designacionAsistencia
select nombre, apellido1, apellido2, correo, celular, telefonofijo, carrera from estudiante

insert into designacionAsistencia(ano) values (2022)
delete from designacionAsistencia

select * from montoHoras

select monto from montoHoras where tipo = 'HE'
/*M�todo para agregar un nuevo presupuesto a la base de datos*/
CREATE PROCEDURE agregarPresupuesto(@codigo varchar(12), @nombre varchar(255),@estado bit OUTPUT) as
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

create procedure modificarPresupuesto(@codigoViejo varchar(12), @codigo varchar(12), @nombre varchar(255)) as
	begin
		update presupuesto
		set presupuesto.codigo = @codigo, presupuesto.nombre = @nombre
		where presupuesto.codigo = @codigoViejo;
	end
go

create procedure eliminarPresupuesto(@codigo varchar(12)) as
	begin
		delete from presupuesto 
		where presupuesto.codigo = @codigo;
	end
go