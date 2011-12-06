using System;
using System.Diagnostics;
using System.Linq;
using TiendaArreglos.Client.Infrastructure.Interface.Reporting;

namespace TiendaArreglos.Client.Infrastructure.Implementation.Reporting
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