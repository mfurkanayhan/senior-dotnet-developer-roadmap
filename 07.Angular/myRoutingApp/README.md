# MyRoutingApp

This project demonstrates a very basic routing setup in Angular with four components: Home, About, Not Found, and Login.

## Routing

The navigation is set up using Angular's `routerLink` directive and `RouterOutlet` component. Below are the key points:

1. **Layout Component**: Contains the navigation links and the router outlet to display the selected component.
    - Links to Home, About, Not Found, and Login pages.
    - Uses `routerLinkActive` to highlight the active link.

2. **App Component**: Initializes the Angular application with a `RouterOutlet`.

3. **Login Component HTML**: Contains a button to redirect to the Home page using `routerLink`.

## Development server

Run `ng serve` for a dev server. Navigate to `http://localhost:4200/`. The application will automatically reload if you change any of the source files.

## Summary

This setup demonstrates a simple Angular application with basic routing. Each link in the navigation bar directs to a different component, and the `routerLink` directive is used to navigate between them. The `RouterOutlet` displays the content of the selected component.

For a better understanding of the project, refer to the project files.