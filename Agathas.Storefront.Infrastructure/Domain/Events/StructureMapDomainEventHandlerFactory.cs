using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructureMap;

namespace Agathas.Storefront.Infrastructure.Domain.Events
{
	public class StructureMapDomainEventHandlerFactory : IDomainEventHandlerFactory
	{
		public IEnumerable<IDomainEventHandler<T>> GetDomainEventHandlersFor<T>(T domainEvent) where T : IDomainEvent
		{
			return ObjectFactory.GetAllInstances<IDomainEventHandler<T>>();
		}
	}
}
