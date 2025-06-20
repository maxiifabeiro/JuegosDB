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
