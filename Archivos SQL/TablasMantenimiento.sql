use celeq
create table SolicitudMantenimiento(
	id					varchar(100)		NOT NULL,
	fecha				date,
	NombreSolicitante	varchar(255),
	telefono			varchar(11),
	contactoAdicional	varchar(255),
	urgencia			varchar(12),
	areaTrabajo			varchar(50),
	lugarTrabajo		varchar(255),
	descripcionTrabajo	varchar(500),
	estado				varchar(15)

	primary key (id)
)

alter table SolicitudMantenimiento add usuario nvarchar(50) foreign key(usuario) references Usuarios(nombreUsuario)
create table SolicitudMantenimientoRechazada(
	idSolicitud			varchar(100)		NOT NULL,
	motivo				varchar(500),

	primary key(idSolicitud),
	foreign key(idSolicitud) references SolicitudMantenimiento(id)
)

create table SolicitudMantenimientoAprobada(
	idSolicitud				varchar(100)		NOT NULL,
	fechaAprobacion			date,
	personaAsignada			nvarchar(50),
	observacionesAprob		varchar(500),
	recibido				varchar(255),
	insumos					varchar(500),
	costoEstimado			varchar(100),
	observacionesAnalisis	varchar(500),
	documento				uniqueidentifier	NULL,
	periodoEjecucion		varchar(100),
	observacionesFinales	varchar(500),

	primary key(idSolicitud),
	foreign key(idSolicitud) references SolicitudMantenimiento(id),
	foreign key(personaAsignada) references Usuarios(nombreUsuario),
	foreign key(documento) references DocumentosMantenimiento(id)
)

drop table SolicitudMantenimientoAprobada

create table DocumentosMantenimiento
(
	id				uniqueidentifier		ROWGUIDCOL		NOT NULL UNIQUE,
	documento		varbinary(max)			FILESTREAM		NULL,
	nombre			varchar(255)
)
drop table DocumentosMantenimiento

select * from DocumentosMantenimiento
insert into DocumentosMantenimiento values(newid(), cast('fsdwad' as varbinary(max)))
delete from DocumentosMantenimiento
select * from SolicitudMantenimientoAprobada

select fechaAprobacion from SolicitudMantenimientoAprobada

update SolicitudMantenimiento set estado = 'Pendiente'