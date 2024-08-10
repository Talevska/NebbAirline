---
title: Flight Controller Description
---
# Introduction

This document will walk you through the implementation of the flight management feature in the <SwmToken path="/Server/Controllers/FlightController.cs" pos="19:5:5" line-data="    public class FlightController : ControllerBase">`FlightController`</SwmToken>.

The feature allows users to:

1. Display all flights.
2. View detailed information about a specific flight.
3. Create a new flight.
4. Edit an existing flight.
5. Confirm the deletion of a flight.
6. Delete a flight.

We will cover:

1. How the feature fetches and displays data.
2. How the feature handles user interactions for creating, editing, and deleting flights.
3. Error handling mechanisms in place.

# Display all flights

<SwmSnippet path="/Client/Controllers/FlightController.cs" line="24">

---

The <SwmToken path="/Client/Controllers/FlightController.cs" pos="24:10:10" line-data="        public async Task&lt;ActionResult&gt; DisplayAllFlights()">`DisplayAllFlights`</SwmToken> method fetches all flights from the API and displays them. This is the entry point for viewing all available flights.

```
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

# View flight information

<SwmSnippet path="/Client/Controllers/FlightController.cs" line="41">

---

The <SwmToken path="/Client/Controllers/FlightController.cs" pos="42:8:8" line-data="        // GET: Flight/FlightInfo">`FlightInfo`</SwmToken> method retrieves detailed information about a specific flight, including its passengers. This method is crucial for providing users with comprehensive flight details.

```

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

# Create a new flight

<SwmSnippet path="/Client/Controllers/FlightController.cs" line="61">

---

The <SwmToken path="/Client/Controllers/FlightController.cs" pos="62:8:8" line-data="        // GET: Flight/Create">`Create`</SwmToken> method handles both the GET and POST requests for creating a new flight. The GET request returns the creation form, while the POST request submits the new flight data to the API.

```

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
```

---

</SwmSnippet>

<SwmSnippet path="/Client/Controllers/FlightController.cs" line="79">

---

The POST request logic includes validation and API interaction to add the flight.

```

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

# Edit an existing flight

<SwmSnippet path="/Client/Controllers/FlightController.cs" line="100">

---

The <SwmToken path="/Client/Controllers/FlightController.cs" pos="101:8:8" line-data="        // GET: Flight/Edit/5">`Edit`</SwmToken> method handles both the GET and POST requests for editing an existing flight. The GET request fetches the flight data to be edited, while the POST request submits the updated flight data to the API.

```

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

<SwmSnippet path="/Client/Controllers/FlightController.cs" line="120">

---

The POST request logic updates the flight details via the API.

```

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

# Confirm flight deletion

<SwmSnippet path="/Client/Controllers/FlightController.cs" line="147">

---

The <SwmToken path="/Client/Controllers/FlightController.cs" pos="148:8:8" line-data="        // GET: Flight/ConfirmDelete/5">`ConfirmDelete`</SwmToken> method fetches the flight data to confirm deletion. This step ensures that the user is aware of the flight details before proceeding with deletion.

```

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

# Delete a flight

<SwmSnippet path="/Client/Controllers/FlightController.cs" line="167">

---

The <SwmToken path="/Client/Controllers/FlightController.cs" pos="168:8:8" line-data="        // POST: Flight/Delete/5">`Delete`</SwmToken> method handles the POST request to delete a flight. It interacts with the API to remove the flight and provides feedback to the user.

```

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

# Conclusion

This feature integrates multiple CRUD operations for managing flights. Each method ensures proper interaction with the API and provides user feedback for successful operations or errors.

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBTmViYkFpcmxpbmUlM0ElM0FUYWxldnNrYQ==" repo-name="NebbAirline"><sup>Powered by [Swimm](https://app.swimm.io/)</sup></SwmMeta>
