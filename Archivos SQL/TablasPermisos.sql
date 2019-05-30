CREATE TABLE Grupos
(
	id				INT	IDENTITY(1,1) PRIMARY KEY,
	descripcion		VARCHAR(300)
)

drop table Grupos

CREATE TABLE Permisos
(
	id				INT	IDENTITY(1,1) PRIMARY KEY,
	descripcion		VARCHAR(300)
)

drop table permisos

Create Table GruposPermisos
(
	grupo		INT				NOT NULL,
	permiso		INT				NOT NULL	 	

	PRIMARY KEY(grupo,permiso)
	FOREIGN KEY(grupo)		REFERENCES Grupos(id) ON UPDATE CASCADE ON DELETE CASCADE,
	FOREIGN KEY(permiso)	REFERENCES Permisos(id) ON UPDATE CASCADE ON DELETE CASCADE
)

DROP TABLE GruposPermisos

Create Table UsuariosGrupos
(
	usuario		NVARCHAR(50)	NOT NULL,
	grupo		INT				NOT NULL

	PRIMARY KEY(usuario,grupo),
	FOREIGN KEY(usuario)	REFERENCES Usuarios(nombreUsuario) ON UPDATE CASCADE ON DELETE CASCADE,
	FOREIGN KEY(grupo)		REFERENCES Grupos(id) ON UPDATE CASCADE ON DELETE CASCADE
)

drop TABLE UsuariosGrupos

CREATE PROCEDURE AgregarPermiso(@descripcion AS VARCHAR(300))
AS
BEGIN
	INSERT INTO Permisos values(@descripcion)
END 
GO

CREATE PROCEDURE ModificarPermiso(@id AS INT, @descripcion AS VARCHAR(300))
AS
BEGIN
	UPDATE Permisos
	SET descripcion = @descripcion
	WHERE id = @id
END 
GO

CREATE PROCEDURE EliminarPermiso(@id AS INT)
AS
BEGIN
	DELETE FROM Permisos
	WHERE id = @id
END 
GO

CREATE PROCEDURE AgregarGrupo(@descripcion AS VARCHAR(300))
AS
BEGIN
	INSERT INTO Grupos values(@descripcion)
END 
GO

CREATE PROCEDURE ModificarGrupo(@id AS INT, @descripcion AS VARCHAR(300))
AS
BEGIN
	UPDATE Grupos
	SET descripcion = @descripcion
	WHERE id = @id
END 
GO

CREATE PROCEDURE EliminarGrupo(@id AS INT)
AS
BEGIN
	DELETE FROM Grupos
	WHERE id = @id
END 
GO

DROP PROCEDURE ModificarGrupo
