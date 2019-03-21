create procedure agregarFeriado(@descripcion VARCHAR(200), @fechaI DATE, @fechaF DATE)
AS
BEGIN
	insert into Feriados VALUES(@descripcion, @fechaI, @fechaF)
END
GO

CREATE PROCEDURE modificarFeriado(@descripcionV VARCHAR(200), @descripcionN VARCHAR(200), @fechaI DATE, @fechaF DATE)
AS
BEGIN
	UPDATE Feriados
	SET descripcion = @descripcionN, fechaInicio = @fechaI, fechaFinal = @fechaF
	WHERE descripcion = @descripcionV
END
GO

CREATE PROCEDURE eliminarFeriado(@descripcion VARCHAR(200))
AS
BEGIN
	DELETE FROM Feriados
	WHERE descripcion = @descripcion
END
GO