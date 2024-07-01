import { Component } from '@angular/core';
import { environment } from '../environments/environment';
import { api } from './constants';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'app_module';
  apiUrl: string = api;
  isTrue: boolean = true;
}
