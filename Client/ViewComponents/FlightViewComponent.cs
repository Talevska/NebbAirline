using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Client.Models;
using Microsoft.AspNetCore.Mvc;

namespace Client.ViewComponents
{
    public class FlightViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(Flight flight)
        {
            return View("Flight", flight);
        }
    }
}
