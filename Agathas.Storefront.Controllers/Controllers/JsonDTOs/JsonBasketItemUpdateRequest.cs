using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

using Agathas.Storefront.Controllers.JsonDTOs;

namespace Agathas.Storefront.Controllers.Controllers.JsonDTOs
{
	[DataContract]
	[ModelBinder(typeof(JsonModelBinder))]
	public class JsonBasketItemUpdateRequest
	{
		[DataMember]
		public int ProductId { get; set; }
		[DataMember]
		public int Qty { get; set; }
	}
}
