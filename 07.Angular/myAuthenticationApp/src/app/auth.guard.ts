import { CanDeactivateFn } from '@angular/router';
import { AboutComponent } from './about/about.component';

export const authGuard: CanDeactivateFn<AboutComponent> = (component, currentRoute, currentState, nextState) => {
  /*
  console.log(currentState); // Mevcut bulunduğu adres
  console.log(nextState);    // Gitmek istediği adres
  return false;
  */
  const result = confirm("Sayfadan çıkmak istiyor musunuz?");

  return result;
};

// Guard eskiden authentication kontrolü için kullanılıyordu.
// Angular 16, 17 ile artık kullanılmıyor.
// Guard'ın kullanılan tek fonksiyonu CanDeactive. O da sayfanın çıkış işlemini kontrol ediyor.


// Component
// Directive
// Pipe
// Guard