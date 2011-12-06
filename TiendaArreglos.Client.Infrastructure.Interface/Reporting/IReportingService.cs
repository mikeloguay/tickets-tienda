using System;
using System.Linq;

namespace TiendaArreglos.Client.Infrastructure.Interface.Reporting
{
    public interface IReportingService
    {
        int Print(int startNumber, int numberOfTickets);
    }
}