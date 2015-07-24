using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StructureMap;
using StructureMap.Configuration.DSL;

using Agathas.Storefront.Controllers.ActionArguments;
using Agathas.Storefront.Infrastructure.Authentication;
using Agathas.Storefront.Infrastructure.Configuration;
using Agathas.Storefront.Infrastructure.CookieStorage;
using Agathas.Storefront.Infrastructure.Email;
using Agathas.Storefront.Infrastructure.Logging;
using Agathas.Storefront.Infrastructure.UnitOfWork;
using Agathas.Storefront.Model.Basket;
using Agathas.Storefront.Model.Categories;
using Agathas.Storefront.Model.Customers;
using Agathas.Storefront.Model.Products;
using Agathas.Storefront.Model.Shipping;
using Agathas.Storefront.Services.Implementations;
using Agathas.Storefront.Services.Interfaces;
using Agathas.Storefront.Model.Orders;
using Agathas.Storefront.Infrastructure.Payments;
using Agathas.Storefront.Infrastructure.Domain.Events;
using Agathas.Storefront.Model.Orders.Events;
using Agathas.Storefront.Services.DomainEventHandlers;

namespace Agathas.Storefront.UI.Web.MVC
{
	public class BootStrapper
	{
		public static void ConfigureDependencies()
		{
			var container = new Container(c => { c.AddRegistry<ControllerRegistry>(); });
		}

		public class ControllerRegistry : Registry
		{
			public ControllerRegistry()
			{
				// Repositories
				For<IOrderRepository>().Use<Repository.NHibernate.Repositories.OrderRepository>();
				For<ICustomerRepository>().Use<Repository.NHibernate.Repositories.CustomerRepository>();
				For<IBasketRepository>().Use<Repository.NHibernate.Repositories.BasketRepository>();
				For<IDeliveryOptionRepository>().Use<Repository.NHibernate.Repositories.DeliveryOptionRepository>();
				For<ICategoryRepository>().Use<Repository.NHibernate.Repositories.CategoryRepository>();
				For<IProductTitleRepository>().Use<Repository.NHibernate.Repositories.ProductTitleRepository>();
				For<IProductRepository>().Use<Repository.NHibernate.Repositories.ProductRepository>();

				For<IUnitOfWork>().Use<Repository.NHibernate.NHUnitOfWork>();

				// Product Catalogue
				For<IProductCatalogService>().Use<ProductCatalogService>();

				For<IBasketService>().Use<BasketService>();
				For<ICookieStorageService>().Use<CookieStorageService>();
				For<ICustomerService>().Use<CustomerService>();

				// Order Service
				For<IOrderService>().Use<OrderService>();

				// Payment
				For<IPaymentService>().Use<PayPalPaymentService>();

				// Handlers for Domain Events
				For<IDomainEventHandlerFactory>().Use<StructureMapDomainEventHandlerFactory>();
				For<IDomainEventHandler<OrderSubmittedEvent>>().Add<OrderSubmittedHandler>();

				// Authentication
				For<IExternalAuthenticationService>().Use<JanrainAuthenticationService>();
				For<IFormsAuthentication>().Use<AspFormsAuthentication>();
				For<ILocalAuthenticationService>().Use<AspMembershipAuthentication>();

				// Controller Helpers
				For<IActionArguments>().Use<HttpRequestActionArguments>();

				// Application Settings
				For<IApplicationSettings>().Use<WebConfigApplicationSettings>();

				// Logger
				For<ILogger>().Use<Log4NetAdapter>();

				// E-Mail Service
				For<IEmailService>().Use<TextLoggingEmailService>();
			}
		}
	}
}