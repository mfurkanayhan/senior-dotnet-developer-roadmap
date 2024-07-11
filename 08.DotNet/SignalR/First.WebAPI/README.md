# SignalR Web API Project

This project implements a basic real-time messaging system using ASP.NET Core and SignalR. The project provides a simple structure where users and groups can send real-time messages.

## Features

- **Real-Time Communication**: Users can send and receive messages instantly.
- **User Management**: Users can join and leave the server.
- **Group Management**: Users can join and leave groups.

## Project Structure

- **Controllers**: Contains the API endpoints.
  - `ValuesController.cs`: Contains API endpoints for message sending.
- **DTOs**: Data transfer objects.
  - `Chat.cs`: DTO representing message data.
  - `Group.cs`: DTO representing group data.
- **Hubs**: Contains the SignalR hubs.
  - `ChatHub.cs`: SignalR hub for user and group management.
- **Properties**: Project configuration files.
- **Program.cs**: The entry point and service configuration for the application.

## Setup

To run the project locally, follow these steps:

1. **Clone the Repository**:
    ```bash
    git clone https://github.com/mfurkanayhan/senior-dotnet-developer-roadmap.git
    cd .\08.DotNet\SignalR\First.WebAPI\
    ```

2. **Install Dependencies**:
    ```bash
    dotnet restore
    ```

3. **Start the Application**:
    ```bash
    dotnet run
    ```

## Usage

Once the application is running, you can use the following API endpoints:

- **Send a Message to All Users**:
  - `GET /api/values/send?name={name}&message={message}`

- **Send a Message to a Group**:
  - `GET /api/values/sendGroup?groupName={groupName}&name={name}&message={message}`

## SignalR Endpoint

The SignalR hub is running at the `/chat-hub` endpoint. You can connect a SignalR client to this endpoint for real-time communication.

## Sample SignalR Client (JavaScript)

```javascript
const connection = new signalR.HubConnectionBuilder()
    .withUrl("/chat-hub")
    .build();

connection.on("receive", (chat) => {
    console.log(`Received message from ${chat.name}: ${chat.message}`);
});

connection.start().catch(err => console.error(err.toString()));
```

For a better understanding of the project, refer to the project files.

---