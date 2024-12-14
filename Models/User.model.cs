namespace UserApi.Models;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
public class UserModel{
    [BsonId]
    public ObjectId Id { get; set;}
    public string? UserName { get; set;}
    public string? Contact { get; set;}

}