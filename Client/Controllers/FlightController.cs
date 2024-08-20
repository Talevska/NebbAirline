using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Client.Models;
using Client.ViewModels;
using System.Net.Http;
using System.Diagnostics;

namespace Client.Controllers
{
    public class FlightController : Controller
    {
        private IHttpClientFactory _httpClientFactory;

        public FlightController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

         // GET: Flight
        public async Task<ActionResult> DisplayAllFlight()
        {
            HttpClient httpClient = _httpClientFactory.CreateClient();
            httpClient.BaseAddress = new Uri("http://localhost:64794");
            HttpResponseMessage response = await httpClient.GetAsync("api/flight");
            if (response.IsSuccessStatusCode)
            {
                IEnumerable<Flight> flights = await response.Content.ReadAsAsync<IEnumerable<Flight>>();
                ViewBag.Message = "All Flights";
                return View(flights);
            }
            else
            {
                ViewBag.Message = "Error while loading flights. Please try again.";
                return View("CustomError");
            }
        }

        // GET: Flight
        public async Task<ActionResult> DisplayAllFlights()
        {
            HttpClient httpClient = _httpClientFactory.CreateClient();
            httpClient.BaseAddress = new Uri("http://localhost:64794");
            HttpResponseMessage response = await httpClient.GetAsync("api/flight");
            if (response.IsSuccessStatusCode)
            {
                IEnumerable<Flight> flights = await response.Content.ReadAsAsync<IEnumerable<Flight>>();
                ViewBag.Message = "All Flights";
                return View(flights);
            }
            else
            {
                ViewBag.Message = "Error while loading flights. Please try again.";
                return View("CustomError");
            }
        }

        // GET: Flight/FlightInfo
        public async Task<ActionResult> FlightInfo(Flight flight)
        {
            HttpClient httpClient = _httpClientFactory.CreateClient();
            httpClient.BaseAddress = new Uri("http://localhost:64794");
            HttpResponseMessage response = await httpClient.GetAsync("api/passenger/GetPassengersByFlightCode/" + flight.FlightCode);
            if (response.IsSuccessStatusCode)
            {
                IEnumerable<Passenger> passengers = await response.Content.ReadAsAsync<IEnumerable<Passenger>>();
                FlightInfoViewModel flightInfo = new FlightInfoViewModel(flight, passengers);
                ViewBag.Message = "Flight Info";
                return View(flightInfo);
            }
            else
            {
                ViewBag.Message = "Error while loading flight details. Please try again";
                return View("CustomError");
            }
        }

        // GET: Flight/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Flight/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Flight flight)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }

                HttpClient httpClient = _httpClientFactory.CreateClient();
                httpClient.BaseAddress = new Uri("http://localhost:64794");
                HttpResponseMessage response = await httpClient.PostAsJsonAsync("api/flight", flight);
                if (response.IsSuccessStatusCode)
                {
                    Flight added = await response.Content.ReadAsAsync<Flight>();
                    ViewBag.Message = "Flight Added successfully";
                    return View("FlightInfo", added);
                }
                else
                {
                    ViewBag.Message = "Error while adding flight. Please try again.";
                    return View("CustomError");
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Flight/Edit/5
        [HttpGet]
        public async Task<ActionResult> Edit(int id)
        {
            HttpClient httpClient = _httpClientFactory.CreateClient();
            httpClient.BaseAddress = new Uri("http://localhost:64794");
            HttpResponseMessage response = await httpClient.GetAsync("api/flight/" + id);
            if (response.IsSuccessStatusCode)
            {
                Flight flight = await response.Content.ReadAsAsync<Flight>();
                ViewBag.Message = "Edit Flight";
                return View(flight);
            }
            else
            {
                ViewBag.Message = "Error while loading flight. Please try again.";
                return View("CustomError");
            }
        }

        // POST: Flight/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Flight flight)
        {
            try
            {
                HttpClient httpClient = _httpClientFactory.CreateClient();
                httpClient.BaseAddress = new Uri("http://localhost:64794");
                HttpResponseMessage response = await httpClient.PutAsJsonAsync("api/flight/" + flight.FlightID, flight);
                if (response.IsSuccessStatusCode)
                {
                    ViewBag.Message = await response.Content.ReadAsStringAsync();
                    return View("FlightInfo", flight);
                }
                else
                {
                    ViewBag.Message = "Error while editing flight. Please try again.";
                    return View("CustomError");
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Flight/ConfirmDelete/5
        [HttpGet]
        public async Task<ActionResult> ConfirmDelete(int id)
        {
            HttpClient httpClient = _httpClientFactory.CreateClient();
            httpClient.BaseAddress = new Uri("http://localhost:64794");
            HttpResponseMessage response = await httpClient.GetAsync("api/flight/" + id);
            if (response.IsSuccessStatusCode)
            {
                Flight flight = await response.Content.ReadAsAsync<Flight>();
                ViewBag.Message = "Are you sure you want to delete flight?";
                return View(flight);
            }
            else
            {
                ViewBag.Message = "Error while loading flight. Please try again.";
                return View("CustomError");
            }
        }

        // POST: Flight/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int FlightID)
        {
            try
            {
                HttpClient httpClient = _httpClientFactory.CreateClient();
                httpClient.BaseAddress = new Uri("http://localhost:64794");
                HttpResponseMessage response = await httpClient.DeleteAsync("api/flight/" + FlightID);
                if (response.IsSuccessStatusCode)
                {
                    ViewBag.Message = "Flight Deleted Succesfully";
                    return View("SuccesfullyDeleted");
                }
                else
                {
                    ViewBag.Message = "Error while deleting flight. Please try again.";
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
