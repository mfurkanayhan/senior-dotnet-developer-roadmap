# SimpleTodoAPI

This project, SimpleTodoAPI, is a simple ASP.NET Core Web API for managing a todo list. It allows users to view and add todo items through a RESTful API.

## Features

- **Get Todos**: Retrieve all todo items.
- **Add Todo**: Add a new item to the todo list.

## Endpoints

### GET /api/Home/Get

This endpoint returns a list of all current todo items. It starts with the item "Furkan Ayhan".

### POST /api/Home/Add

This endpoint adds a new todo item to the list. The request should include a `User` object, which carries the `Name` and `LastName` fields to be added to the todo list.

## Usage

Each endpoint works with JSON data types. For example, a POST request to the `Add` endpoint might look like this:

```json
{
  "Name": "John",
  "LastName": "Doe"
}
