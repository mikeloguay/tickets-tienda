using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using TiendaArreglos.Client.Wpf.ViewModels;

namespace TiendaArreglos.Client.Wpf.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
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
    }
}