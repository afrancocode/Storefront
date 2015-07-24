using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using StructureMap;

using Agathas.Storefront.Controllers;
using Agathas.Storefront.Infrastructure.Configuration;
using Agathas.Storefront.Infrastructure.Email;
using Agathas.Storefront.Infrastructure.Logging;

namespace Agathas.Storefront.UI.Web.MVC
{
	public class MvcApplication : System.Web.HttpApplication
	{
		protected void Application_Start()
		{
			AreaRegistration.RegisterAllAreas();
			RouteConfig.RegisterRoutes(RouteTable.Routes);

			BootStrapper.ConfigureDependencies();
			Controllers.AutoMapperBootStrapper.ConfigureAutoMapper();
			Services.AutoMapperBootStrapper.ConfigureAutoMapper();

			ApplicationSettingsFactory.InitializeApplicationSettingsFactory(ObjectFactory.GetInstance<IApplicationSettings>());

			LoggingFactory.InitializeLogFactory(ObjectFactory.GetInstance<ILogger>());

			EmailServiceFactory.InitializeEmailServiceFactory(ObjectFactory.GetInstance<IEmailService>());

			ControllerBuilder.Current.SetControllerFactory(new IoCControllerFactory());

			LoggingFactory.GetLogger().Log("Application Started");
		}
	}
}
