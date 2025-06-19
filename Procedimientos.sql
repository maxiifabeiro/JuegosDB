--PROCEDIMIENTOS

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
CREATE OR ALTER PROCEDURE SP_AltaUsuario
    @NombreUsuario VARCHAR(100),
    @Correo VARCHAR(100),
    @Contrasena VARCHAR(100),
    @IdPermiso INT,

    @Nombre VARCHAR(50),
    @Apellido VARCHAR(50),
    @FechaNacimiento DATE,
    @IDPais INT,
    @Genero VARCHAR(20)
AS
BEGIN
    BEGIN TRY
		--Uso transaction para asegurar que se completen los dos insert si una da error se anula el insert
        BEGIN TRANSACTION;

		--Inserto en Usuarios
        INSERT INTO Usuarios (
            NombreUsuario, CorreoElectronico, Contrasena, IDPermiso
        )
        VALUES (
            @NombreUsuario, @Correo, @Contrasena, @IdPermiso
        );

		--Uso SCOPE_IDENTITY para obtener el id del usuario que recien se creo y lo guardo en la variable para despues usarlo en el insert de datosUsuarios
        DECLARE @IDUsuarioNuevo INT = SCOPE_IDENTITY();

		--Inserto en datosUsuarios
        INSERT INTO DatosUsuarios (
            IDUsuario, Nombre, Apellido, FechaNacimiento, IDPais, Genero
        )
        VALUES (
            @IDUsuarioNuevo, @Nombre, @Apellido, @FechaNacimiento, @IDPais, @Genero
        );

        COMMIT;
    END TRY
    BEGIN CATCH
        ROLLBACK;
        THROW;
    END CATCH
END;
GO

EXEC SP_AltaUsuario
    @NombreUsuario = 'maxi123',
    @Correo = 'maxi@gmail.com',
    @Contrasena = '12345',
    @IdPermiso = 2,
    @Nombre = 'Maximiliano',
    @Apellido = 'Fabeiro',
    @FechaNacimiento = '1999-06-03',
    @IDPais = 1,
    @Genero = 'Masculino';
GO

--Procedimiento para modificar usuario
CREATE OR ALTER PROCEDURE SP_ModificarUsuario
    @IDUsuario INT,
    @NombreUsuario VARCHAR(100),
    @Correo VARCHAR(100),
    @Contrasena VARCHAR(100),
    @IdPermiso INT,
    @Nombre VARCHAR(50),
    @Apellido VARCHAR(50),
    @FechaNacimiento DATE,
    @IDPais INT,
    @Genero VARCHAR(20)
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
            IDPermiso = @IdPermiso
        WHERE IDUsuario = @IDUsuario;

        -- Modifica datos en tabla DatosUsuarios
        UPDATE DatosUsuarios
        SET 
            Nombre = @Nombre,
            Apellido = @Apellido,
            FechaNacimiento = @FechaNacimiento,
            IDPais = @IDPais,
            Genero = @Genero
        WHERE IDDatoUsuario = @IDUsuario;

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
        UPDATE DatosUsuarios
        SET Estado = 0
        WHERE IDDatoUsuario = @IDUsuario;

        COMMIT;
    END TRY
    BEGIN CATCH
        ROLLBACK;
        THROW;
    END CATCH
END;
GO

--Procedimiento para listar usuarios
CREATE OR ALTER PROCEDURE SP_ListarUsuarios
AS
BEGIN
    SELECT 
        u.IDUsuario,
        u.NombreUsuario,
        u.CorreoElectronico,
        u.FechaRegistro,
        u.IDPermiso,
        p.Nombre,
        u.Estado,

        du.Nombre,
        du.Apellido,
        du.FechaNacimiento,
        du.IDPais,
        pais.Nombre,
        du.Genero,
        du.Estado AS EstadoDatos
    FROM Usuarios u
    INNER JOIN DatosUsuarios du ON u.IDUsuario = du.IDDatoUsuario
    LEFT JOIN Permisos p ON u.IDPermiso = p.IdPermiso
    LEFT JOIN Paises pais ON du.IDPais = pais.IDPais
    WHERE u.Estado = 1 AND du.Estado = 1 -- solo activos
    ORDER BY u.FechaRegistro DESC;
END;
GO

--Procedimiento para mostrar las ventas mensuales
CREATE PROCEDURE EstadisticasMensuales
    @Mes INT = NULL,
    @Anio INT = NULL
AS
BEGIN
    SELECT
        YEAR(i.FechaVenta) AS Anio,
        MONTH(i.FechaVenta) AS Mes,
        COUNT(DISTINCT i.IDVenta) AS CantidadVentas,
        SUM(c.Cantidad) AS JuegosVendidos,
        SUM(c.Cantidad * c.PrecioTotal) AS TotalRecaudado
    FROM InfoVentas i
    JOIN Carrito c ON i.IDCarrito = c.IDCarrito
    WHERE
        (@Mes IS NULL OR MONTH(i.FechaVenta) = @Mes) AND
        (@Anio IS NULL OR YEAR(i.FechaVenta) = @Anio)
    GROUP BY YEAR(i.FechaVenta), MONTH(i.FechaVenta)
    ORDER BY Anio, Mes;
END;
GO
EXEC EstadisticasMensuales @Mes = 6, @Anio = 2024;

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
END
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

--Vista Desarrolladoras juegos

CREATE VIEW desarrolladorasJUEGOS AS
SELECT IDDesarrolladoraJ,Nombre,IDPais, FechaFundacion FROM DesarrolladorasJuegos

--Vista Desarrolladoras Consolas

CREATE VIEW desarrolladorasCONSOLAS AS
SELECT IDDesarrolladorC,Nombre,IDPais, FechaFundacion FROM DesarrolladorasConsola
