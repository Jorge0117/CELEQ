CREATE TABLE listaMaestra
(
	Codigo			VARCHAR(100)	NOT NULL,
	Ver				VARCHAR(10)		NOT NULL,
	Nombre			VARCHAR(500),
	FechaEntV		DATE,
	masNuevo		Bit

	PRIMARY KEY(Codigo, Ver)
)
drop table listaMaestra

CREATE TABLE listaMaestraActual
(
	Codigo			VARCHAR(100)	NOT NULL,
	Ver				VARCHAR(10)		NOT NULL,
	Nombre			VARCHAR(500),
	FechaEntV		DATE,
	idlistaM		VARCHAR(100),
	verListaM		VARCHAR(10)

	PRIMARY KEY(Codigo,Ver),
	FOREIGN KEY(idListaM,verListaM)	REFERENCES	listaMaestra(Codigo,Ver) ON UPDATE CASCADE
)
drop table listaMaestraActual

select * from listaMaestra

delete from listaMaestra

