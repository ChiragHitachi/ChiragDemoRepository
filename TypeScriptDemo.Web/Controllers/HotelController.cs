using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TypeScriptDemo.Domain;

namespace TypeScriptDemo.Controllers
{
    public class HotelController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Hotel> Get()
        {
            return HotelHelper.GetHotels();
        }

        // GET api/<controller>/5
        public Hotel Get(int id)
        {
           var hotels =  HotelHelper.GetHotels();
           return hotels.FirstOrDefault(r => r.HotelId == id);
        }
    }
}