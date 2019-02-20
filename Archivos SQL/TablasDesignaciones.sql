use CELEQ
select * from usuarios
create table designacionAsistencia
(
	id				int			IDENTITY(1,1)		primary key,
	ano				varchar(4),
	ciclo			varchar(10),
	fechaInicio		date,
	fechafinal		date,
	convocatoria	varchar(10),
	horas			int,
	modalidad		varchar(10),
	monto			int,
	inopia			bit,
	motivoInopia	varchar(500),
	tramitado		bit,
	observaciones	varchar(500),
	idEstudiante	varchar(30),
	presupuesto		varchar(12),
	encargado		varchar(100),
	unidad			varchar(100),
	adHonorem		bit

	foreign key (idEstudiante) references estudiante(id),
	foreign key (presupuesto) references presupuesto(codigo),
	foreign key (unidad) references unidad(nombre),
	foreign key (encargado) references responsable(nombre)
)
drop table designacionAsistencia
create table estudiante
(
	id				varchar(30)			NOT NULL		PRIMARY KEY,
	tipoId			varchar(100),
	nombre			varchar(255),
	apellido1		varchar(255),
	apellido2		varchar(255),
	correo			varchar(255),
	celular			varchar(255),
	telefonoFijo	varchar(255),
	carrera			varchar(255)
)
drop table estudiante
create table presupuesto
(
	codigo			varchar(12)			NOT NULL		PRIMARY KEY,
	nombre			varchar(560)
)

select * from Localizaciones

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
	numero			varchar(20),
	idDesignacion	int,
	ultimoAgregado	bit

	foreign key (idDesignacion) references designacionAsistencia(id)
)
drop table p9

create table responsable
(
	nombre		varchar(100)		primary key
)

select * from estudiante
delete from designacionAsistencia
select tipoId, nombre, apellido1, apellido2, correo, celular, telefonoFijo, carrera from estudiante where id = '116980153'
select * from designacionAsistencia

select * from responsable
insert into responsable values('Daniel Chavarría')