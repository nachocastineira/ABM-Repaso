USE Parcial2;

CREATE TABLE Empresa
(
	Id INT IDENTITY,
	Nombre VARCHAR(50),
	Direccion VARCHAR(50),
	Ciudad VARCHAR(50)
	CONSTRAINT PK_Empresa PRIMARY KEY (Id)
);


CREATE TABLE Empleado
(
	Id	INT IDENTITY,
	Nombre VARCHAR(50) NOT NULL,
	Apellido VARCHAR(50),
	Edad INT,
	Id_Empresa INT
	CONSTRAINT PK_Empleado PRIMARY KEY (Id),
	CONSTRAINT FK_Empresa_Empleado FOREIGN KEY (Id_Empresa) REFERENCES Empresa (Id)
);