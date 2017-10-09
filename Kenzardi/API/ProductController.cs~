using System;
using System.Collections.Generic;
using System.Web.Http;
using Attributes;

namespace API
{

	public class ProductController
	{

		public ProductController()
		{
		}

		// GET api/values 
		public IEnumerable<string> Get()
		{
			return new string[] { "value1", "value2" };
		}


		[CustomAuthorize]
		// GET api/product/5 
		public string Get(int id)
		{
			return "value";
		}

		// POST api/values 
		public void Post([FromBody]string value)
		{
		}

		// PUT api/values/5 
		public void Put(int id, [FromBody]string value)
		{
		}

		// DELETE api/values/5 
		public void Delete(int id)
		{
		}
	}
}
