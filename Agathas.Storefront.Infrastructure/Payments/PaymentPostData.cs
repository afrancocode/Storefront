﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agathas.Storefront.Infrastructure.Payments
{
	public class PaymentPostData
	{
		public string PaymentPostToUrl { get; set; }
		public NameValueCollection PostDataAndValue { get; set; }
	}
}
