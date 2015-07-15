using System;
using System.Web.Mvc;
using StructureMap;
using System.Web.Routing;

namespace Agathas.Storefront.Controllers
{
	public class IoCControllerFactory : DefaultControllerFactory
	{
		protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
		{
			return ObjectFactory.GetInstance(controllerType) as IController;
		}
	}
}