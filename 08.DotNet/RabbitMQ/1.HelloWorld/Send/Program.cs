using RabbitMQ.Client;
using System.Text;

var factory = new ConnectionFactory { HostName = "localhost" };
using var connection = factory.CreateConnection();
using var channel = connection.CreateModel();

channel.QueueDeclare(
    queue: "hello",
    durable: false,     // dayanıklılık => RabbitMQ kapandığında ayakta kal veya kalma
    exclusive: false,   // Özel kuyruk oluştur veya oluşturma
    autoDelete: false,   // Bağlı Consume yoksa kuyruğu sil veya silme
    arguments: null     // Özel argümanlar
);

const string message = "Hello World!";
var body = Encoding.UTF8.GetBytes(message);

channel.BasicPublish(
    exchange: string.Empty, // Direct/Topic/Fonut ve Headers
    routingKey: "hello",    // Bağlanacağımız kuyruk adı
    basicProperties: null,  // Temel özellikler
    body: body              // Göndereceğimiz message
);

Console.WriteLine($" x Send { message }");

Console.WriteLine($" Press [enter] to exit.");

Console.ReadLine();