import { Component, OnInit, Input } from '@angular/core';
import { RecipeModel } from 'src/app/models/recipes.model';

@Component({
  selector: 'app-recipe-card',
  templateUrl: './recipe-card.component.html',
  styleUrls: ['./recipe-card.component.scss']
})
export class RecipeCardComponent implements OnInit {

  @Input("recipe")
  recipe: RecipeModel

  constructor() { }

  ngOnInit() {
  }

}
