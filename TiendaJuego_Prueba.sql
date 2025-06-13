CREATE DATABASE TiendaJuegos
GO
USE TiendaJuegos

CREATE TABLE Usuarios (
    IDUsuario int not null primary key identity (1,1),
    NombreUsuario varchar(50) not null unique,
    CorreoElectronico varchar(100) not null unique,
    Contrasena varchar(255) not null,
    FechaRegistro date not null default getdate(),
    FechaNacimiento date,
    Pais varchar(50),
    Genero varchar(20),
    AvatarURL varchar (255),
    EsAdministrador bit not null default 0,
    EstadoCuenta varchar(20) not null default 'Activo',
);

EXEC sp_rename 'Usuarios.ContrasenaHash', 'Contrasena', 'COLUMN';



INSERT INTO Usuarios 
    (NombreUsuario, CorreoElectronico, Contrasena, FechaRegistro, FechaNacimiento, Pais, Genero, AvatarURL, EsAdministrador, EstadoCuenta)
VALUES
    ('MaxiFabeiro','maxi@mail.com', '12345', GETDATE(),'1990-01-25', 'Argentina', 'Masculino', 'aca va el avatar',1,'Activo'),
    ('FacuHerrera','facu@mail.com', '12345', GETDATE(),'1998-07-23', 'Argentina', 'Masculino', 'aca va el avatar',1,'Activo'),
    ('RodriGalarza','rodri@mail.com', '12345', GETDATE(),'2005-12-28', 'Argentina', 'Masculino', 'aca va el avatar',1,'Activo'),
    ('CarlosPerez','carlos@mail.com', '12345', GETDATE(),'1981-12-28', 'Argentina', 'Masculino', 'aca va el avatar',0,'Activo');


SELECT * FROM Usuarios