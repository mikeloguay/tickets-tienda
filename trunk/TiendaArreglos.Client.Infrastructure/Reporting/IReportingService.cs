using System;
using System.Linq;

namespace TiendaArreglos.Client.Infrastructure.Reporting
{
    public interface IReportingService
    {
        int Print(int numberOfTickets);
    }
}