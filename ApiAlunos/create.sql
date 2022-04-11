/* Create Tables */

CREATE TABLE Alunos (   Id INTEGER NOT NULL CONSTRAINT PK_Alunos PRIMARY KEY AUTOINCREMENT, 
                        Matricula TEXT,
                        Nome TEXT, 
                        DtNascimento TEXT NOT NULL);
CREATE TABLE Turmas (   Id INTEGER NOT NULL CONSTRAINT PK_Turmas PRIMARY KEY AUTOINCREMENT, 
                        Nome TEXT,
                        Turno INTEGER);

/* Populate Tables */

INSERT INTO Alunos(Id, Matricula, Nome, DtNascimento) VALUES (1, '032022EF000123', 'Eduardo Sousa Trindade', '2009-10-15 00:00:00');
INSERT INTO Alunos(Id, Matricula, Nome, DtNascimento) VALUES (2, '032022EF000456', 'Gustavo Accury Paiva', '2008-11-11 00:00:00');
INSERT INTO Alunos(Id, Matricula, Nome, DtNascimento) VALUES (4, '032021EF000789', 'Francisco Araujo Paixão', '2010-01-05 00:00:00');
INSERT INTO Alunos(Id, Matricula, Nome, DtNascimento) VALUES (5, '032022EF000221', 'Ana Beatriz Galvão', '2016-08-25 00:00:00');
INSERT INTO Alunos(Id, Matricula, Nome, DtNascimento) VALUES (6, '032020EF000113', 'Denilton Machado Paz', '2010-12-07 00:00:00');
INSERT INTO Alunos(Id, Matricula, Nome, DtNascimento) VALUES (7, '032022EF000003', 'Gabriel Arraz Prado', '2009-10-23 00:00:00');
INSERT INTO Alunos(Id, Matricula, Nome, DtNascimento) VALUES (8, '032019EM000333', 'Geovana Benveval Dias', '2016-10-13 00:00:00');
INSERT INTO Alunos(Id, Matricula, Nome, DtNascimento) VALUES (9, '032021EM000122', 'Kennedy Brastemp', '2010-10-11 00:00:00');
INSERT INTO Alunos(Id, Matricula, Nome, DtNascimento) VALUES (10, '032021EF000523', 'Mitchell Aragão', '2007-01-19 00:00:00');
INSERT INTO Alunos(Id, Matricula, Nome, DtNascimento) VALUES (11, '032019EM000113', 'Marcos Eduardo', '2008-01-10 00:00:00');
INSERT INTO Alunos(Id, Matricula, Nome, DtNascimento) VALUES (12, '032017EM000083', 'Douglas Dultra', '2014-10-04 00:00:00');
INSERT INTO Alunos(Id, Matricula, Nome, DtNascimento) VALUES (13, '032017EF000023', 'Patric Oliveira', '2014-03-29 00:00:00');
INSERT INTO Alunos(Id, Matricula, Nome, DtNascimento) VALUES (14, '032022EF000111', 'Douglas Oliveira', '2005-02-15 00:00:00');
INSERT INTO Alunos(Id, Matricula, Nome, DtNascimento) VALUES (15, '032022EF000189', 'Saulo Olanda Silva Sauro', '2010-03-15 00:00:00');
INSERT INTO Turmas(Id, Nome, Turno) VALUES (1, '06M5A', 1);
INSERT INTO Turmas(Id, Nome, Turno) VALUES (2, '08M3D', 1);
INSERT INTO Turmas(Id, Nome, Turno) VALUES (3, '07M8E', 1);
INSERT INTO Turmas(Id, Nome, Turno) VALUES (4, '06V4B', 2);
