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
        Models.airplaneQuote.Quote[] quotes = new Models.airplaneQuote.Quote[]
            {
                new Models.airplaneQuote.Quote { QuoteId = 1, MinPrice = 10, Direct = true, OutboundLeg = {}, InboundLeg = {} },
                new Models.airplaneQuote.Quote { QuoteId = 2, MinPrice = 11, Direct = true, OutboundLeg = {}, InboundLeg = {} }
            };

        Models.airplaneQuote.OutboundLeg[] outboundlegs = new Models.airplaneQuote.OutboundLeg[] { };
        Models.airplaneQuote.InboundLeg[] inboundlegs = new Models.airplaneQuote.InboundLeg[] { };


        public IEnumerable<Models.airplaneQuote.Quote> GetAllQuote()
        {
            return quotes;
        }

        public Models.airplaneQuote.Quote getQuotebyID(int QuoteId)
        {
            var quote = quotes.FirstOrDefault((q) => q.QuoteId == QuoteId);
            if(quote == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return quote;

        } 

        public IEnumerable<Models.airplaneQuote.Quote> getQuotebyMinPrice(int MinPrice)
        {
            return quotes.Where((q) => q.MinPrice == MinPrice);
               
        }
    }
}