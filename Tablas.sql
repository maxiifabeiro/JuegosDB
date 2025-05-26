CREATE TABLE Idiomas(
	IdIdiomas INT  IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Nombre CHAR(50) NOT NULL 
);
GO

CREATE TABLE JuegosXConsolas (
    IdJuego INT NOT NULL,
    IdConsola INT NOT NULL,
    CONSTRAINT PK_JuegosXConsolas PRIMARY KEY (IdJuego, IdConsola),
    CONSTRAINT FK_JuegosXConsolas_Juego FOREIGN KEY (IdJuego) REFERENCES Juegos(IdJuego),
    CONSTRAINT FK_JuegosXConsolas_Consola FOREIGN KEY (IdConsola) REFERENCES Consolas(IdConsola)
);
GO

CREATE TABLE FormasDePagoPorVenta (
    IdInfoVenta INT NOT NULL,
    IdFormaDePago INT NOT NULL,
    CONSTRAINT PK_FormasDePagoPorVenta PRIMARY KEY (IdInfoVenta, IdFormaDePago),
    CONSTRAINT FK_FormasDePagoPorVenta_InfoVenta FOREIGN KEY (IdInfoVenta) REFERENCES Ventas(IdVenta),
    CONSTRAINT FK_FormasDePagoPorVenta_Forma FOREIGN KEY (IdFormaDePago) REFERENCES FormasDePago(IdFormaDePago)
);
GO

CREATE TABLE DesarrolladorasJuegos(
	IdDesarrolladoraJ INT  IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Nombre VARCHAR(50) NOT NULL,
	IdPais INT NOT NULL,
	FechaFundacion DATE NOT NULL,
	CONSTRAINT FK_DesarrolladorasJuegos_Pais FOREIGN KEY (IdPais) REFERENCES Pais (IdPais)
);
GO