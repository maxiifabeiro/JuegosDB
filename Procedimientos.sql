--PROCEDIMIENTOS

USE JuegosDB;

GO

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
-- GO

-- EXEC SP_AltaUsuario
--     @NombreUsuario = 'maxi123',
--     @Correo = 'maxi@gmail.com',
--     @Contrasena = '12345',
--     @IdPermiso = 2,
--     @Nombre = 'Maximiliano',
--     @Apellido = 'Fabeiro',
--     @FechaNacimiento = '1999-06-03',
--     @IDPais = 1,
--     @Genero = 'Masculino';
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
EXEC EstadisticasMensuales @Mes = 6, @Anio = 2024;

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

