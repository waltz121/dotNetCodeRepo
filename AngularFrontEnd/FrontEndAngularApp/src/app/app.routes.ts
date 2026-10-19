import { Routes } from '@angular/router';
import { Tictactoe } from './pages/tictactoe/tictactoe';
import { Homepage } from './pages/homepage/homepage';

export const routes: Routes = [
  { path: '', component: Homepage, title: 'Home Page'},
  { path: 'tictactoe', component: Tictactoe }
];
