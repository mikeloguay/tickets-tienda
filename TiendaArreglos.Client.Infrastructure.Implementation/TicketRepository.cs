using System;
using System.Collections.Generic;
using System.Linq;
using TiendaArreglos.Client.Infrastructure.Interface;
using TiendaArreglos.Client.Model;

namespace TiendaArreglos.Client.Infrastructure.Implementation
{
    public class TicketRepository : ITicketRepository
    {
        public IEnumerable<Ticket> GetTickets(int startNumber, int endNumber)
        {
            Ticket ticket;
            IList<Ticket> tickets = new List<Ticket>();

            for (int i = startNumber; i <= endNumber; i++)
            {
                ticket = new Ticket() { Number = i };
                tickets.Add(ticket);
            }

            return tickets;
        }
    }
}
