import { Component, ElementRef, ViewChild } from '@angular/core';
import { PersonelModel, ProfessionType } from '../models/personel.model';
import { FormsModule, NgForm } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { PersonelPipe } from '../pipes/personel.pipe';
import { NgxPaginationModule } from 'ngx-pagination';

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [FormsModule, CommonModule, PersonelPipe, NgxPaginationModule],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent {
  @ViewChild("addPersonelModalCloseBtn") addCloseBtn: ElementRef<HTMLButtonElement> | undefined;
  @ViewChild("updatePersonelModalCloseBtn") updateCloseBtn: ElementRef<HTMLButtonElement> | undefined;

  p:number = 1;

  personels: PersonelModel[] = [];
  createModel: PersonelModel = new PersonelModel();
  updateModel: PersonelModel = new PersonelModel();
  
  professions: ProfessionType[] = ["Accountant", "Software", "Teacher"];
  
  search: string = "";

  constructor(
    private http: HttpClient
  ) {
    this.getAll();
  }

  getAll() {
    this.http.get<PersonelModel[]>("http://localhost:3000/personels")
      .subscribe({
        next: (res) => {
          this.personels = res.sort((a, b) => b.firstName.localeCompare(a.firstName));
        },
        error: (err: HttpErrorResponse) => {
          console.log(err);
        }
      })
  }

  create(form: NgForm) {
    if (form.valid) {
      this.http.post("http://localhost:3000/personels", this.createModel)
        .subscribe({
          next: (res: any) => {
            this.createModel = new PersonelModel();
            /*
            //const el = document.getElementById("addPersonelModalCloseBtn");
            const el: HTMLButtonElement = document.getElementById("addPersonelModalCloseBtn") as HTMLButtonElement;
            el?.click();
            */
            /* Above, I showed a way to access the element with JavaScript. However, JavaScript can cause potential problems in Single Page Applications.
            I'm not saying JavaScript will definitely cause errors. I'm saying we need to completely eliminate the possibility of errors. Because JavaScript might not find this element, JavaScript might encounter an error while trying to find this element, or even if JavaScript finds this element, it might fail or fail to render, etc.
            Therefore, the following usage is recommended in Angular. */
            this.addCloseBtn?.nativeElement.click(); 
            this.getAll();
          },
          error: (err: HttpErrorResponse) => {
            console.log(err);
          }
        })
    }
  }

  removeById(id: string){
    this.http.delete("http://localhost:3000/personels/" + id)
    .subscribe({
      next: (res:any)=> {
        this.getAll();
      },
      error: (err: HttpErrorResponse)=> {
        console.log(err);
      }
    })
  }

  get(personel:PersonelModel){
    this.updateModel = {...personel};
    
  }

  update(form:NgForm){
    if (form.valid) {
      this.http.put("http://localhost:3000/personels/" + this.updateModel.id, this.updateModel)
      .subscribe({
        next: (res:any)=> {
          this.updateCloseBtn?.nativeElement.click();
          this.getAll();
        },
        error: (err: HttpErrorResponse) => {
          console.log(err);                    
        },
      })
    }    
  }
  checkValidation(input: any){
    const valid: boolean = input.validity.valid;
    
  }
}
