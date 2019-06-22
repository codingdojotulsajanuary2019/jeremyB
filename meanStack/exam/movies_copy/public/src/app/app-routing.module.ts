import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { HomeComponent } from './home/home.component';
import { ShowComponent } from './show/show.component';
import { ReviewComponent } from './review/review.component';

const routes: Routes = [
  {path: 'home', component: HomeComponent},
  {path: 'review/:id', component: ReviewComponent},
  {path: 'show/:id', component: ShowComponent},
  {path: '', pathMatch:'full', redirectTo:'/home'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
