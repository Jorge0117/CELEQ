use CELEQ
CREATE TABLE dbo.[Usuarios]
(
	nombreUsuario NVARCHAR(50)	NOT NULL	PRIMARY KEY,
	correo varchar(255)			NOT NULL,
	nombre	varchar(100)		NOT NULL,
	apellido1 varchar(100)		NOT NULL,
	apellido2 varchar(100)		NOT NULL,
	unidad varchar(100)			NOT NULL,
	categoria varchar(255)		NOT NULL,
	passwordHash BINARY(64)		NOT NULL,
	salt UNIQUEIDENTIFIER,

	foreign key (unidad) references Unidad(nombre)
)

drop table Usuarios

create table Unidad
(
	nombre varchar(100)		NOT NULL	PRIMARY KEY,
)

alter table Unidad add encargado NVARCHAR(50)
alter table Unidad add FOREIGN KEY (encargado) REFERENCES Usuarios(nombreUsuario)

go
CREATE PROCEDURE dbo.agregarUsuario(@pLogin NVARCHAR(50), @pPassword NVARCHAR(50), @correo varchar(255),@categoria varchar(255), @unidad varchar(100), @nombre varchar(100), @apellido1 varchar(255), @apellido2 varchar(255), @estado bit OUTPUT)
AS
BEGIN
	SET NOCOUNT ON
	/*Se genera un salt, el cual corresponde a una llave de encriptación del password*/
	DECLARE @salt UNIQUEIDENTIFIER=NEWID()
	BEGIN TRY
	/*Se inserta en la tabla Usuarios los datos de un nuevo usuario, se encripta la contraseña con un HASHBYTES con el algoritmo SHA2_512
	con la unión del password digitado y el salt (notese que este salt es único para cada usuario sin importar que tengan la misma contraseña,
	este se almacena diferente para cada uno)*/
		INSERT INTO dbo.[Usuarios] (correo, nombreUsuario, passwordHash, Salt, Categoria, unidad, nombre, apellido1, apellido2)
		VALUES(@correo, @pLogin, HASHBYTES('SHA2_512', @pPassword+CAST(@salt AS NVARCHAR(36))), @salt, @categoria, @unidad ,@nombre, @apellido1, @apellido2)
		/*si lacinserción se pudo realizar se devuelve un 1*/
		SET @estado=1 
	END TRY
	BEGIN CATCH
		/*En cualquier otro caso se devuelve el mensaje de error*/
		SET @estado=ERROR_MESSAGE()
	END CATCH
END

go
CREATE PROCEDURE dbo.Login(@pLoginName NVARCHAR(50), @pPassword NVARCHAR(50), @isInDb bit=0 OUTPUT)
AS
	BEGIN
		SET NOCOUNT ON
		/*Se declara la variable para buscar el usuario*/
		DECLARE @userID Varchar(255)

		/*Se pregunta si existe una cedulaUsuario que coincida con pLoginName*/
		IF EXISTS (SELECT TOP 1 correo FROM [dbo].Usuarios WHERE nombreUsuario = @pLoginName)
		BEGIN
			/*Si existe un usuario con este nombre se le pide la contraseña*/
			SET @userID = (Select correo from [dbo].Usuarios where nombreUsuario=@pLoginName
			and passwordHash = HASHBYTES('SHA2_512', @pPassword+CAST(Salt AS nvarchar(36))))

			/*Si al final de ambas consultas userId es null se retorna 0*/
			IF(@userID is null)
				Set @isInDb = 0
			ELSE
				Set @isInDb = 1
		END
		ELSE
			Set @isInDb = 0
	END
go

create procedure modificarUsuario(@usuario Nvarchar(50), @correo varchar(255), @categoria varchar(255), @unidad varchar(100), @nombre varchar(100), @apellido1 varchar(255), @apellido2 varchar(255)) as
	begin

		declare @salt uniqueidentifier
		select @salt = salt from Usuarios where nombreUsuario = @usuario

		update Usuarios
		set passwordHash = HASHBYTES('SHA2_512', @pass+CAST(@salt AS NVARCHAR(36))), correo = @correo, categoria = @categoria, unidad = @unidad, nombre = @nombre, apellido1 = @apellido1, apellido2 = @apellido2
		where nombreUsuario = @usuario
	end
go

create procedure modificarContrasena(@usuario Nvarchar(50), @pass nvarchar(50)) as
	begin

		declare @salt uniqueidentifier
		select @salt = salt from Usuarios where nombreUsuario = @usuario

		update Usuarios
		set passwordHash = HASHBYTES('SHA2_512', @pass+CAST(@salt AS NVARCHAR(36)))
		where nombreUsuario = @usuario
	end
go

create procedure modificarUnidad(@nombreViejo varchar(100), @nombre varchar(100), @encargado nvarchar(50)) as
	begin
		update Unidad
		set Unidad.nombre = @nombre, Unidad.encargado = @encargado
		where Unidad.nombre = @nombreViejo;
	end
go

/*Método para agregar una nueva Unidad a la base de datos*/
CREATE PROCEDURE agregarUnidad(@nombre varchar(100), @encargado nvarchar(50),@estado bit OUTPUT) as
	BEGIN
	BEGIN TRY
		INSERT INTO Unidad VALUES(@nombre, @encargado)
		SET @estado=1 
	END TRY
	BEGIN CATCH
		/*En cualquier otro caso se devuelve el mensaje de error*/
		SET @estado=ERROR_MESSAGE()
	END CATCH
	END
GO

insert into presupuesto values('0000','prueba lololdoaskoifjiewufs')

drop procedure agregarPresupuesto

exec dbo.agregarUsuario 'jorge', 'jor', 'jorgea1177@gmail.com', 'Administrador', 'UMI', 'Jorge', 'Araya', 'González', 0

exec dbo.agregarUsuario 'Admin', 'AdminCeleq', 'informatica.celeq@ucr.ac.cr', 0

exec dbo.agregarUsuario 'Estudiante', 'est', 'estudiante@ucr.ac.cr', 'Estudiante', 0

exec dbo.agregarUsuario 'Regente', 'reg', 'regente@ucr.ac.cr', 'Regencia', 0

insert into Unidad values ('UMI')
go



select CONCAT(nombre , ' ' , apellido1 , ' ' , apellido2) as Encargado from Usuarios


SELECT nombreUsuario FROM Usuarios U WHERE U.nombre = 'Jorge' AND U.apellido1 ='Araya' AND U.apellido2 ='González'

DELETE FROM Unidad WHERE encargado = 'Estiven'

select nombre from Unidad

SELECT * FROM designacionAsistencia
SELECT * FROM estudiante

select E.id as Identificación, E.tipoId as 'Tipo Identificación', CONCAT(E.nombre, ' ', E.apellido1, ' ', E.apellido2) as Nombre, E.carrera as Carrera from estudiante E

insert into designacionAsistencia(idEstudiante) values(116980153)

select D.idEstudiante as Cédula, CONCAT(E.nombre, ' ', E.apellido1, ' ', E.apellido2) as Nombre, D.ano as Año,
D.ciclo as Ciclo, D.horas as Horas, D.modalidad as Modalidad, D.monto as Monto, E.carrera as Carrera, D.encargado as Encargado, D.unidad as Unidad,
D.presupuesto as Presupuesto, D.convocatoria as Convocatoria from designacionAsistencia D join estudiante E on D.idEstudiante = E.id

select D.idEstudiante as Cédula, CONCAT(E.nombre, ' ', E.apellido1, ' ', E.apellido2) as Nombre, D.ano as Año,
D.ciclo as Ciclo, D.horas as Horas, D.modalidad as Modalidad, D.monto as Monto from designacionAsistencia D join estudiante E on D.idEstudiante = E.id and D.ano like '%2015"%' or D.ciclo like '%2%'


DELETE FROM Unidad WHERE nombre = 'fewai{sf-bjafdshv,afdshvjzfdshvfds'

select U.nombre as Unidad, CONCAT(E.nombre, ' ', E.apellido1, ' ', E.apellido2) as Encargado 
from unidad U 
join Usuarios E ON E.nombreUsuario = U.encargado;

SELECT nombreUsuario FROM Usuarios U WHERE U.nombre = 'Estiven' AND U.apellido1 ='Alfaro' AND U.apellido2 ='Gómez' AND categoria != 'Estudiante'

select U.nombre as Unidad, CONCAT(E.nombre, ' ', E.apellido1, ' ', E.apellido2) as Encargado from unidad U left join Usuarios E ON E.nombreUsuario = U.encargado