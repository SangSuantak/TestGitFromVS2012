﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GitProject.Controllers
{
    public class DataController : ApiController
    {
        public string TestResponse2()
        {
            return "Test Response";
        }
    }
}
