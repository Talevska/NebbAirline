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
    public class PassengerController : ControllerBase
    {
        IRepository _repository;
        public PassengerController(IRepository repository)
        {
            _repository = repository;
        }

        // GET: api/Passenger
        [HttpGet]
        public ActionResult<List<Passenger>> Get()
        {
            return _repository.GetPassengers().ToList();
        }

        // GET: api/Passenger/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var passenger = await _repository.GetPassengerById(id);

            if (passenger == null)
            {
                return NotFound();
            }

            return Ok(passenger);
        }

        [HttpGet("[action]/{passport}")]
        public async Task<ActionResult> GetByPassport([FromRoute] string passport)
        {
            var passenger = await _repository.GetPassengerByPassport(passport);

            if (passenger == null)
            {
                return NotFound();
            }

            return Ok(passenger);
        }

        [HttpGet("[action]/{code}")]
        public async Task<List<Passenger>> GetPassengersByFlightCode([FromRoute] string code)
        {
            List<Passenger> passengers = new List<Passenger>();
            if (!_repository.FlightExists(code))
            {
                return null;
            }
            var tickets = _repository.GetTicketsByFlightCode(code).ToList();
            foreach (var item in tickets)
            {
                passengers.Add(await _repository.GetPassengerByPassport(item.Passport));
            }
            return passengers;
        }

        // POST: api/Passenger
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Passenger passenger)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Format First letters to Uppercase
            passenger.FirstName = FormatLetters.FirstCharToUpper(passenger.FirstName);
            passenger.LastName = FormatLetters.FirstCharToUpper(passenger.LastName);
            passenger.Passport = FormatLetters.FirstCharToUpper(passenger.Passport);

            var created = await _repository.CreatePassenger(passenger);
            if (created == null)
            {
                return BadRequest();
            }
            return Ok(created);
        }

        // PUT: api/Passenger/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] Passenger passenger)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != passenger.PassengerID)
            {
                return BadRequest();
            }

            try
            {
                await _repository.UpdatePassenger(passenger);
                return new ObjectResult("Passenger edited successfully!");
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PassengerExists(id))
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
        public async Task<IActionResult> Delete(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var passenger = await _repository.GetPassengerById(id);
            if (passenger == null)
            {
                return NotFound();
            }
            await _repository.DeletePassenger(id);
            return new ObjectResult("Passenger deleted successfully!");
        }

        private bool PassengerExists(int id)
        {
            return _repository.PassengerExists(id);
        }
    }
}
