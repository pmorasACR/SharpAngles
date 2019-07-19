import { logging } from 'protractor';

export class TodoItem {
    id: number;
    isComplete: boolean;

    constructor(public name : string){
        
    }
}
