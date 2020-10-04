using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Server.Models;
using Server.Data;
using Microsoft.EntityFrameworkCore;

namespace Server.Repositories
{
    public class Repository : IRepository
    {
        TicketContext _context;
        public Repository(TicketContext context)
        {
            _context = context;
        }

        public IList<Ticket> GetTickets()
        {
            return _context.Tickets.ToList();
        }

        public async Task<Ticket> GetTicketById(int id)
        {
            var ticket = await _context.Tickets.FindAsync(id);
            return ticket;
        }

        public async Task<Ticket> CreateTicket(Ticket ticket)
        {
            if (_context.Tickets.FirstOrDefault(t => t.Passport == ticket.Passport && t.FlightCode == ticket.FlightCode) != null)
            {
                return null;
            }
            _context.Tickets.Add(ticket);
            await _context.SaveChangesAsync();
            return ticket;
        }

        public async Task UpdateTicket(Ticket ticket)
        {
            _context.Entry(ticket).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteTicket(int id)
        {
            var ticket = _context.Tickets.FirstOrDefault(t => t.TicketID == id);
            _context.Tickets.Remove(ticket);
            await _context.SaveChangesAsync();
        }

        public bool TicketExists(int id)
        {
            return _context.Tickets.Any(t => t.TicketID == id);
        }

        public IList<Passenger> GetPassengers()
        {
            return _context.Passengers.ToList();
        }

        public async Task<Passenger> GetPassengerById(int id)
        {
            var passenger = await _context.Passengers.FindAsync(id);
            return passenger;
        }

        public async Task<Passenger> CreatePassenger(Passenger passenger)
        {
            if (_context.Passengers.FirstOrDefault(p => p.Passport == passenger.Passport) != null)
            {
                return null;
            }
            _context.Passengers.Add(passenger);
            await _context.SaveChangesAsync();
            return passenger;
        }

        public async Task UpdatePassenger(Passenger passenger)
        {
            _context.Entry(passenger).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeletePassenger(int id)
        {
            var passenger = _context.Passengers.FirstOrDefault(p => p.PassengerID == id);
            _context.Passengers.Remove(passenger);
            await _context.SaveChangesAsync();
        }

        public bool PassengerExists(int id)
        {
            return _context.Passengers.Any(p => p.PassengerID == id);
        }

        public IList<Flight> GetFlights()
        {
            return _context.Flights.ToList();
        }

        public async Task<Flight> GetFlightById(int id)
        {
            var flight = await _context.Flights.FindAsync(id);
            return flight;
        }

        public async Task<Flight> CreateFlight(Flight flight)
        {
            if (_context.Flights.FirstOrDefault(f => f.FlightCode == flight.FlightCode) != null)
            {
                return null;
            }
            _context.Flights.Add(flight);
            await _context.SaveChangesAsync();
            return flight;
        }

        public async Task UpdateFlight(Flight flight)
        {
            _context.Entry(flight).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteFlight(int id)
        {
            var flight = _context.Flights.FirstOrDefault(f => f.FlightID == id);
            _context.Flights.Remove(flight);
            await _context.SaveChangesAsync();
        }

        public bool FlightExists(int id)
        {
            return _context.Flights.Any(f => f.FlightID == id);
        }

        public async Task<Passenger> GetPassengerByPassport(string passport)
        {
            var passenger = await _context.Passengers.FirstOrDefaultAsync(p => p.Passport == passport);
            return passenger;
        }

        public async Task<Flight> GetFlightByCode(string code)
        {
            var flight = await _context.Flights.FirstOrDefaultAsync(f => f.FlightCode == code);
            return flight;
        }

        public bool PassengerExists(string passport)
        {
            if (_context.Passengers.FirstOrDefault(p => p.Passport == passport) == null)
            {
                return false;
            }
            return true;
        }

        public bool FlightExists(string code)
        {
            if (_context.Flights.FirstOrDefault(f => f.FlightCode == code) == null)
            {
                return false;
            }
            return true;
        }

        public IList<Ticket> GetTicketsByFlightCode(string code)
        {
            var tickets = from t in _context.Tickets
                          where t.FlightCode == code
                          select t;
            return tickets.ToList();
        }

        public IList<Ticket> GetTicketsByUserPassport(string passport)
        {
            var tickets = from t in _context.Tickets
                          where t.Passport == passport
                          select t;
            return tickets.ToList();
        }
    }
}
