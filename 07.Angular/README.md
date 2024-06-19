# Angular and Angular CLI

## What is Angular?

Angular is an open-source platform and framework developed by Google for building modern web applications. It uses a component-based architecture that makes it easy to create reusable and modular applications. Angular is written in TypeScript, which provides strong typing and helps detect errors during development.

## What is Angular CLI?

Angular CLI (Command Line Interface) is a tool that simplifies the process of creating, developing, and managing Angular projects. With Angular CLI, you can generate new projects, add components, compile projects, and run tests with ease.

## Installing Angular CLI

Follow these steps to install Angular CLI globally:

1. **Install Node.js and npm:** Angular CLI requires Node.js and npm (Node Package Manager). Make sure you have both installed on your system. You can download Node.js from the [official website](https://nodejs.org/).

2. **Install Angular CLI:**
   ```bash
   npm install -g @angular/cli
   ```
This command will install Angular CLI globally on your system.

## Creating a New Angular Project

To create a new Angular project using Angular CLI, follow these steps:

1. **Create a New Project**:

```bash
ng new project-name
```
This command tells Angular CLI to generate a new project. Replace project-name with the name of your project. When you run this command, the CLI will prompt you with some questions to configure your project.

2. **Navigate to the Project Directory**:

```bash
cd project-name
```

3. **Start the Development Server**:

```bash
ng serve
```

This command starts the Angular development server and serves your project at **\`http://localhost:4200`** by default.

## Creating a Component with Angular CLI

You can create new components using Angular CLI. To generate a new component, use the following command:

```bash
ng generate component component-name
```

This command will create a new component with the specified name in the **\`src/app`** directory.

## Projects

Here are some example projects you can explore to understand and learn more about Angular:

- ### [ExampleSPA](https://github.com/mfurkanayhan/senior-dotnet-developer-roadmap/tree/main/07.Angular/ExampleSPA)

- ### [MyFirstAngularApp](https://github.com/mfurkanayhan/senior-dotnet-developer-roadmap/tree/main/07.Angular/MyFirstAngularApp)

- ### [MyTodoApp](https://github.com/mfurkanayhan/senior-dotnet-developer-roadmap/tree/main/07.Angular/MyTodoApp)

- ### [myOldApp](https://github.com/mfurkanayhan/senior-dotnet-developer-roadmap/tree/main/07.Angular/myOldApp)

- ### [myApiApp](https://github.com/mfurkanayhan/senior-dotnet-developer-roadmap/tree/main/07.Angular/myApiApp)

- ### [myRoutingApp](https://github.com/mfurkanayhan/senior-dotnet-developer-roadmap/tree/main/07.Angular/myRoutingApp)

- ### [myPersonelApp](https://github.com/mfurkanayhan/senior-dotnet-developer-roadmap/tree/main/07.Angular/myPersonelApp)

- ### [myAuthenticationApp](https://github.com/mfurkanayhan/senior-dotnet-developer-roadmap/tree/main/07.Angular/myAuthenticationApp)

- ### [myStateManagementApp](https://github.com/mfurkanayhan/senior-dotnet-developer-roadmap/tree/main/07.Angular/myStateManagementApp)

## Additional Resources
For more information about Angular and Angular CLI, you can visit the following resources:

- [Angular Official Website](https://angular.io/)
- [Angular CLI Documentation](https://angular.io/cli)

This README.md file provides a basic overview of Angular and Angular CLI, including the steps to get started with a new project. As you learn more about Angular and develop your projects, you can update and expand this file.