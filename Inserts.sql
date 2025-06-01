INSERT INTO Idiomas (Nombre)
VALUES 
    ('Espa�ol'),
    ('Ingl�s'),
    ('Franc�s'),
    ('Italiano'),
    ('Portugu�s'),
    ('Japon�s'),
    ('Chino'),
    ('Coreano'),
    ('Alem�n'),
    ('Ruso'),
    ('�rabe'),
    ('Hindi'),
    ('Turco'),
    ('Neerland�s'),
    ('Sueco'),
    ('Dan�s'),
    ('Noruego'),
    ('Finland�s'),
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

INSERT INTO Permisos(Nombre, Descripcion) 
VALUES 
    ('Administrador', 'Permiso absoluto para administradores del sistema'),
    ('Vendedor', 'Permiso para vendedores de la tienda, en el que podra gestionar nuevas ventas...'),
    ('Comprador', 'Permiso para el usuarios externos, el cual podran comprar juegos');
GO

INSERT INTO ClasificacionEdades(Nombre, Descripcion)
VALUES
    --Clasificación ESRB (Estados Unidos y Canadá)
    ('EC', 'Para niños pequeños (3+). Sin contenido inapropiado'),
    ('E', 'Apto para todos (6+). Puede tener algo de humor leve o violencia muy leve'),
    ('E10+', 'Para mayores de 10 años. Puede incluir violencia leve, lenguaje moderado'),
    ('T', 'Para mayores de 13 años. Violencia, lenguaje fuerte, temas sugerentes'),
    ('M', 'Para mayores de 17 años. Violencia intensa, sangre, lenguaje fuerte, contenido sexual'),
    ('AO', 'Solo para adultos (18+). Contenido sexual explícito o violencia extrema'),
    ('RP', 'Clasificación aún no asignada'),
    --Clasificación PEGI (Europa)
    ('PEGI 3', 'Apto para todas las edades. Sin sonidos ni imágenes que puedan asustar'),
    ('PEGI 7', 'Puede tener escenas o sonidos que asusten a niños pequeños'),
    ('PEGI 12', 'Violencia moderada, lenguaje suave, insinuaciones sexuales leves'),
    ('PEGI 16', 'Violencia más realista, lenguaje fuerte, consumo de drogas'),
    ('PEGI 18', 'Violencia extrema, contenido sexual explícito, glorificación de drogas'),
    --Clasificación CERO (Japón)
    ('A','Todos los públicos'),
    ('B','12 años o más'),
    ('C','15 años o más'),
    ('D','17 años o más'),
    ('Z','Solo para adultos (18+). Venta restringida legalmente');
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

INSERT INTO Formatos(Nombre, Fisico)
VALUES
    ('Cartucho', 1),
    ('Blu-ray', 1),
    ('Descarga', 0),
    ('Streaming',0),
    ('App Movil',0),
    ('CD',1),
    ('DVD', 1);
GO
INSERT INTO DatosUsuarios (IDUsuario, Nombre, Apellido, FechaNacimiento, IDPais, Genero) VALUES
(1, 'Melina', 'Gonzalez', '1990-05-12', 1, 'Femenino'),
(2, 'Maria', 'Lopez', '1988-08-23', 1, 'Femenino'),
(3, 'Lucas', 'Perez', '1992-11-30', 2, 'Masculino'),
(4, 'Sofia', 'Ramirez', '1995-07-17', 1, 'Femenino'),
(5, 'Martin', 'Fernandez', '1985-01-09', 3, 'Masculino'),
(6, 'Carla', 'Sanchez', '1993-10-28', 1, 'Femenino'),
(7, 'Diego', 'Diaz', '1989-03-15', 2, 'Masculino'),
(8, 'Natalia', 'Torres', '1991-12-02', 1, 'Femenino'),
(9, 'Tomas', 'Vargas', '1994-06-21', 3, 'Masculino'),
(10, 'Laura', 'Morales', '1987-09-19', 1, 'Femenino'),
(11, 'Andres', 'Ruiz', '1986-11-05', 2, 'Masculino'),
(12, 'Camila', 'Castro', '1993-04-11', 1, 'Femenino'),
(13, 'Valeria', 'Mendez', '1990-02-25', 1, 'Femenino'),
(14, 'Bruno', 'Ortiz', '1988-07-30', 3, 'Masculino'),
(15, 'Florencia', 'Rojas', '1995-05-14', 2, 'Femenino'),
(16, 'Matias', 'Gomez', '1991-01-22', 1, 'Masculino'),
(17, 'Carolina', 'Nunez', '1989-03-06', 3, 'Femenino'),
(18, 'Rodrigo', 'Flores', '1992-12-18', 2, 'Masculino'),
(19, 'Julia', 'Herrera', '1994-08-08', 1, 'Femenino'),
(20, 'Agustin', 'Sosa', '1990-10-29', 1, 'Masculino');

INSERT INTO Categorias (Nombre) VALUES
('Acción'),
('Aventura'),
('Estrategia'),
('Deportes'),
('Simulación'),
('Rol'),
('Puzzle'),
('Terror'),
('Multijugador'),
('Educativo');