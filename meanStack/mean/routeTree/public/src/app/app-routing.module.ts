import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import {ProductComponent} from './product/product.component';
import {ProdDetComponent} from './product/prod-det/prod-det.component';
import {BrandComponent} from './product/brand/brand.component';
import {CategoryComponent} from './product/category/category.component';

import {ReviewComponent} from './review/review.component';
import {RevDetComponent} from './review/rev-det/rev-det.component';
import {AuthorComponent} from './review/author/author.component';
import {AllComponent} from './review/all/all.component';

const routes: Routes = [
  {path:'products', component: ProductComponent, children: [
    {path: 'details/:id', component: ProdDetComponent},
    {path: 'brand/:brand', component: BrandComponent},
    {path: 'category/:cat', component: CategoryComponent}
  ]},
  {path:'reviews', component: ReviewComponent, children: [
    {path:'details/:id', component: RevDetComponent},
    {path:'author/:id', component: AuthorComponent},
    {path:'all/:id', component: AllComponent}
  ]},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
