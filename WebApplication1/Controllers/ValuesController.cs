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
		public List<string> Get(int id)
		{
			int index = (id - 1);
			string specificValue = values[index];
            return values;
        }

		// POST api/values
		public void Post([FromBody]CustomModel value)
		{
			values.Add(value.Name);
		}

		// PUT api/values/5
		public void Put(int id, [FromBody]CustomModel value)
		{
            int index = (id - 1);
            values[index] = value.Name;
		}

		// DELETE api/values/5
		public void Delete(int id)
		{
            int index = (id - 1);
            values.RemoveAt(index);
		}
	}
}

public class CustomModel
{
	public string Name { get; set; }
}