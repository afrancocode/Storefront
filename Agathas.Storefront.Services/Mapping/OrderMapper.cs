﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

using Agathas.Storefront.Model.Orders;
using Agathas.Storefront.Services.ViewModels;

namespace Agathas.Storefront.Services.Mapping
{
	public static class OrderMapper
	{
		public static OrderView ConvertToOrderView(this Order order)
		{
			return Mapper.Map<Order, OrderView>(order);
		}

		public static IEnumerable<OrderSummaryView> ConvertToOrderSummaryViews(this IEnumerable<Order> orders)
		{
			return Mapper.Map<IEnumerable<Order>, IEnumerable<OrderSummaryView>>(orders);
		}
	}
}
