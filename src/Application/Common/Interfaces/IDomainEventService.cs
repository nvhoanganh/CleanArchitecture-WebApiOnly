using Northwind.Domain.Common;
using System.Threading.Tasks;

namespace Northwind.Application.Common.Interfaces
{
    public interface IDomainEventService
    {
        Task Publish(DomainEvent domainEvent);
    }
}
