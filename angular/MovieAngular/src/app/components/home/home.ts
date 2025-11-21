import { Component, inject, OnInit } from '@angular/core';
import { FilmService } from '../../services/film-service';
import { Film } from '../../models/film';

@Component({
  selector: 'app-home',
  imports: [],
  templateUrl: './home.html',
  styleUrl: './home.scss',
})
export class Home implements OnInit {
  private readonly _serv = inject(FilmService)

  films?: Film[];

  ngOnInit(): void {
    this._serv.getFilms().subscribe({
      next: (films) => {
        this.films = films;
      }
    });
  }
}
