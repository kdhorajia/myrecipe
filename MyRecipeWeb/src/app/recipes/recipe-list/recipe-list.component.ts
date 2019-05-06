import { Component, OnInit } from '@angular/core';
import { RecipeModel } from 'src/app/models/recipes.model';
import { PageEvent } from '@angular/material';
import { RecipeService } from 'src/app/services/recipe.services';
import { RecipeSearchModel } from 'src/app/models/recipes.search.model';
import { FormGroup, FormBuilder, FormControlName } from '@angular/forms';


@Component({
  selector: 'app-recipe-list',
  templateUrl: './recipe-list.component.html',
  styleUrls: ['./recipe-list.component.scss']
})
export class RecipeListComponent implements OnInit {

  searchForm: FormGroup;
  
  totalCount: number;
  pageSize = 10;
  pageSizeOptions: number[] = [5, 10, 25, 100];
  recipeName: string = "";
  searchParam: RecipeSearchModel;

  recipeList: RecipeModel[] = []

  recipeNameControl: FormControlName;

  constructor(private recipeService: RecipeService, private formBuilder: FormBuilder) { }

  ngOnInit() {
    this.buildForm();
    this.searchParam = new RecipeSearchModel("", 0, this.pageSize);
    this.searchParam.recipeName = this.searchForm.controls.recipeNameControl.value;
    this.searchData();
  }

  getPage(page: PageEvent) {
    const startRecordNumber = page.pageIndex * page.pageSize;
    this.searchParam = new RecipeSearchModel(this.recipeName, startRecordNumber, this.pageSize);
    this.searchData();
  }

  searchData() {
     this.searchParam.recipeName = this.searchForm.controls.recipeNameControl.value || '';
     this.recipeService.getRecipes(this.searchParam).subscribe((data) => {
       this.totalCount = data.totalCount;
       this.recipeList = data.resultSet;
     })
  }

  buildForm() {
    this.searchForm = this.formBuilder.group({
      recipeNameControl: this.formBuilder.control(null, []),
    });
  }

}
