CREATE TRIGGER tr_ActualizarStock
ON InfoVentas
AFTER INSERT
AS
BEGIN
    UPDATE J
    SET J.Stock = J.Stock - I.Cantidad
    FROM Juegos J
    INNER JOIN inserted I ON J.IdJuego = I.IdJuego;
END;
GO

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