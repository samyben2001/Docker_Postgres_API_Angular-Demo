import { inject, Injectable } from '@angular/core';
import { environment } from '../../environments/environment';
import { HttpClient } from '@angular/common/http';
import { Film } from '../models/film';
import { Observable } from 'rxjs';

const BASE_URL = environment.apiUrl;

@Injectable({
  providedIn: 'root',
})
export class FilmService {
  private readonly _http = inject(HttpClient)
  
  getFilms(): Observable<Film[]> {
    return this._http.get<Film[]>(`${BASE_URL}film`);
  }
}
