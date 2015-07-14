﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Agathas.Storefront.Infrastructure.Domain;

namespace Agathas.Storefront.Model.Products
{
	public class ProductSize : EntityBase<int>, IProductAttribute
	{
		public string Name { get; set; }

		protected override void Validate()
		{
			throw new NotImplementedException();
		}
	}
}
