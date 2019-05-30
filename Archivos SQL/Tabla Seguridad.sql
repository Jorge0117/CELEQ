CREATE TABLE permiso 
(
	usuario										NVARCHAR(50)	PRIMARY KEY		NOT NULL,
	archivoUnidades								BIT		DEFAULT 0,
	archivoUsuarios								BIT		DEFAULT 0,
	regenciaRealizarSolicitud					BIT		DEFAULT 0,
	regenciaInventario							BIT		DEFAULT 0,
	regenciaVerSolicitudesPendienteHistorico	BIT		DEFAULT 0,
	regenciaVerSolicitudesRealizadas			BIT		DEFAULT 0,
	mantenimientoRealizarSolicitud				BIT		DEFAULT 0,
	mantenimientoVerSolicitudes					BIT		DEFAULT 0,
	mantenimientoAnalizarSolicitud				BIT		DEFAULT 0,
	mantenimientoFinalizarSolicitud				BIT		DEFAULT 0,
	manteniminetoHistoricoSolicitudes			BIT		DEFAULT 0,
	regimenBecarioPresupuesto					BIT		DEFAULT 0,
	regimenBecarioDesignaciones					BIT		DEFAULT 0,
	regimenBecarioResponsables					BIT		DEFAULT 0,
	regimenBecarioAranceles						BIT		DEFAULT 0,
	regimenBecarioEstudiantes					BIT		DEFAULT 0,
	regimenBecarioReportes						BIT		DEFAULT 0,
	vinculoExternoCotizaciones					BIT		DEFAULT 0,
	vinculoExternoPrecioGiras					BIT		DEFAULT 0,
	vinculoExternoLocalizaciones				BIT		DEFAULT 0

	FOREIGN KEY(usuario)	REFERENCES Usuarios(nombreUsuario)
)

