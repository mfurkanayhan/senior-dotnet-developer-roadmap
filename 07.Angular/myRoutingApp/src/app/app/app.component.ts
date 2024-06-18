import { Component } from "@angular/core";
import { RouterOutlet } from "@angular/router";

@Component({
    selector: "app-root",
    template: `<router-outlet></router-outlet>`,
    standalone: true,
    // imports: [CommonModule] //Allows us to use *ngIf and *ngFor directives
    imports: [RouterOutlet]

})
export class AppComponent {

}