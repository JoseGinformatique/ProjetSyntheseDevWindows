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
NumeroReservation VARCHAR(2) PRIMARY KEY,
Prix INT,
[Type] VARCHAR(20),
[Status] BIT,
)
GO

CREATE TABLE Salles(
NumeroReservation VARCHAR(2) PRIMARY KEY,
Prix INT,
nom VARCHAR(20),
[Status] BIT,
)
GO

CREATE TABLE Clients(
num_client INT PRIMARY KEY,
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

CREATE VIEW V_Ch_SL
AS
SELECT NumeroReservation from Chambres
union
SELECT Numeroreservation from Salles
GO


CREATE TABLE Reservations(
num_reservation VARCHAR(2),
client INT
CONSTRAINT fk_client FOREIGN KEY (client) REFERENCES Clients(num_client)
)
GO

CREATE VIEW V_CHAMBRES
AS
SELECT NumeroReservation, Prix, [Type], [Status], client FROM Chambres
left JOIN Reservations ON Chambres.NumeroReservation = Reservations.num_reservation
GO
CREATE VIEW V_SALLES
AS
SELECT NumeroReservation, Prix, nom , [Status], client FROM Salles
left JOIN Reservations ON Salles.NumeroReservation = Reservations.num_reservation
GO


INSERT INTO Chambres
VALUES	('A1', 100, 'Régulière', 1),
		('A2', 100, 'Régulière', 1),
		('A3', 100, 'Régulière', 0),
		('A4', 100, 'Régulière', 0),
		('A5', 200, 'Suite', 1),
		('A6', 200, 'Suite', 0),
		('A7', 200, 'Suite', 0),
		('A8', 200, 'Suite', 0)
GO

INSERT INTO Salles
VALUES	('B1', 50, 'Piscine', 0),
		('B2', 200, 'Cinema A', 0),
		('B3', 200, 'Cinema B', 0),
		('B4', 100, 'Salle de reunions A', 0),
		('B5', 100, 'Salle de reunions B', 1)

GO

INSERT INTO TarifsChambres
VALUES	('Suite', 200,'par jour'),
		('Régulière', 100, 'par jour')

INSERT INTO TarifsSalles
VALUES	('Piscine', 50, 'par heure'),
		('Cinema', 200, 'par 3 heure'),
		('Salle de reunions', 100, 'par heure')

INSERT INTO Clients
VALUES	(100001, 'Password1', 'Stewart', 'Patrick', 82),
		(100002, 'Password1', 'Jackman', 'Hugh', 54),
		(100003, 'Password1', 'Mckellen', 'Ian', 83),
		(100004, 'Password1', 'Berry', 'Halle', 53),
		(100005, 'Password1', 'Lawrence', 'Jennifer', 32)

INSERT INTO Administrateur
VALUES	(200001, 'Password1', 'Michel', 'Jean'),
		(200002, 'Password1', 'Jean', 'Billie'),
		(200003, 'Password1', 'Card', 'Credit'),
		(200004, 'Password1', 'Homes', 'Rachel'),
		(200005, 'Password1', 'Trudeau', 'Pierre')

INSERT INTO Reservations
VALUES	('B5', 100004),
		('A1', 100002),
		('A2', 100001),
		('A5', 100004)

GO
SELECT * FROM Chambres
SELECT * FROM Reservations
SELECT * FROM Salles
SELECT * FROM Clients
GO

CREATE TRIGGER trig_reserv
ON Reservations AFTER INSERT
AS BEGIN
	IF (SELECT num_reservation FROM inserted) NOT IN (SELECT NumeroReservation FROM V_Ch_SL)
	BEGIN
		RAISERROR('Le numero de reservation ne correspond pas a aucune salla ni chambre', 1, 1)
		ROLLBACK TRANSACTION
	END
END
GO