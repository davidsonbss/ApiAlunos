CREATE TABLE Alunos (
    Id INTEGER NOT NULL CONSTRAINT PK_Alunos PRIMARY KEY AUTOINCREMENT,
    Matricula TEXT,
    Nome TEXT,
    DtNascimento TEXT NOT NULL
);
CREATE TABLE Turmas (
    Id INTEGER NOT NULL CONSTRAINT PK_Turmas PRIMARY KEY AUTOINCREMENT,
    Nome TEXT,
    Turno INTEGER
);
INSERT INTO Turmas(Id, Nome, Turno)
VALUES(1, '08M3D', 1)
