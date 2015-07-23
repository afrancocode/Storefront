using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agathas.Storefront.Infrastructure.Domain.Events
{
	public interface IDomainEventHandler<T> where T : IDomainEvent
	{
		void Handle(T domainEvent);
	}
}
