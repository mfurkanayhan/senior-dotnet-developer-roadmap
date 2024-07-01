import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BlogComponent } from './blog/blog.component';
import { MyDirectiveDirective } from './my-directive.directive';
import { SearchPipe } from './search.pipe';

@NgModule({
  declarations: [ // Buraya component, directive ve pipe eklenir.
    AppComponent,
    BlogComponent,
    MyDirectiveDirective,
    SearchPipe
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
