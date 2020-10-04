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
    public class PassengerController : Controller
    {
        private IHttpClientFactory _httpClientFactory;

        public PassengerController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        // GET: Passenger/PassengerInfo
        public async Task<ActionResult> PassengerInfo(Passenger passenger)
        {
            HttpClient httpClient = _httpClientFactory.CreateClient();
            httpClient.BaseAddress = new Uri("http://localhost:64794");
            HttpResponseMessage response = await httpClient.GetAsync("api/ticket/GetByPassengerPassport/" + passenger.Passport);
            if (response.IsSuccessStatusCode)
            {
                IEnumerable<Ticket> tickets = await response.Content.ReadAsAsync<IEnumerable<Ticket>>();
                PassengerInfoViewModel passengerInfo = new PassengerInfoViewModel(passenger, tickets);
                ViewBag.Message = "Passenger Info";
                return View(passengerInfo);
            }
            else
            {
                ViewBag.Message = "Error while loading passenger details. Please try again";
                return View("CustomError");
            }
        }

        // GET: Passenger/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Passenger/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Passenger passenger)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }

                HttpClient httpClient = _httpClientFactory.CreateClient();
                httpClient.BaseAddress = new Uri("http://localhost:64794");
                HttpResponseMessage response = await httpClient.PostAsJsonAsync("api/passenger", passenger);
                if (response.IsSuccessStatusCode)
                {
                    Passenger added = await response.Content.ReadAsAsync<Passenger>();
                    ViewBag.Message = "Passenger Added successfully";
                    return View("PassengerInfo", added);
                }
                else
                {
                    ViewBag.Message = "Error while adding passenger. Please try again.";
                    return View("CustomError");
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Passenger/Edit/5
        [HttpGet]
        public async Task<ActionResult> Edit(int id)
        {
            HttpClient httpClient = _httpClientFactory.CreateClient();
            httpClient.BaseAddress = new Uri("http://localhost:64794");
            HttpResponseMessage response = await httpClient.GetAsync("api/passenger/" + id);
            if (response.IsSuccessStatusCode)
            {
                Passenger passenger = await response.Content.ReadAsAsync<Passenger>();
                return View(passenger);
            }
            else
            {
                ViewBag.Message = "Error while loading passenger. Please try again.";
                return View("CustomError");
            }
        }

        // POST: Passenger/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Passenger passenger)
        {
            try
            {
                HttpClient httpClient = _httpClientFactory.CreateClient();
                httpClient.BaseAddress = new Uri("http://localhost:64794");
                HttpResponseMessage response = await httpClient.PutAsJsonAsync("api/passenger/" + passenger.PassengerID, passenger);
                if (response.IsSuccessStatusCode)
                {
                    ViewBag.Message = await response.Content.ReadAsStringAsync();
                    return RedirectToAction("PassengerInfo", passenger);
                }
                else
                {
                    ViewBag.Message = "Error while editing passenger. Please try again.";
                    return View("CustomError");
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Passenger/ConfirmDelete/5
        [HttpGet]
        public async Task<ActionResult> ConfirmDelete(int id)
        {
            HttpClient httpClient = _httpClientFactory.CreateClient();
            httpClient.BaseAddress = new Uri("http://localhost:64794");
            HttpResponseMessage response = await httpClient.GetAsync("api/passenger/" + id);
            if (response.IsSuccessStatusCode)
            {
                Passenger passenger = await response.Content.ReadAsAsync<Passenger>();
                ViewBag.Message = "Are you sure you want to delete passenger?";
                return View(passenger);
            }
            else
            {
                ViewBag.Message = "Error while loading passenger. Please try again.";
                return View("CustomError");
            }
        }

        // POST: Passenger/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int PassengerID)
        {
            try
            {
                HttpClient httpClient = _httpClientFactory.CreateClient();
                httpClient.BaseAddress = new Uri("http://localhost:64794");
                HttpResponseMessage response = await httpClient.DeleteAsync("api/passenger/" + PassengerID);
                if (response.IsSuccessStatusCode)
                {
                    ViewBag.Message = "Passenger Deleted Succesfully";
                    return View("SuccesfullyDeleted");
                }
                else
                {
                    ViewBag.Message = "Error while deleting passenger. Please try again.";
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