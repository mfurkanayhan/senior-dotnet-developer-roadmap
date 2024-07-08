# RabbitMQ

This project includes examples of message queue management using RabbitMQ, featuring various RabbitMQ functionalities and scenarios implemented in C#.

## System Requirements

- Docker
- .NET 8.0 or newer version

## Installation

To install RabbitMQ server using Docker, the following command can be used. This command runs a version of RabbitMQ that includes the management console and standard AMQP ports.

```bash
docker run -it --rm --name rabbitmq -p 5672:5672 -p 15672:15672 rabbitmq:3.12-management
```

You can access the management panel at http://localhost:15672.

### Username and Password
The default username and password are:

- Username: guest
- Password: guest

## Project Structure

The project contains multiple C# script files for various operations with RabbitMQ:

- `Send.cs` and `Receive.cs`: A simple "Hello World" message queue.
- `NewTask.cs` and `Worker.cs`: Workload distribution over a durable queue.
- `EmitLog.cs` and `ReceiveLogs.cs`: Broadcasting logs using a fanout exchange type.
- `EmitLogDirect.cs` and `ReceiveLogsDirect.cs`: Receiving and processing directed messages over a direct exchange type.

Each script includes basic setups for connection, sending or receiving messages, and making a clean exit.

## How to Run?

Each `.cs` file can be executed using Visual Studio or the .NET CLI. To run a file, you can use the following command:

```bash
dotnet run Program.cs
```

For a better understanding of the project, refer to the project files.