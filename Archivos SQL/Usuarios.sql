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

create table puestos
(
	puesto varchar(100)		NOT NULL	PRIMARY KEY
)

create table puestosUsuarios
(
	nombreUsuario NVARCHAR(50),
	puesto varchar(100),

	primary key (nombreUsuario, puesto),
	foreign key(nombreUsuario) references Usuarios(nombreUsuario),
	foreign key(puesto) references puestos(puesto)
)
go
CREATE PROCEDURE dbo.agregarUsuario(@pLogin NVARCHAR(50), @pPassword NVARCHAR(50), @correo varchar(255),@categoria varchar(255), @unidad varchar(100), @nombre varchar(100), @apellido1 varchar(255), @apellido2 varchar(255), @estado bit OUTPUT)
AS
BEGIN
	SET NOCOUNT ON
	/*Se genera un salt, el cual corresponde a una llave de encriptaci�n del password*/
	DECLARE @salt UNIQUEIDENTIFIER=NEWID()
	BEGIN TRY
	/*Se inserta en la tabla Usuarios los datos de un nuevo usuario, se encripta la contrase�a con un HASHBYTES con el algoritmo SHA2_512
	con la uni�n del password digitado y el salt (notese que este salt es �nico para cada usuario sin importar que tengan la misma contrase�a,
	este se almacena diferente para cada uno)*/
		INSERT INTO dbo.[Usuarios] (correo, nombreUsuario, passwordHash, Salt, Categoria, unidad, nombre, apellido1, apellido2)
		VALUES(@correo, @pLogin, HASHBYTES('SHA2_512', @pPassword+CAST(@salt AS NVARCHAR(36))), @salt, @categoria, @unidad ,@nombre, @apellido1, @apellido2)
		/*si lacinserci�n se pudo realizar se devuelve un 1*/
		SET @estado=1 
		INSERT INTO permisos(usuario) values(@pLogin)
	END TRY
	BEGIN CATCH
		/*En cualquier otro caso se devuelve el mensaje de error*/
		SET @estado=ERROR_MESSAGE()
	END CATCH
END
go

drop procedure agregarUsuario

CREATE PROCEDURE dbo.Login(@pLoginName NVARCHAR(50), @pPassword NVARCHAR(50), @isInDb bit=0 OUTPUT)
AS
	BEGIN
		SET NOCOUNT ON
		/*Se declara la variable para buscar el usuario*/
		DECLARE @userID Varchar(255)

		/*Se pregunta si existe una cedulaUsuario que coincida con pLoginName*/
		IF EXISTS (SELECT TOP 1 correo FROM [dbo].Usuarios WHERE nombreUsuario = @pLoginName)
		BEGIN
			/*Si existe un usuario con este nombre se le pide la contrase�a*/
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

/*M�todo para agregar una nueva Unidad a la base de datos*/
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


create procedure agregarPuestoUsuario(@usuario nvarchar(50), @puesto varchar(10)) as
begin
	insert into puestosUsuarios values(@usuario, @puesto)
end
go

select * from puestosUsuarios

insert into puestosUsuarios values ('fcjg', 'Qu�mico') 

