﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

using Agathas.Storefront.Infrastructure.Payments;
using Agathas.Storefront.Services.ViewModels;

namespace Agathas.Storefront.Controllers
{
	public static class OrderMapper
	{
		public static OrderPaymentRequest ConvertToOrderPaymentRequest(this OrderView order)
		{
			return Mapper.Map<OrderView, OrderPaymentRequest>(order);
		}
	}
}
