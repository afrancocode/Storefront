﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agathas.Storefront.Model.Orders
{
	public class PaymentAmountDoesNotEqualOrderTotalException : Exception
	{
		public PaymentAmountDoesNotEqualOrderTotalException(string message)
			: base(message)
		{
		}
	}
}
