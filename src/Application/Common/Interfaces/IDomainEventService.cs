using CER.Domain.Common;
using System.Threading.Tasks;

namespace CER.Application.Common.Interfaces
{
    public interface IDomainEventService
    {
        Task Publish(DomainEvent domainEvent);
    }
}
