# MyPersonelApp

This is a simple personnel management application built with Angular. It allows you to manage personnel data including adding, updating, and deleting personnel records. The data is fetched from a local JSON server.

## Features

- Add new personnel
- Update existing personnel
- Delete personnel
- Search and filter personnel by name or profession
- Paginate through personnel records

## Technologies Used

- Angular
- JSON Server
- Bootstrap for UI
- Font Awesome for icons

## Installation

1. Clone the repository:
    ```sh
    git clone https://github.com/mfurkanayhan/senior-dotnet-developer-roadmap.git
    ```
2. Navigate to the project directory:
    ```sh
    cd .\07.Angular\myPersonelApp\
    ```
3. Install the dependencies:
    ```sh
    npm install
    ```

## Running the Application

1. Start the JSON server:
    ```sh
    json-server --watch .\src\assets\db.json
    ```
2. Run the Angular application:
    ```sh
    ng serve
    ```
3. Open your browser and navigate to `http://localhost:4200`.

## Usage

- Click the "Add Personnel" button to add a new personnel.
- Use the search bar to filter personnel by first name, last name, or profession.
- Click the edit button to update personnel details.
- Click the delete button to remove a personnel.

## Notes

- The search functionality is case-insensitive.
- Personnel records are sorted by first name in descending order.

For a better understanding of the project, refer to the project files.