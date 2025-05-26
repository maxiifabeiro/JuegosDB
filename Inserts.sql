INSERT INTO Idiomas (Nombre)
VALUES 
    ('Español'),
    ('Inglés'),
    ('Francés'),
    ('Italiano'),
    ('Portugués'),
    ('Japonés'),
    ('Chino'),
    ('Coreano'),
    ('Alemán'),
    ('Ruso'),
    ('Árabe'),
    ('Hindi'),
    ('Turco'),
    ('Neerlandés'),
    ('Sueco'),
    ('Danés'),
    ('Noruego'),
    ('Finlandés'),
    ('Griego'),
    ('Polaco');
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

INSERT INTO FormasDePagoPorVenta (IdInfoVenta, IdFormaDePago)
VALUES
    (1, 1),  -- Venta 1: Efectivo
    (2, 2),  -- Venta 2: Tarjeta
    (3, 1),  -- Venta 3: Efectivo
    (3, 2),  -- Venta 3: Tarjeta
    (4, 3);  -- Venta 4: Transferencia
GO

INSERT INTO DesarrolladorasJuegos (Nombre, IdPais, FechaFundacion)
VALUES
    ('Nintendo', 1, '1889-09-23'),
    ('Sony Interactive Entertainment', 1, '1993-11-16'),
    ('Capcom', 1, '1979-05-30'),
    ('Valve', 2, '1996-08-24'),
    ('Rockstar Games', 2, '1998-12-01'),
    ('Ubisoft', 4, '1986-03-28'),
    ('CD Projekt Red', 7, '2002-05-01'),
    ('Electronic Arts', 2, '1982-05-27'),
    ('Bethesda Softworks', 2, '1986-06-28'),
    ('Mojang Studios', 6, '2009-05-17'),
    ('Naughty Dog', 2, '1984-09-27'),
    ('Rare', 5, '1985-07-01'),
    ('BioWare', 3, '1995-02-01');
GO