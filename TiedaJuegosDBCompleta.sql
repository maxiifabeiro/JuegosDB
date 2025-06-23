CREATE DATABASE TiendaJuegos
GO

USE TiendaJuegos
GO

--TABLAS--

CREATE TABLE ClasificacionEdades(
    IDClasificacionEdad INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    Nombre VARCHAR(50) NOT NULL,
    Descripcion VARCHAR(250) NOT NULL,
);
GO
CREATE TABLE Formatos(
    IDFormato INT IDENTITY(1,1) PRIMARY KEY NOT NULL ,
    Nombre VARCHAR(50) NOT NULL,
    Fisico BIT NOT NULL,
);
GO
CREATE TABLE Idiomas(
	IDIdioma INT  IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Nombre CHAR(50) NOT NULL 
);
GO
CREATE TABLE Categorias (
    IDCategoria INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(50) NOT NULL
);
GO
CREATE TABLE Paises (
    IDPais INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(50) NOT NULL
);
GO
CREATE TABLE DesarrolladorasConsola (
    IDDesarrolladorC INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(50) NOT NULL,
    IDPais INT NOT NULL,
    FechaFundacion DATE NULL,
    FOREIGN KEY (IDPais) REFERENCES Paises(IDPais)
);
GO
CREATE TABLE DesarrolladorasJuegos(
	IDDesarrolladoraJ INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Nombre VARCHAR(50) NOT NULL,
	IDPais INT NOT NULL,
	FechaFundacion DATE NOT NULL,
	CONSTRAINT FK_DesarrolladorasJuegos_Pais FOREIGN KEY (IDPais) REFERENCES Paises (IDPais)
);
GO
CREATE TABLE Consolas (
    IDConsola INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    IDDesarrolladorC INT NOT NULL,
    Nombre VARCHAR(50) NOT NULL,
    Descripcion VARCHAR(250) NOT NULL,
    FechaCreacion DATE NOT NULL,
    FOREIGN KEY (IDDesarrolladorC) REFERENCES DesarrolladorasConsola(IDDesarrolladorC)
);
GO
CREATE TABLE Permisos(
    IDPermiso INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    Nombre VARCHAR(50) NOT NULL,
    Descripcion VARCHAR(250) NULL,
);
GO
CREATE TABLE Usuarios (
    IDUsuario INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    NombreUsuario VARCHAR(50) NOT NULL UNIQUE,
    CorreoElectronico VARCHAR(100) NOT NULL UNIQUE,
    Contrasena VARCHAR(20) NOT NULL,
    FechaRegistro DATETIME NOT NULL DEFAULT GETDATE(),
    FechaNacimiento DATE NOT NULL,
    AvatarURL VARCHAR(255),
    EsAdministrador BIT NOT NULL DEFAULT 0,
    Estado BIT NOT NULL DEFAULT 1,
    IDPermiso INT NOT NULL

    FOREIGN KEY (IDPermiso) REFERENCES Permisos(IDPermiso)
);

GO
CREATE TABLE DatosUsuarios (
    IDUsuario INT PRIMARY KEY NOT NULL,
    Nombre VARCHAR(50) NOT NULL,
    Apellido VARCHAR(50) NOT NULL,
    FechaNacimiento DATE NOT NULL,
    IDPais INT NOT NULL,
    Genero VARCHAR(20),

    FOREIGN KEY (IDPais) REFERENCES Paises(IDPais),
    FOREIGN KEY (IDUsuario) REFERENCES Usuarios(IDUsuario)
);
GO
--DATOS USUARIOS EL IDUSUARIO TIENE QUE SER PRIMARY Y FOREING

CREATE TABLE Juegos (
    IDJuego INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(200) NOT NULL,
    IDDesarrolladoraJ INT NOT NULL,
    IDCategoria INT NOT NULL,
    FechaLanzamiento DATE NOT NULL,
    Tamaño INT NOT NULL, --en kilobytes
    IDFormato INT NOT NULL,
    IDClasificacionEdad INT NOT NULL,
    CantidadJugadores INT NULL,
    Descripcion VARCHAR(250) NULL,
    Precio DECIMAL(10,2) NOT NULL, --en Pesos
    Stock INT NOT NULL CHECK(Stock >= 0),
    Estado bit not null default 1

    FOREIGN KEY (IDDesarrolladoraJ) REFERENCES DesarrolladorasJuegos(IDDesarrolladoraJ),
    FOREIGN key (IDCategoria) REFERENCES Categorias(IDCategoria),
    FOREIGN KEY (IDFormato) REFERENCES Formatos(IDFormato),
    FOREIGN KEY (IDClasificacionEdad) REFERENCES ClasificacionEdades(IDClasificacionEdad)
);
GO
CREATE TABLE IdiomasXJuegos (
    IDIdiomaXJuego INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    IDJuego INT NOT NULL,
    IDIdioma INT NOT NULL,

    FOREIGN KEY (IDJuego) REFERENCES Juegos(IDJuego),
    FOREIGN KEY (IDIdioma) REFERENCES Idiomas(IDIdioma)
);
GO
CREATE TABLE JuegosXConsolas (
    IDJuego INT NOT NULL,
    IDConsola INT NOT NULL,
    CONSTRAINT PK_JuegosXConsolas PRIMARY KEY (IDJuego, IDConsola),
    CONSTRAINT FK_JuegosXConsolas_Juego FOREIGN KEY (IDJuego) REFERENCES Juegos(IDJuego),
    CONSTRAINT FK_JuegosXConsolas_Consola FOREIGN KEY (IDConsola) REFERENCES Consolas(IDConsola)
);
GO
CREATE TABLE FormasDePago(
    IDFormaDePago INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    Nombre VARCHAR(250) NOT NULL,
    Estado BIT DEFAULT 1 NOT NULL,
);
GO
CREATE TABLE InfoVentas (
    IDVenta INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    IDUsuarioVendedor INT NULL,
    FechaVenta DATETIME NOT NULL DEFAULT GETDATE(),
    IDFormaPago INT NOT NULL,
    Cantidad INT NOT NULL,
    IDJuego INT NOT NULL,
    PrecioTotal DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (IDUsuarioVendedor) REFERENCES Usuarios(IDUsuario),
    FOREIGN KEY (IDFormaPago) REFERENCES FormasDePago(IDFormaDePago),
    FOREIGN KEY (IDJuego) REFERENCES Juegos(IDJuego)
);
GO

--INSERTS

INSERT INTO ClasificacionEdades(Nombre, Descripcion)
VALUES
    --Clasificación ESRB (Estados Unidos y Canadá)
    ('EC', 'Para niños pequeños (3+). Sin contenido inapropiado'), --1
    ('E', 'Apto para todos (6+). Puede tener algo de humor leve o violencia muy leve'), --2
    ('E10+', 'Para mayores de 10 años. Puede incluir violencia leve, lenguaje moderado'), --3
    ('T', 'Para mayores de 13 años. Violencia, lenguaje fuerte, temas sugerentes'), --4
    ('M', 'Para mayores de 17 años. Violencia intensa, sangre, lenguaje fuerte, contenido sexual'), --5
    ('AO', 'Solo para adultos (18+). Contenido sexual explícito o violencia extrema'),--6
    ('RP', 'Clasificación aún no asignada');--7
GO
INSERT INTO Formatos(Nombre, Fisico)
VALUES
    ('Cartucho', 1),--1
    ('Blu-ray', 1),--2
    ('Descarga', 0),--3
    ('Streaming',0),--4
    ('App Movil',0),--5
    ('CD',1),--6
    ('DVD', 1);--7
GO
INSERT INTO Idiomas (Nombre)
VALUES 
    ('Español'),--1
    ('Ingles'),--2
    ('Frances'),--3
    ('Italiano'),--4
    ('Portugues'),--5
    ('Japones'),--6
    ('Chino'),--7
    ('Coreano'),--8
    ('Aleman'),--9
    ('Ruso'),--10
    ('Arabe'),--11
    ('Hindi'),--12
    ('Turco'),--13
    ('Neerlandes'),--14
    ('Sueco'),--15
    ('Danes'),--16
    ('Noruego'),--17
    ('Finlandes'),--18
    ('Griego'),--19
    ('Polaco');--20
GO
INSERT INTO Categorias (Nombre) VALUES
('Acción'), --1
('Aventura'), --2
('Estrategia'), --3
('Deportes'), --4
('Simulación'), --5
('Rol'), --6
('Puzzle'), --7
('Terror'), --8
('Multijugador'), --9
('Educativo'); --10
GO
-- PAISES
INSERT INTO Paises (Nombre) VALUES 
('Japon'), --1
('Estados Unidos'),--2
('Corea del Sur'), --3
('China'),--4
('Canada'),--5
('Francia'),--6
('Alemania'),--7
('Brasil'),--8
('España'),--9
('Reino Unido'),--10
('Italia'),--11
('Australia'),--12
('Suecia'),--13
('Rusia'),--14
('Argentina'),--15
('Mexico'),--16
('India'),--17
('Sudafrica'),--18
('Noruega'),--19
('Finlandia');--20
GO
-- DESARROLLADORES CONSOLAS
INSERT INTO DesarrolladorasConsola (Nombre, FechaFundacion, IDPais) VALUES ('Nintendo', '1889-09-23', 1),
('Sony Interactive Entertainment', '1993-11-16', 1),
('Microsoft', '1975-04-04', 2),
('Sega', '1960-06-03', 1),
('SNK Corporation', '1978-07-22', 1),
('Atari', '1972-06-27', 2);
GO
INSERT INTO DesarrolladorasJuegos (Nombre, IdPais, FechaFundacion)
VALUES
    ('Nintendo', 1, '1889-09-23'), --1
    ('Sony Interactive Entertainment', 1, '1993-11-16'), --2
    ('Capcom', 1, '1979-05-30'), --3
    ('Valve', 2, '1996-08-24'),--4
    ('Rockstar Games', 2, '1998-12-01'),--5
    ('Ubisoft', 4, '1986-03-28'),--6
    ('CD Projekt Red', 7, '2002-05-01'),--7
    ('Electronic Arts', 2, '1982-05-27'),--8
    ('Bethesda Softworks', 2, '1986-06-28'),--9
    ('Mojang Studios', 6, '2009-05-17'),--10
    ('Naughty Dog', 2, '1984-09-27'),--11
    ('Rare', 5, '1985-07-01'),--12
    ('BioWare', 3, '1995-02-01');--13
GO
-- CONSOLAS
INSERT INTO Consolas (Nombre, Descripcion, FechaCreacion, IDDesarrolladorC) VALUES 
('Nintendo Switch', 'Consola híbrida de Nintendo lanzada en 2017, permite jugar en modo portátil y de sobremesa con una gran variedad de juegos exclusivos.', '2017-03-03', 1),
('PlayStation 5', 'Consola de última generación de Sony lanzada en 2020 con gráficos 4K, SSD ultrarrápido y retrocompatibilidad con PS4.', '2020-11-12', 2),
('Xbox Series X', 'Consola de Microsoft con potente hardware, soporte para juegos 4K, Quick Resume y Game Pass integrado.', '2020-11-10', 3),
('Sega Genesis', 'Consola de 16 bits lanzada por Sega a finales de los 80, famosa por juegos como Sonic the Hedgehog.', '1988-10-29', 4),
('Nintendo Wii', 'Consola de Nintendo famosa por su jugabilidad con sensores de movimiento, lanzada en 2006.', '2006-11-19', 1),
('Atari 2600', 'Una de las primeras consolas de videojuegos domésticas, popularizó los cartuchos intercambiables.', '1977-09-11', 6),
('PlayStation 4', 'Consola de Sony lanzada en 2013, con gran catálogo de juegos, rendimiento sólido y éxito global.', '2013-11-15', 2),
('Xbox One', 'Consola de Microsoft de octava generación con soporte multimedia, retrocompatibilidad y juegos digitales.', '2013-11-22', 3),
('Xbox Series S', 'Versión digital y más accesible de Xbox Series, con compatibilidad con títulos modernos a menor resolución.', '2020-11-10', 3),
('PlayStation 4 Pro', 'Versión mejorada de PS4 con soporte para resolución 4K y mejor rendimiento gráfico.', '2016-11-10', 2);
GO
INSERT INTO Permisos(Nombre, Descripcion) 
VALUES 
    ('Administrador', 'Permiso absoluto para administradores del sistema'),
    ('Vendedor', 'Permiso para vendedores de la tienda, en el que podra gestionar nuevas ventas...')
GO
INSERT INTO Usuarios 
    (NombreUsuario, CorreoElectronico, Contrasena, FechaRegistro, FechaNacimiento, AvatarURL, EsAdministrador, Estado, IDPermiso)
VALUES
    ('MaxiFabeiro','maxi@mail.com', '12345', GETDATE(),'1990-01-25', 'aca va el avatar',1, 1, 1),
    ('FacuHerrera','facu@mail.com', '12345', GETDATE(),'1998-07-23', 'aca va el avatar',1, 1, 1),
    ('RodriGalarza','rodri@mail.com', '12345', GETDATE(),'2005-12-28', 'aca va el avatar',1, 1, 1),
	('MajoIllanes','majo@mail.com', '12345', GETDATE(),'1987-07-10', 'aca va el avatar',1, 1, 1),
    ('CarlosPerez','carlos@mail.com', '12345', GETDATE(),'1981-12-28', 'aca va el avatar',0, 1, 2);
GO
INSERT INTO DatosUsuarios (IDUsuario, Nombre, Apellido, FechaNacimiento, IDPais, Genero) VALUES
(1, 'Maximiliano', 'Fabeiro', '1990-05-12', 1, 'Masculino'),
(2, 'Facundo', 'Herrera', '1988-08-23', 1, 'Masculino'),
(3, 'Rodrigo', 'Galarza', '1992-11-30', 2, 'Masculino'),
(4, 'Maria Jose', 'Illanes', '1995-07-17', 1, 'Femenino'),
(5, 'Carlos', 'Perez', '1985-01-09', 3, 'Masculino');
GO
--JUEGOS
INSERT INTO Juegos 
    (Nombre, IDDesarrolladoraJ, IDCategoria, FechaLanzamiento, Tamaño, IDFormato, IDClasificacionEdad, CantidadJugadores, Descripcion, Precio, Stock) 
VALUES
    ('The Legend of Zelda', 1, 2, '1986-02-21', 128, 1, 2, 1, 'Link debe rescatar a la princesa Zelda y derrotar a Ganon en el reino de Hyrule', 10500, 5),
    ('God of War ', 2, 1, '2005-03-22', 4514845, 7, 5, 1, 'Kratos busca venganza contra Ares, el dios de la guerra', 7500, 6),
    ('The Witcher 3 ', 7, 6, '2015-05-19', 36859531, 3, 5, 1, 'Geralt de Rivia busca a su hija adoptiva Ciri mientras enfrenta a la Cacería Salvaje en un vasto mundo abierto', 12500, 10),
    ('GTA V', 5, 1, '2013-09-17', 70312500, 3, 5, 2, 'Tres criminales muy distintos arriesgan todo en una serie de robos en Los Santos, una ciudad inspirada en Los Ángeles', 11000, 6),
    ('Minecraft',10, 2, '2011-11-18', 1048576, 3, 3, 1, ' Juego de mundo abierto donde los jugadores exploran, construyen y sobreviven en un entorno generado por bloques', 6000, 5);
GO
--IDIOMAS X JUEGOS
INSERT INTO IdiomasXJuegos (IDJuego, IDIdioma)
VALUES
    (1,6), --The Legend of Zelda en Japones
    (1,2), --The Legend of Zelda en Ingles
    (1,9), --The Legend of Zelda en Aleman
    (1,1), --The Legend of Zelda en Español
    (1,3), --The Legend of Zelda en Frances

    (2,6), --God of War en Japones
    (2,9), --God of War en Aleman
    (2,2), --God of War en Ingles
    (2,1), --God of War en Español
    (2,5), --God of War en Portugues

    (3,10), --The Witcher 3 en Ruso
    (3,9), --The Witcher 3 en Aleman
    (3,2), --The Witcher 3 en Ingles
    (3,1), --The Witcher 3 en Español
    (3,17), --The Witcher 3 en Noruego
    (3,16), --The Witcher 3 en Danes
    (3,18), --The Witcher 3 en Finlandes

    (4,4), --GTA V en Italiano
    (4,10), --GTA V en Ruso
    (4,2), --GTA V en Ingles
    (4,1), --GTA V en Español
    (4,3), --GTA V en Frances

    (5,6), --Minecraft en Japones
    (5,9), --Minecraft en Aleman
    (5,2), --Minecraft en Ingles
    (5,1), --Minecraft en Español
    (5,3), --Minecraft en Frances
    (5,5); --Minecraft en Portugues
GO
INSERT INTO JuegosXConsolas (IdJuego, IdConsola)
VALUES
    (1, 1),  -- The Legend of Zelda en Nintendo Switch
    (2, 2),  -- God of War en PS4
    (2, 5),  -- God of War en PS5
    (3, 2),  -- The Witcher 3 en PS4
    (3, 3),  -- The Witcher 3 en Xbox One
    (3, 4),  -- The Witcher 3 en PC
    (4, 2),  -- GTA V en PS4
    (4, 3),  -- GTA V en Xbox One
    (4, 4),  -- GTA V en PC
    (5, 1),  -- Minecraft en Nintendo Switch
    (5, 2),  -- Minecraft en PS4
    (5, 3),  -- Minecraft en Xbox One
    (5, 4);  -- Minecraft en PC
GO
INSERT INTO FormasDePago(Nombre, Estado)
VALUES
    ('Efectivo',1),
    ('Tarjeta de credito', 1),
    ('Tarjeta de debito', 1),
    ('Mercado Pago', 1),
    ('Pago Facil', 1),
    ('Trasferencia', 1),
    ('Criptomonedas',1);
GO

--FUNCIONES
CREATE OR ALTER FUNCTION dbo.FN_ClasificacionEdad (
    @IDClasificacionEdad INT
)
RETURNS VARCHAR(50)
AS
BEGIN
    DECLARE @Resultado VARCHAR(50);

    SET @Resultado =
        CASE @IDClasificacionEdad
            WHEN 1 THEN 'ATP - Todo público'
            WHEN 2 THEN '+7 años'
            WHEN 3 THEN '+13 años'
            WHEN 4 THEN '+16 años'
            WHEN 5 THEN '+18 años'
            ELSE 'Desconocida'
        END;

    RETURN @Resultado;
END;
GO


--VISTAS
--Vista Desarrolladoras juegos

CREATE VIEW vw_desarrolladoraJUEGOS AS
SELECT IDDesarrolladoraJ,Nombre,IDPais, FechaFundacion FROM DesarrolladorasJuegos
GO
--Vista Desarrolladoras Consolas

CREATE VIEW vw_desarrolladoraCONSOLAS AS
SELECT IDDesarrolladorC,Nombre,IDPais, FechaFundacion FROM DesarrolladorasConsola
GO

CREATE OR ALTER VIEW vw_JuegosDisponiblesParaVenta AS
SELECT 
    IDJuego,
    Nombre,
    Precio,
    Stock
FROM 
    Juegos
WHERE 
    Stock > 0 AND Estado = 1;
GO

CREATE OR ALTER VIEW vw_VentasDetalladas AS
SELECT 
    v.IDVenta,
    v.FechaVenta,
    u.NombreUsuario AS Comprador,
    j.Nombre AS Juego,
    v.Cantidad,
    fp.Nombre AS FormaDePago,
    v.PrecioTotal
FROM 
    InfoVentas v
LEFT JOIN 
    Usuarios u ON v.IDUsuarioVendedor = u.IDUsuario
INNER JOIN 
    Juegos j ON v.IDJuego = j.IDJuego
INNER JOIN
    FormasDePago fp ON v.IDFormaPago = fp.IDFormaDePago;
GO

CREATE OR ALTER VIEW VW_JuegosConClasificacion
AS
SELECT 
    j.IDJuego,
    j.Nombre AS NombreJuego,
    j.Precio,
    j.Stock,
    dbo.FN_ClasificacionEdad(j.IDClasificacionEdad) AS ClasificacionEdad
FROM Juegos j
WHERE j.Estado = 1;
GO

--PROCEDIMIENTOS--

--Procedimiento para dar de alta un juego
CREATE OR ALTER PROCEDURE SP_altaJuego
    @Nombre VARCHAR(100),
    @IdDesarrolladoraJ INT,
    @IdCategoria INT,
    @IdFormato INT,
    @IdClasificacionEdad INT,
    @FechaLanzamiento DATE,
    @Tamaño INT,
    @CantidadJugadores INT,
    @Descripcion VARCHAR(250),
    @Precio DECIMAL(10,2),
    @Stock INT
AS
BEGIN
    INSERT INTO Juegos(
        Nombre, IDDesarrolladoraJ, IdCategoria, IdFormato,
        IdClasificacionEdad, FechaLanzamiento, Tamaño,
		CantidadJugadores, Descripcion, Precio, Stock
    )
    VALUES (
        @Nombre, @IdDesarrolladoraJ, @IdCategoria, @IdFormato, @IdClasificacionEdad, @FechaLanzamiento, @Tamaño, @CantidadJugadores, @Descripcion, @Precio, @Stock
    );
END;
GO

--Procedimiento para modificar juego
CREATE OR ALTER PROCEDURE SP_ModificarJuego
	@IdJuego INT,
	@Nombre VARCHAR(100),
    @IdDesarrolladoraJ INT,
    @IdCategoria INT,
    @IdFormato INT,
    @IdClasificacionEdad INT,
    @FechaLanzamiento DATE,
    @Tamaño INT,
    @CantidadJugadores INT,
    @Descripcion VARCHAR(250),
    @Precio DECIMAL(10,2),
    @Stock INT
AS
BEGIN
	UPDATE Juegos
	SET	
		Nombre = @Nombre,
		IDDesarrolladoraJ = @IdDesarrolladoraJ,
		IDCategoria = @IdCategoria,
		IDFormato = @IdFormato,
		IDClasificacionEdad = @IdClasificacionEdad,
		FechaLanzamiento = @FechaLanzamiento,
		Tamaño = @Tamaño,
		CantidadJugadores = @CantidadJugadores,
		Descripcion = @Descripcion,
		Precio = @Precio,
		Stock = @Stock
	WHERE IDJuego = @IdJuego AND Estado = 1;
END;
GO

--Procedimiento para dar de baja un juego
CREATE OR ALTER PROCEDURE SP_BajaJuego
	@IdJuego INT
AS
BEGIN
	UPDATE Juegos SET Estado = 0 WHERE IdJuego = @IdJuego;
END;
GO

--Procedimiento para listar juegos
CREATE OR ALTER PROCEDURE SP_ListarJuegos
AS
BEGIN
    SELECT 
        j.Nombre AS NombreJuego, 
        dj.Nombre AS Desarrolladora,
        c.Nombre AS Categoria,
        f.Nombre AS Formato,
        ce.Nombre AS ClasificacionEdad,
        j.FechaLanzamiento,
        j.Tamaño,
        j.CantidadJugadores,
        j.Descripcion,
        j.Precio,
        j.Stock
    FROM 
        Juegos j
        INNER JOIN DesarrolladorasJuegos dj ON j.IDDesarrolladoraJ = dj.IdDesarrolladoraJ
        INNER JOIN Categorias c ON j.IdCategoria = c.IdCategoria
        INNER JOIN Formatos f ON j.IdFormato = f.IdFormato
        INNER JOIN ClasificacionEdades ce ON j.IdClasificacionEdad = ce.IdClasificacionEdad
    WHERE 
        j.Estado = 1;
END;

GO

--Procedimiento para buscar juego por ID
CREATE OR ALTER PROCEDURE SP_BuscarJuegoPorID
    @IdJuego INT
AS
BEGIN
    SELECT 
        j.Nombre AS NombreJuego, 
        dj.Nombre AS Desarrolladora,
        c.Nombre AS Categoria,
        f.Nombre AS Formato,
        ce.Nombre AS ClasificacionEdad,
        j.FechaLanzamiento,
        j.Tamaño,
        j.CantidadJugadores,
        j.Descripcion,
        j.Precio,
        j.Stock
    FROM 
        Juegos j
        INNER JOIN DesarrolladorasJuegos dj ON j.IDDesarrolladoraJ = dj.IdDesarrolladoraJ
        INNER JOIN Categorias c ON j.IdCategoria = c.IdCategoria
        INNER JOIN Formatos f ON j.IdFormato = f.IdFormato
        INNER JOIN ClasificacionEdades ce ON j.IdClasificacionEdad = ce.IdClasificacionEdad
    WHERE 
        j.Estado = 1 AND j.IDJuego = @IdJuego;
END

GO



--Procedimiento para dar de alta un usuario
CREATE OR ALTER PROCEDURE SP_altaUsuario
    @NombreUsuario VARCHAR(100),
    @Correo VARCHAR(100),
    @Contrasena VARCHAR(100),
    @FechaNacimiento DATETIME,
    @AvatarURL VARCHAR(255),
    @IdPermiso INT
AS
BEGIN
    

    INSERT INTO Usuarios(
        NombreUsuario, CorreoElectronico, Contrasena, FechaNacimiento, AvatarURL, IDPermiso
    )
    VALUES (
        @NombreUsuario, @Correo, @Contrasena, @FechaNacimiento, @AvatarURL, @IdPermiso
    );

    SELECT SCOPE_IDENTITY() AS NuevoId;
	-- Asignar valor a EsAdministrador según el permiso
    IF @IdPermiso = 1
	UPDATE Usuarios
        SET EsAdministrador = 1
	WHERE IDUsuario = SCOPE_IDENTITY()
    ELSE
	UPDATE Usuarios
        SET EsAdministrador = 0
	WHERE IDUsuario = SCOPE_IDENTITY()
END;
GO

CREATE OR ALTER PROCEDURE SP_DatosUsuarios
	@IDUsuario INT,
    @Nombre VARCHAR(50),
    @Apellido VARCHAR(50),
    @FechaNacimiento DATETIME,
    @IDPais INT,
    @Genero VARCHAR(20)
AS
BEGIN
	INSERT INTO DatosUsuarios(
		IDUsuario, Nombre, Apellido, FechaNacimiento, IDPais, Genero
	)
	VALUES(
		@IDUsuario, @Nombre, @Apellido, @FechaNacimiento, @IDPais, @Genero
	);
END;
GO

EXEC SP_DatosUsuarios 11,'Pepe', 'Carlos', '1999-06-22', 2, 'Masculino'
GO

--Procedimiento para modificar usuario
CREATE OR ALTER PROCEDURE SP_ModificarUsuario
    @IDUsuario INT,
    @NombreUsuario VARCHAR(100),
    @Correo VARCHAR(100),
    @Contrasena VARCHAR(100),
    @FechaRegistro DATETIME,
    @AvatarURL VARCHAR(255),
    @EsAdministrador BIT,
    @IdPermiso INT
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;

        -- Modifica datos en tabla Usuarios
        UPDATE Usuarios
        SET 
            NombreUsuario = @NombreUsuario,
            CorreoElectronico = @Correo,
            Contrasena = @Contrasena,
            FechaRegistro = @FechaRegistro,
            AvatarURL= @AvatarURL,
            EsAdministrador = @EsAdministrador,
            IDPermiso = @IdPermiso
        WHERE IDUsuario = @IDUsuario;

        COMMIT;
    END TRY
    BEGIN CATCH
        ROLLBACK;
        THROW;
    END CATCH
END;

GO

--Procedimiento para modificar DatosUsuarios
CREATE OR ALTER PROCEDURE SP_ModificarDatosUsuarios
    @IDUsuario INT,
    @Nombre VARCHAR(50),
    @Apellido VARCHAR(50),
    @FechaNacimiento DATETIME,
    @IDPais INT,
    @Genero VARCHAR(20)
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;

        -- Modifica datos en tabla Usuarios
        UPDATE DatosUsuarios
        SET 
            Nombre = @Nombre,
            Apellido = @Apellido,
            FechaNacimiento = @FechaNacimiento,
            IDPais = @IDPais,
            Genero= @Genero
        WHERE IDUsuario = @IDUsuario;

        COMMIT;
    END TRY
    BEGIN CATCH
        ROLLBACK;
        THROW;
    END CATCH
END;

GO

--Procedimiento para de baja usuario
CREATE OR ALTER PROCEDURE SP_BajaUsuario
    @IDUsuario INT
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;

        -- Baja logica en tabla Usuarios
        UPDATE Usuarios
        SET Estado = 0
        WHERE IDUsuario = @IDUsuario;

        -- Baja logica en DatosUsuarios 
        -- UPDATE DatosUsuarios
        -- SET Estado = 0
        -- WHERE IDDatoUsuario = @IDUsuario;

        COMMIT;
    END TRY
    BEGIN CATCH
        ROLLBACK;
        THROW;
    END CATCH
END;

GO

--Procedimiento para listar todos usuarios
CREATE OR ALTER PROCEDURE SP_ListarUsuarios
AS
BEGIN
    SELECT 
        U.NombreUsuario AS NombreUsuario,
        U.CorreoElectronico AS Email,
        U.FechaRegistro AS FechaRegistro,
        P.Nombre AS Permiso,

        DU.Nombre AS Nombre,
        DU.Apellido AS Apellido,
        DU.FechaNacimiento AS FechaNacimiento,
        pais.Nombre AS Pais,
        DU.Genero AS Genero
    FROM Usuarios U
    INNER JOIN DatosUsuarios DU ON U.IDUsuario = DU.IDDatoUsuario
    LEFT JOIN Permisos P ON U.IDPermiso = P.IdPermiso
    LEFT JOIN Paises pais ON DU.IDPais = pais.IDPais
    WHERE U.Estado = 1
    ORDER BY U.FechaRegistro DESC;
END;

GO

CREATE OR ALTER PROCEDURE SP_ListarUsuariosConID
    @IDUsuario INT
AS
BEGIN
    SELECT 
        U.NombreUsuario AS NombreUsuario,
        U.CorreoElectronico AS Email,
        U.FechaRegistro AS FechaRegistro,
        P.Nombre AS Permiso,

        DU.Nombre AS Nombre,
        DU.Apellido AS Apellido,
        DU.FechaNacimiento AS FechaNacimiento,
        pais.Nombre AS Pais,
        DU.Genero AS Genero
    FROM Usuarios U
    INNER JOIN DatosUsuarios DU ON U.IDUsuario = DU.IDDatoUsuario
    LEFT JOIN Permisos P ON U.IDPermiso = P.IdPermiso
    LEFT JOIN Paises pais ON DU.IDPais = pais.IDPais
    WHERE U.Estado = 1 and U.IDUsuario=@IDUsuario
    ORDER BY U.FechaRegistro DESC;
END;

GO

--Procedimiento para buscar Usuario por ID
CREATE OR ALTER PROCEDURE SP_BuscarUsuarioPorID
    @IDUsuario INT
AS
BEGIN
    SELECT 
        U.NombreUsuario AS NombreUsuario, 
        U.CorreoElectronico AS Email,
        U.Contrasena AS Contraseña,
        U.FechaRegistro AS "Fecha de Registro",
        U.AvatarURL AS "AvatarURL",
        U.EsAdministrador AS EsAdministrador,
        U.Estado AS "Activo",
        P.Nombre AS "Permiso"
    FROM 
        Usuarios U
        INNER JOIN Permisos P ON U.IDPermiso = P.IDPermiso
    WHERE 
        U.Estado = 1 AND U.IDUsuario = @IDUsuario;
END

GO  

--Procedimiento para mostrar las ventas mensuales
CREATE OR ALTER PROCEDURE SP_EstadisticasMensuales
    @Mes INT = NULL,
    @Anio INT = NULL
AS
BEGIN
    SELECT
        YEAR(i.FechaVenta) AS Anio,
        MONTH(i.FechaVenta) AS Mes,
        COUNT(DISTINCT i.IDVenta) AS CantidadVentas,
        SUM(i.Cantidad) AS JuegosVendidos,
        SUM(i.Cantidad * i.PrecioTotal) AS TotalRecaudado
    FROM InfoVentas i
    WHERE
        (@Mes IS NULL OR MONTH(i.FechaVenta) = @Mes) AND
        (@Anio IS NULL OR YEAR(i.FechaVenta) = @Anio)
    GROUP BY YEAR(i.FechaVenta), MONTH(i.FechaVenta)
    ORDER BY Anio, Mes;
END;
GO


GO
--Procedimiento para listar stock de mayor a menor
CREATE OR ALTER PROCEDURE SP_ListarStock
AS
BEGIN
    SELECT
        j.IDJuego,
        j.Nombre AS NombreJuego,
        j.Stock
    FROM 
        Juegos j
    WHERE
        j.Estado = 1
    ORDER BY
        j.Stock DESC;
END;

GO
-- Procedimiento para listar juegos por stock con filtros
CREATE OR ALTER PROCEDURE SP_ListarStockPorFiltro
    @Cantidad INT,
    @TipoDeFiltro INT --1:Mayor a; 2:Igual a; 3:Menor a
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION
            --Filtrar por Mayor a @cantidad
        IF @TipoDeFiltro = 1 BEGIN
            SELECT j.IDJuego,
                j.Nombre AS NombreJuego,
                j.Stock
            FROM 
                Juegos j
            WHERE
                j.Estado = 1 AND j.Stock > @Cantidad
            ORDER BY
                j.Stock DESC;
            
            COMMIT TRANSACTION
        END
        --Filtrar por Igual a @cantidad
        ELSE IF @TipoDeFiltro = 2 BEGIN
            SELECT j.IDJuego,
                j.Nombre AS NombreJuego,
                j.Stock
            FROM 
                Juegos j
            WHERE
                j.Estado = 1 AND j.Stock = @Cantidad
            ORDER BY
                j.Stock DESC;

            COMMIT TRANSACTION
        END
        --Filtrar por Menor a @cantidad
        ELSE IF @TipoDeFiltro = 3 BEGIN
            SELECT j.IDJuego,
                j.Nombre AS NombreJuego,
                j.Stock
            FROM 
                Juegos j
            WHERE
                j.Estado = 1 AND j.Stock < @Cantidad
            ORDER BY
                j.Stock DESC;
            
            COMMIT TRANSACTION;
        END
        ELSE BEGIN
            ROLLBACK TRANSACTION
            RAISERROR('No se pudo realizar el filtrado ',16,1);
        END

    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
        RAISERROR('No se pudo realizar el filtrado ',16,1);
    END CATCH 
END;

GO
--Procedimiento para verificar si el usuario es admin o no
CREATE PROCEDURE VerificarUsuario
    @NombreUsuario NVARCHAR(50),
    @Contrasena NVARCHAR(50)
AS
BEGIN
    SELECT EsAdministrador FROM Usuarios
    WHERE NombreUsuario = @NombreUsuario AND Contrasena = @Contrasena
END
GO

CREATE OR ALTER PROCEDURE sp_BuscarJuegoParaVenta
    @TerminoBusqueda NVARCHAR(100) = '',
    @IDCategoria INT = 0,
    @IDClasificacionEdad INT = 0
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        v.IDJuego,
        v.Nombre AS [Nombre del Juego], 
        c.Nombre AS [Categoría],
        ce.Nombre AS [Clasificación],
        v.Precio,
        v.Stock
    FROM  v_JuegosDisponiblesParaVenta v
    INNER JOIN Juegos j ON v.IDJuego = j.IDJuego 
    INNER JOIN Categorias c ON j.IDCategoria = c.IDCategoria
    INNER JOIN ClasificacionEdades ce ON j.IDClasificacionEdad = ce.IDClasificacionEdad
    WHERE
        (v.Nombre LIKE '%' + @TerminoBusqueda + '%') AND
        (@IDCategoria = 0 OR j.IDCategoria = @IDCategoria) AND
        (@IDClasificacionEdad = 0 OR j.IDClasificacionEdad = @IDClasificacionEdad)
    ORDER BY 
        v.Nombre;
END
GO

CREATE OR ALTER PROCEDURE sp_RegistrarVenta
    @IDJuego INT,
    @NombreUsuarioVendedor NVARCHAR(50),
    @IDFormaPago INT,
    @Cantidad INT,
    @PrecioTotal DECIMAL(10, 2)
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @IDVendedor INT;
    SELECT @IDVendedor = IDUsuario 
    FROM Usuarios 
    WHERE NombreUsuario = @NombreUsuarioVendedor;
    INSERT INTO InfoVentas (IDJuego,IDUsuarioVendedor, IDFormaPago, Cantidad, PrecioTotal, FechaVenta)
    VALUES (@IDJuego, @IDVendedor, @IDFormaPago, @Cantidad, @PrecioTotal, GETDATE());
END
GO

CREATE OR ALTER PROCEDURE sp_ReporteVentasMensuales
    @Anio INT,
    @Mes INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        Juego,
        SUM(Cantidad) AS UnidadesVendidas,
        SUM(PrecioTotal) AS TotalVendido
    FROM 
        v_VentasDetalladas
    WHERE 
        YEAR(FechaVenta) = @Anio AND MONTH(FechaVenta) = @Mes
    GROUP BY
        Juego
    ORDER BY
        TotalVendido DESC;
END
GO

CREATE OR ALTER PROCEDURE sp_ObtenerTotalesMensuales
    @Anio INT,
    @Mes INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        ISNULL(SUM(Cantidad), 0) AS UnidadesTotales,
        ISNULL(SUM(PrecioTotal), 0) AS IngresosTotales,
        COUNT(IDVenta) AS CantidadDeVentas
    FROM 
        InfoVentas
    WHERE 
        YEAR(FechaVenta) = @Anio AND MONTH(FechaVenta) = @Mes;
END
GO

--TRIGGERS--
CREATE OR ALTER TRIGGER tr_ActualizarStockPorVenta
ON InfoVentas
AFTER INSERT 
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE J
    SET J.Stock = J.Stock - i.Cantidad
    FROM Juegos AS J
    INNER JOIN inserted AS i ON J.IDJuego = i.IDJuego;
END
GO

