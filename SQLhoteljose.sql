USE master
GO
DROP DATABASE HotelJose
GO

CREATE DATABASE HotelJose
GO
USE HotelJose

CREATE TABLE Chambres(
NumeroReservation INT PRIMARY KEY,
Prix INT,
[Type] VARCHAR(20),
Duree INT,
[Status] BIT,
)
