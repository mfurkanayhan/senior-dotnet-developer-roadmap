import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterOutlet } from '@angular/router';
import { TableComponent } from './table/table.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule, RouterOutlet, TableComponent],
  template: `
  <app-table [headers]="headers">
    @for(user of users; track user){
          <tr>
            <td>{{$index + 1}}</td>
            <td>{{user.firstName}}</td>
            <td>{{user.lastName}}</td>
            <td>{{user.profession}}</td>
          </tr>
        }
  </app-table>
  `
})
export class AppComponent {
  headers: {name: string, desc: boolean}[] = [
    {
      name: "#",
      desc: false
    },
    {
      name: "Name",
      desc: false
    },
    {
      name: "Surname",
      desc: false
    },
    {
      name: "Profession",
      desc: false
    },
  ]
  users = [
    {
      firstName: "John",
      lastName: "Doe",
      profession: "Software"
    },
    {
      firstName: "Jane",
      lastName: "Doe",
      profession: "Software"
    },{
      firstName: "Jack",
      lastName: "Doe",
      profession: "Software"
    },{
      firstName: "Baby",
      lastName: "Doe",
      profession: "Software"
    },
  ]
}
