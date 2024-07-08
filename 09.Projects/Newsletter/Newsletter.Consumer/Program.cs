using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;
using System.Text.Json;

var factory = new ConnectionFactory { HostName = "localhost" };
using var connection = factory.CreateConnection();
using var channel = connection.CreateModel();

channel.QueueDeclare(
    queue: "newsletter",
    exclusive: false,
    autoDelete: false,
    arguments: null);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(" [*] Waiting for messages...");

var consumer = new EventingBasicConsumer(channel);
consumer.Received += (model, ea) =>
{
    var body = ea.Body.ToArray();
    var message = Encoding.UTF8.GetString(body);
    ResponseDto? response = JsonSerializer.Deserialize<ResponseDto>(message);
    if (response is null)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Response is empty or null");
    }

    // mail gönderme işlemi
};

channel.BasicConsume(queue: "newsletter", autoAck: true, consumer: consumer);

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine(" Press [enter] to exit.");
Console.ReadLine();


//docker run -p 5001:80 -p 2525:25 rnwood/smtp4dev
// --rm -it