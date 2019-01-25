use CELEQ

create table designacionAsistencia
(
	id				int			IDENTITY(1,1)		primary key,
	ano				varchar(4),
	ciclo			varchar(3),
	fechaInicio		date,
	fechafinal		date,
	convocatoria	varchar(10),
	horas			int,
	modalidad		varchar(3),
	monto			int,
	inopia			bit,
	motivoInopia	varchar(500),
	tramitado		bit,
	observaciones	varchar(500),
	carne			varchar(6),
	presupuesto		varchar(12),

	foreign key (carne) references estudiante(carne),
	foreign key (presupuesto) references presupuesto(codigo) 
)

create table estudiante
(
	carne			varchar(6)			NOT NULL		PRIMARY KEY,
	nombre			varchar(255),
	apellido1		varchar(255),
	apellido2		varchar(255),
	correo			varchar(255),
	celular			varchar(255),
	telefonoFijo	varchar(255),
	carrera			varchar(255)
)

create table presupuesto
(
	codigo			varchar(12)			NOT NULL		PRIMARY KEY,
	nombre			varchar(255)
)

create table montoHoras
(
	Tipo		varchar(3),
	monto		int
)

create table p9
(
	id				uniqueidentifier		ROWGUIDCOL		NOT NULL UNIQUE,
	documento		varbinary(max)			FILESTREAM		NULL,
	nombre			varchar(255),
	numero			int,
	idDesignacion	int,

	foreign key (idDesignacion) references designacionAsistencia(id)
)
