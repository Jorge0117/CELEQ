/*Método para agregar un nuevo presupuesto a la base de datos*/
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