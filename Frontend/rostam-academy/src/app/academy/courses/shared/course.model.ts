import { CourseCategory } from "../../course-categories/shared/course-category.model";

export class Course {
    public id:number;
    public title:string;
    public category:CourseCategory;

    constructor(id:number, title:string){
        this.id = id;
        this.title = title;
    }
}