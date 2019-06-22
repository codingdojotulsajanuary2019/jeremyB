import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ProductComponent } from './product/product.component';
import { ReviewComponent } from './review/review.component';
import { ProdDetComponent } from './product/prod-det/prod-det.component';
import { BrandComponent } from './product/brand/brand.component';
import { CategoryComponent } from './product/category/category.component';
import { RevDetComponent } from './review/rev-det/rev-det.component';
import { AuthorComponent } from './review/author/author.component';
import { AllComponent } from './review/all/all.component';

@NgModule({
  declarations: [
    AppComponent,
    ProductComponent,
    ReviewComponent,
    ProdDetComponent,
    BrandComponent,
    CategoryComponent,
    RevDetComponent,
    AuthorComponent,
    AllComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
