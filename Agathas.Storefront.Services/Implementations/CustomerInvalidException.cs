﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agathas.Storefront.Services.Implementations
{
	public class CustomerInvalidException : Exception
	{
		public CustomerInvalidException(string message)
			: base(message)
		{
		}
	}
}
