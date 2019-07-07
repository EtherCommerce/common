using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace EtherCommerce.Common.MongoDb
{
    public class MongoSeeder : IDatabaseSeeder
    {
        protected readonly IMongoDatabase _database;

        public MongoSeeder(IMongoDatabase database)
        {
            _database = database;
        }

        public async Task SeedAsync()
        {
            var collectionCursor = await _database.ListCollectionsAsync();
            var collections = await collectionCursor.ToListAsync();

            if (collections.Any())
            {
                return;
            }

            await CustomSeedAsync();
        }

        protected virtual Task CustomSeedAsync() => Task.CompletedTask;
    }
}
