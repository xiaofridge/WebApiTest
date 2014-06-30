using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace TestApi.Controllers
{
    public class FormSubmitController : ApiController
    {
        [HttpPost]
        public async void submitForm()
        {
            //StringBuilder sb = new StringBuilder();
            //HttpContent content = Request.Content;
            //JsonObject jsonValue = await content.ReadAsOrDefaultAsync<JsonObject>();
            //foreach (var x in jsonValue)
            //{
            //    sb.Append(x.Key);
            //    string va;
            //    if (x.Value.TryReadAs<string>(out va))
            //    {
            //        sb.Append(va);
            //    }
            //}
        }
    }
}
