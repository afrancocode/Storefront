﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agathas.Storefront.Services.ViewModels
{
	public class OrderView
	{
		public DateTime PaymentDatePaid { get; set; }
		public string PaymentTransactionId { get; set; }
		public bool OrderHasBeenPaidFor { get; set; }
		public IEnumerable<OrderItemView> Items { get; set; }
		public DateTime Created { get; set; }
		public string ShippingCharge { get; set; }
		public string ShippingServiceCourierName { get; set; }
		public string ShippingServiceDescription { get; set; }
		public string Total { get; set; }
		public int Id { get; set; }
		public DeliveryAddressView DeliveryAddress { get; set; }
		public string CustomerFirstName { get; set; }
		public string CustomerSecondName { get; set; }
	}
}
