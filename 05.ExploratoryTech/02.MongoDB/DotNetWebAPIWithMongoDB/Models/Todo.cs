using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace DotNetWebAPIWithMongoDB.Models;

public sealed class Todo
{
    //BSON Type kullanıyor. Byte + Json => Bson
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string _id { get; set; }

    [BsonElement("work")]
    public string Work { get; set; }

    [BsonElement("date")]
    public DateTime Date { get; set; }

    //[BsonElement("__v")]
    //public int Version { get; set; }
}
