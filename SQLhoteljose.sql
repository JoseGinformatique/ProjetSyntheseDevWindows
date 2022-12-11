USE master
GO
DROP DATABASE HotelJose
GO

CREATE DATABASE HotelJose
GO
USE HotelJose

CREATE TABLE TarifsChambres(
nom varchar(9),
Prix INT,
temps varchar(20),

)
GO
CREATE TABLE TarifsSalles(
nom varchar(20),
Prix INT,
temps varchar(20),
)
GO

CREATE TABLE Chambres(
NumeroReservation INT PRIMARY KEY,
Prix INT,
[Type] VARCHAR(20),
[Status] BIT,
)
GO

CREATE TABLE Salles(
NumeroReservation INT PRIMARY KEY,
Prix INT,
nom VARCHAR(20),
[Status] BIT,
)
GO

CREATE TABLE Clients(
num_client INT,
mot_de_passe VARCHAR(20),
nom VARCHAR(20),
prenom VARCHAR (20),
age INT
)
GO

CREATE TABLE Administrateur(
num_admin INT,
mot_de_passe VARCHAR(20),
nom VARCHAR(20),
prenom VARCHAR (20)
)
GO

INSERT INTO Chambres
VALUES	(01, 100, 'Régulière', 1),
		(02, 100, 'Régulière', 0),
		(03, 100, 'Régulière', 1),
		(04, 100, 'Régulière', 0),
		(05, 200, 'Suite', 0),
		(06, 200, 'Suite', 0),
		(07, 200, 'Suite', 0),
		(08, 200, 'Suite', 0)
GO

INSERT INTO Salles
VALUES	(01, 50, 'Piscine', 1),
		(02, 200, 'Cinema A', 0),
		(03, 200, 'Cinema B', 1),
		(04, 100, 'Salle de reunions A', 1),
		(05, 100, 'Salle de reunions B', 0)

GO

INSERT INTO TarifsChambres
VALUES	('Suite', 200,'par jour'),
		('Régulière', 100, 'par jour')

INSERT INTO TarifsSalles
VALUES	('Piscine', 50, 'par heure'),
		('Cinema', 200, 'par 3 heure'),
		('Salle de reunions', 100, 'par heure')