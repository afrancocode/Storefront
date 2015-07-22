using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

using Agathas.Storefront.Model.Customers;
using Agathas.Storefront.Services.ViewModels;

namespace Agathas.Storefront.Services.Mapping
{
	public static class DeliveryAddressMapper
	{
		public static DeliveryAddressView ConvertToDeliveryAddressView(this DeliveryAddress deliveryAddress)
		{
			return Mapper.Map<DeliveryAddress, DeliveryAddressView>(deliveryAddress);
		}
	}
}
