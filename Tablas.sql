CREATE DATABASE JuegosDB;
GO
USE JuegosDB;
GO


CREATE TABLE Permisos(
    IdPermiso INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    Nombre VARCHAR(50) NOT NULL,
    Descripcion VARCHAR(250) NULL,
);
GO

CREATE TABLE ClasificacionEdades(
    IdClasificacionEdade INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    Nombre VARCHAR(50) NOT NULL,
    Descripcion VARCHAR(250) NOT NULL,
);
GO

CREATE TABLE FormasDePago(
    IdFormaDePago INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    Nombre VARCHAR(250) NOT NULL,
    Estado BIT DEFAULT 1 NOT NULL,
);
GO

CREATE TABLE Formatos(
    IdFormato INT IDENTITY(1,1) PRIMARY KEY NOT NULL ,
    Nombre VARCHAR(50) NOT NULL,
    Fisico BIT NOT NULL,
);
GO

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
	IdDesarrolladoraJ INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Nombre VARCHAR(50) NOT NULL,
	IdPais INT NOT NULL,
	FechaFundacion DATE NOT NULL,
	CONSTRAINT FK_DesarrolladorasJuegos_Pais FOREIGN KEY (IdPais) REFERENCES Pais (IdPais)
);

CREATE TABLE DatosUsuarios (
    IDDatoUsuario INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    IDUsuario INT NOT NULL,
    Nombre VARCHAR(50) NOT NULL,
    Apellido VARCHAR(50) NOT NULL,
    FechaNacimiento DATE NOT NULL,
    IDPais INT NOT NULL,
    Genero VARCHAR(20),

    FOREIGN KEY (IDPais) REFERENCES Paises(IDPais),
    FOREIGN KEY (IDUsuario) REFERENCES Usuarios(IDUsuario)
);


CREATE TABLE IdiomasXJuegos (
    IDIdiomaXJuego INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    IDJuego INT NOT NULL,
    IDIdioma INT NOT NULL,

    FOREIGN KEY (IDJuego) REFERENCES Juegos(IDJuego),
    FOREIGN KEY (IDIdioma) REFERENCES Idiomas(IDIdioma)
);


CREATE TABLE Categorias (
    IDCategoria INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(50) NOT NULL
);

CREATE TABLE InfoVentas (
    IDVenta INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    IDUsuarioComprador INT NULL,
    FechaVenta DATETIME NOT NULL DEFAULT GETDATE(),
    IDFormaPago INT NOT NULL,
    IDCarrito INT NOT NULL,
    FOREIGN KEY (IDUsuarioComprador) REFERENCES Usuario(IDUsuario),
    FOREIGN KEY (IDFormaPago) REFERENCES FormaPago(IDFormaPago),
    FOREIGN KEY (IDCarrito) REFERENCES Carrito(IDCarrito)
);

CREATE TABLE Carrito (
    IDCarrito INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Cantidad INT NOT NULL,
    IDJuego INT NOT NULL,
    PrecioTotal DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (IDJuego) REFERENCES Juego(IDJuego)
);


