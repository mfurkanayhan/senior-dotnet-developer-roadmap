# MyAuthenticationApp

This project is a simple authentication application built with Angular. It demonstrates basic login functionality using access tokens.

## Features

- **Home Page**: A simple home page that indicates the application is working.
- **About Page**: An about page with basic content.
- **Login Page**: A login page where users can sign in.
- **Authentication Guard**: Protects routes to ensure only authenticated users can access certain parts of the application.
- **JWT Decoding**: Uses JWT tokens to handle authentication.

## Installation

1. Clone the repository:
    ```sh
    git clone https://github.com/mfurkanayhan/senior-dotnet-developer-roadmap.git
    ```
2. Navigate to the project directory:
    ```sh
    cd .\07.Angular\myAuthenticationApp\
    ```
3. Install the dependencies:
    ```sh
    npm install
    ```

## Running the Application

1. Run the Angular application:
    ```sh
    ng serve
    ```
2. Open your browser and navigate to `http://localhost:4200`.

## Usage

- **Login**: Navigate to the login page, enter your credentials, and sign in to access the protected routes.
- **Protected Routes**: The home and about pages are protected by an authentication guard. Only authenticated users can access these pages.
- **Navigation**: Use the navigation links to switch between the home, about, and login pages.

## Authentication Details

- The authentication guard uses JWT tokens stored in `localStorage` to verify user authentication.
- Specifically, the token is stored under the name `accessToken`.
- When a user logs in, an `accessToken` is generated and stored in `localStorage`.
- To generate a JWT token, you can use online tools such as [jwt.io](https://jwt.io/).
  - For example, you can create a JWT token by providing a payload and a secret key on the [jwt.io](https://jwt.io/) website.
  - The generated token can then be used as the `accessToken` in the application.
- The `AuthService` checks if the `accessToken` is present in `localStorage` and verifies its validity.
  - If the token is valid, the user is considered authenticated.
  - If the token is invalid or not present, the user is redirected to the login page.

## Notes

- The authentication guard uses JWT tokens stored in `localStorage` to verify user authentication.
- The guard for the about page asks for confirmation before navigating away.

For a better understanding of the project, refer to the project files.