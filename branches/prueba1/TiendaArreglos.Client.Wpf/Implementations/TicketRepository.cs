using System;
using System.Collections.Generic;
using TiendaArreglos.Client.Wpf.Interfaces;
using TiendaArreglos.Client.Wpf.Model;

namespace TiendaArreglos.Client.Wpf.Implementations
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