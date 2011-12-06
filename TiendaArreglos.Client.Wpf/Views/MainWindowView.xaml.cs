using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using TiendaArreglos.Client.Wpf.Reporting;
using TiendaArreglos.Client.Wpf.ViewModels;

namespace TiendaArreglos.Client.Wpf.Views
{
    /// <summary>
    /// Interaction logic for MainWindowView.xaml
    /// </summary>
    public partial class MainWindowView : Window
    {
        public MainWindowView()
        {
            InitializeComponent();
            InitializeDataContext();
            AttachEvents();
        }

        private void AttachEvents()
        {
            Loaded += OnMainWindowLoaded;
            KeyUp += OnMainWindowKeyUp;
        }

        private void InitializeDataContext()
        {
            DataContext = new MainWindowViewModel();
        }

        private void InitializeFocus()
        {
            NumberOfTicketsToPrintTextBox.Focus();
        }

        void OnMainWindowKeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                Close();
            }
        }

        void OnMainWindowLoaded(object sender, RoutedEventArgs e)
        {
            InitializeFocus();
        }

        private void OnNumberOfTicketsToPrintTextBoxGotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox != null)
            {
                textBox.SelectAll();
            }
        }

        private void PrintButton_Click(object sender, RoutedEventArgs e)
        {
            Report report = new Report();
            report.Show();
        }
    }
}