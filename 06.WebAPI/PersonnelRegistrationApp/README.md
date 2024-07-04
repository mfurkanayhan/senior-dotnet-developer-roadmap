# PersonnelRegistrationApp.WebAPI

PersonnelRegistrationApp.WebAPI is a simple RESTful API that manages personnel records. Developed with .NET 5, this project includes basic CRUD functionalities.

## Features

- Add, update, delete, and list personnel.
- Upload and manage personnel photographs.
- Robust data validation mechanisms.
- Swagger UI integration.

## Getting Started

This section describes the steps to set up and run the project on your local machine.

### Prerequisites

To run the project, the following tools must be installed:
- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- Visual Studio 2022

### Installation

1. Clone or download the project from GitHub:
    ```sh
    git clone https://github.com/mfurkanayhan/senior-dotnet-developer-roadmap.git
    ```

2. Navigate to the `PersonnelRegistrationApp.WebAPI` directory:
    ```sh
    cd .\06.WebAPI\PersonnelRegistrationApp\
    ```

3. Restore dependencies and build the project:
    ```sh
    dotnet restore
    dotnet build
    ```

### Running

To run the project:

```sh
dotnet run
```

You can test the API via Swagger UI by going to `http://localhost:7241/swagger` in your browser.

## API Usage

The primary endpoints of the API include:

- `GET /api/Personnels/GetAll` - Lists all personnel.
- `POST /api/Personnels/Add` - Adds a new personnel.
- `PUT /api/Personnels/Update/{id}` - Updates a personnel with the specified ID.
- `DELETE /api/Personnels/DeleteById/{id}` - Deletes a personnel with the specified ID.

For detailed information and testing capabilities for each endpoint, run the project and use the Swagger UI interface.

For a better understanding of the project, refer to the project files.

