import { Directive, ElementRef, HostListener, Input } from '@angular/core';

@Directive({
  selector: '[myDirective]'
})
export class MyDirectiveDirective {

  @Input() myDirective:boolean = false;
  @Input() name: string = "";
  count: number = 0;
  constructor(
    private el: ElementRef<HTMLHeadElement>
  ) {  }


  @HostListener("mouseenter") metot1(){
    this.count++;
    //console.log(this.el);
    // alert("The JavaScript code has been executed");
    // const element = document.querySelector("h1");
    // console.log(element)
    console.log(this.myDirective);
    console.log(this.name)

    console.log("Mouse hovers over this element: " + this.count);
  }

}
