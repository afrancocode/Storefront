using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

using Agathas.Storefront.Model.Basket;
using Agathas.Storefront.Services.ViewModels;

namespace Agathas.Storefront.Services.Mapping
{
	public static class BasketMapper
	{
		public static BasketView ConvertToBasketView(this Basket basket)
		{
			return Mapper.Map<Basket, BasketView>(basket);
		}
	}
}
