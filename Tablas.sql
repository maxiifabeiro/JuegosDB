USE master;
go
CREATE DATABASE JuegosDB;
GO
USE JuegosDB;

GO
CREATE TABLE ClasificacionEdades(
    IDClasificacionEdad INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    Nombre VARCHAR(50) NOT NULL,
    Descripcion VARCHAR(250) NOT NULL,
);
GO
CREATE TABLE Formatos(
    IDFormato INT IDENTITY(1,1) PRIMARY KEY NOT NULL ,
    Nombre VARCHAR(50) NOT NULL,
    Fisico BIT NOT NULL,
);
GO
CREATE TABLE Idiomas(
	IDIdioma INT  IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Nombre CHAR(50) NOT NULL 
);
GO
CREATE TABLE Categorias (
    IDCategoria INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(50) NOT NULL
);
GO
CREATE TABLE Paises (
    IDPais INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(50) NOT NULL
);
GO
CREATE TABLE DesarrolladorasConsola (
    IDDesarrolladorC INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(50) NOT NULL,
    IDPais INT NOT NULL,
    FechaFundacion DATE NULL,
    FOREIGN KEY (IDPais) REFERENCES Paises(IDPais)
);
GO
CREATE TABLE DesarrolladorasJuegos(
	IDDesarrolladoraJ INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Nombre VARCHAR(50) NOT NULL,
	IDPais INT NOT NULL,
	FechaFundacion DATE NOT NULL,
	CONSTRAINT FK_DesarrolladorasJuegos_Pais FOREIGN KEY (IDPais) REFERENCES Paises (IDPais)
);
GO
CREATE TABLE Consolas (
    IDConsola INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    IDDesarrolladorC INT NOT NULL,
    Nombre VARCHAR(50) NOT NULL,
    Descripcion VARCHAR(250) NOT NULL,
    FechaCreacion DATE NOT NULL,
    FOREIGN KEY (IDDesarrolladorC) REFERENCES DesarrolladorasConsola(IDDesarrolladorC)
);
GO
CREATE TABLE Permisos(
    IDPermiso INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    Nombre VARCHAR(50) NOT NULL,
    Descripcion VARCHAR(250) NULL,
);
GO
CREATE TABLE Usuarios (
    IDUsuario INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    NombreUsuario VARCHAR(50) NOT NULL UNIQUE,
    CorreoElectronico VARCHAR(100) NOT NULL UNIQUE,
    Contrasena VARCHAR(20) NOT NULL,
    FechaRegistro DATETIME NOT NULL DEFAULT GETDATE(),
    FechaNacimiento DATE NOT NULL,
    AvatarURL VARCHAR(255),
    EsAdministrador BIT NOT NULL DEFAULT 0,
    Estado BIT NOT NULL DEFAULT 1,
    IDPermiso INT NOT NULL

    FOREIGN KEY (IDPermiso) REFERENCES Permisos(IDPermiso)
);
GO
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
GO
CREATE TABLE Juegos (
    IDJuego INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(200) NOT NULL,
    IDDesarrolladoraJ INT NOT NULL,
    IDCategoria INT NOT NULL,
    FechaLanzamiento DATE NOT NULL,
    Tamaño INT NOT NULL, --en kilobytes
    IDFormato INT NOT NULL,
    IDClasificacionEdad INT NOT NULL,
    CantidadJugadores INT NULL,
    Descripcion VARCHAR(250) NULL,
    Precio DECIMAL(10,2) NOT NULL, --en Pesos
    Stock INT NOT NULL CHECK(Stock >= 0),
    Estado bit not null default 1

    FOREIGN KEY (IDDesarrolladoraJ) REFERENCES DesarrolladorasJuegos(IDDesarrolladoraJ),
    FOREIGN key (IDCategoria) REFERENCES Categorias(IDCategoria),
    FOREIGN KEY (IDFormato) REFERENCES Formatos(IDFormato),
    FOREIGN KEY (IDClasificacionEdad) REFERENCES ClasificacionEdades(IDClasificacionEdad)
);
GO
CREATE TABLE IdiomasXJuegos (
    IDIdiomaXJuego INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    IDJuego INT NOT NULL,
    IDIdioma INT NOT NULL,

    FOREIGN KEY (IDJuego) REFERENCES Juegos(IDJuego),
    FOREIGN KEY (IDIdioma) REFERENCES Idiomas(IDIdioma)
);
GO
CREATE TABLE JuegosXConsolas (
    IDJuego INT NOT NULL,
    IDConsola INT NOT NULL,
    CONSTRAINT PK_JuegosXConsolas PRIMARY KEY (IDJuego, IDConsola),
    CONSTRAINT FK_JuegosXConsolas_Juego FOREIGN KEY (IDJuego) REFERENCES Juegos(IDJuego),
    CONSTRAINT FK_JuegosXConsolas_Consola FOREIGN KEY (IDConsola) REFERENCES Consolas(IDConsola)
);
GO
CREATE TABLE FormasDePago(
    IDFormaDePago INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    Nombre VARCHAR(250) NOT NULL,
    Estado BIT DEFAULT 1 NOT NULL,
);
GO
CREATE TABLE InfoVentas (
    IDVenta INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    IDUsuarioComprador INT NULL,
    FechaVenta DATETIME NOT NULL DEFAULT GETDATE(),
    IDFormaPago INT NOT NULL,
    Cantidad INT NOT NULL,
    IDJuego INT NOT NULL,
    PrecioTotal DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (IDUsuarioComprador) REFERENCES Usuarios(IDUsuario),
    FOREIGN KEY (IDFormaPago) REFERENCES FormasDePago(IDFormaDePago),
    FOREIGN KEY (IDJuego) REFERENCES Juegos(IDJuego)
);
-- GO
-- CREATE TABLE FormasDePagoPorVenta (
--     IdInfoVenta INT NOT NULL,
--     IdFormaDePago INT NOT NULL,
--     CONSTRAINT PK_FormasDePagoPorVenta PRIMARY KEY (IdInfoVenta, IdFormaDePago),
--     CONSTRAINT FK_FormasDePagoPorVenta_InfoVenta FOREIGN KEY (IdInfoVenta) REFERENCES InfoVentas(IdVenta),
--     CONSTRAINT FK_FormasDePagoPorVenta_Forma FOREIGN KEY (IdFormaDePago) REFERENCES FormasDePago(IdFormaDePago)
-- );




