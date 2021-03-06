﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Agathas.Storefront.Infrastructure.Domain;

namespace Agathas.Storefront.Model.Products
{
	public interface IProductRepository : IReadOnlyRepository<Product, int>
	{
	}
}
