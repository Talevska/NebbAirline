---
title: A flow in the Flight Controller using AI powered tool
---
## Introduction

This doc describes the <SwmToken path="/Client/Controllers/FlightController.cs" pos="14:5:5" line-data="    public class FlightController : Controller">`FlightController`</SwmToken> flow in our system using /ai command in Swimm to auto generate description using AI tool. We will follow its implementation across the various locations so you can understand how the different parts create the full picture.

## Following the flow

<SwmSnippet path="/Client/Controllers/FlightController.cs" line="12">

---

This code snippet defines a `FlightController` class that extends a `Controller` class. It has a private `_httpClientFactory` field and a constructor that takes an `IHttpClientFactory` object as a parameter and assigns it to the `_httpClientFactory` field.

```c#
namespace Client.Controllers
{
    public class FlightController : Controller
    {
        private IHttpClientFactory _httpClientFactory;

        public FlightController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
```

---

</SwmSnippet>

<SwmSnippet path="/Client/Controllers/FlightController.cs" line="23">

---

This code snippet sends a GET request to the `http://localhost:64794/api/flight` endpoint to retrieve a list of flights. If the response is successful, it reads the content as an array of `Flight` objects and returns the view with the flights. Otherwise, it sets the `ViewBag.Message` to display an error message and returns the 'CustomError' view.

```c#
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
```

---

</SwmSnippet>

<SwmSnippet path="/Client/Controllers/FlightController.cs" line="42">

---

This code snippet sends a GET request to retrieve flight information. It creates an `HttpClient` and sets the base address to `http://localhost:64794`. It then sends a GET request to the endpoint `api/passenger/GetPassengersByFlightCode/` concatenated with the `flight.FlightCode` value. If the response is successful, it reads the response content as a collection of `Passenger` objects using `ReadAsAsync`. It creates a `FlightInfoViewModel` object with the `flight` and `passengers`, sets the `ViewBag.Message` to 'Flight Info', and returns the `flightInfo` view. If the response is not successful, it sets the `ViewBag.Message` to 'Error while loading flight details. Please try again' and returns the 'CustomError' view.

```c#
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
```

---

</SwmSnippet>

<SwmSnippet path="/Client/Controllers/FlightController.cs" line="62">

---

This code snippet represents a controller action method named `Create` that is used to handle the GET request for the `Flight/Create` route. It returns a `View` result, which renders the corresponding view for creating a new flight.

```c#
        // GET: Flight/Create
        public ActionResult Create()
        {
            return View();
        }
```

---

</SwmSnippet>

<SwmSnippet path="/Client/Controllers/FlightController.cs" line="68">

---

This code snippet is a controller action method that handles the HTTP POST request for creating a flight. It takes a `Flight` object as a parameter and performs the following steps:

1. Checks if the `ModelState` is valid. If not, it returns the view without performing further actions.
2. Creates an instance of `HttpClient` and sets the base address to `http://localhost:64794`.
3. Sends a POST request to the `api/flight` endpoint with the `flight` object serialized as JSON.
4. Checks if the response is successful. If so, it reads the response content as a `Flight` object and sets the `ViewBag.Message` to "Flight Added successfully". It then returns the `FlightInfo` view with the added flight.
5. If the response is not successful, it sets the `ViewBag.Message` to "Error while adding flight. Please try again." and returns the `CustomError` view.
6. If an exception occurs, it returns the view without performing further actions.

```c#
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
```

---

</SwmSnippet>

<SwmSnippet path="/Client/Controllers/FlightController.cs" line="101">

---

This code snippet sends a GET request to retrieve a `Flight` object with the specified `id` from an API. If the request is successful, it deserializes the response content into a `Flight` object, sets a view bag message, and returns a view with the `Flight` object. If the request is not successful, it sets a view bag error message and returns a custom error view.

```c#
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

```

---

</SwmSnippet>

<SwmSnippet path="/Client/Controllers/FlightController.cs" line="121">

---

This code snippet handles the `Edit` action for the `Flight` model. It creates an instance of `HttpClient` and sets its base address to `http://localhost:64794`. Then, it sends a PUT request to the `api/flight/{flight.FlightID}` endpoint with the `flight` object as JSON. If the response is successful, it sets the `ViewBag.Message` property to the content of the response and returns the `FlightInfo` view with the `flight` object. If the response is not successful, it sets the `ViewBag.Message` property to an error message and returns the `CustomError` view. If an exception occurs, it returns the default view.

```c#
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
```

---

</SwmSnippet>

<SwmSnippet path="/Client/Controllers/FlightController.cs" line="148">

---

This code snippet sends a GET request to retrieve information about a specific flight by `id`. If the response is successful (`IsSuccessStatusCode` is true), it reads the response content as a `Flight` object and sets the `ViewBag.Message` to "Are you sure you want to delete flight?" before returning the `View` with the flight data. If the response is not successful, it sets the `ViewBag.Message` to "Error while loading flight. Please try again." and returns the `CustomError` view.

```c#
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
```

---

</SwmSnippet>

<SwmSnippet path="/Client/Controllers/FlightController.cs" line="168">

---

This code snippet is a controller action method that handles the HTTP POST request to delete a flight. It creates an `HttpClient` and sets its base address to `http://localhost:64794`. Then it sends a DELETE request to the API endpoint `api/flight/` appended with the `FlightID` parameter. If the response is successful, it sets the `ViewBag.Message` to 'Flight Deleted Successfully' and returns the `SuccesfullyDeleted` view. Otherwise, it sets the `ViewBag.Message` to 'Error while deleting flight. Please try again.' and returns the `CustomError` view. If any exception occurs during the process, it returns a default view.

```c#
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
```

---

</SwmSnippet>

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBTmViYkFpcmxpbmUlM0ElM0FUYWxldnNrYQ==" repo-name="NebbAirline"><sup>Powered by [Swimm](https://app.swimm.io/)</sup></SwmMeta>
