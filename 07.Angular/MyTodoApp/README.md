# MyTodoApp

## Description
This Todo App is a simple web application developed using Angular that allows users to manage their tasks. It features the ability to add, delete, and update tasks. The app uses a `json-server` to mimic an API server, allowing for full CRUD functionality through HTTP requests.

## Features
- **Add Todo:** Users can add new tasks to their todo list.
- **Update Todo:** Tasks can be edited by clicking the "Update" button next to any task.
- **Delete Todo:** Tasks can be removed by clicking the "Delete" (Delete) button.
- **Persistence:** Changes are persisted on a mock server using `json-server`, simulating interaction with a backend API.

## Project Structure
- **app.component.ts:** Manages the root component of the application, including task creation, update, and removal.
- **list.component.ts:** Displays the list of tasks and handles the UI for updating and deleting tasks.
- **db.json:** Contains the mock data for the application, used by `json-server`.
- **angular.json, package.json, etc.:** Configuration and dependency management files.

## Prerequisites
Before running the application, ensure you have the following installed:
- [Node.js](https://nodejs.org/)
- [Angular CLI](https://cli.angular.io/)
- [json-server](https://www.npmjs.com/package/json-server)

## Setup and Running the App

1. **Clone the Repository:**
   Clone the repository to your local machine or download the source code.

2. **Install Dependencies:**
   Navigate to the root directory of the project and install the required npm packages:

```bash
cd path/to/project
npm install
```

3. **Start the JSON Server:**
Change directory to where `db.json` is located and launch the mock server:

```bash
cd path/to/project/src/assets
json-server --watch db.json
```

4. **Run the Angular Application:**
In a separate terminal, change back to the project root directory and start the Angular development server:

```bash
cd path/to/project
ng serve
```

Open your browser and go to `http://localhost:4200` to view the app.

## Usage
To add a task, enter text into the input box and click "Save." To edit a task, click "Update," modify the text, and then save changes by clicking "Update" again. To delete a task, click "Delete."