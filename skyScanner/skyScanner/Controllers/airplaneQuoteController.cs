using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace skyScanner.Controllers
{
    public class airplaneQuoteController : ApiController
    {
        Models.airplaneQuote.Quote[] quote = new Models.airplaneQuote.Quote[]
            {

            };
        
        public IEnumerable<Models.airplaneQuote> GetAllQuote()
        {
            return Models.airplaneQuote.Quote;
        }
    }
}