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
