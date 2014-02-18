using System;
using System.Collections.Generic;
using TiendaArreglos.Client.Wpf.Model;

namespace TiendaArreglos.Client.Wpf.Interfaces
{
    public interface ITicketRepository
    {
        IEnumerable<Ticket> GetTickets(int startNumber, int endNumber);
    }
}