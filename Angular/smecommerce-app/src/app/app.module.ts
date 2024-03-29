import { NgModule } from '@angular/core';

import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ExploreModule } from './explore/explore.module';
import { ProductModule } from './products/product.module';


@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ExploreModule,
    ProductModule

  
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
