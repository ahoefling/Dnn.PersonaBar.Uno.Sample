﻿using System.Net;
using System.Net.Http;
using System.Web.Http;
using Dnn.PersonaBar.Library;
using Dnn.PersonaBar.Library.Attributes;

namespace Dnn.PersonaBar.Uno.WebApi.Controllers
{
    [MenuPermission(Scope = ServiceScope.Host)]
    public class HomeController : PersonaBarApiController
    {
        [HttpGet]
        //[RequireHost]
        //[ValidateAntiForgeryToken]
        [AllowAnonymous]
        public HttpResponseMessage Get()
        {
            return new HttpResponseMessage(HttpStatusCode.OK) { Content = new StringContent("Hello World!") };
        }
    }
}