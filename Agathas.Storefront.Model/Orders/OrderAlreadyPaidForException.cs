using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agathas.Storefront.Model.Orders
{
	public class OrderAlreadyPaidForException : Exception
	{
		public OrderAlreadyPaidForException(string message)
			: base(message)
		{
		}
	}
}
