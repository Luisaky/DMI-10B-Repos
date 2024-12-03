using MongoDB.Driver;

namespace MongoDBAPI10B.Repositories
{
    public class MongoDBRepository
    {
        public MongoClient client;
        public IMongoDatabase db;
        public MongoDBRepository()
        {
            client = new MongoClient("mongodb+srv://luisantonio102:dfAejExhCU4BKGoY@cluster0.1dec3.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0");
            db = client.GetDatabase("Tiendita");

        }
    }
}
