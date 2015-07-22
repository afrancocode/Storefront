using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agathas.Storefront.Services.Messaging.CustomerService
{
	public class ModifyCustomerRequest
	{
		public string CustomerIdentityToken { get; set; }
		public string FirstName { get; set; }
		public string SecondName { get; set; }
		public string Email { get; set; }
	}
}
