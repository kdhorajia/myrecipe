import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators, FormControlName } from '@angular/forms';

@Component({
  selector: 'app-recipe-add',
  templateUrl: './recipe-add.component.html',
  styleUrls: ['./recipe-add.component.scss']
})
export class RecipeAddComponent implements OnInit {

  addForm: FormGroup;
  recipeNameControl: FormControlName;

  constructor(private formBuilder: FormBuilder) { }

  ngOnInit() {
    this.buildForm();
  }

  buildForm(){
    this.addForm = this.formBuilder.group({
      recipeNameControl: this.formBuilder.control(null, [Validators.required]),
    });
  }

  isValidInputClass(controlName: string) {

    if(this.addForm.controls[controlName].pristine) {
      return;
    }

    if(this.addForm.controls[controlName].errors === null){
      return 'is-success';
    }

    if(this.addForm.controls[controlName].errors.required){
      return 'is-danger';
    }

    return;
  }

}
