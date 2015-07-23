using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agathas.Storefront.Model.Orders.States
{
	public class SubmittedOrderState : OrderState
	{
		public override OrderStatus Status
		{
			get { return OrderStatus.Submitted; }
		}

		public override bool CanAddProductTo(Order order)
		{
			return false;
		}

		public override void Submit(Order order)
		{
			throw new InvalidOperationException("You cannot submit this order as it has already been submitted.");
		}
	}
}
