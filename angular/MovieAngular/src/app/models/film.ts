export interface FilmBase {
    titreFR: string;
    titreCA: string;
    annee: number;
}

export interface Film extends FilmBase {
    id: number;
}