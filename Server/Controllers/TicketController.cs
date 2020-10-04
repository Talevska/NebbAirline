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
    public class TicketController : ControllerBase
    {
        IRepository _repository;
        public TicketController(IRepository repository)
        {
            _repository = repository;
        }

        // GET: api/Ticket
        [HttpGet]
        public ActionResult<List<Ticket>> Get()
        {
            return _repository.GetTickets().ToList();
        }

        // GET: api/Ticket/passport#
        [Route("[action]/{passport}")]
        [HttpGet]
        public ActionResult<List<Ticket>> GetByPassengerPassport([FromRoute] string passport)
        {
            if (!PassengerExists(passport))
            {
                return NotFound();
            }
            return _repository.GetTicketsByUserPassport(passport).ToList();
        }

        // GET: api/Ticket/code#
        [Route("[action]/{code}")]
        [HttpGet]
        public ActionResult<List<Ticket>> GetByFlightCode([FromRoute] string code)
        {
            if (!FlightExists(code))
            {
                return NotFound();
            }
            return _repository.GetTicketsByFlightCode(code).ToList();
        }

        // GET: api/Ticket/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var ticket = await _repository.GetTicketById(id);

            if (ticket == null)
            {
                return NotFound();
            }

            return Ok(ticket);
        }
                
        // POST: api/Ticket
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Ticket ticket)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Format First letters to Uppercase and Flight Code letters to Uppercase
            ticket.FirstName = FormatLetters.FirstCharToUpper(ticket.FirstName);
            ticket.LastName = FormatLetters.FirstCharToUpper(ticket.LastName);
            ticket.Passport = FormatLetters.FirstCharToUpper(ticket.Passport);
            ticket.FlightCode = FormatLetters.CodeCharsToUpper(ticket.FlightCode);
            ticket.Origin = FormatLetters.FirstCharToUpper(ticket.Origin);
            ticket.Destination = FormatLetters.FirstCharToUpper(ticket.Destination);

            Ticket created = await _repository.CreateTicket(ticket);

            if (created == null)
            {
                return BadRequest(ModelState);
            }

            if (!PassengerExists(ticket.Passport))
            {
                await _repository.CreatePassenger(new Passenger { FirstName = ticket.FirstName, LastName = ticket.LastName, DateBirth = ticket.DateBirth, Passport = ticket.Passport });
            }
            if (!FlightExists(ticket.FlightCode))
            {
                await _repository.CreateFlight(new Flight { Origin = ticket.Origin, Destination = ticket.Destination, Departure = ticket.Departure, FlightCode = ticket.FlightCode});
            }
            return Ok(created);
        }

        // PUT: api/Ticket/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] Ticket ticket)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != ticket.TicketID)
            {
                return BadRequest();
            }

            try
            {
                await _repository.UpdateTicket(ticket);
                return new ObjectResult("Ticket Edited successfully!");
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TicketExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
        }

        // DELETE: api/Ticket/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var ticket = await _repository.GetTicketById(id);
            if (ticket == null)
            {
                return NotFound();
            }
            await _repository.DeleteTicket(id);
            return Ok();
        }

        private bool TicketExists(int id)
        {
            return _repository.TicketExists(id);
        }

        private bool PassengerExists(string passport)
        {
            return _repository.PassengerExists(passport);
        }

        private bool FlightExists(string code)
        {
            return _repository.FlightExists(code);
        }
    }
}
