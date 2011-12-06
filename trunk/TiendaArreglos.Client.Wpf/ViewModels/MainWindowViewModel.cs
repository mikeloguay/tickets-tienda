using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.ViewModel;
using System;
using System.Linq;
using System.Windows.Input;
using TiendaArreglos.Client.Infrastructure.Implementation.Reporting;
using TiendaArreglos.Client.Infrastructure.Implementation.Serialization;
using TiendaArreglos.Client.Infrastructure.Interface.Reporting;
using TiendaArreglos.Client.Infrastructure.Interface.Serialization;
using TiendaArreglos.Client.Model;

namespace TiendaArreglos.Client.Wpf.ViewModels
{
    public class MainWindowViewModel : NotificationObject
    {
        private const string TIENDA_ARREGLOS_CONFIG_PATH = @"Config\TiendaArreglosConfig.xml";

        private int _lastPrintedNumber;

        private string _numberOfTicketsToPrint;

        private IReportingService _reportingService;

        private ISerializer<TiendaArreglosConfig> _serializer;

        private TiendaArreglosConfig _tiendaArreglosConfig;

        public MainWindowViewModel()
        {
            InitializeServices();
            InitializeValues();
            InitializeCommands();
        }

        public int LastPrintedNumber
        { 
            get
            {
                return _lastPrintedNumber;    	
            }
            set
            {
                if (_lastPrintedNumber != value)
                {
                    _lastPrintedNumber = value;
                    RaisePropertyChanged(() => LastPrintedNumber);
                }
            }
        }
        public string NumberOfTicketsToPrint
        {
            get
            {
                return _numberOfTicketsToPrint;
            }
            set
            {
                if (_numberOfTicketsToPrint != value)
                {
                    _numberOfTicketsToPrint = value;
                    RaisePropertyChanged(() => NumberOfTicketsToPrint);
                }
            }
        }
        public ICommand PrintCommand { get; set; }

        public bool CanPrint()
        {
            int temp;

            return !string.IsNullOrWhiteSpace(_numberOfTicketsToPrint) && int.TryParse(_numberOfTicketsToPrint,
                out temp);
        }

        public void Print()
        {
            LastPrintedNumber = _reportingService.Print(_lastPrintedNumber + 1, int.Parse(_numberOfTicketsToPrint));
            SaveLastPrintedNumber();
        }

        private void InitializeCommands()
        {
            PrintCommand = new DelegateCommand(Print, CanPrint);
        }

        private void InitializeServices()
        {
            _serializer = new SerializerBase<TiendaArreglosConfig>();
            _reportingService = new ReportingService();
        }

        private void InitializeValues()
        {
            _tiendaArreglosConfig = _serializer.DeserializeObject(TIENDA_ARREGLOS_CONFIG_PATH);

            // Convert config values to view model values
            LastPrintedNumber = _tiendaArreglosConfig.LastPrintedNumber;
            NumberOfTicketsToPrint = _tiendaArreglosConfig.NumberOfTicketsToPrint.ToString();
        }

        private void SaveLastPrintedNumber()
        {
            _tiendaArreglosConfig.LastPrintedNumber = _lastPrintedNumber;
            _tiendaArreglosConfig.NumberOfTicketsToPrint = int.Parse(_numberOfTicketsToPrint);
            _serializer.SerializeObject(_tiendaArreglosConfig, TIENDA_ARREGLOS_CONFIG_PATH);
        }
    }
}