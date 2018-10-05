use Usuarios
CREATE TABLE dbo.[Usuarios]
(
	nombreUsuario NVARCHAR(50)	NOT NULL	PRIMARY KEY,
	correo varchar(255)			NOT NULL,
	categoria varchar(255)		NOT NULL,
	passwordHash BINARY(64)		NOT NULL,
	salt UNIQUEIDENTIFIER,
)


go
CREATE PROCEDURE dbo.agregarUsuario(@pLogin NVARCHAR(50), @pPassword NVARCHAR(50), @correo varchar(255),@categoria varchar(255), @estado bit OUTPUT)
AS
BEGIN
	SET NOCOUNT ON
	/*Se genera un salt, el cual corresponde a una llave de encriptación del password*/
	DECLARE @salt UNIQUEIDENTIFIER=NEWID()
	BEGIN TRY
	/*Se inserta en la tabla Usuarios los datos de un nuevo usuario, se encripta la contraseña con un HASHBYTES con el algoritmo SHA2_512
	con la unión del password digitado y el salt (notese que este salt es único para cada usuario sin importar que tengan la misma contraseña,
	este se almacena diferente para cada uno)*/
		INSERT INTO dbo.[Usuarios] (correo, nombreUsuario, passwordHash, Salt, Categoria)
		VALUES(@correo, @pLogin, HASHBYTES('SHA2_512', @pPassword+CAST(@salt AS NVARCHAR(36))), @salt, @categoria)
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

create procedure modificarUsuario(@usuario Nvarchar(50), @pass nvarchar(50), @correo varchar(255), @categoria varchar(255)) as
	begin
		delete from Usuarios where nombreUsuario = @usuario
		exec dbo.agregarUsuario @usuario, @pass, @correo, @categoria, 0
	end
go
drop procedure modificarUsusario

exec dbo.agregarUsuario 'jorge', 'jor', 'jorgea1177@gmail.com', 'Administrador', 0

exec dbo.agregarUsuario 'Admin', 'AdminCeleq', 'informatica.celeq@ucr.ac.cr', 0

exec dbo.agregarUsuario 'Estudiante', 'est', 'estudiante@ucr.ac.cr', 'Estudiante', 0

exec dbo.agregarUsuario 'Regente', 'reg', 'regente@ucr.ac.cr', 'Regencia', 0


go