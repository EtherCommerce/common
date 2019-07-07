using System.Threading.Tasks;

namespace EtherCommerce.Common.MongoDb
{
    public interface IDatabaseSeeder
    {
        Task SeedAsync();
    }
}
