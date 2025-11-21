-- CREATE DATABASE moviedb;

\c moviedb

CREATE TABLE film (
    id SERIAL PRIMARY KEY,
    titrefr VARCHAR(255),
    titreca VARCHAR(255),
    annee INTEGER
);

INSERT INTO film(titrefr, titreca, annee) VALUES('Seven', 'Sept', 1995);
INSERT INTO film(titrefr, titreca, annee) VALUES('Les Évadés', 'À l''ombre de Shawshank', 1994);
INSERT INTO film(titrefr, titreca, annee) VALUES('Inglourious Basterds', 'Le Commando des Bâtards', 2009);
