import { Component } from '@angular/core';
import { CountComponent } from './count.component';
import { OperationsComponent } from './operations.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CountComponent, OperationsComponent],
  template: `
  <app-count></app-count>
  <app-operations></app-operations>
  `

})
export class AppComponent {}
