export class RecipeSearchModel {
    constructor(public recipeName: string = "",
        public startRecordNumber: number = 0,
        public pageSize: number = 10,
        public sortBy?: string) { }
}