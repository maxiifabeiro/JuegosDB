USE JuegosDB;
GO

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
-- GO
-- INSERT INTO FormasDePagoPorVenta (IdInfoVenta, IdFormaDePago)
-- VALUES
--     (1, 1),  -- Venta 1: Efectivo
--     (2, 2),  -- Venta 2: Tarjeta
--     (3, 1),  -- Venta 3: Efectivo
--     (3, 2),  -- Venta 3: Tarjeta
--     (4, 3);  -- Venta 4: Transferencia



