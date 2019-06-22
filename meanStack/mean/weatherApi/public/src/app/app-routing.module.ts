import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {TulsaComponent } from './tulsa/tulsa.component';
import {DallasComponent } from './dallas/dallas.component';
import {ChicagoComponent } from './chicago/chicago.component';
import {SeattleComponent } from './seattle/seattle.component';
import {BurbankComponent } from './burbank/burbank.component';
import {WashingtonComponent } from './washington/washington.component';


const routes: Routes = [
  {path: 'tulsa', component: TulsaComponent},
  {path: 'dallas', component: DallasComponent},
  {path: 'chicago', component: ChicagoComponent},
  {path: 'seattle', component: SeattleComponent},
  {path: 'burbank', component: BurbankComponent},
  {path: 'washington', component: WashingtonComponent},
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
  
})
export class AppRoutingModule { }
