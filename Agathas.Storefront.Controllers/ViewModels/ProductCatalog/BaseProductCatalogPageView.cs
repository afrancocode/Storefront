﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Agathas.Storefront.Services.ViewModels;

namespace Agathas.Storefront.Controllers.ViewModels.ProductCatalog
{
	public abstract class BaseProductCatalogPageView : BasePageView
	{
		public IEnumerable<CategoryView> Categories { get; set; }
	}
}