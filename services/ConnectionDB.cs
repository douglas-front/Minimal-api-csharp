using MongoDB.Driver;
using UserApi.Models;

namespace UserApi.Services;
public class ConnectionDB
{
    private readonly IMongoCollection<UserModel>? _collection;

    public ConnectionDB()
    {
        try
        {
            MongoClient dbClient = new MongoClient("mongodb+srv://douglasjknw007:0011@cluster0.6pvyx.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0");
            if (dbClient.GetDatabase("UserApi") != null){
                Console.WriteLine("pegou");
            }
            else{
                return;
            }
         
            var userApiDataBase = dbClient.GetDatabase("UserApi");
            _collection = userApiDataBase.GetCollection<UserModel>("Users");
            Console.WriteLine("conectado");
        }
        catch (System.Exception)
        {
            Console.WriteLine("erro ao se connectar");
            throw new Exception("erro");
        }

    }

    public void PostUser(UserModel user){
        try
        {
            _collection?.InsertOne(user);
            Console.WriteLine("usuario adicionado com sucesso");
        }
        catch (System.Exception)
        {
            Console.WriteLine("erro ao adicionar usuario");
            throw new Exception("erro ao adicionar usuario");
        }
    }

    public List<UserModel> GetUsers(){
        List<UserModel> users = _collection.Find(FilterDefinition<UserModel>.Empty).ToList();

        return users;
    }
}