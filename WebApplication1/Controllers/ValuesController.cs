using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
	public class ValuesController : ApiController
	{
		// GET api/values

		private static List<string> values = new List<string>(new string[] { "value1", "value2" });

		public IEnumerable<string> Get()
		{
			return values;
		}

		// GET api/values/5
		public string Get(int id)
		{
			int index = (id - 1);
			string specificValue = values[index];
			return specificValue;
		}

		// POST api/values
		public void Post([FromBody]CustomModel value)
		{
			values.Add(value.Name);
			Console.WriteLine(value);
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

public class CustomModel
{
	public string Name { get; set; }
}