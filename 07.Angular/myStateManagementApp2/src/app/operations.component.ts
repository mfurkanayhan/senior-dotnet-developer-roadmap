import { Component } from "@angular/core";
import { CountService } from "./count.service";

@Component({
    standalone: true,
    selector: "app-operations",
    template: `
    <button (click)="c.increment()">+</button>
    <button (click)="c.decrement()">-</button>
    
    
    `
})
export class OperationsComponent{
    constructor(public c:CountService){

    }
    
}