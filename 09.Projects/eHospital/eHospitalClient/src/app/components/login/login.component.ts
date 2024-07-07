import { Component, ElementRef, ViewChild } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { FormsModule, NgForm } from '@angular/forms';
import { Router } from '@angular/router';
import { FormValidateDirective } from 'form-validate-angular';

import { LoginModel } from '../models/login.model';

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [FormsModule, FormValidateDirective],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent {
  @ViewChild("password") password: ElementRef<HTMLInputElement> | undefined;

  isShowPassword: boolean = false;
  loginModel: LoginModel = new LoginModel();

  constructor(
    private http: HttpClient,
    private router: Router
  ){}

  showOrHidePassword(){
    this.isShowPassword = !this.isShowPassword;

    if(this.isShowPassword){
      this.password!.nativeElement.type = "text";
    }else{
      this.password!.nativeElement.type = "password";
    }
  }

  login(form: NgForm){
    if (form.valid) {
      this.http.post("https:localhost:7099/api/auth/login", this.loginModel).subscribe({
        next: (res:any) => {
          localStorage.setItem("token", res.data.token);
          this.router.navigateByUrl("/");
        },
        error: (err: HttpErrorResponse)=> {
          console.log(err);
        }
      })
    }
  }
}