import { Component, inject, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { FilmService } from '../../services/film-service';
import { Router } from '@angular/router';
import { FilmBase } from '../../models/film';

@Component({
  selector: 'app-film-creation',
  imports: [ReactiveFormsModule],
  templateUrl: './film-creation.html',
  styleUrl: './film-creation.scss',
})
export class FilmCreation implements OnInit {
  private readonly _serv = inject(FilmService);
  private readonly _fb = inject(FormBuilder);
  private readonly _router = inject(Router)

  form!: FormGroup

  ngOnInit(): void {
    this.form = this._fb.group({
      titrefr: ['', [Validators.required]],
      titreca: ['', [Validators.required]],
      annee: ['', [Validators.required]],
    })
  }

  submit() {
    if (this.form.invalid) return

    this._serv.addFilm(this.form.value).subscribe({
      next: (data) => {
        console.log(data);
        this._router.navigate(['']);
      }
    });
  }

  back() {
    this._router.navigate(['']);
  }
}
