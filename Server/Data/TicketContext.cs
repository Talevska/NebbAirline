using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Server.Models;

namespace Server.Data
{
    public class TicketContext : DbContext
    {
        public TicketContext(DbContextOptions<TicketContext> options) : base(options)
        {

        }

        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Flight> Flights { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Passenger>().HasData(
                new Passenger
                {
                    PassengerID = 1,
                    FirstName = "Hana",
                    LastName = "Peters",
                    Passport = "A2345678",
                    DateBirth = new DateTime(2008, 5, 1)
                },
                new Passenger
                {
                    PassengerID = 2,
                    FirstName = "John",
                    LastName = "Peters",
                    Passport = "B2345678",
                    DateBirth = new DateTime(2008, 5, 1)
                }
            );

            modelBuilder.Entity<Flight>().HasData(
                new Flight
                {
                    FlightID = 1,
                    FlightCode = "AB1234",
                    Origin = "Skopje",
                    Destination = "London",
                    Departure = new DateTime(2021, 5, 1, 8, 30, 52)
                },
                new Flight
                {
                    FlightID = 2,
                    FlightCode = "XY1234",
                    Origin = "Skopje",
                    Destination = "Treviso",
                    Departure = new DateTime(2021, 5, 1, 8, 30, 52)
                }
                );

            modelBuilder.Entity<Ticket>().HasData(
                new Ticket
                {
                    TicketID = 1,
                    FirstName = "Hana",
                    LastName = "Peters",
                    DateBirth = new DateTime(2008, 5, 1, 8, 30, 52),
                    Passport = "A2345678",
                    FlightCode = "XY1234",
                    Origin = "Skopje",
                    Destination = "London",
                    Departure = new DateTime(2021, 5, 1, 8, 30, 52),
                    Return = new DateTime(2022, 5, 1, 8, 30, 52),
                    CarryOnBag = 1,
                    TrolleyBag = 2,
                    CheckedInBag = 2
                },
                new Ticket
                {
                    TicketID = 2,
                    FirstName = "Hana",
                    LastName = "Peters",
                    DateBirth = new DateTime(2008, 5, 1, 8, 30, 52),
                    Passport = "A2345678",
                    FlightCode = "AB1234",
                    Origin = "Skopje",
                    Destination = "Treviso",
                    Departure = new DateTime(2023, 5, 1, 8, 30, 52),
                    Return = new DateTime(2024, 5, 1, 8, 30, 52),
                    CarryOnBag = 1,
                    TrolleyBag = 2,
                    CheckedInBag = 2
                },
                new Ticket
                {
                    TicketID = 3,
                    FirstName = "John",
                    LastName = "Peters",
                    DateBirth = new DateTime(2009, 5, 1, 8, 30, 52),
                    Passport = "B2345678",
                    FlightCode = "AB1234",
                    Origin = "Skopje",
                    Destination = "Treviso",
                    Departure = new DateTime(2023, 5, 1, 8, 30, 52),
                    Return = new DateTime(2024, 5, 1, 8, 30, 52),
                    CarryOnBag = 1,
                    TrolleyBag = 2,
                    CheckedInBag = 2
                },
                new Ticket
                {
                    TicketID = 4,
                    FirstName = "John",
                    LastName = "Peters",
                    DateBirth = new DateTime(2009, 5, 1, 8, 30, 52),
                    Passport = "B2345678",
                    FlightCode = "XY1234",
                    Origin = "Skopje",
                    Destination = "London",
                    Departure = new DateTime(2021, 5, 1, 8, 30, 52),
                    Return = new DateTime(2022, 5, 1, 8, 30, 52),
                    CarryOnBag = 1,
                    TrolleyBag = 2,
                    CheckedInBag = 2
                }
                );
        }
    }
}
