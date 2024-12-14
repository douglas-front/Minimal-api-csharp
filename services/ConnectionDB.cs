using Microsoft.OpenApi.Any;
using MongoDB.Driver;

namespace UserApi.Services;
//0011
public class ConnectionDB
{

    public void Connection()
    {
        try
        {
            MongoClient dbClient = new MongoClient("mongodb+srv://douglasjknw007:0011@cluster0.6pvyx.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0");
            var dbList = dbClient.ListDatabases().ToList();
            Console.WriteLine("conectado");
            foreach (var db in dbList)
            {
                Console.WriteLine(db);
            }
        }
        catch (System.Exception)
        {
            Console.WriteLine("erro ao se connectar");
            throw new Exception("erro");
        }

    }

}