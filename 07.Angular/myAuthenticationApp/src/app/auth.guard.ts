import { CanDeactivateFn } from '@angular/router';
import { AboutComponent } from './about/about.component';

export const authGuard: CanDeactivateFn<AboutComponent> = (component, currentRoute, currentState, nextState) => {
  /*
  console.log(currentState); // Current address
  console.log(nextState);    // Desired address
  return false;
  */
  const result = confirm("Do you want to leave the page?");

  return result;
};

// Guard was previously used for authentication control.
// With Angular 16 and 17, it is no longer used.
// The only function used from the Guard is CanDeactivate. It checks the exit process of the page.

// Component
// Directive
// Pipe
// Guard
