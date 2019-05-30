CREATE PROCEDURE agregarGira(@horasMuestreo int, @cantidadProfesionales int, @nochesAlojamiento int, @cantidadTecnicos int,
@gastoTotal float, @provincia varchar(100), @canton varchar(100), @localidad varchar(100), @idCotizacion int, @annoCotizacion int)
AS
INSERT INTO Gira Values(@horasMuestreo,@cantidadProfesionales,@nochesAlojamiento,@cantidadTecnicos,@gastoTotal,@provincia,@canton,
@localidad,@idCotizacion,@annoCotizacion)
GO
drop procedure agregarGira

CREATE PROCEDURE modificarGira(@horasMuestreo int, @cantidadProfesionales int, @nochesAlojamiento int, @cantidadTecnicos int,
@gastoTotal float, @provincia varchar(100), @canton varchar(100), @localidad varchar(100), @idCotizacion int, @annoCotizacion int)
AS
UPDATE Gira
SET horasMuestreo = @horasMuestreo, cantidadProfesionales = @cantidadProfesionales, nochesAlojamiento = @nochesAlojamiento,
cantidadTecnicos = @cantidadTecnicos, gastoTotal = @gastoTotal, provincia = @provincia, canton = @canton, localidad = @localidad
Where idCotizacion = @idCotizacion and annoCotizacion = @annoCotizacion
GO

select * from Cotizacion