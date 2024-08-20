using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Server.Models;
using Server.Repositories;
using Server.Services;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightController : ControllerBase
    {
        IRepository _repository;
        public FlightController(IRepository repository)
        {
            _repository = repository;
        }

        // GET: api/Flight
        [HttpGet]
        public ActionResult<List<Flight>> Get()
        {
            return _repository.GetFlights().ToList();
        }

        // GET: api/Flight
        [HttpGet]
        public ActionResult<List<Flight>> GetAll()
        {
            return _repository.GetFlights().ToList();
        }

        // GET: api/Flight/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var flight = await _repository.GetFlightById(id);

            if (flight == null)
            {
                return NotFound();
            }

            return Ok(flight);
        }

        // GET: api/Flight/GetByCode/123456789
        [HttpGet("[action]/{code}")]
        public async Task<IActionResult> GetByCode([FromRoute]string code)
        {
            var flight = await _repository.GetFlightByCode(code);

            if (flight == null)
            {
                return NotFound();
            }

            return Ok(flight);
        }

        // POST: api/Flight
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Flight flight)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Format First letters to Uppercase and Flight Code letters to Uppercase
            flight.FlightCode = FormatLetters.CodeCharsToUpper(flight.FlightCode);
            flight.Origin = FormatLetters.FirstCharToUpper(flight.Origin);
            flight.Destination = FormatLetters.FirstCharToUpper(flight.Destination);

            var created = await _repository.CreateFlight(flight);
            if (created == null)
            {
                return BadRequest();
            }
            return Ok(created);
        }

        // PUT: api/Flight/5
        [HttpPut("{FlightID}")]
        public async Task<IActionResult> Update([FromRoute] int FlightID, [FromBody] Flight flight)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (FlightID != flight.FlightID)
            {
                return BadRequest();
            }

            try
            {
                await _repository.UpdateFlight(flight);
                return new ObjectResult("Flight edited successfully!");
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FlightExists(FlightID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
        }

        // DELETE: api/Delete/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int FlightID)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var flight = await _repository.GetFlightById(FlightID);
            if (flight == null)
            {
                return NotFound();
            }
            await _repository.DeleteFlight(FlightID);
            return new ObjectResult("Flight deleted successfully!");
        }

        private bool FlightExists(int id)
        {
            return _repository.FlightExists(id);
        }
    }
}
