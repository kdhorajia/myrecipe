import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NavBarComponent } from './layout/nav-bar/nav-bar.component';
import { MatToolbarModule, MatIconModule, MatButtonModule, MatCardModule, MatGridListModule, MatPaginatorModule } from '@angular/material';
import { RecipeListComponent } from './recipes/recipe-list/recipe-list.component';
import { RecipeCardComponent } from './recipes/recipe-card/recipe-card.component';
import { TruncatePipe } from './pipes/truncate.pipe';
import { RecipeAddComponent } from './recipes/recipe-add/recipe-add.component';
import { HeroBodyComponent } from './layout/hero-body/hero-body.component';

@NgModule({
  declarations: [
    AppComponent,
    NavBarComponent,
    RecipeListComponent,
    RecipeCardComponent,
    TruncatePipe,
    RecipeAddComponent,
    HeroBodyComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    MatToolbarModule,
    MatIconModule,
    MatButtonModule,
    MatCardModule,
    MatGridListModule,
    MatPaginatorModule,
    BrowserAnimationsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
