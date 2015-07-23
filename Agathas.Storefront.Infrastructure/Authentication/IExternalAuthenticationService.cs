﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agathas.Storefront.Infrastructure.Authentication
{
	public interface IExternalAuthenticationService
	{
		User GetUserDetailsFrom(string token);
	}
}
