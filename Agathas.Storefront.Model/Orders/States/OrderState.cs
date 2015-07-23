using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agathas.Storefront.Model.Orders.States
{
	public abstract class OrderState : IOrderState
	{
		public virtual int Id { get; set; }
		public abstract OrderStatus Status { get; }
		public abstract bool CanAddProductTo(Order order);
		public abstract void Submit(Order order);
	}
}
