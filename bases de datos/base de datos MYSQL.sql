CREATE DATABASE Biblioteca;

 use Biblioteca;
 
CREATE TABLE Libros(
IdLibro int primary key not null ,
NombreLibro varchar (100) not null,
editorial varchar (100) not null,
Autor varchar (100) not null,
genero varchar (100) not null
);

CREATE TABLE PRESTAMOS(
IdPedido int primary key not null ,
IdLibroPrestamo int not null,
IdUsuarioPrestamo int not null,
FechaSalida date not null,
FechaEntrega date not null
);

CREATE TABLE USUARIOS(
IdUsuario int primary key not null,
Nombre varchar (100) not null,
Apellido varchar (100) not null,
Cedula int not null,
Celular int not null
);

INSERT INTO Libros(IdLibro,NombreLibro,editorial,Autor,genero) Values 
(01,'EL INGENIOSOS HIDALGO DON QUIJOTE DE LA MANCHA', 'ANAYA', 'MIGUEL DE CERVANTES', 'CABALLERESCO');

INSERT INTO Libros(IdLibro,NombreLibro,editorial,Autor,genero) Values 
(02,'EL PRINCIPITO', 'ANDINA', 'ANTOINE DE SAINT-EXUPÉRY', 'AVANTURA');

INSERT INTO Libros(IdLibro,NombreLibro,editorial,Autor,genero) Values 
(03,'CAZADORES DE SOMBRA: CIUDAD DE HUESO', 'PLANETA','CASSANDRA CLARE', 'FANTASTICA');

INSERT INTO USUARIOS (IdUsuario,Nombre,Apellido,Cedula,Celular) Values 
(01,'MIGUEL', 'VELASQUEZ', 1000410984,5063981);

INSERT INTO USUARIOS (IdUsuario,Nombre,Apellido,Cedula,Celular) Values 
(02,'EMMA', 'MONTOYA', 1000251506,4382141);

INSERT INTO PRESTAMOS(IdPedido,IdLibroPrestamo,IdUsuarioPrestamo,FechaSalida,FechaEntrega)VALUES
(01,02,02,'2021-03-14','2021-04-14');

INSERT INTO PRESTAMOS(IdPedido,IdLibroPrestamo,IdUsuarioPrestamo,FechaSalida,FechaEntrega)VALUES
(02,03,01,'2021-03-12','2021-04-12');

SELECT * FROM biblioteca.libros;
SELECT * FROM biblioteca.usuarios;
SELECT * FROM biblioteca.prestamos;
