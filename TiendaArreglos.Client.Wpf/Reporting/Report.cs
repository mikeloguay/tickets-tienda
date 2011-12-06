using System;
using System.Linq;
using System.Windows.Forms;
using TiendaArreglos.Client.Infrastructure.Implementation;
using TiendaArreglos.Client.Infrastructure.Interface;

namespace TiendaArreglos.Client.Wpf.Reporting
{
    public partial class Report : Form
    {
        private ITicketRepository _ticketRepository;

        public Report()
        {
            InitializeComponent();

            _ticketRepository = new TicketRepository();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            TicketBindingSource.DataSource = _ticketRepository.GetTickets(100, 105);
            ticketReportViewer.RefreshReport();
        }
    }
}