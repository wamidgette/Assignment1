﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class SquareController : ApiController
    {
        //Get api/Square/id
        //Returns the square of the number input 
        public int Get(int id)
        {
            return id * id;
        }
    }
}
