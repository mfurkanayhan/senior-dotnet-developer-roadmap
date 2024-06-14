# Synchronous and Asynchronous Structures

This simple HTML document demonstrates the implementation of synchronous and asynchronous structures in JavaScript to make API requests. These structures showcase how different methods handle API calls either by blocking or allowing continuation of other tasks.

## Overview

- **Synchronous Structure**: Utilizes `XMLHttpRequest` to make a synchronous GET request. This operation blocks the execution until the API responds, illustrating a synchronous structure where each process must complete before the next can start.
  
- **Asynchronous Structure**: Employs the modern `fetch` API with `async` and `await` syntax. This non-blocking approach allows the application to perform other operations while awaiting the API response, demonstrating how asynchronous structures handle tasks concurrently.

## Usage

To see the examples in action:
1. Open the HTML file in a web browser that supports modern JavaScript features.
2. Open the browser's developer console to observe the outputs from both the synchronous and asynchronous requests.

## Note

While synchronous requests can simplify the flow of control in applications, they can degrade user experience by freezing the UI until the request is complete. Therefore, it is generally recommended to use asynchronous requests in web applications to enhance responsiveness and performance.
