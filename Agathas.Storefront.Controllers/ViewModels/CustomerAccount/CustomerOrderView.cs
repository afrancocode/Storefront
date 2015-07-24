using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Agathas.Storefront.Services.ViewModels;

namespace Agathas.Storefront.Controllers.ViewModels.CustomerAccount
{
	public class CustomerOrderView : BaseCustomerAccountView
	{
		public OrderView Order { get; set; }
	}
}
