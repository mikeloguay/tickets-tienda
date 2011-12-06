using System;
using System.Diagnostics;
using System.Linq;

namespace TiendaArreglos.Client.Infrastructure.Reporting
{
    public class ReportingService : IReportingService
    {
        public int Print(int numberOfTickets)
        {
            Debug.WriteLine("Printing {0} tickets...", numberOfTickets);

            return 168;
        }
    }
}