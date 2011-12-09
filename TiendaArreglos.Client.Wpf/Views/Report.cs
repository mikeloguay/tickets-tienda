using System;
using System.Windows.Forms;
using TiendaArreglos.Client.Wpf.Implementations;
using TiendaArreglos.Client.Wpf.Interfaces;

namespace TiendaArreglos.Client.Wpf.Views
{
    public partial class Report : Form
    {
        private ITicketRepository _ticketRepository;

        public Report()
        {
            InitializeComponent();

            _ticketRepository = new TicketRepository();
        }

        private void OnReportLoad(object sender, EventArgs e)
        {
            TicketBindingSource.DataSource = _ticketRepository.GetTickets(100, 105);
            ticketReportViewer.RefreshReport();
        }
    }
}