using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Conventions;

namespace EtherCommerce.Common.MongoDb
{
    public class MongoInitializer : IDatabaseInitializer
    {
        private readonly IMongoDatabase _database;
        private readonly bool _seed;
        private bool _initialized;

        public MongoInitializer(IMongoDatabase database, IOptions<MongoOptions> optionsAccessor)
        {
            _database = database;
            _seed = optionsAccessor.Value.Seed;
        }


        public async Task InitializeAsync()
        {
            if (_initialized)
            {
                return;
            }

            RegisterConventions();
            _initialized = true;

            if (!_seed)
            {
                return;
            }
        }

        private void RegisterConventions()
        {
            ConventionRegistry.Register("EtherCommerceConventions", new MongoConventions(), x => true);
        }
        

        private class MongoConventions : IConventionPack
        {
            public IEnumerable<IConvention> Conventions => new List<IConvention>
            {
                new IgnoreExtraElementsConvention(true),
                new EnumRepresentationConvention(BsonType.String),
                new CamelCaseElementNameConvention()
            };
        }
    }
}
