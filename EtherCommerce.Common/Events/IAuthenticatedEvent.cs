using System;

namespace EtherCommerce.Common.Events
{
    public interface IAuthenticatedEvent : IEvent
    {
        Guid UserId { get; set; }
    }
}
