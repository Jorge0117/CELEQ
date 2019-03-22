CREATE PROCEDURE agregarListaMaestra(@codigo VARCHAR(100), @version VARCHAR(10), @nombre VARCHAR(500), @fechaEV DATE)
AS
BEGIN
	insert into ListaMaestra VALUES(@codigo, @version, @nombre, @fechaEV,1)
END
GO

CREATE PROCEDURE modificarListaMaestra(@codigo VARCHAR(100), @codigoN VARCHAR(100), @version VARCHAR(10), @versionN VARCHAR(10), @nombre VARCHAR(500), @fechaEV DATE)
AS
BEGIN
	update ListaMaestra
	set codigo = @codigoN, nombre = @nombre, fechaEntV = @fechaEV, ver = @versionN
	where codigo = @codigo and ver = @version
END
GO

CREATE PROCEDURE actualizarEnListaMaestra(@codigo VARCHAR(100), @versionV VARCHAR(10), @version VARCHAR(10), @nombre VARCHAR(500), @fechaEV DATE)
AS 
BEGIN
	insert into listaMaestra VALUES(@codigo, @version, @nombre, @fechaEV,1)
	update listaMaestra
	set masNuevo = 0
	where codigo = @codigo and ver = @versionV
END
GO 

drop procedure actualizarEnListaMaestra
drop procedure modificarListaMaestra
drop procedure agregarListaMaestra