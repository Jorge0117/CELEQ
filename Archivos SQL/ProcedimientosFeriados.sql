create procedure agregarFeriado(@descripcion VARCHAR(200), @fechaI DATE, @fechaF DATE)
AS
BEGIN
	insert into Feriados VALUES(@descripcion, @fechaI, @fechaF)
END
GO

CREATE PROCEDURE modificarFeriado(@id INT, @descripcion VARCHAR(200), @fechaI DATE, @fechaF DATE)
AS
BEGIN
	UPDATE Feriados
	SET descripcion = @descripcion, fechaInicio = @fechaI, fechaFinal = @fechaF
	WHERE id = @id
END
GO

CREATE PROCEDURE eliminarFeriado(@id INT)
AS
BEGIN
	DELETE FROM Feriados
	WHERE id = @id
END
GO
drop procedure eliminarFeriado

select * from Feriados