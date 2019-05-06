import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { RecipeSearchModel } from '../models/recipes.search.model';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { RecipeOutputModel } from '../models/recipe.output.model';

@Injectable()
export class RecipeService {

    constructor(private httpClient: HttpClient) { }

    getRecipes(searchParam: RecipeSearchModel): Observable<RecipeOutputModel> {
        const url = environment.baseApiLink + environment.baseUrls.getRecipeUrl;
        const queryString = Object.keys(searchParam).map(key => key + '=' + searchParam[key] || '').join('&');
        return this.httpClient.get<RecipeOutputModel>(url + '?' + queryString);
    }
}