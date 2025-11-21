-- CREATE DATABASE moviedb;

\c moviedb

CREATE TABLE film (
    id SERIAL PRIMARY KEY,
    titre_fr VARCHAR(255),
    titre_ca VARCHAR(255),
    annee INTEGER
);

INSERT INTO film(titre_fr, titre_ca, annee) VALUES('Seven', 'Sept', 1995);
INSERT INTO film(titre_fr, titre_ca, annee) VALUES('Les Évadés', 'À l''ombre de Shawshank', 1994);
INSERT INTO film(titre_fr, titre_ca, annee) VALUES('Inglourious Basterds', 'Le Commando des Bâtards', 2009);
