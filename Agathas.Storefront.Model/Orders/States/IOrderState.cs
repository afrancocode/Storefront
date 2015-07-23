using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agathas.Storefront.Model.Orders.States
{
	public interface IOrderState
	{
		int Id { get; set; }
		OrderStatus Status { get; }
		bool CanAddProductTo(Order order);
		void Submit(Order order);
	}
}
