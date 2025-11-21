import { Routes } from '@angular/router';
import { Home } from './components/home/home';

export const routes: Routes = [
    {
        path: '',
        component: Home,
        pathMatch: 'full'
    },
    {
        path: 'filmCreation',
        loadComponent: () => import('./components/film-creation/film-creation').then(m => m.FilmCreation)
    }
];
