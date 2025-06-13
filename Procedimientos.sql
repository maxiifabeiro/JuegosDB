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
    @Stock INT,
	@Estado BIT
AS
BEGIN
    INSERT INTO Juegos(
        Nombre, IdDesarrolladoraJ, IdCategoria, IdFormato,
        IdClasificacionEdad, FechaLanzamiento, Tamaño,
		CantidadJugadores, Descripcion, Precio, Stock,
		Estado
    )
    VALUES (
        @Nombre, @IdDesarrolladoraJ, @IdCategoria, @IdFormato, @IdClasificacionEdad, @FechaLanzamiento, @Tamaño, @CantidadJugadores, @Descripcion, @Precio, @Stock, 1
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
		IdDesarrolladoraJ = @IdDesarrolladoraJ,
		IdCategoria = @IdCategoria,
		IdFormato = @IdFormato,
		IdClasificacionEdad = @IdClasificacionEdad,
		FechaLanzamiento = @FechaLanzamiento,
		Tamaño = @Tamaño,
		CantidadJugadores = @CantidadJugadores,
		Descripcion = @Descripcion,
		Precio = @Precio,
		Stock = @Stock
	WHERE IdJuego = @IdJuego AND Estado = 1;
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
        INNER JOIN DesarrolladorasJuegos dj ON j.IdDesarrolladoraJ = dj.IdDesarrolladoraJ
        INNER JOIN Categorias c ON j.IdCategoria = c.IdCategoria
        INNER JOIN Formatos f ON j.IdFormato = f.IdFormato
        INNER JOIN ClasificacionEdades ce ON j.IdClasificacionEdad = ce.IdClasificacionEdad
    WHERE 
        j.IdJuego = @IdJuego;
END;
GO
