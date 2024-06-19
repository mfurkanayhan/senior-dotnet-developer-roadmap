import { Component, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-operations',
  standalone: true,
  imports: [],
  template: `
  <button (click)="increment()">+</button>
  <button (click)="decrement()">-</button>  
  `

})
export class OperationsComponent {
  @Output() myIncrementEvent = new EventEmitter();
  @Output() myDecrementEvent = new EventEmitter();

  decrement() {
    this.myDecrementEvent.emit();
  }

  increment() {
    this.myIncrementEvent.emit();
  }

}
