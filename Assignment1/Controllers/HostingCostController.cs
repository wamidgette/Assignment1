using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class HostingCostController : ApiController
    {
        public IEnumerable<string> Get(decimal id)
        {
            decimal fullFortnights = Math.Floor(id / 14);
            decimal FNrate = 5.50M;
            decimal subtotal = FNrate * (fullFortnights + 1);
            decimal HST = subtotal * 0.13M;
            decimal Total = HST + subtotal;
            subtotal = Math.Round(subtotal, 2);
            HST = Math.Round(HST, 2);
            Total = Math.Round(Total, 2);
            return new string[]
            {
                fullFortnights + " fortnights at $5.50/FN = $" + subtotal + " CAD",
                "HST 13% = $" + HST + " CAD",
                "Total = $" + Total + " CAD"
            };
        }
    }
}
