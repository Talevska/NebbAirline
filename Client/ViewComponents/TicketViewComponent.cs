using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Client.Models;
using Microsoft.AspNetCore.Mvc;

namespace Client.ViewComponents
{
    public class TicketViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(Ticket ticket)
        {
            return View("Ticket", ticket);
        }
    }
}
