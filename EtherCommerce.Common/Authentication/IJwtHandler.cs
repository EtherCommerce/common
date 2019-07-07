using System;

namespace EtherCommerce.Common.Authentication
{
    public interface IJwtHandler
    {
        JsonWebToken Create(Guid userId);
    }
}
