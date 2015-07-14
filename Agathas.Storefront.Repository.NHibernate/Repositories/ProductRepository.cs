using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;

using Agathas.Storefront.Infrastructure.UnitOfWork;
using Agathas.Storefront.Model.Products;

namespace Agathas.Storefront.Repository.NHibernate.Repositories
{
	public class ProductRepository : Repository<Product, int>, IProductRepository
	{
		public ProductRepository(IUnitOfWork uow)
			: base(uow)
		{ }

		public override void AppendCriteria(ICriteria criteria)
		{
			criteria.CreateAlias("Title", "ProductTitle");
			criteria.CreateAlias("ProductTitle.Category", "Category");
			criteria.CreateAlias("ProductTitle.Brand", "Brand");
			criteria.CreateAlias("ProductTitle.Color", "Color");
		}
	}
}
