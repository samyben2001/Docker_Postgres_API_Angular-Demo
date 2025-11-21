import { inject, Injectable } from '@angular/core';
import { environment } from '../../environments/environment';
import { HttpClient } from '@angular/common/http';
import { Film, FilmBase } from '../models/film';
import { Observable } from 'rxjs';

const BASE_URL_READ = environment.apiReadUrl;
const BASE_URL_WRITE = environment.apiWriteUrl;

@Injectable({
  providedIn: 'root',
})
export class FilmService {
  private readonly _http = inject(HttpClient)
  
  getFilms(): Observable<Film[]> {
    return this._http.get<Film[]>(`${BASE_URL_READ}film`);
  }

  addFilm(film: FilmBase): Observable<any> {
    return this._http.post<any>(`${BASE_URL_WRITE}film`, film);
  }
}
