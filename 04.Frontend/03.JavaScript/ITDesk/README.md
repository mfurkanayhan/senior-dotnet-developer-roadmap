# ITDesk

ITDesk is a ticket tracking system designed to allow users to log, manage, and respond to various IT support requests. The system provides a user-friendly interface for recording problems, updating statuses, and tracking resolution processes.

## Modules

The project consists of two main modules:

- **ITDesk.Server:** Handles server-side operations. Developed using .NET Core and Entity Framework.
- **ITDesk.Client:** Contains the client-side interface. Developed using JavaScript, HTML, and CSS.

## Features

- **User Registration and Login:** Users can register to the system and log in using their existing user information.
- **Ticket Creation:** Users can create new tickets detailing the issues they encounter.
- **Ticket Status Update:** Users can update the status of their tickets and add notes related to the tickets.
- **Ticket Deletion:** Users can remove unnecessary tickets from the system.

## Technologies Used

- **Frontend:** JavaScript, HTML, CSS
- **Backend:** .NET Core, Entity Framework
- **Database:** MSSQL
- **Authentication:** JWT

## Installation and Startup

To run the project locally:

1. Clone the repository:

```
git clone https://github.com/mfurkanayhan/senior-dotnet-developer-roadmap.git
```

2. Start the server-side:

```
cd .\04.Frontend\03.JavaScript\ITDesk\ITDesk.Server\
dotnet restore
dotnet run
```

3. To use the client side, open the `ITDesk/ITDesk.Client/index.html` file in your browser.

## Client Interface

The client interface provides a user-friendly environment for managing ticket operations. This interface allows users to create, update, and delete their tickets.

For a better understanding of the project, refer to the project files.