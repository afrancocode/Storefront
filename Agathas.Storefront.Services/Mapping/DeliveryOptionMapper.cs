using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

using Agathas.Storefront.Model.Shipping;
using Agathas.Storefront.Services.ViewModels;

namespace Agathas.Storefront.Services.Mapping
{
	public static class DeliveryOptionMapper
	{
		public static IEnumerable<DeliveryOptionView> ConvertToDeliveryOptionViews(this IEnumerable<DeliveryOption> deliveryOptions)
		{
			return Mapper.Map<IEnumerable<DeliveryOption>, IEnumerable<DeliveryOptionView>>(deliveryOptions);
		}
	}
}
