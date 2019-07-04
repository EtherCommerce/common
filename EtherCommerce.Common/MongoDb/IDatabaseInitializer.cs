using System.Threading.Tasks;

namespace EtherCommerce.Common.MongoDb
{
    public interface IDatabaseInitializer
    {
        Task InitializeAsync();
    }
}
