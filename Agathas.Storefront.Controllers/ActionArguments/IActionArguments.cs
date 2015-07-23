using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agathas.Storefront.Controllers.ActionArguments
{
	public interface IActionArguments
	{
		string GetValueForArgument(ActionArgumentKey key);
	}
}
