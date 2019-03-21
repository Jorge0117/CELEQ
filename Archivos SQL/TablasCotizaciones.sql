CREATE TABLE ClienteCotizacion
(
	nombre		VARCHAR(255)	PRIMARY KEY NOT NULL,
	telefono	VARCHAR(20),
	telefono2	VARCHAR(20),
	correo		VARCHAR(255),
	fax			VARCHAR(20),
	direccion	VARCHAR(255)						
)
drop table ClienteCotizacion
CREATE TABLE ContactoCotizacion
(
	nombreCliente		VARCHAR(255),
	atencionDe			VARCHAR(255),
	ultimoAgregado		BIT
	PRIMARY KEY(nombreCliente, atencionDe)

	FOREIGN KEY(nombreCliente)	REFERENCES ClienteCotizacion(nombre) on update cascade
)
drop table ContactoCotizacion
CREATE TABLE Cotizacion
(
	consecutivo		VARCHAR(100)	PRIMARY KEY NOT NULL,
	licitacion		BIT,
	observaciones	VARCHAR(600),
	precioMuestreo	FLOAT,
	descuento		FLOAT,
	gastosAdm		FLOAT,
	fechaLimite		DATE,
	fechaSolicitud	DATE,
	fechaRespuesta	DATE,
	saldoAfavor		FLOAT,
	granTotal		FLOAT,
	moneda			CHAR,
	cotizador		NVARCHAR(50),
	cliente			VARCHAR(255)

	FOREIGN KEY(cotizador)	REFERENCES Usuarios(nombreUsuario),
	FOREIGN KEY(cliente)	REFERENCES ClienteCotizacion(nombre)
)
drop table Cotizacion
CREATE TABLE Gira
(
	id						INT		IDENTITY(1,1)	PRIMARY KEY,
	horasMuestreo			INT,
	cantidadProfesionales	INT,
	nochesAlojamiento		INT,
	cantidadTecnicos		INT,
	gastoTotal				FLOAT,
	provincia				VARCHAR(100),
	localidad				VARCHAR(100),
	idCotizacion			VARCHAR(100)

	FOREIGN KEY(idCotizacion)	REFERENCES Cotizacion(consecutivo)	
)
drop table Gira
CREATE TABLE tipoAnalisis
(
	tipo	VARCHAR(100)	PRIMARY KEY NOT NULL
)

CREATE TABLE Muestra
(
	id					INT		IDENTITY(1,1)	PRIMARY KEY,
	especifique			VARCHAR(100),
	empaque				BIT,
	sellada				BIT,
	numeroMuestras		INT,
	cantidadNecesaria	VARCHAR(50),
	tipoAnalisis		VARCHAR(100)

	FOREIGN KEY(tipoAnalisis) REFERENCES tipoAnalisis(tipo)
)

CREATE TABLE Analisis
(
	descripcion			VARCHAR(255)	PRIMARY KEY NOT NULL,
	metodo				VARCHAR(255),
	precio				INT,
	acreditacion		TINYINT,
	tipoAnalisis		VARCHAR(100)

	FOREIGN KEY(tipoAnalisis) REFERENCES tipoAnalisis(tipo)
)

CREATE TABLE Localizaciones
(
	provincia		VARCHAR(100),
	canton			VARCHAR(100),
	localidad		VARCHAR(100),
	distancia		FLOAT,
	hospedaje		FLOAT,
	PRIMARY KEY(provincia,canton,localidad)
)   

CREATE TABLE precioGiras
(
	id					INT		IDENTITY(1,1)	PRIMARY KEY,
	valorKilometro		FLOAT,
	valorTecnico		FLOAT,
	valorProfesional	FLOAT
)

CREATE TABLE CotizacionAnalisis
(
	consecutivo		VARCHAR(100)	NOT NULL,
	idAnalisis		VARCHAR(255)	NOT NULL,

	PRIMARY KEY(consecutivo,idAnalisis),
	FOREIGN KEY(consecutivo)	REFERENCES	Cotizacion(consecutivo),
	FOREIGN KEY(idAnalisis)		REFERENCES Analisis(descripcion)
)
drop table CotizacionAnalisis

CREATE TABLE Feriados
(
	id					INT		IDENTITY(1,1)	PRIMARY KEY,
	descripcion		VARCHAR(200),
	fechaInicio		DATE,
	fechaFinal		DATE
)
drop table Feriados

insert into Feriados VALUES('D�a 1','2019/04/03', '2019/04/03')
insert into Feriados VALUES('D�a 2','2019/04/03', '2019/04/15')

