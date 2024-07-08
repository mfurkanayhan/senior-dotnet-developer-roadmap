using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

// Connection Setup
var factory = new ConnectionFactory { HostName = "localhost" };
using var connection = factory.CreateConnection();
using var channel = connection.CreateModel();

// Queue Declaration
channel.QueueDeclare(
    queue: "hello",
    durable: false,
    exclusive: false,
    autoDelete: false,
    arguments: null
);

Console.WriteLine(" [*] Waiting for messages.");

// Message Reception and Processing
var consumer = new EventingBasicConsumer(channel);
consumer.Received += (model, ea) =>
{
    var body = ea.Body.ToArray();
    var message = Encoding.UTF8.GetString(body);
    Console.Write($" [*] Received {message}\n");
};

// Consuming Messages
channel.BasicConsume(
    queue: "hello",
    autoAck: true, // Ensures that an automatic acknowledgment is sent when a message is successfully received and processed, meaning that the message will be safely deleted from the queue.
    consumer: consumer
);

Console.WriteLine(" Press [enter] to exit.");
Console.ReadLine();
