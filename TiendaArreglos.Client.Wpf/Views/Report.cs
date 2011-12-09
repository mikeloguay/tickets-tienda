using System;
using System.Windows.Forms;
using TiendaArreglos.Client.Wpf.Implementations;
using TiendaArreglos.Client.Wpf.Interfaces;

namespace TiendaArreglos.Client.Wpf.Views
{
    public partial class Report : Form
    {
        private ITicketRepository _ticketRepository;
        private int _startNumber;
        private int _endNumber;

        public Report(int startNumber, int endNumber)
        {
            InitializeComponent();

            _ticketRepository = new TicketRepository();
            _startNumber = startNumber;
            _endNumber = endNumber;
        }

        private void OnReportLoad(object sender, EventArgs e)
        {
            TicketBindingSource.DataSource = _ticketRepository.GetTickets(_startNumber, _endNumber);
            ticketReportViewer.RefreshReport();
        }
    }
}