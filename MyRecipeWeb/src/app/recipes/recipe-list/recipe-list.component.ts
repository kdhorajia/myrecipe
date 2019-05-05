import { Component, OnInit } from '@angular/core';
import { RecipeModel } from 'src/app/models/recipes.model';

@Component({
  selector: 'app-recipe-list',
  templateUrl: './recipe-list.component.html',
  styleUrls: ['./recipe-list.component.scss']
})
export class RecipeListComponent implements OnInit {

  recipeList: RecipeModel[] = []
  constructor() { }

  ngOnInit() {
    this.recipeList.push(new RecipeModel('Win\'s Shrimp and Spaghetti', 'Fresh shrimp simmered in butter, teriyaki sauce and Creole-style seasoning, served over pasta.', 'Jeremie Lumandong', '../../../assets//products/product1.jpg'));
    this.recipeList.push(new RecipeModel('Chicken Pot Pie IX', 'A delicious chicken pot pie made from scratch with carrots, peas, and celery for a comfort.', 'Lili Lumandong', '../../../assets//products/product2.jpg'));
    this.recipeList.push(new RecipeModel('Chicken Marsala Over White Rice', 'A delicious chicken pot pie made from scratch with carrots, peas, and celery for a comfort.', 'Jane Doe', '../../../assets//products/product3.jpg'));
    this.recipeList.push(new RecipeModel('Spicy Thai Basil Chicken', 'A delicious chicken pot pie made from scratch with carrots, peas, and celery for a comfort.', 'Alex Supper', '../../../assets//products/product4.jpg'));
    this.recipeList.push(new RecipeModel('Moroccan Chicken Tagine', 'A delicious chicken pot pie made from scratch with carrots, peas, and celery for a comfort.', 'Tony Stark', '../../../assets//products/product5.jpg'));
  }

}
