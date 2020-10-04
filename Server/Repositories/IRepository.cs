using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Server.Models;

namespace Server.Repositories
{
    public interface IRepository
    {
        // Ticket
        IList<Ticket> GetTickets();
        Task<Ticket> GetTicketById(int id);
        IList<Ticket> GetTicketsByFlightCode(string code);
        IList<Ticket> GetTicketsByUserPassport(string passport);
        Task<Ticket> CreateTicket(Ticket ticket);
        Task UpdateTicket(Ticket ticket);
        Task DeleteTicket(int id);
        bool TicketExists(int id);

        // Passenger
        IList<Passenger> GetPassengers();
        Task<Passenger> GetPassengerById(int id);
        Task<Passenger> GetPassengerByPassport(string passport);
        Task<Passenger> CreatePassenger(Passenger passenger);
        Task UpdatePassenger(Passenger passenger);
        Task DeletePassenger(int id);
        bool PassengerExists(int id);
        bool PassengerExists(string passport);
        // Flight
        IList<Flight> GetFlights();
        Task<Flight> GetFlightById(int id);
        Task<Flight> GetFlightByCode(string code);
        Task<Flight> CreateFlight(Flight flight);
        Task UpdateFlight(Flight flight);
        Task DeleteFlight(int id);
        bool FlightExists(int id);
        bool FlightExists(string code);
    }
}
