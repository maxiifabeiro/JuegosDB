--Vista Desarrolladoras juegos

CREATE VIEW desarrolladorasJUEGOS AS
SELECT IDDesarrolladoraJ,Nombre,IDPais, FechaFundacion FROM DesarrolladorasJuegos

--Vista Desarrolladoras Consolas

CREATE VIEW desarrolladorasCONSOLAS AS
SELECT IDDesarrolladorC,Nombre,IDPais, FechaFundacion FROM DesarrolladorasConsola


CREATE OR ALTER VIEW v_JuegosDisponiblesParaVenta AS
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

CREATE OR ALTER VIEW v_VentasDetalladas AS
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
    Usuarios u ON v.IDUsuarioComprador = u.IDUsuario
INNER JOIN 
    Juegos j ON v.IDJuego = j.IDJuego
INNER JOIN
    FormasDePago fp ON v.IDFormaPago = fp.IDFormaDePago;
GO