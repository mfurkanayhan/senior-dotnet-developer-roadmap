# DotNet WebAPI with MongoDB

This project demonstrates a full-stack application using .NET Core WebAPI for the backend and a simple HTML frontend. It interacts with a MongoDB database to perform CRUD operations on todo items.

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

Before you begin, ensure you have the following installed:
- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- [MongoDB](https://www.mongodb.com/try/download/community)
- Any modern web browser that supports JavaScript and Fetch API.

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/mfurkanayhan/senior-dotnet-developer-roadmap.git
   cd 05.ExploratoryTech/02.MongoDB/DotNetWebAPIWithMongoDB
   ```
2. **Start MongoDB**

   Ensure MongoDB is running on your machine. Use the MongoDB service or start it manually:

   ```bash
   mongod
   ```

3. **Run the application**
   
   Navigate to the project directory and run the application using:
   ```bash
   dotnet run
   ```

### Accessing the Application

- **Web API**: Once the application is running, you can access the Web API at **\`https://localhost:7201/swagger`**.
- **Frontend**: Open the **\`index.html**` file in your web browser to interact with the todos.

### Features

- **Add Todo**: Input a task and save it to the MongoDB.
- **Update Todo**: Modify existing tasks.
- **Delete Todo**: Remove tasks individually.
- **Delete All Todos**: Remove all tasks from the database.
- **Seed and Measure**: Populate the database with sample data and measure the operation time.

### API Endpoints

- **\`GET /api/values/getAll`**: Retrieves all todos.
- **\`POST /api/values/save`**: Adds a new todo.
- **\`POST /api/values/update`**: Updates an existing todo.
- **\`POST /api/values/removeById`**: Deletes a specific todo.
- **\`GET /api/values/removeAll`**: Deletes all todos.
- **\`GET /api/values/seedAndMeasure`**: Seeds the database with todos and measures the time taken.