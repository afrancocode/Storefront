using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Agathas.Storefront.Services.Messaging.ProductCatalogService;

namespace Agathas.Storefront.Services.Interfaces
{
	public interface IBasketService
	{
		GetBasketResponse GetBasket(GetBasketRequest basketRequest);
		CreateBasketResponse CreateBasket(CreateBasketRequest basketRequest);
		ModifyBasketResponse ModifyBasket(ModifyBasketRequest request);
		GetAllDispatchOptionsResponse GetAllDispatchOptions();
	}
}
