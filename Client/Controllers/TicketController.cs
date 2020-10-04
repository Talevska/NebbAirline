using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Client.Models;
using System.Net.Http;
using System.Diagnostics;

namespace Client.Controllers
{
    public class TicketController : Controller
    {
        private IHttpClientFactory _httpClientFactory;

        public TicketController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        // GET: Ticket
        public async Task<ActionResult> DisplayAllTickets()
        {
            HttpClient httpClient = _httpClientFactory.CreateClient();
            httpClient.BaseAddress = new Uri("http://localhost:64794");
            HttpResponseMessage response = await httpClient.GetAsync("api/ticket");
            if (response.IsSuccessStatusCode)
            {
                IEnumerable<Ticket> tickets = await response.Content.ReadAsAsync<IEnumerable<Ticket>>();
                ViewBag.Message = "All Tickets";
                return View(tickets);
            }
            else
            {
                ViewBag.Message = "Error while loading tickets. Please try again.";
                return View("CustomError");
            }
        }

        // GET: Ticket/GetTicketsByFlightCode/123456789
        public async Task<ActionResult> GetTicketsByFlightCode(string code)
        {
            HttpClient httpClient = _httpClientFactory.CreateClient();
            httpClient.BaseAddress = new Uri("http://localhost:64794");
            HttpResponseMessage response = await httpClient.GetAsync("api/ticket/GetByFlightCode/" + code);
            if (response.IsSuccessStatusCode)
            {
                IEnumerable<Ticket> tickets = await response.Content.ReadAsAsync<IEnumerable<Ticket>>();
                return View(tickets);
            }
            else
            {
                ViewBag.Message = "Error while loading tickets. Please try again.";
                return View("CustomError");
            }
        }

        // GET: Ticket/AutoFillPassengerFields
        [HttpPost]
        public async Task<ActionResult> AutoFillPassengerFields(Ticket ticket)
        {
            HttpClient httpClient = _httpClientFactory.CreateClient();
            httpClient.BaseAddress = new Uri("http://localhost:64794");
            HttpResponseMessage response = await httpClient.GetAsync("api/passenger/GetByPassport/" + ticket.Passport);
            if (response.IsSuccessStatusCode)
            {
                Ticket returned = await response.Content.ReadAsAsync<Ticket>();
                return View(ticket);
            }
            else
            {
                ViewBag.Message = "Nebb Airline Booking System";
                return View(ticket);
            }
        }

        // GET: Ticket/AutoFillFlightFields
        [HttpPost]
        public async Task<ActionResult> AutoFillFlightFields(Ticket ticket)
        {
            HttpClient httpClient = _httpClientFactory.CreateClient();
            httpClient.BaseAddress = new Uri("http://localhost:64794");
            HttpResponseMessage response = await httpClient.GetAsync("api/flight/GetByCode/" + ticket.FlightCode);
            if (response.IsSuccessStatusCode)
            {
                Ticket returned = await response.Content.ReadAsAsync<Ticket>();
                return View(returned);
            }
            else
            {
                ViewBag.Message = "Nebb Airline Booking System";
                return View(ticket);
            }
        }

        // GET: Ticket/TicketDetails/5
        public async Task<ActionResult> TicketInfo(int id)
        {
            HttpClient httpClient = _httpClientFactory.CreateClient();
            httpClient.BaseAddress = new Uri("http://localhost:64794");
            HttpResponseMessage response = await httpClient.GetAsync("api/ticket/" + id);
            if (response.IsSuccessStatusCode)
            {
                Ticket ticket = await response.Content.ReadAsAsync<Ticket>();
                ViewBag.Message = "Ticket Info";
                return View(ticket);
            }
            else
            {
                ViewBag.Message = "Error while loading ticket details. Please try again";
                return View("CustomError");
            }
        }

        // GET: Ticket/Create
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Message = "Nebb Airline Booking System";
            return View();
        }

        // POST: Ticket/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Ticket ticket)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }

                HttpClient httpClient = _httpClientFactory.CreateClient();
                httpClient.BaseAddress = new Uri("http://localhost:64794");
                HttpResponseMessage response = await httpClient.PostAsJsonAsync("api/ticket", ticket);
                if (response.IsSuccessStatusCode)
                {
                    Ticket created = await response.Content.ReadAsAsync<Ticket>();
                    ViewBag.Message = "Ticket Booked successfully";
                    return View("TicketInfo", created);
                }
                else
                {
                    ViewBag.Message = "Passenger with passport #: " + ticket.Passport + ", already has booked ticket for this flight.";
                    return View("CustomError");
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Ticket/Edit/5
        [HttpGet]
        public async Task<ActionResult> Edit(int id)
        {
            HttpClient httpClient = _httpClientFactory.CreateClient();
            httpClient.BaseAddress = new Uri("http://localhost:64794");
            HttpResponseMessage response = await httpClient.GetAsync("api/ticket/" + id);
            if (response.IsSuccessStatusCode)
            {
                Ticket ticket = await response.Content.ReadAsAsync<Ticket>();
                ViewBag.Message = "Edit Ticket";
                return View(ticket);
            }
            else
            {
                ViewBag.Message = "Error while loading ticket. Please try again.";
                return View("CustomError");
            }
        }

        // POST: Ticket/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Ticket ticket)
        {
            try
            {
                HttpClient httpClient = _httpClientFactory.CreateClient();
                httpClient.BaseAddress = new Uri("http://localhost:64794");
                HttpResponseMessage response = await httpClient.PutAsJsonAsync("api/ticket/" + ticket.TicketID, ticket);
                if (response.IsSuccessStatusCode)
                {
                    ViewBag.Message = await response.Content.ReadAsStringAsync();
                    return View("TicketInfo", ticket);
                }
                else
                {
                    ViewBag.Message = "Error while editing ticket. Please try again.";
                    return View("CustomError");
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Ticket/ConfirmDelete/5
        [HttpGet]
        public async Task<ActionResult> ConfirmDelete(int id)
        {
            HttpClient httpClient = _httpClientFactory.CreateClient();
            httpClient.BaseAddress = new Uri("http://localhost:64794");
            HttpResponseMessage response = await httpClient.GetAsync("api/ticket/" + id);
            if (response.IsSuccessStatusCode)
            {
                Ticket ticket = await response.Content.ReadAsAsync<Ticket>();
                ViewBag.Message = "Are you sure you want to delete ticket?";
                return View(ticket);
            }
            else
            {
                ViewBag.Message = "Error while loading ticket. Please try again.";
                return View("CustomError");
            }
        }

        // POST: Ticket/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int TicketID)
        {
            try
            {
                HttpClient httpClient = _httpClientFactory.CreateClient();
                httpClient.BaseAddress = new Uri("http://localhost:64794");
                HttpResponseMessage response = await httpClient.DeleteAsync("api/ticket/" + TicketID);
                if (response.IsSuccessStatusCode)
                {
                    ViewBag.Message = "Ticked Deleted Succesfully";
                    return View("SuccesfullyDeleted");
                }
                else
                {
                    ViewBag.Message = "Error while deleting ticket. Please try again.";
                    return View("CustomError");
                }
            }
            catch
            {
                return View();
            }
        }
    }
}