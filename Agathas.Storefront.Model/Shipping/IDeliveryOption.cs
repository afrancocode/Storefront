using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agathas.Storefront.Model.Shipping
{
	public interface IDeliveryOption
	{
		int Id { get; set; }
		decimal FreeDeliveryThreshold { get; }
		decimal Cost { get; }
		ShippingService ShippingService { get; }
		decimal GetDeliveryChargeForBasketTotalOf(decimal total);
	}
}
