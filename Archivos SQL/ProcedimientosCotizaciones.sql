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

DELETE FROM Localizaciones
WHERE provincia = 'Alajuela' AND canton = 'Grecia' AND localidad = 'Grecia'

select * from Localizaciones