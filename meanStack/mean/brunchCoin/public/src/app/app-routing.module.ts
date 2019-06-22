import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {BrowseComponent} from './browse/browse.component';
import {BuyComponent} from './buy/buy.component';
import {DetailsComponent} from './details/details.component';
import {HomeComponent} from './home/home.component';
import {MineComponent} from './mine/mine.component';
import {SellComponent} from './sell/sell.component';

const routes: Routes = [
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
