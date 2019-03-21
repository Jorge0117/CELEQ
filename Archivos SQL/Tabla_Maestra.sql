CREATE TABLE listaMaestra
(
	Codigo			VARCHAR(100)	NOT NULL,
	Ver				INT				NOT NULL,
	Nombre			VARCHAR(500),
	FechaEntV		DATE

	PRIMARY KEY(Codigo, Ver)
)

CREATE TABLE listaMaestraActual
(
	Codigo			VARCHAR(100)	NOT NULL,
	Ver				INT				NOT NULL,
	Nombre			VARCHAR(500),
	FechaEntV		DATE

	PRIMARY KEY(Codigo, Ver)
)