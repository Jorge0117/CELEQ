use CELEQ

CREATE TABLE Solicitud(
	Id					varchar(130)				NOT NULL,
	FechaSolicitud		date,
	FechaAprobacion		date,
	Estado				varchar(20),
	NombreSolicitante	varchar(255),
	NombreEncargado		varchar(255),
	CorreoSolicitante	varchar(255),
	Unidad				varchar(100),
	NombreRegente		varchar(255),
	Observacion			varchar(255),
	ultimoAgregado		bit,
	UsuarioSolicitante	nvarchar(50),
	PRIMARY KEY (Id),
	FOREIGN KEY (UsuarioSolicitante) REFERENCES Usuarios(nombreUsuario)
)


CREATE TABLE Reactivo(
	Nombre				varchar(255)		NOT NULL,
	Pureza				varchar(100)		NOT NULL,
	Cantidad			float,
	Estado				varchar(10),
	Estante				varchar(10),

	PRIMARY KEY(Nombre, Pureza)
)

CREATE TABLE Cristaleria(
	Nombre				varchar(255)		NOT NULL,
	Material			varchar(255)		NOT NULL,
	Capacidad			varchar(255)		NOT NULL,

	PRIMARY KEY(Nombre, Material, Capacidad)
)
ALTER TABLE Cristaleria ADD Cantidad int
ALTER TABLE Cristaleria ADD Caja varchar(5)

CREATE TABLE SolicitudReactivo(
	IdSolicitud			varchar(130)		NOT NULL,
	NombreReactivo		varchar(255)		NOT NULL,
	Pureza				varchar(100)		NOT NULL,
	Cantidad			int,

	PRIMARY KEY(IdSolicitud, NombreReactivo),
	FOREIGN KEY(IdSolicitud) REFERENCES Solicitud(ID),
	FOREIGN KEY(NombreReactivo, Pureza) REFERENCES Reactivo(Nombre, Pureza) ON UPDATE CASCADE
)

CREATE TABLE SolicitudCristaleria(
	IdSolicitud			varchar(130)		NOT NULL,
	NombreCristaleria	varchar(255)		NOT NULL,
	Material			varchar(255)		NOT NULL,
	Capacidad			varchar(255)		NOT NULL,
	Cantidad			int,

	PRIMARY KEY(IdSolicitud, NombreCristaleria, Material, Capacidad),
	FOREIGN KEY(IdSolicitud) REFERENCES Solicitud(Id),
	FOREIGN KEY(NombreCristaleria, Material, Capacidad) REFERENCES Cristaleria(Nombre, Material, Capacidad) ON UPDATE CASCADE
)
select * from Solicitud

drop table SolicitudReactivo
drop table SolicitudCristaleria