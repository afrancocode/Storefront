﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agathas.Storefront.Services.ViewModels
{
	public class RefinementGroup
	{
		public string Name { get; set; }
		public int GroupId { get; set; }
		public IEnumerable<Refinement> Refinements { get; set; }
	}
}
