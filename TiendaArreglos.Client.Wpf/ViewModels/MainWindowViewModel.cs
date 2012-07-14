using System;
using System.Windows.Input;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.ViewModel;
using TiendaArreglos.Client.Wpf.Implementations;
using TiendaArreglos.Client.Wpf.Interfaces;
using TiendaArreglos.Client.Wpf.Model;
using TiendaArreglos.Client.Wpf.Views;

namespace TiendaArreglos.Client.Wpf.ViewModels
{
    public class MainWindowViewModel : NotificationObject
    {
        private const string TIENDA_ARREGLOS_CONFIG_PATH = @"Config\TiendaArreglosConfig.xml";

        private int _lastPrintedNumber;

        private int _numberOfTicketsToPrint;

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
        public int NumberOfTicketsToPrint
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
            return true;
        }

        public void Print()
        {
            Report report = default(Report);

            try
            {
                report = new Report(_lastPrintedNumber + 1, _lastPrintedNumber + _numberOfTicketsToPrint);
                report.ShowDialog();

                SaveLastPrintedNumber();
            }
            finally
            {
                report.Dispose();
            }
        }

        private void InitializeCommands()
        {
            PrintCommand = new DelegateCommand(Print, CanPrint);
        }

        private void InitializeServices()
        {
            _serializer = new SerializerBase<TiendaArreglosConfig>();
        }

        private void InitializeValues()
        {
            _tiendaArreglosConfig = _serializer.DeserializeObject(TIENDA_ARREGLOS_CONFIG_PATH);

            // Convert config values to view model values
            LastPrintedNumber = _tiendaArreglosConfig.LastPrintedNumber;
            NumberOfTicketsToPrint = _tiendaArreglosConfig.NumberOfTicketsToPrint;
        }

        private void SaveLastPrintedNumber()
        {
            _tiendaArreglosConfig.LastPrintedNumber = _lastPrintedNumber + _numberOfTicketsToPrint;
            _tiendaArreglosConfig.NumberOfTicketsToPrint = _numberOfTicketsToPrint;
            _serializer.SerializeObject(_tiendaArreglosConfig, TIENDA_ARREGLOS_CONFIG_PATH);
        }
    }
}