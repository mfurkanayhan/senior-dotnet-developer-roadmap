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

## Notes

- The authentication guard uses JWT tokens stored in `localStorage` to verify user authentication.
- The guard for the about page asks for confirmation before navigating away.

For a better understanding of the project, refer to the project files.