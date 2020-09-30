using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class GreetingController : ApiController
    {
        // POST api/greeting
        //Returns string "Hello World!"
        public string POST()
        {
            return "Hello World!";
        }
        //Get api/greeting/id
        //Return "Greetings to {id} people!"
        public string Get(int id)
        {
            return "Greetings to " + id + " people!";
        }

    }
}
