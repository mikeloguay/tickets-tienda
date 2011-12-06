using System;
using System.Collections.Generic;
using System.Linq;
using TiendaArreglos.Client.Model;

namespace TiendaArreglos.Client.Infrastructure.Interface
{
    public interface ITicketRepository
    {
        IEnumerable<Ticket> GetTickets(int startNumber, int endNumber);
    }
}
