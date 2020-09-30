using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class AddTenController : ApiController
    {
        //Get api/AddTen/id
        //Returns 10 more than the integer input 
        public int Get(int id)
        {
            return (id+10);
        }
    
    }
}

